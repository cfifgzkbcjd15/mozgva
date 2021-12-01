using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Partner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string PhotoFileName { get; set; }
        public string PhotoContentType { get; set; }
        public int? PhotoFileSize { get; set; }
        public DateTime? PhotoUpdatedAt { get; set; }
        public int? Discount { get; set; }
        public string Link { get; set; }
        public int Priority { get; set; }
    }
}
