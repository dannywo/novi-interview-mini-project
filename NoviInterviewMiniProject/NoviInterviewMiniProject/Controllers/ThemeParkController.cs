using NoviInterviewMiniProject.Models;
using NoviInterviewMiniProject.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace NoviInterviewMiniProject.Controllers
{
    public class ThemeParkController : Controller
    {
        public string _url { get; set; } = "https://ftpa.novistaging.com/api/members";
        private string _token { get; } = "";
        private List<MemberResult> members { get; set; } = new List<MemberResult>();

        // GET: ThemePark
        public async Task<ActionResult> Index()
        {
            members = TempData["Members"] as List<MemberResult>;
            if (members == null || members.Count == 0)
            {
                ApiHelper.Initialize();
                ApiHelper.ApiClient.DefaultRequestHeaders.Add("Authorization", $"Basic {_token}");

                using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(_url))
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
                        return View(response.ReasonPhrase);
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
