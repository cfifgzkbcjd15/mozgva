using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameTrialReconciliation
    {
        public int Id { get; set; }
        public int? TourId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? DelayTime { get; set; }
    }
}
