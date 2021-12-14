using NoviInterviewMiniProject.Models;
using NoviInterviewMiniProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Configuration;

namespace NoviInterviewMiniProject.Controllers
{
    public class ThemeParkController : Controller
    {
        private string _url { get; set; } = ConfigurationManager.AppSettings["ApiUrl"];
        private string _token { get; } = ConfigurationManager.AppSettings["ApiKey"];
        private List<MemberResult> members { get; set; } = new List<MemberResult>();

        // GET: Theme Park Members
        public async Task<ActionResult> Members()
        {
            var section = "/members";
            members = TempData["Members"] as List<MemberResult>;
            if (members == null || members.Count == 0)
            {
                ApiHelper.Initialize();
                ApiHelper.ApiClient.DefaultRequestHeaders.Add("Authorization", $"Basic {_token}");

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"{_url}{section}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        MembersResponse memberResponse = await response.Content.ReadAsAsync<MembersResponse>();
                        members = memberResponse.Results.Where(item => item.Active == true).ToList();
                        TempData["Members"] = members;
                        return View(members);
                    }   
                    else
                    {
                        return Content(response.ReasonPhrase);
                    }

                }
            }

            return View(members);
        }

        // GET: ThemePark/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
