using LeFrenchMelee.Web.Helpers;
using LeFrenchMelee.Web.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LeFrenchMelee.Web.Controllers
{
    public abstract class AbstractController<TViewModel> : Controller where TViewModel : AbstractViewModel
    {
        protected readonly string ApiController;

        protected AbstractController(string apiController)
        {
            ApiController = apiController;
        }

        // GET: Abstract
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
        public ActionResult Create(TViewModel model)
        {
            if (ModelState.IsValid)
            {

                var response = RestHelper.ExecuteRestRequest(ApiController, Method.POST, JsonConvert.SerializeObject(model));

                model = JsonConvert.DeserializeObject<TViewModel>(response.Content);

                return RedirectToAction("Details", new { id = model.Id });
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            IRestResponse datas = RestHelper.ExecuteRestRequest(ApiController, Method.GET, null, new KeyValuePair<string, object>("id", id));

            TViewModel model = JsonConvert.DeserializeObject<TViewModel>(datas.Content);

            return View(model);
        }
    }
}