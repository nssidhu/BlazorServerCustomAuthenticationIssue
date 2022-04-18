using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;
using Models;
using Microsoft.JSInterop;
using Newtonsoft.Json;

namespace BlazorWasm.Client.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
      
       private readonly IJSRuntime _jsruntime;
        public  CustomAuthenticationStateProvider(IJSRuntime jsruntime)
        {
              _jsruntime = jsruntime;
        }

        private ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity());

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
      
            return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(claimsPrincipal)));
        }

        public async Task SetAuthInfo()
        {
          
            try
            {
                var identity = new ClaimsIdentity(new Claim[] {
                            new Claim(ClaimTypes.Name,"user1"),
                            new Claim(ClaimTypes.Email,"user1@email.com"),
                             new Claim(ClaimTypes.Role,"admin"),
                            },"AuthInfo");

                claimsPrincipal = new ClaimsPrincipal(identity);
                               
                NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            }
            catch (Exception ex)
            {

                throw;
            }

          
        }

        public async Task Logout()
        {
            var authInfojson = await _jsruntime.InvokeAsync<string>("localStorage.removeitem", "AuthInfo");
         
            claimsPrincipal = new ClaimsPrincipal(new ClaimsIdentity());
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
    
}
