using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Lightning
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public bool? Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
