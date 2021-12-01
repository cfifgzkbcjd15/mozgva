using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class ConfirmationCode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
