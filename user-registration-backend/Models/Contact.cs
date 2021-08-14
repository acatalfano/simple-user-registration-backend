namespace UserRegistrationBackend.Models
{
    public class Contact
    {
        public long Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual AppUser User { get; set; }
    }
}