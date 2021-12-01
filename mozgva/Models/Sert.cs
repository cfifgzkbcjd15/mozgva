using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class Sert
    {
        public Sert()
        {
            GameRegistrationSerts = new HashSet<GameRegistrationSert>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Take { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? PersonCount { get; set; }
        public string Number { get; set; }
        public bool? Electronic { get; set; }
        public bool? Used { get; set; }
        public string ImageFileName { get; set; }
        public string ImageContentType { get; set; }
        public int? ImageFileSize { get; set; }
        public DateTime? ImageUpdatedAt { get; set; }
        public string Issuer { get; set; }
        public DateTime? ActivationDate { get; set; }
        public bool? Issued { get; set; }
        public DateTime? ValidityOff { get; set; }
        public DateTime? IssuedAdminDate { get; set; }
        public string SertType { get; set; }

        public virtual ICollection<GameRegistrationSert> GameRegistrationSerts { get; set; }
    }
}
