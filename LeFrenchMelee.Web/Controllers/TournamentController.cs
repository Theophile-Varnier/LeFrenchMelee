using LeFrenchMelee.Web.Helpers;
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

                var response = RestHelper.ExecuteRestRequest("Tournament", Method.POST, JsonConvert.SerializeObject(model));
                
                model = JsonConvert.DeserializeObject<TournamentViewModel>(response.Content);

                return RedirectToAction("Details", new { id = model.IdTournament });
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            IRestResponse datas = RestHelper.ExecuteRestRequest("Tournament", Method.GET, null, new KeyValuePair<string, object>("id", id));

            TournamentViewModel model = JsonConvert.DeserializeObject<TournamentViewModel>(datas.Content);

            return View(model);
        }
    }
}