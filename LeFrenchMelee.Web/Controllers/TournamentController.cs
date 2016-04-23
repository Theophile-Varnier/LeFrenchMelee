using LeFrenchMelee.Web.Models;
using System.Web.Mvc;

namespace LeFrenchMelee.Web.Controllers
{
    public class TournamentController : AbstractController<TournamentViewModel>
    {
        public TournamentController()
            : base("Tournament")
        {
        }

        public ActionResult Calendar()
        {
            return View();
        }
    }
}