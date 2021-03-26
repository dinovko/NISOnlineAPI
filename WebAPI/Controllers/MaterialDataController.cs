using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        ContextDB db;

        public MaterialDataController(ContextDB context)
        {
            db = context;
        }

        [HttpPost("saveMaterialData")]
        public async Task<ActionResult<InfoMaterialAdd>> Post(InfoMaterialAdd info)
        {
            try
            {
                if (info == null)
                {
                    return BadRequest();
                }
                //db.InfoMaterialAdd.Add(info);
                await db.SaveChangesAsync();
                return Ok(info);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
