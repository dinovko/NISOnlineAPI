using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using WebAPI.Models.NSIModel;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NSIController :  ControllerBase
    {
        ContextDB db;

        public NSIController(ContextDB context)
        {
            db = context;
        }

        /// <summary>API справочник Навыки</summary>
        [HttpGet("dicSkills")]
        public async Task<ActionResult<IEnumerable<NSISkillsName>>> GetDicSkills()
        {
            try
            {
                return await db.NSISkillsName.ToListAsync();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>API справочник Тип сортировки</summary>
        [HttpGet("dicSortTypes")]
        public async Task<ActionResult<IEnumerable<NSISortTypes>>> GetDicSortTypes()
        {
            try
            {
                return await db.NSISortTypes.ToListAsync();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>API справочник Классы</summary>
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

        /// <summary>API справочник Школы</summary>
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
    }
}
