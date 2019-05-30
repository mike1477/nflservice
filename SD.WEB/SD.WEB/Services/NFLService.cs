using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Configuration;
using FantasyData.Api.Client;
using FantasyData.Api.Client.Model.NFLv3;

namespace SD.WEB.Services
{
    public class NFLService
    {
        private readonly string SportDataKey = WebConfigurationManager.AppSettings["SportDataKey"];
        private NFLv3StatsClient _client;

        public NFLService()
        {
            _client = new NFLv3StatsClient(SportDataKey);
        }

        public List<Stadium> GetAllStadium()
        {
            return _client.GetStadiums();
        }

        public Stadium GetStadiumById(int StadiumId)
        {
            var stadiums = _client.GetStadiums();
            return stadiums.FirstOrDefault(s => s.StadiumID == StadiumId);
        }

        public async Task<List<Team>> GetAllTeams()
        {
            return await _client.GetAllTeamsAsync();
        }

        public async Task<Team> GetTeam(int TeamId)
        {
            var teams = await _client.GetAllTeamsAsync();
            return teams.FirstOrDefault(t => t.TeamID == TeamId);
        }
    }
}