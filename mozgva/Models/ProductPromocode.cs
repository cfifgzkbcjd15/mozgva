using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class ProductPromocode
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Discount { get; set; }
        public int? ProductId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UsedCount { get; set; }
    }
}
