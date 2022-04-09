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

        // Config and stuff
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
        public static void SaveFavoritePlayers() => FileRepo.SaveFavoritePlayers(Config.FavoritePlayers);
        public static void SaveFavoriteTeam(Team team) => Config.FavoriteTeam = team;
        public static void SaveFavoritePlayer(Player player) => Config.FavoritePlayers.Add(player);
        public static void DeleteFavoritePlayers() => Config.FavoritePlayers.Clear();
        public static List<Player> GetFavoritePlayers() => new List<Player>(Config.FavoritePlayers);

        // API comunication
        public async static Task<List<Team>> GetTeams() => await ApiRepo.GetAllResults(Config.GetURLAllResults());
        public async static Task<List<Match>> GetMatchEvents() => await ApiRepo.GetTeamMatches(Config.GetURLTeamMatches(), Config.FavoriteTeam.Fifa_Code);
        public async static Task<List<Player>> GetPlayers()
        {
            if (Config.FavoriteTeam.Players != null)
            {
                return new List<Player>(Config.FavoriteTeam.Players);
            }            
            List<Player> players = await ApiRepo.GetTeamPlayers(Config.GetURLTeamMatches(), Config.FavoriteTeam.Fifa_Code);
            Config.FavoriteTeam.Players = players;
            return players;
        } 
    }
}
