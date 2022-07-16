using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Application.Dtos.Article
{
    public class GetAllPostDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string? Body { get; set; }
        public int EstimationReadTime { get; set; }
        public string Author { get; set; }
    }
}
