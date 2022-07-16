using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Application.Dtos.Auth
{
    public class LoginResultDto
    {
     public string AccessToken { get; set; }
     public string Email { get; set; }
     public string Role { get; set; }
    }
}
