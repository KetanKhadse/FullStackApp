using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APi.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public int? StickId { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public Stock? stock { get; set; }

    }
}