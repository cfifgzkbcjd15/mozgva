using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameIngosTour
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public bool? Plus2 { get; set; }
        public bool? Plus3 { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
