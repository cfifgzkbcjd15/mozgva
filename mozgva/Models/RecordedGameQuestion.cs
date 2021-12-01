using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class RecordedGameQuestion
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public int? TourId { get; set; }
        public string[] CorrectAnswerVariants { get; set; }
        public string[] IncorrectAnswerVariants { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
