using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EducationAccessApi.Enums;
namespace EducationAccessApi.DTOs
{
    public class ScholarShipDto
    {
        public int Id { get; set; }
        public int ApplicantsNumber { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string User { get; set; }
        public bool RequireTest { get; set; }
        public selprocess SelectionProcess { get; set; }
        public bool IsPaid { get; set; }
        public bool IsActive { get; set; }
        public ApplicationStatus ApplicationStatus { get; set; }
        public bool UserProvidesQuestions { get; set; }
        public bool QuestionsUploaded { get; set; }
        public bool ApplicantsUploaded { get; set; }
        public string ExamDuration { get; set; }
        public string DocumentstoUpload { get; set; }
        public int Level { get; set; }
        public DateTime ExamStartDateTime { get; set; }
        public DateTime ExamEndDateTime { get; set; }
        public double AmountperEach { get; set; }
        public double TotalAmount { get; set; }
        public double CutoffPercent { get; set; }
        //public IFormFile ExamQuestionsFile { get; set; }
        //public IFormFile ApplicantsUpload { get; set; }
        public List<ExamQuestionsDto> ExamQuestions { get; set; }
        public List<ScholarshipApplicantsDto> Applicants { get; set; }
        public List<ApplicantsViewModel> SelectedEmails { get; set; }
    }
}
