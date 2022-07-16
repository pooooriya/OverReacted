using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Application.Dtos.Api
{
    public class ApiResult
    {
        public int StatusCode { get; set; }
        public string? Error { get; set; }
        public object Data { get; set; }
        public bool IsError { get; set; }
    }
}
