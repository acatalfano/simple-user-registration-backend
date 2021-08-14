using System.Data.Entity;
using UserRegistrationBackend.Models;

namespace UserRegistrationBackend.Context
{

    public interface IRegistrationDbContext : IDbContext
    {
        DbSet<Address> Addresses { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Name> Names { get; set; }
        DbSet<AppUser> Users { get; set; }
    }
}
