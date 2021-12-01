using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class ParlayWinner
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? GameId { get; set; }
        public int? ValueAccurateScore { get; set; }
        public int? ParlayAccurateScore { get; set; }
        public int? ValueRangeScores { get; set; }
        public int? ParlayRangeScores { get; set; }
        public int? ValueFora { get; set; }
        public int? ParlayFora { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public double? RatioFora { get; set; }
        public bool? Closed { get; set; }
        public string TokenId { get; set; }
    }
}
