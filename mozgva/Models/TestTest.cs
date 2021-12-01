using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class TestTest
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? LastTour { get; set; }
        public int? LastQuestion { get; set; }
        public bool? EndPage { get; set; }
    }
}
