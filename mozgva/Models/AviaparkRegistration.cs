using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class AviaparkRegistration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string TeamName { get; set; }
        public string PeopleNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
