using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class FreeOrder
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string Fio { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string SecretCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? SendFirstEmail { get; set; }
        public bool? SendSecondEmail { get; set; }
    }
}
