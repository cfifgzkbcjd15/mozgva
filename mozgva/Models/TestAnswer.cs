using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class TestAnswer
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? QuestionId { get; set; }
        public string Answer { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Correct { get; set; }
        public bool? Incorrect { get; set; }
    }
}
