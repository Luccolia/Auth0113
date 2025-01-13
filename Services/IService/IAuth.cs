using AuthApi.Models.Dtos;
using Microsoft.AspNetCore.Identity.Data;

namespace AuthApi.Services.IService
{
    public interface IAuth
    {
        Task<object> Login(LoginRequestDto loginRequestDto);
        Task<object> Register(RegisterRequestDto registerRequestDto);
    }
}
