using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class RegistrationStatistic
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public DateTime? LastReg { get; set; }
        public DateTime? ExpectedReg { get; set; }
        public DateTime? SendTime { get; set; }
        public int? DifferenceReg { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
