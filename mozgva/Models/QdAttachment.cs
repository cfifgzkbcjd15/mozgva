using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class QdAttachment
    {
        public int Id { get; set; }
        public string FileFileName { get; set; }
        public string FileContentType { get; set; }
        public int? FileFileSize { get; set; }
        public DateTime? FileUpdatedAt { get; set; }
        public string Purpose { get; set; }
        public string FileType { get; set; }
        public int? QdQuestionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual QdQuestion QdQuestion { get; set; }
    }
}
