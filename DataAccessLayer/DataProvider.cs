using DataAccessLayer.Dal;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class DataProvider
    {

        private static readonly IGetable ApiRepo = ApiRepoFactory.GetRepo();
        private static readonly IRepo FileRepo = FileRepoFactory.GetRepo();
        private static Config Config;

        public static void LoadConfiguration()
        {
            Config = FileRepo.GetConfig();
        }

        public static void UpdateConfig(TeamType teamType, Language language)
        {
            if (Config == null)
                Config = new Config();
            Config.Language = language;
            Config.TeamType = teamType;
        }

        public static void SaveConfig() => FileRepo.SaveConfig(Config);

        public async static Task<List<Team>> GetTeams() => await ApiRepo.GetAllResults(Config.GetURLAllResults());

        public static void SaveFavoriteTeam(Team team) => Config.FavoriteTeam = team;
    }
}
