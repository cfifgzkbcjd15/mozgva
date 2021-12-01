using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Attachment
    {
        public int Id { get; set; }
        public string FileFileName { get; set; }
        public string FileContentType { get; set; }
        public int? FileFileSize { get; set; }
        public DateTime? FileUpdatedAt { get; set; }
        public string Key { get; set; }
        public int? CityId { get; set; }
        public bool? ForceDownload { get; set; }
        public string DownloadFileName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual City City { get; set; }
    }
}
