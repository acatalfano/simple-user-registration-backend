namespace UserRegistrationBackend.Models
{
    public class Name
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual AppUser User { get; set; }
    }
}