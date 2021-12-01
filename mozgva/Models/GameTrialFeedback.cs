using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameTrialFeedback
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
