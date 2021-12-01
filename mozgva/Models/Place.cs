using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Place
    {
        public Place()
        {
            Games = new HashSet<Game>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Site { get; set; }
        public string Address { get; set; }
        public int? CityId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string GoogleQuery { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}
