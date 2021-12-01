using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ResourceType { get; set; }
        public int? ResourceId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
