using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class FranchiseStaticPage
    {
        public int Id { get; set; }
        public string NameUrl { get; set; }
        public bool? Active { get; set; }
        public string Slug { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
