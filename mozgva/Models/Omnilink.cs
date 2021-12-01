using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Omnilink
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Provider { get; set; }
        public string Uid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Omniauth { get; set; }

        public virtual User User { get; set; }
    }
}
