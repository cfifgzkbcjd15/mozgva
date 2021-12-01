using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class QuizTour
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public string Name { get; set; }
        public int? Number { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
