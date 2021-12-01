using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class CategoryFeedback
    {
        public CategoryFeedback()
        {
            Feedbacks = new HashSet<Feedback>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Key { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
