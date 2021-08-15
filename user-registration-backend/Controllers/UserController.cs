using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using UserRegistrationBackend.Dtos;
using UserRegistrationBackend.Services;

namespace UserRegistrationBackend.Controllers
{
    [RoutePrefix("api/v1/user")]
    public class UserController : ApiController
    {
        //private readonly IRegistrationDbContext _dbContext;
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/v1/user
        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<UserDto>> GetAllUsers()
        {
            throw new NotImplementedException();
            //return _dbContext.Users;
        }

        // GET: api/v1/user/5
        [Route("{userId}")]
        [HttpGet]
        [ResponseType(typeof(UserDto))]
        public async Task<IHttpActionResult> GetUserById(long userId)
        {
            throw new NotImplementedException();
            //AppUser appUser = await _dbContext.Users.FindAsync(id);
            //if (appUser == null)
            //{
            //    return NotFound();
            //}

            //return Ok(appUser);
        }

        // POST: api/v1/user
        [Route("")]
        [HttpPost]
        [ResponseType(typeof(UserDto))]
        public async Task<IHttpActionResult> PostUser(UserDto appUser)
        {
            //TODO: this is the registration service!
            throw new NotImplementedException();
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //_dbContext.Users.Add(appUser);

            //try
            //{
            //    await _dbContext.SaveChangesAsync();
            //}
            //catch (DbUpdateException)
            //{
            //    if (AppUserExists(appUser.Id))
            //    {
            //        return Conflict();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return CreatedAtRoute("DefaultApi", new { id = appUser.Id }, appUser);
        }

        // DELETE: api/v1/user/5
        [Route("{userId}")]
        [HttpDelete]
        [ResponseType(typeof(UserDto))]
        public async Task<IHttpActionResult> DeleteAppUser(long userId)
        {
            throw new NotImplementedException();
            //AppUser appUser = await _dbContext.Users.FindAsync(id);
            //if (appUser == null)
            //{
            //    return NotFound();
            //}

            //_dbContext.Users.Remove(appUser);
            //await _dbContext.SaveChangesAsync();

            //return Ok(appUser);
        }

        //private bool AppUserExists(long id)
        //{
        //    return _dbContext.Users.Count(e => e.Id == id) > 0;
        //}
    }
}