using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegistrationBackend.Dtos;

namespace UserRegistrationBackend.Services
{
    public interface INameService
    {
        Task<IEnumerable<NameDto>> GetAllNames();
    }
}
