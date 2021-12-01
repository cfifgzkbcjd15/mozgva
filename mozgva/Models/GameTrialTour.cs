using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameTrialTour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
