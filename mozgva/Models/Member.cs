using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Member
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? TeamId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string TeamRole { get; set; }
        public string Name { get; set; }
        public string AvatarFileName { get; set; }
        public string AvatarContentType { get; set; }
        public int? AvatarFileSize { get; set; }
        public DateTime? AvatarUpdatedAt { get; set; }
        public bool? SearchTeam { get; set; }

        public virtual Team Team { get; set; }
        public virtual User User { get; set; }
    }
}
