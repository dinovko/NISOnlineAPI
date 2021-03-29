using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Minio.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinIOController : ControllerBase
    {
        private readonly IConfiguration Configuration;
        private readonly Minio.MinioClient minioClient;
        private IWebHostEnvironment _appEnvironment;
        private readonly string defaultBucketName;
        public MinIOController(IWebHostEnvironment appEnvironment)
        {
            try
            {
                _appEnvironment = appEnvironment;

                defaultBucketName = Configuration["MinioRepository:defaultBucket"];

                var endpoint = Configuration["MinioRepository:endpoint"];
                var accessKey = Configuration["MinioRepository:accessKey"];
                var secretKey = Configuration["MinioRepository:secretKey"];
                minioClient = new Minio.MinioClient(endpoint, accessKey, secretKey).WithSSL();
            }
            catch (Exception)
            {

                throw;
            }
        }
        #region Bucket operations
        #endregion

        #region Object operations
        /// <summary>
        /// Загрузка файлад размером до 5ТБ на minio сервер
        /// на сервер загружается с именем сгенерированным GUID4 формата + расширение файла
        /// </summary>
        /// <returns>{ objectName = "название объекта в хранилище", fileName = "название загруженного файла" }</returns>
        [HttpPost("upload")]
        public async Task<ActionResult> UploadObject([FromForm] IFormFile file)
        {
            byte[] bts = new Byte[64];
            Array.Clear(bts, 0, bts.Length);
            try
            {
                using (var ms = new MemoryStream())
                {
                    await file.CopyToAsync(ms);
                    bts = ms.ToArray();
                }
                string fileNewGuidName = Guid.NewGuid().ToString("N") + System.IO.Path.GetExtension(file.FileName);

                using (System.IO.MemoryStream filestream = new MemoryStream(bts))
                {
                    await minioClient.PutObjectAsync(defaultBucketName, fileNewGuidName, filestream, filestream.Length);
                    return Ok(new { objectName = fileNewGuidName, fileName = file.FileName });

                }
            }
            catch (Exception ex)
            {
                string exMessage = ex.Message;
                while (ex.InnerException != null)
                {
                    exMessage += ";" + ex.InnerException.Message;
                }
                return BadRequest($"ошибка загрузки файла:{file.FileName} -->{exMessage}");
            }
        }

        /// <summary>
        /// Выгрузка объекта из хранилища по полному имени
        /// </summary>
        /// <param name="obj">полное имя файла в хранилище</param>
        /// <returns>объект из хранилища</returns>
        [HttpGet("download/{obj}")]
        public async Task<ActionResult> DownloadObject(string obj)
        {
            try
            {
                byte[] bts = new Byte[64];
                Array.Clear(bts, 0, bts.Length);
                await minioClient.StatObjectAsync(defaultBucketName, obj);

                var memoryStream = new MemoryStream();
                await minioClient.GetObjectAsync(defaultBucketName, obj,
                (stream) =>
                {
                    stream.CopyToAsync(memoryStream);
                    bts = memoryStream.ToArray();
                });

                return File(bts, System.Net.Mime.MediaTypeNames.Application.Octet, obj);
            }
            catch(MinioException mex)
            {
                string exMessage = mex.Message;
                while (mex.InnerException != null)
                {
                    exMessage += ";" + mex.InnerException.Message;
                }
                return BadRequest($"объект {obj} отсутствует в хранилище");
            }
            catch (Exception ex)
            {
                string exMessage = ex.Message;
                while (ex.InnerException != null)
                {
                    exMessage += ";" + ex.InnerException.Message;
                }
                return BadRequest($"ошибка загрузки файла:{obj} -->{exMessage}");
            }
        }


        /// <summary>
        /// Удаление объекта из хранилища
        /// </summary>
        /// <param name="objectName">полное имя объекта в хранилище включая расширение файла</param>
        /// <returns>{ имя объекта string }</returns>
        [HttpDelete("delete/{objectName}")]
        public async Task<ActionResult> RemoveObject(string objectName)
        {
            try
            {
                await minioClient.RemoveObjectAsync(defaultBucketName, objectName);
                return Ok(new { objectName });
            }
            catch (Exception ex)
            {
                string exMessage = ex.Message;
                while (ex.InnerException != null)
                {
                    exMessage += ";" + ex.InnerException.Message;
                }
                return BadRequest($"ошибка удаления файла:{exMessage}");
            }
        }

        #endregion
    }
}
