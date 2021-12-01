using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class ChampionshipBeginnerRegistration
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Phone { get; set; }
        public DateTime? When { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
