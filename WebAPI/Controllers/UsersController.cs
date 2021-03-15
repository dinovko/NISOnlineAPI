using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        ContextDB db;

        public UsersController(ContextDB context)
        {
            db = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> Get()
        {
            return await db.Users.ToListAsync();
        }

        [HttpGet("get")]
        public string Get2()
        {
            return "asdasdasdas";
        }

        [HttpPost("post")]
        public string Post([FromBody] string value)
        {
            return value + " " + "asdasdasdas";
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> Get(int id)
        {
            Users user = await db.Users.FirstOrDefaultAsync(x => x.ID == id);
            if (user == null)
                return NotFound();
            return new ObjectResult(user);
        }

        // POST api/users
        [HttpPost]
        public async Task<ActionResult<Users>> Post(Users user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            db.Users.Add(user);
            await db.SaveChangesAsync();
            return Ok(user);
        }

        // PUT api/users/
        [HttpPut]
        public async Task<ActionResult<Users>> Put(Users user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            if (!db.Users.Any(x => x.ID == user.ID))
            {
                return NotFound();
            }

            db.Update(user);
            await db.SaveChangesAsync();
            return Ok(user);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Users>> Delete(int id)
        {
            Users user = db.Users.FirstOrDefault(x => x.ID == id);
            if (user == null)
            {
                return NotFound();
            }
            db.Users.Remove(user);
            await db.SaveChangesAsync();
            return Ok(user);
        }
    }
}
