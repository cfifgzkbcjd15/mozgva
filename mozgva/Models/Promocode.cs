using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Promocode
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int? PersonCount { get; set; }
        public int? UsedCount { get; set; }
        public bool? Issued { get; set; }
        public DateTime? IssuedDate { get; set; }
        public string ValidityType { get; set; }
        public DateTime? ValidityOff { get; set; }
        public int? SpecialGameId { get; set; }
        public string Issuer { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Game SpecialGame { get; set; }
    }
}
