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
    public class NameController : ApiController
    {
        private readonly INameService _nameService;

        public NameController(INameService nameService)
        {
            _nameService = nameService;
        }

        // GET: api/v1/user/5/Name
        [HttpGet]
        public async Task<IEnumerable<NameDto>> GetName(long userId)
        {
            return await _nameService.GetAllNames();
        }

        // PUT: api/v1/user/5/Name
        [HttpPut]
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutName(long userId, NameDto name)
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

        // POST: api/v1/user/5/Name
        [HttpPost]
        [ResponseType(typeof(NameDto))]
        public async Task<IHttpActionResult> PostName(long userId, NameDto name)
        {
            throw new NotImplementedException();
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //_dbContext.Names.Add(name);

            //try
            //{
            //    await _dbContext.SaveChangesAsync();
            //}
            //catch (DbUpdateException)
            //{
            //    if (NameExists(name.Id))
            //    {
            //        return Conflict();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return CreatedAtRoute("DefaultApi", new { id = name.Id }, name);
        }

        // DELETE: api/v1/user/5/Name
        [HttpDelete]
        [ResponseType(typeof(NameDto))]
        public async Task<IHttpActionResult> DeleteName(long userId)
        {
            throw new NotImplementedException();
            //Name name = await _dbContext.Names.FindAsync(id);
            //if (name == null)
            //{
            //    return NotFound();
            //}

            //_dbContext.Names.Remove(name);
            //await _dbContext.SaveChangesAsync();

            //return Ok(name);
        }

        //private bool NameExists(long id)
        //{
        //    return _dbContext.Names.Count(e => e.Id == id) > 0;
        //}
    }
}