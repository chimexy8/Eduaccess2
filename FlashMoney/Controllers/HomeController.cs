using EducationAccess.DTO;
using FlashMoney.DTO;
using FlashMoney.Models;
using FlashMoney.Services;
using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FlashMoney.Controllers
{
   // [Authorize(Roles = "student")]
    public class HomeController : Controller
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IFlashMoneyHttpClient _flashMoneyHttpClient;

        public HomeController(IHttpContextAccessor httpContextAccessor, IFlashMoneyHttpClient flashMoneyHttpClient)
        {
            _httpContextAccessor = httpContextAccessor;
            _flashMoneyHttpClient = flashMoneyHttpClient;
        }
       
        public async Task<IActionResult> Index(string Pxt = null)
        {
           
            var email = User.Claims.FirstOrDefault(p => p.Type == "phone").Value;

            using (var client = _flashMoneyHttpClient.GetClient())
            {
                var response = await client.GetAsync($"GetStudentApplication/{email}");
                if (response.IsSuccessStatusCode)
                {
                    var b = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<HomeOverviewModel>(b);
                    

                    if (result.TransactionCount != 0)
                    {
                        ViewBag.AppCount = result.TransactionCount;
                        ViewBag.ApprovalCount = result.Approvedscholarship;
                        ViewBag.fl = result.FSLCC;
                        ViewBag.wa = result.WAAC;
                        ViewBag.ja = result.JAMMB;
                        ViewBag.ga = result.GAAD;
               
                    }
                    else
                    {
                        ViewBag.AppCount = 0;
                        ViewBag.ApprovalCount = 0;
                    }
                    //{
                    //    ViewBag.HasResetPin = true;
                    //}
                    //else
                    //{
                    //    ViewBag.HasResetPin = false;
                    //}


                }
                //    var response = await client.GetAsync($"Balance/{phone}");

                //    if (response.IsSuccessStatusCode)
                //    {
                //        var b = await response.Content.ReadAsStringAsync();
                //        var result = JsonConvert.DeserializeObject<HomeOverviewModel>(b);

                //        var h = decimal.Parse(result.Balance).ToString(); // ("c", new CultureInfo("ha-Latn-NG"));

                //        var bal = new OverviewModel { Balance = h, Activities = result.activities, TransactionCount  = result.TransactionCount, FundWalletCount = result.FundWalletCount, Phone = phone,LastFunded = !string.IsNullOrEmpty(result.LastFunded) ? result.LastFunded : "N/A" };

                //        return View(bal);
                //    }
                //}
                //var defaultBalance = "";
                //if (Pxt == "New")
                //{
                //    defaultBalance = decimal.Parse("0.00").ToString(); //("c", new CultureInfo("ha-Latn-NG"));
                //    return View(new OverviewModel { Balance = defaultBalance, Activities = new List<ActivityDTO>(), Pin = Pxt, Phone = phone, LastFunded = "N/A" });
            }
            return View(/*new OverviewModel { Balance = defaultBalance, Activities = new List<ActivityDTO>(), Phone = phone, LastFunded = "N/A" }*/);
        }
        public async Task<IActionResult> Leaderboard()
        {
            var email = User.Claims.FirstOrDefault(p => p.Type == "phone").Value;

            using (var client = _flashMoneyHttpClient.GetClient())
            {

                var response = await client.GetAsync($"GetScholarshipTest");
                if (response.IsSuccessStatusCode)
                {
                    var b = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<LeaderBoardDTO>(b);
                    ViewBag.Fsl = result.ExamTests.Where(p => p.ExamTypeId == 1).ToList();
                    ViewBag.Jamb = result.ExamTests.Where(p => p.ExamTypeId == 3).ToList();
                    ViewBag.Waec = result.ExamTests.Where(p => p.ExamTypeId == 2).ToList();
                   

                    return View(result);
                }
                return View();
            }
        }

        private void Wellcome()
        {
            foreach (var claim in User.Claims)
            {
                Debug.WriteLine($"{claim.Type}: {claim.Value}");
            }
        }

        public async Task UserInfo()
        {
            var client = new HttpClient();

            var disco = await client.GetDiscoveryDocumentAsync("https://localhost:44333/");
            if (disco.IsError) throw new Exception(disco.Error);

            var token = await HttpContext.GetTokenAsync(OpenIdConnectParameterNames.AccessToken);
            var response = await client.GetUserInfoAsync(new UserInfoRequest
            {
                Address = disco.UserInfoEndpoint,
                Token = token,
            });

            if (response.IsError) throw new Exception(response.Error);

            var claims = response.Claims.FirstOrDefault(p => p.Type == "address")?.Value;

            Debug.WriteLine(claims);
        }

        public async Task CallAPi()
        {

            var _client = _flashMoneyHttpClient.GetClient();
            var response = await _client.GetAsync("api/values/Welcome");
            if (!response.IsSuccessStatusCode)
            {
                Debug.WriteLine(response.StatusCode);
            }
            else
            {
                var content = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(JArray.Parse(content));
            }
        }

        public async Task<IActionResult> History()
        {
            var phone = User.Claims.FirstOrDefault(p => p.Type == "phone").Value;

            using (var client = _flashMoneyHttpClient.GetClient())
            {
                var tOKEN = User.Claims.FirstOrDefault(p => p.Type == "token").Value;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.SetBearerToken(tOKEN);


                var response = await client.GetAsync($"History/{phone}");
                if (response.IsSuccessStatusCode)
                {
                    var b = await response.Content.ReadAsStringAsync();

                    return View();
                }
                ModelState.AddModelError(string.Empty, "Error");
            }
            return View();
        }

        public IActionResult ResetPin()
        {
            var phone = User.Claims.FirstOrDefault(p => p.Type == "phone").Value;
            var model = new ResetPinModel
            {
                Phone = phone
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPin(ResetPinModel model)
        {
            if (ModelState.IsValid)
            {
                using (var client = _flashMoneyHttpClient.GetClient())
                {
                    var tOKEN = User.Claims.FirstOrDefault(p => p.Type == "token").Value;
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.SetBearerToken(tOKEN);

                    var json = JsonConvert.SerializeObject(model);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync("ResetPin", content);
                    if (response.IsSuccessStatusCode)
                    {
                        var b = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<TransInfo>(b);

                        if (result.status == "success")
                        {
                            return RedirectToAction("Success", "Transaction");
                        }
                    }
                    ModelState.AddModelError(string.Empty, "Error");
                }
            }
            return View(model);
        }

        public async Task<object> GetDailyChatData()
        {
            var phone = User.Claims.FirstOrDefault(p => p.Type == "phone").Value;
            var fakeObject = new
            {
                Quantity = new List<int>(),
            };

            using (var client = _flashMoneyHttpClient.GetClient())
            {
                var tOKEN = User.Claims.FirstOrDefault(p => p.Type == "token").Value;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.SetBearerToken(tOKEN);
                var response = await client.GetAsync($"QetChartData/{phone}");
                if (response.IsSuccessStatusCode)
                {
                    var b = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<ChartDataDTO>(b);

                    fakeObject.Quantity.Add(result.Tranfers);
                    fakeObject.Quantity.Add(result.FundWallet);
                }
            }

            return fakeObject;
        }

        //This method returns the approval page
        public IActionResult Approval()
        {
            return View();
        }

        //This method returns the Exam view
        public IActionResult Exam()
        {
            return View();
        }

        //This method return the Leaderboard View
        //public IActionResult Leaderboard()
        //{
        //    return View();
        //}

        //This method returns the payment 
        public IActionResult Payment()
        {
            return View();
        }

        //This method returns the questions view
        public IActionResult Questions()
        {
            return View();
        }

        //This method returns the Scholarship View
        public IActionResult Scholarship()
        {
            return View();
        }

        //This method returns the Settings View
        public IActionResult Settings()
        {
            //var count = 1;
            //ViewBag.H = count;
            return View();
        }

        //This method returns the Single Scholarship view
        public IActionResult Single_scholarship()
        {
            return View();
        }

        //This method returns the Subject View
        public IActionResult Subject()
        {
            return View();
        }

        //This method returns the Test View
        public async Task<IActionResult> Test()
        {
            var email = User.Claims.FirstOrDefault(p => p.Type == "phone").Value;

            using (var client = _flashMoneyHttpClient.GetClient())
            {

                var response = await client.GetAsync($"GetScholarshipTest");
                if (response.IsSuccessStatusCode)
                {
                    var b = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<LeaderBoardDTO>(b);
                    var Fsl = result.ExamTests.Where(p => p.ExamTypeId == 1).ToList();
                    var Jamb = result.ExamTests.Where(p => p.ExamTypeId == 3).ToList();
                    var Waec = result.ExamTests.Where(p => p.ExamTypeId == 2).ToList();

                    ViewBag.fsl = 0;
                    ViewBag.jamb = 0;
                    ViewBag.waec = 0;
                    if (Fsl.Count!=0)
                    {
                        ViewBag.fsl = Fsl.Max(p => p.Score);
                    }
                    if (Jamb.Count!=0)
                    {
                        ViewBag.jamb = Jamb.Max(p => p.Score);
                    }
                    if (Waec.Count!=0)
                    {
                        ViewBag.waec = Waec.Max(p => p.Score);
                    }


                    
                    return View(result);
                }
                return View();
            }   
        }

        [AllowAnonymous]
        public IActionResult Privacy()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult FAQ()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Terms()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult ErrorPage()
        {
            return View();
        }

        public async Task Logout()
        {
            await HttpContext.SignOutAsync("Cookies");
            await HttpContext.SignOutAsync("oidc");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
