using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class ThematicRating
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Description { get; set; }
    }
}
