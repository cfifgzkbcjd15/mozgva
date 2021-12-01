using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class SpecialRegistration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SpecialGameId { get; set; }
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
        public bool? Banned { get; set; }
        public int? UserId { get; set; }
        public string[] UserConnections { get; set; }
        public string Email { get; set; }
        public string CityName { get; set; }

        public virtual SpecialGame SpecialGame { get; set; }
    }
}
