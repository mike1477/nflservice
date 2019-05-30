using SD.WEB.Services;
using SD.WEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SD.WEB.Controllers
{
    public class NFLTeamsController : Controller
    {
        private NFLService _nflService;

        public NFLTeamsController()
        {
            _nflService = new NFLService();
        }
        // GET: NFLTeams/GetAllTeams
        public async Task<ActionResult> GetAllTeams()
        {
            var model = new TeamsViewModel
            {
                Teams = await _nflService.GetAllTeams()
            };
            return View(model);
        }

        // GET: NFLTeams/GetTeam/5
        public async Task<ActionResult> GetTeam(int id)
        {
            var model = new TeamViewModel
            {
                Team = await _nflService.GetTeam(id)
            };
            return View("GetTeam",model);
        }

        
    }
}
