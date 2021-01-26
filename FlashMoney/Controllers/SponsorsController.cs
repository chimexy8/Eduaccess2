//using System.Web.Mvc;
using CsvHelper;
using EducationAccess.Models;
using FlashMoney.Data;
using FlashMoney.DTO;
using FlashMoney.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EducationAccess.Controllers
{

    public class SponsorsController : Controller
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IFlashMoneyHttpClient _flashMoneyHttpClient;
      

        public SponsorsController(IHttpContextAccessor httpContextAccessor, IFlashMoneyHttpClient flashMoneyHttpClient)
        {
            _httpContextAccessor = httpContextAccessor;
            _flashMoneyHttpClient = flashMoneyHttpClient;
            //_context = context;
        }

        //This method is the same as the overview method
        public async Task<IActionResult> Index(string Txt = null)
        {
            var email = User.Claims.FirstOrDefault(p => p.Type == "email").Value;

            return View();
        }

        //The AddScholarship method
        public async Task<IActionResult> AddScholarship(string tdata)
        {
            TempData["Error"] = tdata;
            var email = User.Claims.FirstOrDefault(p => p.Type == "email").Value;
            using (var client = _flashMoneyHttpClient.GetClient())
            {
                var response = await client.GetAsync($"GetExamTypes");
                if (response.IsSuccessStatusCode)
                {
                    var b = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<List<ExamType>>(b);
                    ViewBag.ExamTypes = new SelectList(result, "Id", "ExamTypeName");
                }
                return View();
            }


        }

        [HttpPost]
        public async Task<IActionResult> CreateScholarship(Scholarship scholarship)
        {
            scholarship.User = User.Claims.FirstOrDefault(p => p.Type == "email").Value;

            if (scholarship.RequireTest)
            {
                if (scholarship.CutoffPercent>0 && scholarship.CutoffPercent <= 100 && scholarship.ExamDuration != null && scholarship.ExamStartDateTime!= null && scholarship.Level != 0 && scholarship.AmountperEach >0 && scholarship.ApplicantsNumber >0)
                {
                    scholarship.TotalAmount = scholarship.ApplicantsNumber * scholarship.AmountperEach;
                    if (scholarship.UserProvidesQuestions)
                    {
                        if (scholarship.ExamQuestionsFile!=null)
                        {
                            var res = new List<ExamQuestionVM>();
                            var examQuestions = new List<ExamQuestion>();
                           
                            try
                            {

                                using (var reader = new StreamReader(scholarship.ExamQuestionsFile.OpenReadStream()))
                                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                                {
                                    var records = csv.GetRecords<ExamQuestionVM>();
                                    res = records.ToList();
                                }
                                if (res.Any(p => p.Answer == null || p.Answer == ""))
                                {
                                    TempData["Error"] = "Empty Answer Field in uploaded File, Please follow Format";
                                    return RedirectToAction(nameof(AddScholarship));
                                }
                                else
                                if (res.Any(p => p.Option1 == null || p.Option1 == ""))
                                {
                                    TempData["Error"] = "Empty Option1 Field in uploaded  File, Please follow Format";
                                    return RedirectToAction(nameof(AddScholarship), new { tdata= "Empty Option1 Field in uploaded  File, Please follow Format" });
                                }
                                else
                                if (res.Any(p => p.Option2 == null || p.Option2 == ""))
                                {
                                    TempData["Error"] = "Empty Option 2 Field in uploaded File, Please follow Format";
                                    return RedirectToAction(nameof(AddScholarship));
                                }
                                else
                                if (res.Any(p => p.Option3 == null || p.Option3 == ""))
                                {
                                    TempData["Error"] = "Empty Option3 Field in uploaded File, Please follow Format";
                                    return RedirectToAction(nameof(AddScholarship));
                                }else
                                if (res.Any(p => p.Option4 == null || p.Option4 == ""))
                                {
                                    TempData["Error"] = "Empty Option4 Field in uploaded File, Please follow Format";
                                    return RedirectToAction(nameof(AddScholarship));
                                }
                                else
                                if (res.Any(p => p.Question == null || p.Question == ""))
                                {
                                    TempData["Error"] = "Empty Question Field in uploaded File, Please follow Format";
                                    return RedirectToAction(nameof(AddScholarship));
                                } else
                                if (res.Any(p => p.Subject == null || p.Subject == ""))
                                {
                                    TempData["Error"] = "Empty Question Field in uploaded File, Please follow Format";
                                    return RedirectToAction(nameof(AddScholarship));
                                }
                                foreach (var item in res)
                                {
                                    examQuestions.Add(new ExamQuestion { Answer = item.Answer, Option1 = item.Option1, Option2 = item.Option2, Option3 = item.Option3, Option4 = item.Option4, Question = item.Question, ExSubject=item.Subject});
                                }
                            }
                            catch (Exception)
                            {
                                TempData["Error"] = "Unable to process file";
                                return RedirectToAction(nameof(AddScholarship));
                            }
                            scholarship.ExamQuestions = examQuestions;
                            scholarship.QuestionsUploaded = true;
                            using (var client = _flashMoneyHttpClient.GetClient())
                            {
                                var json = JsonConvert.SerializeObject(scholarship);
                                var content = new StringContent(json, Encoding.UTF8, "application/json");
                                var response = await client.PostAsync("CreateScholarShip", content);
                                if (response.IsSuccessStatusCode)
                                {
                                    var b = await response.Content.ReadAsStringAsync();
                                    var gg = JsonConvert.DeserializeObject<LoginDTO>(b);
                                    if (gg.Status == "fail")
                                    {

                                        TempData["Error"] = "Unable to Create Scholarship";
                                        return RedirectToAction(nameof(AddScholarship), new { tdata= "Unable to Create Scholarship" });
                                    }
                                    else
                                    {
                                        TempData["Success"] = "Scholarship Created Successfully";
                                        return RedirectToAction(nameof(AddScholarship));
                                    }
                                    
                                }
                                ModelState.AddModelError(string.Empty, "Error");
                            }
                        }

                    }

                    using (var client = _flashMoneyHttpClient.GetClient())
                    {
                       // scholarship.User = User.Claims.FirstOrDefault(p => p.Type == "email").Value;

                        var json = JsonConvert.SerializeObject(scholarship);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await client.PostAsync("CreateScholarShip", content);
                        if (response.IsSuccessStatusCode)
                        {
                            var b = await response.Content.ReadAsStringAsync();
                            var gg = JsonConvert.DeserializeObject<LoginDTO>(b);
                            if (gg.Status == "fail")
                            {

                                TempData["Error"] = "Unable to Create Scholarship";
                                return RedirectToAction(nameof(AddScholarship));
                            }
                            else
                            {
                                TempData["Success"] = "Scholarship Created Successfully";
                                return RedirectToAction(nameof(AddScholarship));
                            }

                        }
                        ModelState.AddModelError(string.Empty, "Error");
                    }
                }
                else
                {
                    TempData["Error"] = "Error: Please make sure all details are supplied then try again";
                    return RedirectToAction(nameof(AddScholarship));
                }

            }
            else
            {
                if (scholarship.AmountperEach > 0 && scholarship.ApplicantsNumber > 0)
                {
                    if (scholarship.SelectionProcess == Enum.selprocess.Upload || scholarship.SelectionProcess == Enum.selprocess.HandPickandUpload)
                    {
                        if (scholarship.ApplicantsUpload != null)
                        {
                            var appvm = new List<ApplicantsViewModel>();
                            try
                            {

                                using (var reader = new StreamReader(scholarship.ApplicantsUpload.OpenReadStream()))
                                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                                {
                                    var records = csv.GetRecords<ApplicantsViewModel>();
                                    appvm = records.ToList();
                                }
                                if (!appvm.Any(p => p.Email == null || p.Email == ""))
                                {
                                    TempData["Error"] = "Empty Email Field in uploaded File, Please follow Format";
                                    return RedirectToAction(nameof(AddScholarship), new { tdata= "Empty Email Field in uploaded File, Please follow Format" });
                                }

                            }
                            catch (Exception)
                            {
                                TempData["Error"] = "Unable to process Scholarship receivers file";
                                return RedirectToAction(nameof(AddScholarship));
                            }
                            scholarship.ApplicantsUploaded = true;
                            scholarship.SelectedEmails = appvm;
                        }
                       
                    }
                    using (var client = _flashMoneyHttpClient.GetClient())
                    {
                        var json = JsonConvert.SerializeObject(scholarship);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = await client.PostAsync("CreateScholarShip", content);
                        if (response.IsSuccessStatusCode)
                        {
                            var b = await response.Content.ReadAsStringAsync();
                            var gg = JsonConvert.DeserializeObject<LoginDTO>(b);
                            if (gg.Status == "fail")
                            {

                                TempData["Error"] = "Unable to Create Scholarship";
                                return RedirectToAction(nameof(AddScholarship));
                            }
                            else
                            {
                                TempData["Success"] = "Scholarship Created Successfully";
                                return RedirectToAction(nameof(AddScholarship));
                            }

                        }
                        ModelState.AddModelError(string.Empty, "Error");
                    }
                }
                else
                {
                    TempData["Error"] = "Error: Please make sure all details are supplied then try again";
                    return RedirectToAction(nameof(AddScholarship));
                }

            }
            return RedirectToAction("AddScholarship");
        }
        //This is the Applicant method view on the sponsor page
        public IActionResult Applicant()
        {
            return View();
        }


        //This method returns the applicants List
        public IActionResult ApplicantList()
        {
            return View();
        }

        //This method returns the Applicant Single Page
        public IActionResult ApplicantSingle()
        {
            return View();
        }

        //This is the Approval view
        public IActionResult Approval()
        {
            return View();
        }

        //This is the LeaderBoard view for sponsors
        public IActionResult Leaderboard()
        {
            return View();
        }

        //This is the sponsorpayment View
        public IActionResult SponsorPayment()
        {
            return View();
        }

        //This the Question View page
        public IActionResult Question()
        {
            return View();
        }

        //This method returns the Scholarship view
        public IActionResult Scholarship()
        {
            return View();
        }

        //This is the single scholarship View
        public IActionResult Single_Scholarship()
        {
            return View();
        }

        //This method returns the Settings View
        public IActionResult Settings()
        {
            return View();
        }

        // GET: SponsorsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SponsorsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SponsorsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SponsorsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SponsorsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SponsorsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SponsorsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
