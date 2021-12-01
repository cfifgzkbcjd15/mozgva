using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class QdQuestionTag
    {
        public int Id { get; set; }
        public int? QdTagId { get; set; }
        public int? QdQuestionId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
