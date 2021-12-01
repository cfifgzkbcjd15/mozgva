using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameIngosDefaultSetting
    {
        public int Id { get; set; }
        public int? GameId { get; set; }
        public DateTime? StartTime { get; set; }
        public TimeSpan? BreakTime { get; set; }
        public TimeSpan? ReloadTableTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Emails { get; set; }
        public string FinalVideoUrl { get; set; }

        public virtual Game Game { get; set; }
    }
}
