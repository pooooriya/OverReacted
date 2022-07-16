using OverReacted.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Domain.Entities
{
    public class Article : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public int EstimationReadTime { get; set; }
        public Guid UserId { get; set; }
        public User Author { get; set; }
    }
}
