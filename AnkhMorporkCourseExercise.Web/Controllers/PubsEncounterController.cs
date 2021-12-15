using System.Web.Mvc;
using AnkhMorporkCourseExercise.Web.Encounters;
using AnkhMorporkCourseExercise.Web.Models;
using AnkhMorporkCourseExercise.Web.Repositories;

namespace AnkhMorporkCourseExercise.Web.Controllers
{
    public class PubsEncounterController : Controller
    {
        private readonly PubsEncounter _pubsEncounter;
        private readonly Player _player;
        private readonly IRepository<Pub> _pubsRepository;

        public PubsEncounterController(PubsEncounter pubsEncounter, Player player, IRepository<Pub> pubsRepository)
        {
            _pubsEncounter = pubsEncounter;
            _player = player;
            _pubsRepository = pubsRepository;
        }
        // GET: PubsEncouter
        public ActionResult Index()
        {
            var pubs = _pubsEncounter.GetNpc();
            ViewBag.DealMoneyAmount = pubs.DealMoneyAmount;
            return View();
        }

        [HttpPost]
        public ActionResult Accept(int moneyAmount)
        {
            if (_pubsEncounter.Accept(_player,null, moneyAmount))
            {
                ViewBag.PlayerMoneyAmount = _player.CurrentMoneyAmount;
                return View();
            }

            _pubsEncounter.Decline(_player);
            return View("Failure");
        }

        public ActionResult Decline()
        {
            _pubsEncounter.Decline(_player);
            return View();
        }

        public ActionResult Failure()
        {
            return View();
        }
    }
}