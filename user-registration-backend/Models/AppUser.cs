using System;

namespace user_registration_backend.Models
{
    public class AppUser
    {
        public Guid Id { get; set; }
        public Guid NameId { get; set; }
        public Guid ContactId { get; set; }
        public Guid AddressId { get; set; }
        public string Username { get; set; }
        public string Salt { get; set; }
        public string PasswordHash { get; set; }

        public virtual Name Name { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Address Address { get; set; }
    }
}