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
    public class ContactController : ApiController
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET: api/v1/user/5/Contact
        [HttpGet]
        [ResponseType(typeof(ContactDto))]
        public async Task<IHttpActionResult> GetContact(long userId)
        {
            throw new NotImplementedException();
            //Contact contact = await _dbContext.Contacts.FindAsync(id);
            //if (contact == null)
            //{
            //    return NotFound();
            //}

            //return Ok(contact);
        }

        // PUT: api/v1/user/5/Contact
        [HttpPut]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutContact(long userId, ContactDto contact)
        {
            throw new NotImplementedException();
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (id != contact.Id)
            //{
            //    return BadRequest();
            //}

            //_dbContext.Entry(contact).State = EntityState.Modified;

            //try
            //{
            //    await _dbContext.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!ContactExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/v1/user/5/Contact
        [HttpPost]
        [ResponseType(typeof(ContactDto))]
        public async Task<IHttpActionResult> PostContact(long userId, ContactDto contact)
        {
            throw new NotImplementedException();
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //_dbContext.Contacts.Add(contact);

            //try
            //{
            //    await _dbContext.SaveChangesAsync();
            //}
            //catch (DbUpdateException)
            //{
            //    if (ContactExists(contact.Id))
            //    {
            //        return Conflict();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return CreatedAtRoute("DefaultApi", new { id = contact.Id }, contact);
        }

        // DELETE: api/v1/user/5/Contact
        [HttpDelete]
        [ResponseType(typeof(ContactDto))]
        public async Task<IHttpActionResult> DeleteContact(long userId)
        {
            throw new NotImplementedException();
            //Contact contact = await _dbContext.Contacts.FindAsync(id);
            //if (contact == null)
            //{
            //    return NotFound();
            //}

            //_dbContext.Contacts.Remove(contact);
            //await _dbContext.SaveChangesAsync();

            //return Ok(contact);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        _dbContext.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool ContactExists(long id)
        //{
        //    return _dbContext.Contacts.Count(e => e.Id == id) > 0;
        //}
    }
}