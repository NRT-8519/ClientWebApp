using ClientWebApp.Auth;
using ClientWebApp.Services;
using Microsoft.AspNetCore.Components;

namespace ClientWebApp.Pages
{
    public partial class Login
    {
        private UserAuth userAuth = new UserAuth();

        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public bool ShowAuthError {  get; set; }
        public string Error { get; set; }

        public async Task ExecuteLogin()
        {
            ShowAuthError = false;

            var result = await AuthenticationService.Login(userAuth);
            if (!result.IsAuthSuccessful)
            {
                Error = result.ErrorMessage;
                ShowAuthError = true;
            }
            else
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }
}
