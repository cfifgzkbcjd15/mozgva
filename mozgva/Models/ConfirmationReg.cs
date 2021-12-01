using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class ConfirmationReg
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public int? GameRegistrationId { get; set; }
        public string Status { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
