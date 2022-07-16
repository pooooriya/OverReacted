using OverReacted.Application.Dtos.Api;
using OverReacted.Application.Dtos.Auth;
using OverReacted.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Application.Services
{
    public interface IUserService
    {
        Task<bool> IsUserExistAsync(string email);
        Task<User> RegisterUserAsync(RegisterUserDto user, CancellationToken cancellationToken);
        Task<ApiResult> LoginUserAsync(string email, string password, CancellationToken cancellationToken);
        Task<bool> ValidateUserEmailAsync(string verifyCode, CancellationToken cancellationToken);
        Task<bool> ResetUserPassword(string email, CancellationToken cancellationToken);
    }
}
