using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class QdCategory
    {
        public QdCategory()
        {
            QdCategoriesQuestions = new HashSet<QdCategoriesQuestion>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? QdCategoryGroupId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual QdCategoryGroup QdCategoryGroup { get; set; }
        public virtual ICollection<QdCategoriesQuestion> QdCategoriesQuestions { get; set; }
    }
}
