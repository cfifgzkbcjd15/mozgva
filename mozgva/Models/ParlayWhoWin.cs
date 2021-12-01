using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class ParlayWhoWin
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? GameId { get; set; }
        public int? TeamId { get; set; }
        public double? Ratio { get; set; }
        public int? Position { get; set; }
        public int? Parlay { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Closed { get; set; }
        public string TokenId { get; set; }
    }
}
