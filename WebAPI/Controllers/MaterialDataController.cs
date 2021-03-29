using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NISLogic.BusinessObjects;
using NISLogic.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialDataController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        ContextDB db;

        public MaterialDataController(ContextDB context, IConfiguration configuration)
        {
            db = context;
            _configuration = configuration;
        }

        [HttpPost("saveMaterialData")]
        public InfoMaterialAdd Post([FromBody] InfoMaterialAdd material)
        {
            try
            {
                var conn = _configuration.GetConnectionString("DefaultConnection");
                MaterialDataManager mat = new MaterialDataManager();
                mat.SaveMaterialData(material, conn);
                return material;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
