using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class TestModeration
    {
        public int Id { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public bool? Correct { get; set; }
        public bool? Incorrect { get; set; }
        public int? UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
