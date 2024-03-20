using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace activities8.Models;
public class UserProfile
    {
        public int Id { get; set; }
        
        [MaxLength(32)]
        public string? Name { get; set; }

        [MaxLength(32)]
        public string? City { get; set; }
        
        [MaxLength(2000)]
        public string? About { get; set; }

        [MaxLength(64)]
        public string? Other { get; set; }

        [AllowNull]
        public string Base64Photo { get; set; }

        public bool Approval { get; set; }
        public bool Member { get; set; }

        [MaxLength(200)]
        public string? ApprovalMessage { get; set; }

        public bool Available { get; set; }

        public int IdActivity { get; set; }

        public int IdCountry { get; set; }

        public int IdLanguage { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ApprovedAt { get; set; }

        public bool Test { get; set; }
        
        public virtual ApplicationUser User { get; set; }
    }
