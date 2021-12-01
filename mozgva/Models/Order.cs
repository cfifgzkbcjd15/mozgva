using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public string Status { get; set; }
        public string OrderNumber { get; set; }
        public string OrderId { get; set; }
        public string Fio { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Phone { get; set; }
        public bool? SendFirstEmail { get; set; }
        public bool? SendSecondEmail { get; set; }
        public int? ProductPromocodeId { get; set; }
        public int? PeopleCount { get; set; }
        public int? OnlineSertId { get; set; }
    }
}
