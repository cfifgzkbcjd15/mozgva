using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameIngosGameInstance
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public int? GameId { get; set; }
        public int? LastTour { get; set; }
        public int? LastQuestion { get; set; }
        public bool? IntermediateTable { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
