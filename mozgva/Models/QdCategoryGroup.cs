using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class QdCategoryGroup
    {
        public QdCategoryGroup()
        {
            QdCategories = new HashSet<QdCategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<QdCategory> QdCategories { get; set; }
    }
}
