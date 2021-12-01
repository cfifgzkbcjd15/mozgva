using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class City
    {
        public City()
        {
            Attachments = new HashSet<Attachment>();
            Places = new HashSet<Place>();
            TeamRegistrationCities = new HashSet<Team>();
            TeamSpecialCities = new HashSet<Team>();
            UserCities = new HashSet<User>();
            UserCityFranchises = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string EmailKorporat { get; set; }
        public string Key { get; set; }
        public string Info { get; set; }
        public bool? Active { get; set; }
        public int Priority { get; set; }
        public string EmailRegStatistic { get; set; }
        public string EmailFranchise { get; set; }
        public string EmailPartners { get; set; }
        public string EmailTeamReg { get; set; }
        public string VkLink { get; set; }
        public string FbLink { get; set; }
        public string InstLink { get; set; }

        public virtual ICollection<Attachment> Attachments { get; set; }
        public virtual ICollection<Place> Places { get; set; }
        public virtual ICollection<Team> TeamRegistrationCities { get; set; }
        public virtual ICollection<Team> TeamSpecialCities { get; set; }
        public virtual ICollection<User> UserCities { get; set; }
        public virtual ICollection<User> UserCityFranchises { get; set; }
    }
}
