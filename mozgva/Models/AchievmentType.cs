using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class AchievmentType
    {
        public AchievmentType()
        {
            Achievments = new HashSet<Achievment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageFileName { get; set; }
        public string ImageContentType { get; set; }
        public int? ImageFileSize { get; set; }
        public DateTime? ImageUpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string About { get; set; }
        public string Key { get; set; }
        public int Priority { get; set; }

        public virtual ICollection<Achievment> Achievments { get; set; }
    }
}
