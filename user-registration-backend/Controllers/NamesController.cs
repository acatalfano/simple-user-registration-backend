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
    public class NamesController : ApiController
    {
        private readonly IRegistrationDbContext _dbContext;

        public NamesController(IRegistrationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Names
        public IQueryable<Name> GetNames()
        {
            return _dbContext.Names;
        }

        // GET: api/Names/5
        [ResponseType(typeof(Name))]
        public async Task<IHttpActionResult> GetName(Guid id)
        {
            Name name = await _dbContext.Names.FindAsync(id);
            if (name == null)
            {
                return NotFound();
            }

            return Ok(name);
        }

        // PUT: api/Names/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutName(Guid id, Name name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != name.Id)
            {
                return BadRequest();
            }

            _dbContext.Entry(name).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NameExists(id))
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

        // POST: api/Names
        [ResponseType(typeof(Name))]
        public async Task<IHttpActionResult> PostName(Name name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _dbContext.Names.Add(name);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NameExists(name.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = name.Id }, name);
        }

        // DELETE: api/Names/5
        [ResponseType(typeof(Name))]
        public async Task<IHttpActionResult> DeleteName(Guid id)
        {
            Name name = await _dbContext.Names.FindAsync(id);
            if (name == null)
            {
                return NotFound();
            }

            _dbContext.Names.Remove(name);
            await _dbContext.SaveChangesAsync();

            return Ok(name);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NameExists(Guid id)
        {
            return _dbContext.Names.Count(e => e.Id == id) > 0;
        }
    }
}