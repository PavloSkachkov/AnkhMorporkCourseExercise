using System;
using System.Web.Mvc;
using AnkhMorporkCourseExercise.Web.Encounters;

namespace AnkhMorporkCourseExercise.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly AssassinsEncounter _assassinsEncounter;
        private readonly BeggarsEncounter _beggarsEncounter;
        private readonly FoolsEncounter _foolsEncounter;
        private readonly ThievesEncounter _thievesEncounter;

        public HomeController(AssassinsEncounter assassinsEncounter, BeggarsEncounter beggarsEncounter,
            FoolsEncounter foolsEncounter, ThievesEncounter thievesEncounter)
        {
            _assassinsEncounter = assassinsEncounter;
            _beggarsEncounter = beggarsEncounter;
            _foolsEncounter = foolsEncounter;
            _thievesEncounter = thievesEncounter;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Encounter()
        {
            var rnd = new Random();
            var desider = rnd.Next(0, 5);
            switch (desider)
            {
                //Assassin
                case 0:
                    {
                        ViewBag.Desider = desider;
                        return RedirectToAction("Index", "AssassinsEncounter");
                    }
                //Beggar
                case 1:
                    {
                        ViewBag.Desider = desider;
                        return RedirectToAction("Index", "BeggarsEncounter");
                    }
                //Fool
                case 2:
                    {
                        ViewBag.Desider = desider;
                        return RedirectToAction("Index", "FoolsEncounter");
                    }
                //Thief
                case 3:
                    {
                        ViewBag.Desider = desider;
                        return RedirectToAction("Index", "ThievesEncounter");
                    }
                case 4:
                    {
                        ViewBag.Desider = desider;
                        return RedirectToAction("Index", "PubsEncounter");
                    }
            }
            return View("Index");
        }
    }
}