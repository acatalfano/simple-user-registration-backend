using System;

namespace user_registration_backend.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public virtual AppUser User { get; set; }
    }
}