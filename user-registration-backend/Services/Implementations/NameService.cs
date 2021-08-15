using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UserRegistrationBackend.Context;
using UserRegistrationBackend.Dtos;

namespace UserRegistrationBackend.Services.Implementations
{
    public class NameService : INameService
    {
        private readonly IRegistrationDbContext _dbContext;
        public NameService(IRegistrationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<IEnumerable<NameDto>> GetAllNames()
        {
            throw new NotImplementedException();
        }
    }
}