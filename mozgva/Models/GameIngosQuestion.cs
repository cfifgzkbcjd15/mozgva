using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameIngosQuestion
    {
        public int Id { get; set; }
        public int? TourId { get; set; }
        public int? Number { get; set; }
        public int? DelayTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string VideoUrl { get; set; }
    }
}
