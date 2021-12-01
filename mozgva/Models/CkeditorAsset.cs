using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class CkeditorAsset
    {
        public int Id { get; set; }
        public string DataFileName { get; set; }
        public string DataContentType { get; set; }
        public int? DataFileSize { get; set; }
        public string DataFingerprint { get; set; }
        public string Type { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
