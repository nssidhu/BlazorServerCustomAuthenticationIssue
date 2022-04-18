using Models;
using Refit;
using System.Threading.Tasks;


namespace Domain.Services
{


    [Headers("Content-Type: application/json")]
    public interface IApplicationApi
    {
        //[Post("/Account/Login")]
        //Task<IActionResult> Login([Body] DTO_LoginUser credentials);

        [Post("/api/Account/Login")]
        Task<ApiResponse<DTO_LoginSuccessResponse>> Login([Body] string userName, [Body]string password);



        [Get("/api/Account/GetUserInfo")]
        [Headers("Authorization: Bearer")]
        Task<ApiResponse<DTO_LoginSuccessResponse>> GetUserInfo2();



    }
}
