using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Scoring
    {
        public int Id { get; set; }
        public int? Points { get; set; }
        public int? UserId { get; set; }
        public string Key { get; set; }
        public int? TeamId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}
