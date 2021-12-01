using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Question { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? CategoryFeedbackId { get; set; }
        public string Email { get; set; }

        public virtual CategoryFeedback CategoryFeedback { get; set; }
    }
}
