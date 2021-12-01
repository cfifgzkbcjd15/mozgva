using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Challenge
    {
        public int Id { get; set; }
        public int? GameRegistrationId { get; set; }
        public int? TeamId { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual GameRegistration GameRegistration { get; set; }
        public virtual Team Team { get; set; }
    }
}
