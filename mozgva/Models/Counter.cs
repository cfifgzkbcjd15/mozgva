using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Counter
    {
        public int Id { get; set; }
        public int? Count { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
    }
}
