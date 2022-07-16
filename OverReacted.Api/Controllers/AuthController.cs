using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using OverReacted.Application.Dtos;
using OverReacted.Application.Dtos.Api;
using OverReacted.Application.Dtos.Auth;
using OverReacted.Application.Dtos.Settings;
using OverReacted.Application.Interfaces;
using OverReacted.Application.Services;
using OverReacted.Application.Utilities;
using OverReacted.Domain.Entities;

namespace OverReacted.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IOptions<AuthenticationSetting> options;

        public AuthController(IUserService userService, IOptions<AuthenticationSetting> options)
        {
            this.userService = userService;
            this.options = options;
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser(RegisterUserDto user, CancellationToken cancellationToken)
        {
            try
            {
                var UserExist = await userService.IsUserExistAsync(user.Email);
                if (UserExist)
                {
                    return BadRequest(new ApiResult
                    {
                        Data = "",
                        Error = "Email Already Exist , Please Login !",
                        IsError = true,
                        StatusCode = 400
                    });
                }
                var RegisterUser = await userService.RegisterUserAsync(user, cancellationToken);
        

                return Ok(new ApiResult
                {
                    Data = "Verification Link Has Been Sent To Your Email",
                    Error = "",
                    IsError = false,
                    StatusCode = 200
                });
            }
            catch
            {
                return BadRequest(new ApiResult
                {
                    Error = "server has error please try later",
                    IsError = true,
                    StatusCode = 500,
                    Data = ""
                });
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginUser(LoginUserDto user, CancellationToken cancellationToken)
        {
            try
            {
                var UserExist = await userService.IsUserExistAsync(user.Email);
                if (!UserExist)
                {
                    return BadRequest(new ApiResult
                    {
                        Data = "",
                        Error = "Your Email Isn't Exist , Please Register First !",
                        IsError = true,
                        StatusCode = 400
                    });
                }
                var loginUser = await userService.LoginUserAsync(user.Email, user.Password, cancellationToken);
                return StatusCode(loginUser.StatusCode, loginUser);
            }
            catch
            {
                return BadRequest(new ApiResult
                {
                    Error = "server has error please try later",
                    IsError = true,
                    StatusCode = 500,
                    Data = ""
                });
            }
        }

        [HttpGet("verify/{verifycode}")]
        public async Task<IActionResult> VerifyUserEmail([FromRoute] string verifycode, CancellationToken cancellationToken)
        {
            var verifyUserEmail = await userService.ValidateUserEmailAsync(verifycode, cancellationToken);
            if (!verifyUserEmail)
            {
               return BadRequest();
            }
            return Ok();
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetUserPassword(ResetUserPasswordDto user, CancellationToken cancellationToken)
        {
            var RestPassword = await userService.ResetUserPassword(user.Email, cancellationToken);
            if(RestPassword == false)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
