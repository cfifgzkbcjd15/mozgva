using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class ThematicRatingCity
    {
        public int Id { get; set; }
        public int? CityId { get; set; }
        public int? ThematicRatingId { get; set; }
    }
}
