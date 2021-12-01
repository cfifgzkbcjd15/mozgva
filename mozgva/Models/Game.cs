using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Game
    {
        public Game()
        {
            GameIngosDefaultSettings = new HashSet<GameIngosDefaultSetting>();
            GameRegistrations = new HashSet<GameRegistration>();
            GameUnregistrations = new HashSet<GameUnregistration>();
            Promocodes = new HashSet<Promocode>();
            RatingCurrentGames = new HashSet<Rating>();
            RatingPrevGames = new HashSet<Rating>();
            Standbies = new HashSet<Standby>();
        }

        public int Id { get; set; }
        public int? PlaceId { get; set; }
        public string Name { get; set; }
        public int? LeagueId { get; set; }
        public int? Price { get; set; }
        public DateTime? When { get; set; }
        public string Status { get; set; }
        public int? MaxPeopleNumber { get; set; }
        public int? MaxTeamsNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Main { get; set; }
        public bool? QuickRegistrationAvailable { get; set; }
        public int? GamesetId { get; set; }
        public string ImportStatus { get; set; }
        public int PhotosCount { get; set; }
        public bool? RegistrationStandbies { get; set; }
        public bool? NoRating { get; set; }
        public bool? GameBeginner { get; set; }
        public string Label { get; set; }
        public bool? GameStudent { get; set; }
        public int? MinScores { get; set; }
        public bool? GameKids { get; set; }
        public string Description { get; set; }
        public bool? ShowReport { get; set; }
        public int? MaxScores { get; set; }
        public bool? MainCalendar { get; set; }
        public string ColorLabel { get; set; }
        public int? ThematicRatingId { get; set; }
        public bool? GameFootball { get; set; }
        public int? GameTabImageId { get; set; }
        public string ColorLabelRight { get; set; }

        public virtual GameTabImage GameTabImage { get; set; }
        public virtual League League { get; set; }
        public virtual Place Place { get; set; }
        public virtual ICollection<GameIngosDefaultSetting> GameIngosDefaultSettings { get; set; }
        public virtual ICollection<GameRegistration> GameRegistrations { get; set; }
        public virtual ICollection<GameUnregistration> GameUnregistrations { get; set; }
        public virtual ICollection<Promocode> Promocodes { get; set; }
        public virtual ICollection<Rating> RatingCurrentGames { get; set; }
        public virtual ICollection<Rating> RatingPrevGames { get; set; }
        public virtual ICollection<Standby> Standbies { get; set; }
    }
}
