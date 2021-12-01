using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class RecordedGameAnswer
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public int? RegistrationId { get; set; }
        public int? TourId { get; set; }
        public int? QuestionNumber { get; set; }
        public string Answer { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Correct { get; set; }
        public bool? Incorrect { get; set; }
        public bool? PlusTwo { get; set; }
        public bool? PlusThree { get; set; }
    }
}
