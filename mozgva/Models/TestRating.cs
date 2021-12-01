using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class TestRating
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? TestCount { get; set; }
        public int? Tour1 { get; set; }
        public int? Tour2 { get; set; }
        public int? Tour3 { get; set; }
        public int? Tour4 { get; set; }
        public int? Tour5 { get; set; }
        public int? Tour6 { get; set; }
        public int? Tour7 { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
