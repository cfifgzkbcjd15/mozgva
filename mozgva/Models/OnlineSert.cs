using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class OnlineSert
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime ValidityOff { get; set; }
        public bool Used { get; set; }
        public string ImageFileName { get; set; }
        public string ImageContentType { get; set; }
        public int? ImageFileSize { get; set; }
        public DateTime? ImageUpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
