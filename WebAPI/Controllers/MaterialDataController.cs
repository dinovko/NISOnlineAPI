using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NISLogic.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Models.TableModel;

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
        public InfoMaterialAdd Post([FromBody] InfoMaterialAdd person)
        {
            try
            {
                var conn = _configuration.GetConnectionString("DefaultConnection");
                MaterialDataManager mat = new MaterialDataManager();
                //mat.SaveRegistrationPerson(person, conn);
                return person;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
