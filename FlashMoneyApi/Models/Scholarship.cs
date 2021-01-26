using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationAccessApi.Models
{
    public class Scholarship
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public Guid SponsorId { get; set; }
        public DateTime StartReg { get; set; }
        public DateTime EndReg { get; set; }
        public List<ScholarshipCategory> ScholarshipCategories { get; set; }
        public List<ScholarshipApplication> ScholarshipApplications { get; set; }
        public bool IsFree { get; set; }
        public int MaxNumberOfApplicants { get; set; }
        public double Amount { get; set; }
        public bool IsThereExam { get; set; }
        public bool UserProvideQuestion { get; set; }
        public double ExamCutOffMark { get; set; }
        public List<ExamDocument> ExamDocuments { get; set; }
        public List<ExamQuestion> ExamQuestions { get; set; }
        public bool MadePayment { get; set; }
        public bool UploadDocument { get; set; }
    }
}
