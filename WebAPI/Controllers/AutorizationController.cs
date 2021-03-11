using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NSIManager.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Models.BusinessObjects;
using WebAPI.Models.HelperModel;
using WebAPI.Models.NSIModel;
using WebAPI.Models.TableModel;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorizationController : ControllerBase
    {
        ContextDB db;

        public AutorizationController(ContextDB context)
        {
            db = context;
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
        public async Task<ActionResult<Person>> Post(Person person)
        {
            try
            {
                if (person == null)
                {
                    return BadRequest();
                }
                db.Person.Add(person);
                await db.SaveChangesAsync();
                return Ok(person);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
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
