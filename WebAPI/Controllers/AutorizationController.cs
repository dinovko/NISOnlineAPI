using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NISLogic.BusinessObjects;
using NISLogic.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Models.HelperModel;
using WebAPI.Models.NSIModel;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorizationController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        ContextDB db;

        public AutorizationController(ContextDB context, IConfiguration configuration)
        {
            db = context;
            _configuration = configuration;
        }

        [HttpGet("dicClass")]
        public async Task<ActionResult<IEnumerable<NSIClassName>>> GetClass()
        {
            try
            {
                return await db.NSIClassName.ToListAsync();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("dicSchool")]
        public async Task<ActionResult<IEnumerable<NSISchool>>> GetSchool()
        {
            try
            {
                return await db.NSISchool.ToListAsync();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            
        }

        [HttpPost("saveSchoolboyUser")]
        public Person Post([FromBody] Person person)
        {
            try
            {
                var conn = _configuration.GetConnectionString("DefaultConnection");
                AutorizationManager auto = new AutorizationManager();
                auto.SaveRegistrationPerson(person, conn);
                return person;
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [HttpPost("ADAutorization")]
        public IActionResult Post(ADUser user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest();
                }
                user.IsValid = true;
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}
