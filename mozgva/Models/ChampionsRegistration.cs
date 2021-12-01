using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class ChampionsRegistration
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public int? ChampionsLeagueId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? QuarterFinal { get; set; }
        public int? SemiFinal { get; set; }
        public int? Final { get; set; }

        public virtual ChampionsLeague ChampionsLeague { get; set; }
        public virtual Team Team { get; set; }
    }
}
