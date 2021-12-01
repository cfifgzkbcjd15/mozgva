using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class ParlayExpress
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? GameId { get; set; }
        public string[] AccurateArray { get; set; }
        public string[] RangeArray { get; set; }
        public string[] ForaArray { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? Parlay { get; set; }
        public bool? Closed { get; set; }
    }
}
