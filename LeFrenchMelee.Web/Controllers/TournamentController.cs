using LeFrenchMelee.Web.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeFrenchMelee.Web.Controllers
{
    public class TournamentController : Controller
    {
        // GET: Tournament
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TournamentViewModel model)
        {
            if (ModelState.IsValid)
            {
                RestClient client = new RestClient("http://localhost/LeFrenchMelee.Web/api/");

                RestRequest request = new RestRequest("Tournament", Method.POST)
                {
                    RequestFormat = DataFormat.Json,
                };

                request.AddParameter("application/json", JsonConvert.SerializeObject(model), ParameterType.RequestBody);

                var response = client.Execute(request);
            }
            return View();
        }
    }
}