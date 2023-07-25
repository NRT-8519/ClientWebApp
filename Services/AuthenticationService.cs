using Blazored.LocalStorage;
using ClientWebApp.Auth;
using ClientWebApp.AuthProviders;
using ClientWebApp.Features;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace ClientWebApp.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient client;
        private readonly JsonSerializerOptions options;
        private readonly AuthenticationStateProvider authProvider;
        private readonly ILocalStorageService localStorage;

        public AuthenticationService(HttpClient client, AuthenticationStateProvider authProvider, ILocalStorageService localStorage)
        {
            this.client = client;
            this.authProvider = authProvider;
            this.localStorage = localStorage;
            this.options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
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

            ((AuthStateProvider) authProvider).NotifyUserAuthentication(userAuth.Username);

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", result.Token);

            return new AuthResponse { IsAuthSuccessful = true };
        }

        public async Task Logout()
        {
            await localStorage.RemoveItemAsync("token");
            ((AuthStateProvider) authProvider).NotifyUserLogout();
            client.DefaultRequestHeaders.Authorization = null;
        }
    }
}
