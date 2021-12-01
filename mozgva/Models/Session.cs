using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Session
    {
        public int Id { get; set; }
        public string SessionId { get; set; }
        public string Data { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
