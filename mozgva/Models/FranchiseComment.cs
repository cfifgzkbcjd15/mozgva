using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class FranchiseComment
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? TeamId { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
