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
    public class AddressController : ApiController
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        // GET: api/v1/user/5/Address
        [HttpGet]
        public async Task<IEnumerable<AddressDto>> GetAddresses(long userId)
        {
            throw new NotImplementedException();
            //Address address = await _dbContext.Addresses.FindAsync(id);
            //if (address == null)
            //{
            //    return NotFound();
            //}
            //return Ok(address);
        }

        // PUT: api/v1/user/5/Address
        [HttpPut]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutAddress(long userId, AddressDto address)
        {
            throw new NotImplementedException();
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //if (id != address.Id)
            //{
            //    return BadRequest();
            //}

            //_dbContext.Entry(address).State = EntityState.Modified;

            //try
            //{
            //    await _dbContext.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!AddressExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/v1/user/5/Address
        [HttpPost]
        [ResponseType(typeof(AddressDto))]
        public async Task<IHttpActionResult> PostAddress(long userId, AddressDto address)
        {
            throw new NotImplementedException();
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //_dbContext.Addresses.Add(address);

            //try
            //{
            //    await _dbContext.SaveChangesAsync();
            //}
            //catch (DbUpdateException)
            //{
            //    if (AddressExists(address.Id))
            //    {
            //        return Conflict();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return CreatedAtRoute("DefaultApi", new { id = address.Id }, address);
        }

        // DELETE: api/v1/user/5/Address
        [HttpDelete]
        [ResponseType(typeof(AddressDto))]
        public async Task<IHttpActionResult> DeleteAddress(long userId)
        {
            throw new NotImplementedException();
            //Address address = await _dbContext.Addresses.FindAsync(id);
            //if (address == null)
            //{
            //    return NotFound();
            //}

            //_dbContext.Addresses.Remove(address);
            //await _dbContext.SaveChangesAsync();

            //return Ok(address);
        }

        //private bool AddressExists(long id)
        //{
        //    return _dbContext.Addresses.Count(e => e.Id == id) > 0;
        //}
    }
}