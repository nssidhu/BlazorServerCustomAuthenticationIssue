using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Refit;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Models;
using Domain.Services;

using Microsoft.Extensions.Logging;

using System.Threading.Tasks;

using BlazorWasm.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Blazor.Services
{
    public class LoginService 
    {
       
       
        CustomAuthenticationStateProvider _custAuthProvider;
     
        public LoginService(IServiceProvider serviceProvider)
        {
            _custAuthProvider = serviceProvider.GetRequiredService<CustomAuthenticationStateProvider>();
        }

        public async Task<string> GetUserInfo2()
        {
            return await Task.FromResult("Here is the UserInfo");
        }

        public async Task<string> Login(string userName, string password)
        {
           


            if (userName == "user1")
            {
                await _custAuthProvider.SetAuthInfo();
                return await Task.FromResult("success");
            }
            else
            {
                return await Task.FromResult("Fail");
            }
               

        }

        public async Task Logout()
        {
           await  _custAuthProvider.Logout();
        }


    }
}
