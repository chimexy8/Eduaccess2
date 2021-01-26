using EducationAccessApi.Models;
using FlashMoneyApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationAccessApi.DTOs
{
    public class LeaderBoardDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public List<ExamTest> ExamTests { get; set; }
        public List<User> Users { get; set; }
    }
}
