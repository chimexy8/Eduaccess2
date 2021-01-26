using System;

namespace EducationAccess.Models
{
    public class ActivityModel
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
       // public TransactionType Type { get; set; }
    }
}