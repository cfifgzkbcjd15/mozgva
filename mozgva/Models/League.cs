using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class League
    {
        public League()
        {
            Games = new HashSet<Game>();
            Teams = new HashSet<Team>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}
