using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Achievment
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public int? AchievmentTypeId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual AchievmentType AchievmentType { get; set; }
        public virtual Team Team { get; set; }
    }
}
