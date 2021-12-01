using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public int? Price { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string FileFileName { get; set; }
        public string FileContentType { get; set; }
        public int? FileFileSize { get; set; }
        public DateTime? FileUpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Description { get; set; }
        public string CardImageFileName { get; set; }
        public string CardImageContentType { get; set; }
        public int? CardImageFileSize { get; set; }
        public DateTime? CardImageUpdatedAt { get; set; }
        public int? SpecialGameId { get; set; }
        public bool? Free { get; set; }
        public bool? Hide { get; set; }
        public int? OrderCount { get; set; }
        public bool? SoldOut { get; set; }
        public DateTime? GameWhen { get; set; }
        public string QuizHref { get; set; }
        public bool? DisableRegBtn { get; set; }
        public string MinDescription { get; set; }
        public int? RecordedGameId { get; set; }
        public int? PlaceId { get; set; }
        public int? MaxTeamMemberCount { get; set; }
    }
}
