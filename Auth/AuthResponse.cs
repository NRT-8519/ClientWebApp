namespace ClientWebApp.Auth
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public string ReferenceToken { get; set; }

        public bool IsAuthSuccessful { get; set; }
        public string ErrorMessage { get; set; }
    }
}
