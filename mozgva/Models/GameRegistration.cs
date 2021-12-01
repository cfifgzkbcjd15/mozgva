using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameRegistration
    {
        public GameRegistration()
        {
            Challenges = new HashSet<Challenge>();
            GameRegistrationSerts = new HashSet<GameRegistrationSert>();
        }

        public int Id { get; set; }
        public int? TeamId { get; set; }
        public int? GameId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? PeopleNumber { get; set; }
        public string Referer { get; set; }
        public string Comment { get; set; }
        public string TrafficSource { get; set; }
        public string UtmSource { get; set; }
        public string UtmMedium { get; set; }
        public string UtmCampaign { get; set; }
        public string UtmContent { get; set; }
        public string UtmTerm { get; set; }
        public bool? HideStatus { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string UtmActionpay { get; set; }
        public string ContactEmail { get; set; }

        public virtual Game Game { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Challenge> Challenges { get; set; }
        public virtual ICollection<GameRegistrationSert> GameRegistrationSerts { get; set; }
    }
}
