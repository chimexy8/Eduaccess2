using EducationAccessApi.DTOs;
using EducationAccessApi.Models;
using FlashMoneyApi.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EducationAccessApi.Controllers
{
    [Route("flashmoney")]
    [ApiController]
    [Authorize]
    public class SponsorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        public SponsorController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: api/<SponsorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SponsorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SponsorController>
        [HttpPost("CreateScholarShip")]
        public async Task<IActionResult> CreateScholarShip([FromBody] ScholarShipDto value)
        {
            if (value.RequireTest)
            {
                try
                {
                    char[] seperator = { ',' };
                    String[] commasplit = value.DocumentstoUpload.Split(seperator, StringSplitOptions.None);
                    var documents = new List<ExamDocument>();
                    foreach (var item in commasplit)
                    {
                        var newdoc = new ExamDocument { Name = item };
                        documents.Add(newdoc);
                    }
                    var questions = new List<ExamQuestion>();
                    if (value.ExamQuestions != null)
                    {
                        foreach (var exam in value.ExamQuestions)
                        {
                            try
                            {
                                if (_context.Subjects.Any(p => p.Name == exam.ExSubject))
                                {
                                    var newquestion = new ExamQuestion { Answer = exam.Answer, Option1 = exam.Option1, Option2 = exam.Option2, Option3 = exam.Option3, Option4 = exam.Option4, Question = exam.Question, SubjectId = _context.Subjects.Single(p => p.Name == exam.ExSubject).Id };
                                    questions.Add(newquestion);
                                }
                            }
                            catch (Exception)
                            {

                                return Ok(new { status = "fail", message = $"{exam.ExSubject} does not exist yet in Education Access Database." });
                            }
                            
                        }
                    }
                    var sender = await _userManager.FindByNameAsync(value.User);
                    if (sender == null)
                    {
                        return NotFound();
                    }
                    var user = await _context.User.SingleOrDefaultAsync(p => p.ApplicationUserId == sender.Id);
                    var scholarship = new Scholarship() { Amount = value.AmountperEach, Details = value.Detail, EndReg = value.ExamStartDateTime, ExamCutOffMark = value.CutoffPercent, ExamDocuments = documents, ExamQuestions = questions, IsFree = value.IsPaid, IsThereExam = value.RequireTest, MaxNumberOfApplicants = value.ApplicantsNumber, SponsorId = user.Id, StartReg = value.ExamStartDateTime, Title = value.Title, UserProvideQuestion = value.UserProvidesQuestions };
                    _context.Add(scholarship);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {

                    return Ok(new { status = "fail", message = ex.Message });
                }
               
                return Ok(new { status = "success", message = "scholarship is successfully created" });
            }
            else
            {
                if (value.SelectionProcess==Enums.selprocess.HandPick)
                {
                    try
                    {
                        var sender = await _userManager.FindByNameAsync(value.User);

                        var user = await _context.User.SingleOrDefaultAsync(p => p.ApplicationUserId == sender.Id);

                        char[] seperator = { ',' };
                        String[] commasplit = value.DocumentstoUpload.Split(seperator, StringSplitOptions.None);
                        var documents = new List<ExamDocument>();
                        foreach (var item in commasplit)
                        {
                            var newdoc = new ExamDocument { Name = item };
                            documents.Add(newdoc);
                        }
                        var scholarship = new Scholarship() { Amount = value.AmountperEach, Details = value.Detail, ExamCutOffMark = value.CutoffPercent, ExamDocuments = documents, IsFree = value.IsPaid, IsThereExam = value.RequireTest, MaxNumberOfApplicants = value.ApplicantsNumber, SponsorId = user.Id, StartReg = value.ExamStartDateTime, Title = value.Title, UserProvideQuestion = value.UserProvidesQuestions };
                        if (sender == null)
                        {
                            return NotFound();
                        }
                        _context.Add(scholarship);
                        _context.SaveChanges();
                        return Ok(new { status = "success", message = "scholarship is successfully created" });
                    }
                    catch (Exception ex)
                    {
                        return Ok(new { status = "fail", message = ex.Message });
                    }

                }
                else
                {
                    try
                    {
                        var applications = new List<ScholarshipApplication>();

                        if (value.SelectedEmails.Count>0)
                        {
                            foreach (var item in value.SelectedEmails)
                            {
                                var emailexist = _context.User.Any(p => p.Email == item.Email);
                                var application = new ScholarshipApplication { ApplicantsEmail = item.Email, Date_Time = DateTime.Now, User = emailexist ? _context.User.Single(p => p.Email == item.Email):null};
                                applications.Add(application);
                            };
                        }
                        var sender = await _userManager.FindByNameAsync(value.User);
                        var user = await _context.User.SingleOrDefaultAsync(p => p.ApplicationUserId == sender.Id);
                        char[] seperator = { ',' };
                        String[] commasplit = value.DocumentstoUpload.Split(seperator, StringSplitOptions.None);
                        var documents = new List<ExamDocument>();
                        foreach (var item in commasplit)
                        {
                            var newdoc = new ExamDocument { Name = item };
                            documents.Add(newdoc);
                        }
                        var scholarship = new Scholarship() { Amount = value.AmountperEach, ScholarshipApplications=applications, Details = value.Detail, ExamCutOffMark = value.CutoffPercent, ExamDocuments = documents, IsFree = value.IsPaid, IsThereExam = value.RequireTest, MaxNumberOfApplicants = value.ApplicantsNumber, SponsorId = user.Id, StartReg = value.ExamStartDateTime, Title = value.Title, UserProvideQuestion = value.UserProvidesQuestions };
                       
                        if (sender == null)
                        {
                            return NotFound();
                        }
                        _context.Add(scholarship);
                        _context.SaveChanges();
                        return Ok(new { status = "success", message = "scholarship is successfully created" });
                    }
                    catch (Exception ex)
                    {
                        return Ok(new { status = "fail", message = ex.Message });
                    }
                }
            }
            //return Ok(new { status = "success", message = "scholarship is successfully created" });
        }

        // PUT api/<SponsorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SponsorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
