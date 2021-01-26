using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EducationAccessApi.Models
{
    public class ExamDocument
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ScholarshipId { get; set; }
        public Scholarship  Scholarship { get; set; }
    }
}
