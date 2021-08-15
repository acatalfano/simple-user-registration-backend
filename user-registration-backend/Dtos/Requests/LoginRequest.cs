namespace UserRegistrationBackend.Dtos.Requests
{
    public class LoginRequest
    {
        public string RawPassword { get; set; }
        public string Username { get; set; }
    }
}