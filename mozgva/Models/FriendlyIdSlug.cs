using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class FriendlyIdSlug
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public int SluggableId { get; set; }
        public string SluggableType { get; set; }
        public string Scope { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
