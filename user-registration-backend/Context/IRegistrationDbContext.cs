using System.Data.Entity;
using user_registration_backend.Models;

namespace user_registration_backend.Context
{

    public interface IRegistrationDbContext : IDbContext
    {
        DbSet<Address> Addresses { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Name> Names { get; set; }
        DbSet<AppUser> Users { get; set; }
    }
}
