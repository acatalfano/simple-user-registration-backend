namespace UserRegistrationBackend.Models
{
    public class AppUser
    {
        public long Id { get; set; }
        public long NameId { get; set; }
        public long ContactId { get; set; }
        public long AddressId { get; set; }
        public string Username { get; set; }
        public string Salt { get; set; }
        public string PasswordHash { get; set; }

        public virtual Name Name { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Address Address { get; set; }
    }
}