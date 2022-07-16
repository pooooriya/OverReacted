using Jobguy.Application.Contracts;
using OverReacted.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OverReacted.Application.Utilities;
using OverReacted.Application.Dtos.Auth;
using OverReacted.Application.Dtos.Api;
using OverReacted.Application.Interfaces;

namespace OverReacted.Application.Services.Implements
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> repository;
        private readonly ITokenProvider tokenProvider;

        public UserService(IRepository<User> repository, ITokenProvider tokenProvider)
        {
            this.repository = repository;
            this.tokenProvider = tokenProvider;
        }
        public Task<bool> IsUserExistAsync(string email)
        {
            return repository.TableNoTracking.AnyAsync(n => n.Email == email);
        }

        public async Task<ApiResult> LoginUserAsync(string email, string password, CancellationToken cancellationToken)
        {
            var UserInfo = await repository.TableNoTracking.FirstAsync(n => n.Email == email);
            if (UserInfo.IsActive == false)
            {
                return new ApiResult
                {
                    IsError = true,
                    Error = "Your Account Had Been Blocked !",
                    StatusCode = 401
                };
            }

            if (UserInfo.IsEmailActive == false)
            {
                return new ApiResult
                {
                    IsError = true,
                    Error = "Your Email Not Activated Yet !",
                    StatusCode = 401
                };
            }

            if (UserInfo.Password != SecurityHelper.GetSha256Hash(password))
            {
                return new ApiResult
                {
                    IsError = true,
                    Error = "Your Email Or Creds Isn't Valid",
                    StatusCode = 400
                };
            }
            //generate token
            var accessToken = tokenProvider.GenerateAccessToken(UserInfo);
            return new ApiResult
            {
                Data = new LoginResultDto
                {
                    AccessToken = accessToken,
                    Email = email,
                    Role = Enum.GetName(typeof(RoleType), UserInfo.RoleId),
                },
                IsError = false,
                StatusCode = 200
            };
        }

        public async Task<User> RegisterUserAsync(RegisterUserDto user, CancellationToken cancellationToken)
        {
            var verificationCode = Guid.NewGuid().ToString("N");
            var NewUser = new User()
            {
                Email = user.Email,
                CreatedOnUTC = DateTime.UtcNow,
                IsActive = true,
                IsEmailActive = false,
                RoleId = (int)RoleType.Authenticated,
                VerifyCode = verificationCode,
                Password = SecurityHelper.GetSha256Hash(user.Password),
                LastVerificationSent = DateTime.UtcNow,
                Name = user.Name,
                Avatar = user.Avatar,
            };
            await repository.AddAsync(NewUser, cancellationToken);
            return NewUser;
        }

        public async Task<bool> ResetUserPassword(string email, CancellationToken cancellationToken)
        {
            var UserInfo = await repository.Table.FirstOrDefaultAsync(x => x.Email == email);
            if (UserInfo == null || UserInfo.IsActive == false || UserInfo.IsEmailActive == false)
            {
                return false;
            }
            UserInfo.LastVerificationSent = DateTime.UtcNow;
            await repository.UpdateAsync(UserInfo, cancellationToken);
            return true;
        }

        public async Task<bool> ValidateUserEmailAsync(string verifyCode, CancellationToken cancellationToken)
        {
            var userInfo = await repository.Table.SingleOrDefaultAsync(n => n.VerifyCode == verifyCode);
            if (userInfo == null || userInfo?.LastVerificationSent?.AddMinutes(2) < DateTime.UtcNow || userInfo.IsActive == false)
            {
                return false;
            }
            userInfo.IsEmailActive = true;
            await repository.UpdateAsync(userInfo, cancellationToken);
            return true;
        }
    }
}
