using SD.WEB.Services;
using SD.WEB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SD.WEB.Controllers
{
    public class NFLStadiumsController : Controller
    {
        private NFLService _nflService;

        public NFLStadiumsController()
        {
            _nflService = new NFLService();
        }
        // GET: NFLStadiums
        public ActionResult GetAllStadiums()
        {
            var model = new StadiumsViewModel
            {
                Stadiums = _nflService.GetAllStadium()
            };
            return View(model);
        }

    }
}
