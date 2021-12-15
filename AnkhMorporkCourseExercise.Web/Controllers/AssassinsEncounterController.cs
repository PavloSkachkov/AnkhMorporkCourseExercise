using System.Web.Mvc;
using AnkhMorporkCourseExercise.Web.Encounters;
using AnkhMorporkCourseExercise.Web.Models;

namespace AnkhMorporkCourseExercise.Web.Controllers
{
    public class AssassinsEncounterController : Controller
    {
        private readonly AssassinsEncounter _assassinsEncounter;
        private readonly Player _player;

        public AssassinsEncounterController(AssassinsEncounter assassinsEncounter, Player player)
        {
            _assassinsEncounter = assassinsEncounter;
            _player = player;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Accept(decimal moneyAmount)
        {
            if (_assassinsEncounter.Accept(_player, null, moneyAmount))
            {
                ViewBag.PlayerMoneyAmount = _player.CurrentMoneyAmount;
                return View();
            }

            _assassinsEncounter.Decline(_player);
            return View("Failure");
        }

        public ActionResult Decline()
        {
            _assassinsEncounter.Decline(_player);
            return View();
        }

        public ActionResult Failure()
        {
            _assassinsEncounter.Decline(_player);
            return View();
        }
    }
}