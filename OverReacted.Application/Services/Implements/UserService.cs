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
using OverReacted.Application.Dtos;
using Microsoft.Extensions.Options;
using OverReacted.Application.Dtos.Settings;

namespace OverReacted.Application.Services.Implements
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> repository;
        private readonly ITokenProvider tokenProvider;
        private readonly IEmailService emailService;
        private readonly IOptions<AuthenticationSetting> options;

        public UserService(IRepository<User> repository, ITokenProvider tokenProvider,IEmailService emailService, IOptions<AuthenticationSetting> options)
        {
            this.repository = repository;
            this.tokenProvider = tokenProvider;
            this.emailService = emailService;
            this.options = options;
        }
        public Task<bool> IsUserExistAsync(string email)
        {
            return repository.TableNoTracking.AnyAsync(n => n.Email == email);
        }

        public async Task<ApiResult> LoginUserAsync(string email, string password, CancellationToken cancellationToken)
        {
            var UserInfo = await repository.TableNoTracking.Include(n=>n.Role).FirstAsync(n => n.Email == email);
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
            await emailService.SendEmailAsync(new MailRequest
            {
                Subject = "Verification Link",
                Body = $"Your Verfication Link :{String.Format(options.Value.VerificationLink, NewUser.VerifyCode)}",
                ToEmail = user.Email
            });
            return NewUser;
        }

        public async Task<bool> ResetUserPassword(string email, CancellationToken cancellationToken)
        {
            var UserInfo = await repository.Table.FirstOrDefaultAsync(x => x.Email == email);
            if (UserInfo == null || UserInfo.IsActive == false || UserInfo.IsEmailActive == false)
            {
                return false;
            }
            var verificationCode = Guid.NewGuid().ToString("N");
            UserInfo.LastVerificationSent = DateTime.UtcNow;
            UserInfo.VerifyCode = verificationCode;
            await repository.UpdateAsync(UserInfo, cancellationToken);
            await emailService.SendEmailAsync(new MailRequest
            {
                Subject = "Reset Password Link",
                Body = $"Your Reset Password Link :{String.Format(options.Value.VerificationLink, verificationCode)}",
                ToEmail = email
            });
            return true;
        }

        public async Task<bool> ValidateUserEmailAsync(string verifyCode, CancellationToken cancellationToken)
        {
            var userInfo = await repository.Table.SingleOrDefaultAsync(n => n.VerifyCode == verifyCode);
            if (userInfo == null || userInfo.IsActive == false)
            {
                return false;
            }
            userInfo.IsEmailActive = true;
            userInfo.VerifyCode = Guid.NewGuid().ToString("N");
            await repository.UpdateAsync(userInfo, cancellationToken);
            return true;
        }
    }
}
