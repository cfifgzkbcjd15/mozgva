using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class QdCategoriesQuestion
    {
        public int Id { get; set; }
        public int? QdCategoryId { get; set; }
        public int? QdQuestionId { get; set; }

        public virtual QdCategory QdCategory { get; set; }
        public virtual QdQuestion QdQuestion { get; set; }
    }
}
