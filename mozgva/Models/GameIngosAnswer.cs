using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameIngosAnswer
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public int? QuestionId { get; set; }
        public string Answer { get; set; }
        public bool? Correct { get; set; }
        public bool? Uncorrect { get; set; }
        public int? PlusPoints { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? AdditionalScore { get; set; }

        public virtual Team Team { get; set; }
    }
}
