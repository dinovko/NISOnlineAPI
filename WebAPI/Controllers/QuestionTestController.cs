using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NSIManager.Manager;
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
    public class QuestionTestController : ControllerBase
    {
        ContextDB db;

        public QuestionTestController(ContextDB context)
        {
            db = context;
        }

        [HttpGet("dicTestTypes")]
        public async Task<ActionResult<IEnumerable<NSITestTypes>>> Get()
        {
            return await db.NSITestTypes.ToListAsync();
        }

        //[HttpGet("dicStudySubjectName")]
        //public async Task<ActionResult<IEnumerable<NSIStudySubjectName>>> GetDic()
        //{
        //    return await db.NSIStudySubjectName.ToListAsync();
        //}

        //[HttpPost("saveQuestionTest")]
        //public async Task<ActionResult<QuestionTest>> Post(QuestionTest test)
        //{
        //    if (test == null)
        //    {
        //        return BadRequest();
        //    }

        //    db.QuestionTest.Add(test);
        //    await db.SaveChangesAsync();
        //    return Ok(test);
        //}

        //[HttpPost("saveInputTest")]
        //public async Task<ActionResult<QuestionTest>> Post(QuestionInputTest test)
        //{
        //    if (test == null)
        //    {
        //        return BadRequest();
        //    }

        //    db.QuestionInputTest.Add(test);
        //    await db.SaveChangesAsync();
        //    return Ok(test);
        //}
    }
}
