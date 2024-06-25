using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController1 : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experinces.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experince experience)
        {
            context.Experinces.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experinces.Find(id);
            context.Experinces.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]

        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experinces.Find(id);
            return View(value);
        }
        [HttpPost]

        public IActionResult UpdateExperience(Experince experience)
        {
            context.Experinces.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList"); 
        }
    }
}
