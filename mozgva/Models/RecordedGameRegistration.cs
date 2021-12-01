using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class RecordedGameRegistration
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public string TeamName { get; set; }
        public int? RoundOne { get; set; }
        public int? RoundTwo { get; set; }
        public int? RoundThree { get; set; }
        public int? RoundFour { get; set; }
        public int? RoundFive { get; set; }
        public int? RoundSix { get; set; }
        public int? RoundSeven { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string SecretCode { get; set; }
    }
}
