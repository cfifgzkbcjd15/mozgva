using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class RequestInvitation
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? MemberId { get; set; }

        public virtual Team Team { get; set; }
    }
}
