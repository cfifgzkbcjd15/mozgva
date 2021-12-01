using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class LoyaltyCard
    {
        public int Id { get; set; }
        public int? Number { get; set; }
        public int? FreeEntry { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public int? UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
