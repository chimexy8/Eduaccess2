using EducationAccess.Models;
using FlashMoney.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationAccess.DTO
{
    public class LeaderBoardDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Models.Gender Gender { get; set; }
        public List<ExamTest> ExamTests { get; set; }

       // public List<User> Users { get; set; }
    }
}
