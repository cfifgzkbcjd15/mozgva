using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class QuizQuestion
    {
        public int Id { get; set; }
        public int? TourId { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string[] CorrectAnswerVariants { get; set; }
        public string InterestingFact { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? Number { get; set; }
    }
}
