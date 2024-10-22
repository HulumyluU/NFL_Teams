using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using October8.Models;

namespace October8.Controllers
{
    public class FavoritesController : Controller
    {
        private TeamContext context;
        public FavoritesController(TeamContext ctx) => context = ctx;

        [HttpGet]
        public ViewResult Index()
        {
            var session = new NFLSession(HttpContext.Session);
            var model = new TeamsViewModel
            {
                ActiveConf = session.GetActiveConf(),
                ActiveDiv = session.GetActiveDiv(),
                Teams = session.GetMyTeams()
            };
            return View(model);
        }


        [HttpPost]
        public RedirectToActionResult Add(Team team)
        {
            team = context.Teams
                    .Include(t => t.Conference)
                    .Include(t => t.Division)
                    .Where(t => t.TeamID == team.TeamID)
                    .FirstOrDefault() ?? new Team();

            var session = new NFLSession(HttpContext.Session);
            var teams = session.GetMyTeams();
            teams.Add(team);
            session.SetMyTeams(teams);

            // notify user and redirect to home page
            TempData["message"] =
                $"{team.Name} added to your favorites";
            return RedirectToAction("Index", "Home",
                new
                {
                    ActiveConf = session.GetActiveConf(),
                    ActiveDiv = session.GetActiveDiv()
                });
        }

        [HttpPost]
        public RedirectToActionResult Delete()
        {
            var session = new NFLSession(HttpContext.Session);
            session.RemoveMyTeams();

            // notify user and redirect to home page
            TempData["message"] = "Favorite teams cleared";
            return RedirectToAction("Index", "Home",
                new
                {
                    ActiveConf = session.GetActiveConf(),
                    ActiveDiv = session.GetActiveDiv()
                });
        }
    }
}