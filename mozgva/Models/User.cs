using System;
using System.Collections.Generic;
using System.Net;

#nullable disable

namespace mozgva.Models
{
    public partial class User
    {
        public User()
        {
            InvitationInviters = new HashSet<Invitation>();
            InvitationUsers = new HashSet<Invitation>();
            Members = new HashSet<Member>();
            Omnilinks = new HashSet<Omnilink>();
            QuizGameInstances = new HashSet<QuizGameInstance>();
            Scorings = new HashSet<Scoring>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string EncryptedPassword { get; set; }
        public string ResetPasswordToken { get; set; }
        public DateTime? ResetPasswordSentAt { get; set; }
        public DateTime? RememberCreatedAt { get; set; }
        public int SignInCount { get; set; }
        public DateTime? CurrentSignInAt { get; set; }
        public DateTime? LastSignInAt { get; set; }
        public IPAddress CurrentSignInIp { get; set; }
        public IPAddress LastSignInIp { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? CityId { get; set; }
        public string Phone { get; set; }
        public DateTime? PhoneConfirmedAt { get; set; }
        public string ConfirmationCode { get; set; }
        public int? CurrentMemberId { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public string Fb { get; set; }
        public string Vk { get; set; }
        public string Inst { get; set; }
        public int? CityFranchiseId { get; set; }

        public virtual City City { get; set; }
        public virtual City CityFranchise { get; set; }
        public virtual ICollection<Invitation> InvitationInviters { get; set; }
        public virtual ICollection<Invitation> InvitationUsers { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Omnilink> Omnilinks { get; set; }
        public virtual ICollection<QuizGameInstance> QuizGameInstances { get; set; }
        public virtual ICollection<Scoring> Scorings { get; set; }
    }
}
