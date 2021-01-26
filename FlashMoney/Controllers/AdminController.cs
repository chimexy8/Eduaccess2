using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashMoney.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationAccess.Controllers
{
    public class AdminController : Controller
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IFlashMoneyHttpClient _flashMoneyHttpClient;

        public AdminController(IHttpContextAccessor httpContextAccessor, IFlashMoneyHttpClient flashMoneyHttpClient)
        {
            _httpContextAccessor = httpContextAccessor;
            _flashMoneyHttpClient = flashMoneyHttpClient;
        }

        //This method is the same as the overview method
        public async Task<IActionResult> Index(string Txt = null)
        {
            var email = User.Claims.FirstOrDefault(p => p.Type == "phone").Value;

            return View();
        }

        //This is the AddScholarship method
        public IActionResult AddScholarship()
        {
            return View();
        }

        //This is the ApplicantsList page
        public IActionResult ApplicantList()
        {
            return View();
        }

        //This is the Applicants-Single page
        public IActionResult Applicant_Single()
        {
            return View();
        }

        //This is the Leaderboard page
        public IActionResult Leaderboard()
        {
            return View();
        }

        //This is the Question page
        public IActionResult Question()
        {
            return View();
        }

        //This is the Scolarship page
        public IActionResult Scholarship()
        {
            return View();
        }

        //This is the Single_Scolarship page
        public IActionResult Single_Scholarship()
        {
            return View();
        }

        //This is the Sponsor page
        public IActionResult Sponsor()
        {
            return View();
        }

        //This is the Single_Sponsor page
        public IActionResult Single_Sponsor()
        {
            return View();
        }

        //This is the Student page
        public IActionResult Student()
        {
            return View();
        }

        //This is the Single_Student page
        public IActionResult Single_Student()
        {
            return View();
        }

        //This is the Subscription page
        public IActionResult Subscription()
        {
            return View();
        }

        //This is the settings for the Admin Controller
        public IActionResult Settings()
        {
            return View();
        }
    }
}
