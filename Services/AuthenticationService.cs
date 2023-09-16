using Blazored.LocalStorage;
using ClientWebApp.Auth;
using ClientWebApp.AuthProviders;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace ClientWebApp.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public NavigationManager navigationManager;

        private readonly HttpClient client;
        private readonly JsonSerializerOptions options;
        private readonly AuthenticationStateProvider authProvider;
        private readonly ILocalStorageService localStorage;
        private bool IsLoggedIn = false;
        private bool KeepingSession;

        

        public AuthenticationService(HttpClient client, AuthenticationStateProvider authProvider, ILocalStorageService localStorage, NavigationManager navigationManager)
        {
            this.client = client;
            this.authProvider = authProvider;
            this.localStorage = localStorage;
            this.options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            this.navigationManager = navigationManager;
        }

        public async Task<AuthResponse> Login(UserAuth userAuth)
        {
            var content = JsonSerializer.Serialize(userAuth);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");

            var authResult = await client.PostAsync("api/users/authenticate", bodyContent);
            var authContent = await authResult.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<AuthResponse>(authContent, options);

            if (!authResult.IsSuccessStatusCode)
            {
                return result;
            }

            await localStorage.SetItemAsync("token", result.Token);

            IsLoggedIn = true;
            
            if (!KeepingSession)
            {
                KeepSession();
            }

            ((AuthStateProvider) authProvider).NotifyUserAuthentication(result.Token);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", result.Token);
            return new AuthResponse { IsAuthSuccessful = true };
        }

        public async Task Logout()
        {
            await localStorage.RemoveItemAsync("token");
            IsLoggedIn = false;
            ((AuthStateProvider) authProvider).NotifyUserLogout();
            client.DefaultRequestHeaders.Authorization = null;
        }

        public async void KeepSession()
        {
            KeepingSession = true;
            var token = await localStorage.GetItemAsStringAsync("token");
            if (token != null && !token.Equals("") && !token.Equals("invalid_token"))
            {
                IsLoggedIn = true;

                while (IsLoggedIn)
                {
                    var authResult = await client.GetAsync("api/users/validate?token=" + token.ToString().Trim('"'));

                    var result = await authResult.Content.ReadAsStringAsync();

                    bool.TryParse(result, out bool isExpired);

                    if (!isExpired)
                    {
                        await Logout();
                        navigationManager.NavigateTo("/login");
                        KeepingSession = false;
                        break;
                    }

                    await Task.Delay(10 * 1000);
                }
            }
            else
            {
                navigationManager.NavigateTo("/login");
                KeepingSession = false;
            }
        }
    }
}
