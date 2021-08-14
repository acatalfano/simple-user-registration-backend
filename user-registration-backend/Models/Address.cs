using System;

namespace user_registration_backend.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }

        public virtual AppUser User { get; set; }
    }
}
