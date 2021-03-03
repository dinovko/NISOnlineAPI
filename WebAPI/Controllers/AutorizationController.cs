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
            return await db.NSIClassName.ToListAsync();
        }

        [HttpGet("dicSchool")]
        public async Task<ActionResult<IEnumerable<NSISchool>>> GetSchool()
        {
            return await db.NSISchool.ToListAsync();
        }

        [HttpPost("saveSchoolboyUser")]
        public async Task<ActionResult<Users>> Post(Users user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest();
                }
                db.Users.Add(user);
                await db.SaveChangesAsync();
                return Ok(user);
            }
            catch (Exception e)
            {
                throw e;
            }           
        }
    }
}
