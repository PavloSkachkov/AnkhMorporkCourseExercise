using System.Linq;
using System.Web.Mvc;
using AnkhMorporkCourseExercise.Web.Encounters;
using AnkhMorporkCourseExercise.Web.Models;
using AnkhMorporkCourseExercise.Web.Repositories;

namespace AnkhMorporkCourseExercise.Web.Controllers
{
    public class ThievesEncounterController : Controller
    {
        
        private readonly ThievesEncounter _thievesEncounter;
        private readonly Player _player;
        private readonly IRepository<Thief> _thievesRepository;

        public ThievesEncounterController(ThievesEncounter thievesEncounter, Player player, IRepository<Thief> thievesRepository)
        {
            _thievesEncounter = thievesEncounter;
            _player = player;
            _thievesRepository = thievesRepository;
        }
        // GET: ThievesEncounter
        public ActionResult Index()
        {
            var thieves =_thievesEncounter.GetNpc();
            ViewBag.DealMoneyAmount = thieves.DealMoneyAmount;
            ViewBag.Id = thieves.Id;
            return View();
        }

        public ActionResult Accept(int Id)
        {
            
            var thief = _thievesRepository.Get().FirstOrDefault(t => t.Id == Id);
            if (_thievesEncounter.Accept(_player, thief))
            {
                ViewBag.PlayerMoneyAmount = _player.CurrentMoneyAmount;
                return View();
            }
           
            _thievesEncounter.Decline(_player);
            return View("Failure");
        }

        public ActionResult Decline()
        {
            _thievesEncounter.Decline(_player);
            return View();
        }

        public ActionResult Failure()
        {
            _thievesEncounter.Decline(_player);
            return View();
        }
    }
}