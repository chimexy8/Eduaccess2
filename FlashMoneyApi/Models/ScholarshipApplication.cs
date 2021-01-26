using EducationAccessApi.Enums;
using FlashMoneyApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationAccessApi.Models
{
    public class ScholarshipApplication
    {
        [Key]
        public int Id { get; set; }
        public int ScholarshipId { get; set; }
        public Guid? UserId { get; set; }
        public Scholarshiprecipient ScholarshipType { get; set; }
        public string ApplicantsEmail { get; set; }
     //   public string AppEmail { get; set; }
        //public int ScholarshipCategoryId { get; set; }
        public DateTime Date_Time { get; set; }
        //public decimal AmountForEach { get; set; }
        //public string AboutScholarship { get; set; }
        //public string NumberOfPeople { get; set; }
        //public bool SponsorProvideExam { get; set; }
        //public ApplicationStatus ApplicationStatus { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        //public bool Active { get; set; }
        //public bool MadePayment { get; set; }
       // public List<FlashMoneyApi.Models.User> Users { get; set; }
        //public decimal TotalAmount { get; set; }
        public Scholarship Scholarship { get; set; }
     //   public ScholarshipCategory ScholarshipCategory { get; set; }
        public User User { get; set; }



    }
}
