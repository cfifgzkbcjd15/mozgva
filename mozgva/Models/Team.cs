using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Team
    {
        public Team()
        {
            Achievments = new HashSet<Achievment>();
            Challenges = new HashSet<Challenge>();
            ChampionsRegistrations = new HashSet<ChampionsRegistration>();
            GameIngosAnswers = new HashSet<GameIngosAnswer>();
            GameRegistrations = new HashSet<GameRegistration>();
            GameUnregistrations = new HashSet<GameUnregistration>();
            Invitations = new HashSet<Invitation>();
            Members = new HashSet<Member>();
            RequestInvitations = new HashSet<RequestInvitation>();
            Scorings = new HashSet<Scoring>();
            Standbies = new HashSet<Standby>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? LeagueId { get; set; }
        public string Invite { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Secret { get; set; }
        public string BackupPhone { get; set; }
        public string BackPhotoFileName { get; set; }
        public string BackPhotoContentType { get; set; }
        public int? BackPhotoFileSize { get; set; }
        public DateTime? BackPhotoUpdatedAt { get; set; }
        public int? OfficeId { get; set; }
        public double? Ratio { get; set; }
        public int? SpecialCityId { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public int? AfterGrTeamEmail { get; set; }
        public int? AfterGameTeamEmail { get; set; }
        public int? RegistrationCityId { get; set; }
        public string Creator { get; set; }
        public string Loyalty { get; set; }
        public string Description { get; set; }
        public string AllPhones { get; set; }
        public int[] RelatedTeamIds { get; set; }

        public virtual League League { get; set; }
        public virtual City RegistrationCity { get; set; }
        public virtual City SpecialCity { get; set; }
        public virtual ICollection<Achievment> Achievments { get; set; }
        public virtual ICollection<Challenge> Challenges { get; set; }
        public virtual ICollection<ChampionsRegistration> ChampionsRegistrations { get; set; }
        public virtual ICollection<GameIngosAnswer> GameIngosAnswers { get; set; }
        public virtual ICollection<GameRegistration> GameRegistrations { get; set; }
        public virtual ICollection<GameUnregistration> GameUnregistrations { get; set; }
        public virtual ICollection<Invitation> Invitations { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<RequestInvitation> RequestInvitations { get; set; }
        public virtual ICollection<Scoring> Scorings { get; set; }
        public virtual ICollection<Standby> Standbies { get; set; }
    }
}
