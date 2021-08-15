namespace UserRegistrationBackend.Dtos
{
    public class UserDto
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public NameDto Name { get; set; }
        public ContactDto Contact { get; set; }
        public AddressDto Address { get; set; }
    }
}