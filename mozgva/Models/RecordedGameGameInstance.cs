using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class RecordedGameGameInstance
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public int? RegistrationId { get; set; }
        public int CurrentTourNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? ResetCount { get; set; }
    }
}
