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
        private GoogleService _googleService;

        public NFLStadiumsController()
        {
            _nflService = new NFLService();
            _googleService = new GoogleService();
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
        // GET: NFLStadiums/id
        public ActionResult GetStadium(int id)
        {
            var stadium = _nflService.GetStadiumById(id);
            string googleImageUrl = _googleService.AssembleGoogleImageString(stadium.GeoLat, stadium.GeoLong);

            StadiumViewModel model = new StadiumViewModel
            {
                Stadium = stadium,
                GoogleImage = googleImageUrl
            };
            return View("Stadium",model);
        }

    }
}
