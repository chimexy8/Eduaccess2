using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EducationAccessApi.DTOs;
using EducationAccessApi.Models;
using FlashMoneyApi.Controllers;
using FlashMoneyApi.Data;
using FlashMoneyApi.DTOs;
using FlashMoneyApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace EducationAccessApi.Controllers
{
    [Route("flashmoney")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IFlashHttpClient _flashMoneyHttpClient;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<AccessController> _logger;
        private readonly ApiDetail _apidetail;
        private readonly HttpClient _client;

        public StudentController(UserManager<ApplicationUser> userManager,
            IConfiguration configuration,
            ILogger<AccessController> logger,
            SignInManager<ApplicationUser> signInManager,
             IEmailSender emailSender, ApplicationDbContext context, IOptions<ApiDetail> options, IFlashHttpClient flashMoneyHttpClient)
        {
            _userManager = userManager;
            _configuration = configuration;
            _signInManager = signInManager;
            _flashMoneyHttpClient = flashMoneyHttpClient;
            _emailSender = emailSender;
            _context = context;
            _logger = logger;
            _apidetail = options.Value;
            _client = _flashMoneyHttpClient.GetClient();
        }

        //This API method returns the List of Scholarship for a particular Applicant(Student)
        [HttpGet("GetStudentApplication/{email}")]
        public async  Task<IActionResult> GetStudentApplication(string email)
        {
            
            var Student =  _context.User.FirstOrDefault(x => x.Email == email);
            if(Student != null)
            {
                var studentApplicantion = _context.ScholarshipApplications.Where(x => x.UserId == Student.Id).ToList();
                //var studentApplicantion1 = _context.ScholarshipApplications.Where(x => x.UserId == Student.Id).FirstOrDefault();
                var numberOfApplication = studentApplicantion.Count;
                var approvedscholarships = studentApplicantion.Where(p => p.ApprovalStatus == Enums.ApprovalStatus.Approved).ToList().Count();
                //var IndividualApplication = _context.ScholarshipCategories.Where(x => x.Id == studentApplicantion1.ScholarshipCategoryId).FirstOrDefault();
                var examCount = _context.ExamTest.Where(x => x.UserId == Student.Id).ToList();
                var fsl = examCount.Where(p => p.ExamTypeId == 1).ToList().Count();
                var wac = examCount.Where(p => p.ExamTypeId == 2).ToList().Count();
                var jamb = examCount.Where(p => p.ExamTypeId == 3).ToList().Count();
                var gad = examCount.Where(p => p.ExamTypeId == 4).ToList().Count();
                
                                

                return Ok(new { TransactionCount = numberOfApplication, Approvedscholarship = approvedscholarships,
                    ScholarApps = studentApplicantion, FSLCC = fsl, WAAC = wac, JAMMB = jamb, GAAD = gad});
            }

            return NotFound();
          
        }
        [HttpGet("GetScholarshipTest")]
        public async Task<IActionResult> GetTestSores()
        {
            LeaderBoardDTO leadBoard = new LeaderBoardDTO();
            leadBoard.ExamTests = _context.ExamTest.ToList();
            //leadBoard.Users = _context.Users.Where(x => x.Email != 0);
          
            return Ok(leadBoard);
        }
        [HttpGet("GetExamTypes")]
        public async Task<IActionResult> GetExamTypes()
        {
           
            return Ok(_context.ExamType);
        }
    }
}
