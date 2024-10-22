using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using October8.Models;
using System.Diagnostics;

namespace October8.Controllers
{
    public class HomeController : Controller
    {
        private TeamContext context;

        public HomeController(TeamContext ctx)
        {
            context = ctx;
        }


        public ViewResult Index(TeamsViewModel model)
        {

            //var session = new NFLSession(HttpContext.Session);

            var session = new NFLSession(HttpContext.Session);
            session.SetActiveConf(model.ActiveConf);
            session.SetActiveDiv(model.ActiveDiv);


            model.Conferences = context.Conferences.ToList();
            model.Divisions = context.Divisions.ToList();

            IQueryable<Team> query = context.Teams.OrderBy(t => t.Name);
            if (model.ActiveConf != "all")
                query = query.Where(t =>
                    t.Conference.ConferenceID.ToLower() ==
                         model.ActiveConf.ToLower());
            if (model.ActiveDiv != "all")
                query = query.Where(t =>
                    t.Division.DivisionID.ToLower() ==
                         model.ActiveDiv.ToLower());
            model.Teams = query.ToList();
            return View(model);
        }


        [HttpGet]
        public IActionResult Details(string id)
        {

            var session = new NFLSession(HttpContext.Session);
            var model = new TeamsViewModel
            {
                Team = context.Teams
                    .Include(t => t.Conference)
                    .Include(t => t.Division)
                    .FirstOrDefault(t => t.TeamID == id) ?? new Team(),
                ActiveConf = session.GetActiveConf(),
                ActiveDiv = session.GetActiveDiv()
            };
            return View(model);





         
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}