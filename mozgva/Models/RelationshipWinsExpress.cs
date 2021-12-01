using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class RelationshipWinsExpress
    {
        public int Id { get; set; }
        public int? ParlayWhoWinId { get; set; }
        public int? ParlayExpressId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
