using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class LeroymerlinReg
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Univercity { get; set; }
        public int? RegCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Specialty { get; set; }
    }
}
