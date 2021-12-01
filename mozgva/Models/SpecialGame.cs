using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class SpecialGame
    {
        public SpecialGame()
        {
            SpecialRegistrations = new HashSet<SpecialRegistration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? When { get; set; }
        public string Organizator { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int MaxTour { get; set; }
        public string GameStatus { get; set; }
        public string ActiveTour { get; set; }
        public int? MaxTeamsCount { get; set; }
        public string SpreadsheetKey { get; set; }
        public string EmbedUrl { get; set; }
        public string[] QuestionCount { get; set; }
        public string[] SecretCodes { get; set; }
        public string TourPriority { get; set; }
        public string GoogleFormUrl { get; set; }

        public virtual ICollection<SpecialRegistration> SpecialRegistrations { get; set; }
    }
}
