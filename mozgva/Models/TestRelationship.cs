using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class TestRelationship
    {
        public int Id { get; set; }
        public int? TourId { get; set; }
        public int? QuestionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
