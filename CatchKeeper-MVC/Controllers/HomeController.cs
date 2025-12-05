using System.Linq;
using System.Web.Mvc;
using CatchKeeperMVC.Models;

namespace CatchKeeperMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly CatchKeeperContext db = new CatchKeeperContext();

        public ActionResult Index()
        {
            // Show the 3 most recent catches on the homepage
            var recentCatches = db.Catches
                                  .OrderByDescending(c => c.CatchDate)
                                  .Take(3)
                                  .ToList();

            return View(recentCatches);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult HowItWorks()
        {
            return View();
        }

        public ActionResult Tips()
        {
            return View();
        }

        public ActionResult Gear()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Roadmap()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
