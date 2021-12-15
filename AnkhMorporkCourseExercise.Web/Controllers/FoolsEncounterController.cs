using System.Linq;
using System.Web.Mvc;
using AnkhMorporkCourseExercise.Web.Encounters;
using AnkhMorporkCourseExercise.Web.Models;
using AnkhMorporkCourseExercise.Web.Repositories;

namespace AnkhMorporkCourseExercise.Web.Controllers
{
    public class FoolsEncounterController : Controller
    {
        private readonly FoolsEncounter _foolsEncounter;
        private readonly Player _player;
        private readonly IRepository<Fool> _foolsRepository;

        public FoolsEncounterController(FoolsEncounter foolsEncounter, Player player, IRepository<Fool> foolsRepository)
        {
            _foolsEncounter = foolsEncounter;
            _player = player;
            _foolsRepository = foolsRepository;
        }
        // GET: ThievesEncounter
        public ActionResult Index()
        {
            var fools = _foolsEncounter.GetNpc();
            ViewBag.DealMoneyAmount = fools.DealMoneyAmount;
            ViewBag.Id = fools.Id;
            return View();
        }

        public ActionResult Accept(int Id)
        {

            var fool = _foolsRepository.Get().FirstOrDefault(t => t.Id == Id);
            if (_foolsEncounter.Accept(_player, fool))
            {
                ViewBag.PlayerMoneyAmount = _player.CurrentMoneyAmount;
                return View();
            }

            _foolsEncounter.Decline(_player);
            return View("Decline");
        }

        public ActionResult Decline()
        {
            _foolsEncounter.Decline(_player);
            return View();
        }
    }
}