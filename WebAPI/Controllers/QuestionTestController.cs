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

        [HttpGet("dicStudySubjectName")]
        public async Task<ActionResult<IEnumerable<NSIStudySubjectName>>> GetDic()
        {
            return await db.NSIStudySubjectName.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<QuestionTest>> Post(QuestionTest stest)
        {
            if (stest == null)
            {
                return BadRequest();
            }

            db.QuestionTest.Add(stest);
            await db.SaveChangesAsync();
            return Ok(stest);
        }

        [HttpPut]
        public async Task<ActionResult<QuestionTest>> Put(QuestionTest stest)
        {
            if (stest == null)
            {
                return BadRequest();
            }
            if (!db.QuestionTest.Any(x => x.ID == stest.ID))
            {
                return NotFound();
            }

            db.Update(stest);
            await db.SaveChangesAsync();
            return Ok(stest);
        }

    }
}
