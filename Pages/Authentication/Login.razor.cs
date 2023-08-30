using ClientWebApp.Auth;
using ClientWebApp.Services;
using Microsoft.AspNetCore.Components;

namespace ClientWebApp.Pages.Authentication
{
    public partial class Login
    {
        private UserAuth userAuth = new UserAuth { Username = "", Password = "" };

        [Inject]
        public IAuthenticationService AuthenticationService { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public bool ShowAuthError { get; set; }
        public bool IsDisabled { get; set; } = false;
        public string Error { get; set; }

        public async Task ExecuteLogin()
        {
            ShowAuthError = false;
            if (!userAuth.Username.Equals("") && !userAuth.Password.Equals(""))
            {
                IsDisabled = true;

                await Task.Delay(1000);
                var result = await AuthenticationService.Login(userAuth);
                if (!result.IsAuthSuccessful)
                {
                    Error = result.ErrorMessage;
                    ShowAuthError = true;
                }
                else
                {
                    ShowAuthError = false;
                    NavigationManager.NavigateTo("/");
                }
                IsDisabled = false;
            }
            else
            {
                Error = "Please fill in the username and password fields!";
                ShowAuthError = true;
            }
        }
    }
}
