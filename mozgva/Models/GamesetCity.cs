using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GamesetCity
    {
        public int Id { get; set; }
        public int? GamesetId { get; set; }
        public int? CityId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
