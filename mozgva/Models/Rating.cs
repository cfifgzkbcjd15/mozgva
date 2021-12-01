using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Rating
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public int? CityId { get; set; }
        public int? ThematicRatingId { get; set; }
        public int? Scores { get; set; }
        public double? Percent { get; set; }
        public int? GamesCount { get; set; }
        public int? CurrentGameId { get; set; }
        public int? PrevGameId { get; set; }
        public int? PrevScores { get; set; }
        public double? PrevPercent { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Active { get; set; }
        public bool? FirstOfficialGame { get; set; }
        public int AllTeamRatingsCount { get; set; }
        public DateTime? LastRegDate { get; set; }
        public DateTime? LastAttendedGameWhen { get; set; }

        public virtual Game CurrentGame { get; set; }
        public virtual Game PrevGame { get; set; }
    }
}
