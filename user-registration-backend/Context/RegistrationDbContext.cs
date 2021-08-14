using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using UserRegistrationBackend.Models;

namespace UserRegistrationBackend.Context
{

    public class RegistrationDbContext : DbContext, IRegistrationDbContext
    {
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Name> Names { get; set; }
        public virtual DbSet<AppUser> Users { get; set; }

        public RegistrationDbContext() : base("RegistrationContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            var addressEntity = modelBuilder.Entity<Address>()
                .HasKey(address => address.Id);
            addressEntity.Property(address => address.StreetAddress);
            addressEntity.Property(address => address.City);
            addressEntity.Property(address => address.State);
            addressEntity.Property(address => address.ZipCode);

            var contactEntity = modelBuilder.Entity<Contact>()
                .HasKey(contact => contact.Id);
            contactEntity.Property(contact => contact.Email);
            contactEntity.Property(contact => contact.Phone);

            var nameEntity = modelBuilder.Entity<Name>()
                .HasKey(name => name.Id);
            nameEntity.Property(name => name.FirstName);
            nameEntity.Property(name => name.LastName);

            var userEntity = modelBuilder.Entity<AppUser>()
                .HasKey(user => user.Id);
            userEntity.HasRequired(user => user.Address)
                .WithOptional(address => address.User);
            userEntity.HasRequired(user => user.Contact)
                .WithOptional(contact => contact.User);
            userEntity.HasRequired(user => user.Name)
                .WithOptional(name => name.User);
            userEntity.HasRequired(user => user.Salt);
            userEntity.HasRequired(user => user.PasswordHash);
        }
    }
}