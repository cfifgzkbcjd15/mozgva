using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mozgva.Data;
using mozgva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace mozgva.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class UsersApiController : Controller
    {
        
        private readonly ApplicationContext db;
        public UsersApiController(ApplicationContext context)
        {
            db = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return await db.Users.Where(x=>x.Id==userId).ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<User>> Post(User user)
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
        public async Task<ActionResult<User>> Put(User user)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            User userupdate = db.Users.FirstOrDefault(x => x.Id == userId);
            userupdate.Name = user.Name;
            userupdate.Email = user.Email;
            userupdate.PhoneNumber = user.PhoneNumber;
            if (user == null)
            {
                return BadRequest();
            }
            if (!db.Users.Any(x => x.Email == user.Email))
            {
                return NotFound();
            }
            db.Users.Update(userupdate);
            await db.SaveChangesAsync();
            return Ok(user);
        }
    }
}
