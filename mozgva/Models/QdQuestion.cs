using System;
using System.Collections.Generic;

#nullable disable

namespace mozgva.Models
{
    public partial class QdQuestion
    {
        public QdQuestion()
        {
            QdAttachments = new HashSet<QdAttachment>();
            QdCategoriesQuestions = new HashSet<QdCategoriesQuestion>();
        }

        public int Id { get; set; }
        public string Body { get; set; }
        public string[] AnswerOptions { get; set; }
        public string CorrectAnswer { get; set; }
        public string[] CorrectAnswerVariants { get; set; }
        public string[] IncorrectAnswerVariants { get; set; }
        public string InfoLink { get; set; }
        public int? GamesetId { get; set; }
        public string Source { get; set; }
        public string Note { get; set; }
        public string Hint { get; set; }
        public int? Complexity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string InterestingFact { get; set; }
        public string VideoUrl { get; set; }
        public bool? IncludeTest { get; set; }
        public int? DelayTime { get; set; }
        public string Hint1 { get; set; }
        public string Hint2 { get; set; }
        public string MediaLinkToHint1 { get; set; }
        public string MediaLinkToHint2 { get; set; }
        public string[] AnswerOptions2 { get; set; }
        public string AdapterComment { get; set; }
        public int? OriginalRecord { get; set; }

        public virtual Gameset Gameset { get; set; }
        public virtual ICollection<QdAttachment> QdAttachments { get; set; }
        public virtual ICollection<QdCategoriesQuestion> QdCategoriesQuestions { get; set; }
    }
}
