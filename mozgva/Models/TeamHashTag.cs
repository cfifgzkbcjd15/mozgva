using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class TeamHashTag
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public int? HashTagId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
