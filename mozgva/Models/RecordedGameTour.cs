using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class RecordedGameTour
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string VideoUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? QuestionCount { get; set; }
        public int? DisableAnswerTime { get; set; }
        public bool? PlusTwo { get; set; }
        public bool? PlusThree { get; set; }
    }
}
