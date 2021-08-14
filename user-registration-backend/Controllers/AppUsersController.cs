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
using user_registration_backend.Context;
using user_registration_backend.Models;

namespace user_registration_backend.Controllers
{
    public class AppUsersController : ApiController
    {
        private readonly IRegistrationDbContext _dbContext;

        public AppUsersController(IRegistrationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/AppUsers
        public IQueryable<AppUser> GetUsers()
        {
            return _dbContext.Users;
        }

        // GET: api/AppUsers/5
        [ResponseType(typeof(AppUser))]
        public async Task<IHttpActionResult> GetAppUser(Guid id)
        {
            AppUser appUser = await _dbContext.Users.FindAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }

            return Ok(appUser);
        }

        // PUT: api/AppUsers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAppUser(Guid id, AppUser appUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != appUser.Id)
            {
                return BadRequest();
            }

            _dbContext.Entry(appUser).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppUserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/AppUsers
        [ResponseType(typeof(AppUser))]
        public async Task<IHttpActionResult> PostAppUser(AppUser appUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _dbContext.Users.Add(appUser);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AppUserExists(appUser.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = appUser.Id }, appUser);
        }

        // DELETE: api/AppUsers/5
        [ResponseType(typeof(AppUser))]
        public async Task<IHttpActionResult> DeleteAppUser(Guid id)
        {
            AppUser appUser = await _dbContext.Users.FindAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }

            _dbContext.Users.Remove(appUser);
            await _dbContext.SaveChangesAsync();

            return Ok(appUser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AppUserExists(Guid id)
        {
            return _dbContext.Users.Count(e => e.Id == id) > 0;
        }
    }
}