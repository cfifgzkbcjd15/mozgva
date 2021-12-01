using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Invitation
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public int? UserId { get; set; }
        public int? InviterId { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual User Inviter { get; set; }
        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}
