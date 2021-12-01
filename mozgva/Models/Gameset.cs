using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Gameset
    {
        public Gameset()
        {
            QdQuestions = new HashSet<QdQuestion>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string LinkQuestions { get; set; }
        public string Name { get; set; }

        public virtual ICollection<QdQuestion> QdQuestions { get; set; }
    }
}
