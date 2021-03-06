﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationAccess.Models
{
    public class ScholarshipApplicants
    {
        public int Id { get; set; }
        public int ScholarshipId { get; set; }
        public int? UserId { get; set; }
        public bool IsRegistered { get; set; }
        public bool IsApproved { get; set; }
        public User User { get; set; }
    }
}
