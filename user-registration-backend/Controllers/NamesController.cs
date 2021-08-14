using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using user_registration_backend.Context;
using user_registration_backend.Models;

namespace user_registration_backend.Controllers
{
    public class NamesController : ApiController
    {
        //private RegistrationDbContext db = new RegistrationDbContext();

        // GET: api/Names
        public IQueryable<Name> GetNames()
        {
            return db.Names;
        }

        // GET: api/Names/5
        [ResponseType(typeof(Name))]
        public IHttpActionResult GetName(Guid id)
        {
            Name name = db.Names.Find(id);
            if (name == null)
            {
                return NotFound();
            }

            return Ok(name);
        }

        // PUT: api/Names/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutName(Guid id, Name name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != name.Id)
            {
                return BadRequest();
            }

            db.Entry(name).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
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
        public IHttpActionResult PostName(Name name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Names.Add(name);

            try
            {
                db.SaveChanges();
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
        public IHttpActionResult DeleteName(Guid id)
        {
            Name name = db.Names.Find(id);
            if (name == null)
            {
                return NotFound();
            }

            db.Names.Remove(name);
            db.SaveChanges();

            return Ok(name);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NameExists(Guid id)
        {
            return db.Names.Count(e => e.Id == id) > 0;
        }
    }
}