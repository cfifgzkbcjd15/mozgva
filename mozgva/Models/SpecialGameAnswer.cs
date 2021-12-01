using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class SpecialGameAnswer
    {
        public int Id { get; set; }
        public int? SpecialGameId { get; set; }
        public int? SpecialRegistrationId { get; set; }
        public string Answer { get; set; }
        public int? TourNumber { get; set; }
        public int? QuestionNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Correct { get; set; }
    }
}
