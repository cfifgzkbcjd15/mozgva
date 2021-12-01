using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameRegistrationSert
    {
        public int Id { get; set; }
        public int? GameRegistrationId { get; set; }
        public int? SertId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual GameRegistration GameRegistration { get; set; }
        public virtual Sert Sert { get; set; }
    }
}
