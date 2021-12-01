using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameUnregistration
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public int? GameId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Game Game { get; set; }
        public virtual Team Team { get; set; }
    }
}
