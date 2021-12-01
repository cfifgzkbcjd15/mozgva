using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class QuickRegistration
    {
        public int Id { get; set; }
        public string CaptainName { get; set; }
        public string CaptainPhone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? GameRegistrationId { get; set; }
        public int? StandbyId { get; set; }
        public bool? UserAgreement { get; set; }
    }
}
