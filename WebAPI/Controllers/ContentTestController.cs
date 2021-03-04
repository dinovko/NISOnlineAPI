using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Models.NSIModel;
using WebAPI.Models.TableModel;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentTestController : ControllerBase
    {
        ContextDB db;

        public ContentTestController(ContextDB context)
        {
            db = context;
        }

        //[HttpGet("dicSkills")]
        //public async Task<ActionResult<IEnumerable<NSISkillsName>>> GetClass()
        //{
        //    try
        //    {
        //        return await db.NSISkillsName.ToListAsync();
        //    }
        //    catch (Exception e)
        //    {
        //        return BadRequest(e.Message);
        //    }            
        //}

        [HttpPost("saveCloseTest")]
        public async Task<ActionResult<CloseTest>> Post(CloseTest close)
        {
            try
            {
                if (close == null)
                {
                    return BadRequest();
                }
                db.CloseTest.Add(close);
                await db.SaveChangesAsync();
                return Ok(close);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}
