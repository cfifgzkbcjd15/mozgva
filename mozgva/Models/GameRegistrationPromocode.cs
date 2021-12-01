using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameRegistrationPromocode
    {
        public int Id { get; set; }
        public int? GameRegistrationId { get; set; }
        public int? PromocodeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
