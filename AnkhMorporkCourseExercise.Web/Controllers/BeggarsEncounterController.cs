using System.Linq;
using System.Web.Mvc;
using AnkhMorporkCourseExercise.Web.Encounters;
using AnkhMorporkCourseExercise.Web.Models;
using AnkhMorporkCourseExercise.Web.Repositories;

namespace AnkhMorporkCourseExercise.Web.Controllers
{
    public class BeggarsEncounterController : Controller
    {
        private readonly BeggarsEncounter _beggarsEncounter;
        private readonly Player _player;
        private readonly IRepository<Beggar> _beggarsRepository;

        public BeggarsEncounterController(BeggarsEncounter beggarsEncounter, Player player, IRepository<Beggar> beggarsRepository)
        {
            _beggarsEncounter = beggarsEncounter;
            _player = player;
            _beggarsRepository = beggarsRepository;
        }

        public ActionResult Index()
        {
            var beggars = _beggarsEncounter.GetNpc();
            ViewBag.DealMoneyAmount = beggars.DealMoneyAmount;
            ViewBag.Id = beggars.Id;
            return View();
        }

        public ActionResult Accept(int Id)
        {
            var beggar = _beggarsRepository.Get().FirstOrDefault(t => t.Id == Id);
            if (_beggarsEncounter.Accept(_player, beggar))
            {
                ViewBag.PlayerMoneyAmount = _player.CurrentMoneyAmount;
                return View();
            }

            _beggarsEncounter.Decline(_player);
            return View("Failure");
        }

        public ActionResult Decline()
        {
            _beggarsEncounter.Decline(_player);
            return View();
        }

        public ActionResult Failure()
        {
            _beggarsEncounter.Decline(_player);
            return View();
        }
    }
}