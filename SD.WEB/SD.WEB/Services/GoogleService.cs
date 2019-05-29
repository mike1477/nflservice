using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SD.WEB.Services
{
    public class GoogleService
    {
        private readonly string GoogleApiKey = WebConfigurationManager.AppSettings["GoogleApiKey"];
        private readonly string GoogleMapsUrl = "https://maps.googleapis.com/maps/api/staticmap";


        public string AssembleGoogleImageString(decimal? geolat, decimal? geolong)
        {
            var url = GoogleMapsUrl + "?size=800x500&center=" + geolat + "," + geolong + "&zoom=10&key=" + GoogleApiKey;
            return url;
        }

    }
}