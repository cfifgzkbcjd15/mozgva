using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class ChampionsLeague
    {
        public ChampionsLeague()
        {
            ChampionsRegistrations = new HashSet<ChampionsRegistration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? MaxTeamsNumber { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<ChampionsRegistration> ChampionsRegistrations { get; set; }
    }
}
