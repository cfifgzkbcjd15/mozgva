using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class GameTabImage
    {
        public GameTabImage()
        {
            Games = new HashSet<Game>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageFileName { get; set; }
        public string ImageContentType { get; set; }
        public int? ImageFileSize { get; set; }
        public DateTime? ImageUpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
