using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class RatiosGame
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public double? AccurateScore { get; set; }
        public double? RangeScores { get; set; }
        public double? Fora { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? CloseParlay { get; set; }
        public double? Fora2 { get; set; }
        public double? Fora3 { get; set; }
        public double? Fora4 { get; set; }
        public double? Fora5 { get; set; }
        public double? Fora6 { get; set; }
        public double? Fora0 { get; set; }
        public bool? ActivePassFinal { get; set; }
        public bool? ActiveWhoWin { get; set; }
        public bool? ActiveWinner { get; set; }
        public bool? ActiveExpress { get; set; }
    }
}
