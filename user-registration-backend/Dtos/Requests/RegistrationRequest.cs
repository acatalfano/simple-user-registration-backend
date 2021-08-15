namespace UserRegistrationBackend.Dtos.Requests
{
    public class RegistrationRequest
    {
        public string Username { get; set; }
        public string RawPassword { get; set; }

        // All of the remaining fields are optional and can be created later, or can be provided up front
        public AddressDto Address { get; set; }
        public ContactDto Contact { get; set; }
        public NameDto Name { get; set; }
    }
}