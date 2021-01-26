﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationAccessApi.DTOs
{
    public class ExamQuestionsDto
    {
        public string Question { get; set; }
        public int SubjectId { get; set; }
       // public Subject Subject { get; set; }
        public string ExSubject { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string Answer { get; set; }
    }
}
