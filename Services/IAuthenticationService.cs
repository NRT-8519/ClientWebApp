using ClientWebApp.Auth;

namespace ClientWebApp.Services
{
    public interface IAuthenticationService
    {
        Task<AuthResponse> Login(UserAuth userAuth);
        Task Logout();
    }
}
