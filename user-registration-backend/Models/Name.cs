using System;

namespace user_registration_backend.Models
{
    public class Name
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual AppUser User { get; set; }
    }
}