using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Banner
    {
        public int Id { get; set; }
        public string ImageFileName { get; set; }
        public string ImageContentType { get; set; }
        public int? ImageFileSize { get; set; }
        public DateTime? ImageUpdatedAt { get; set; }
        public string SizeType { get; set; }
        public string ShowType { get; set; }
        public string Link { get; set; }
        public bool? Active { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
