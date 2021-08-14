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
using UserRegistrationBackend.Context;
using UserRegistrationBackend.Models;

namespace UserRegistrationBackend.Controllers
{
    public class AddressesController : ApiController
    {
        private readonly IRegistrationDbContext _dbContext;

        public AddressesController(IRegistrationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/Addresses
        public IQueryable<Address> GetAddresses()
        {
            return _dbContext.Addresses;
        }

        // GET: api/Addresses/5
        [ResponseType(typeof(Address))]
        public async Task<IHttpActionResult> GetAddress(long id)
        {
            Address address = await _dbContext.Addresses.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }

            return Ok(address);
        }

        // PUT: api/Addresses/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAddress(long id, Address address)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != address.Id)
            {
                return BadRequest();
            }

            _dbContext.Entry(address).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(id))
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

        // POST: api/Addresses
        [ResponseType(typeof(Address))]
        public async Task<IHttpActionResult> PostAddress(Address address)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _dbContext.Addresses.Add(address);

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AddressExists(address.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = address.Id }, address);
        }

        // DELETE: api/Addresses/5
        [ResponseType(typeof(Address))]
        public async Task<IHttpActionResult> DeleteAddress(long id)
        {
            Address address = await _dbContext.Addresses.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }

            _dbContext.Addresses.Remove(address);
            await _dbContext.SaveChangesAsync();

            return Ok(address);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AddressExists(long id)
        {
            return _dbContext.Addresses.Count(e => e.Id == id) > 0;
        }
    }
}