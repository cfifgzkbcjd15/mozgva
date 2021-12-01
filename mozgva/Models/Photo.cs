using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Photo
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public string ImageFileName { get; set; }
        public string ImageContentType { get; set; }
        public int? ImageFileSize { get; set; }
        public DateTime? ImageUpdatedAt { get; set; }
        public string Caption { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? MainPhoto { get; set; }
    }
}
