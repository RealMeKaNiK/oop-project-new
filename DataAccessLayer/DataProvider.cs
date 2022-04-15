﻿using DataAccessLayer.Dal;
using DataAccessLayer.Model;
using DataAccessLayer.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class DataProvider
    {

        private static readonly IGetable ApiRepo = JsonParserRepoFactory.GetJsonParserRepo();
        private static readonly IRepo FileRepo = FileRepoFactory.GetRepo();
        private static Config Config;

        // Config and stuff
        public static bool LoadConfiguration()
        {
            Config = FileRepo.GetConfig();
            return Config.Language != Language.NotSet && Config.TeamType != TeamType.NotSet;
        }

        public static void UpdateConfig(TeamType teamType, Language language)
        {
            if (Config == null)
                Config = new Config();
            Config.Language = language;
            Config.TeamType = teamType;
        }
        public static void UpdateConfig(TeamType teamType, Language language, ResolutionType resolutionType)
        {
            if (Config == null)
                Config = new Config();
            Config.Language = language;
            Config.TeamType = teamType;
            Config.ResolutionType = resolutionType;
        }
        public static ResolutionType GetResolutionType() => Config.ResolutionType;
        public static TeamType GetTeamType() => Config.TeamType;
        public static Language GetLanguage() => Config.Language;

        public static string GetConfigInfo() => Config.ToString();
        public static Team GetFavoriteTeam() => Config.FavoriteTeam;

        public static void SaveConfig() => FileRepo.SaveConfig(Config);
        public static void SaveFavoritePlayers() => FileRepo.SaveFavoritePlayers(Config.FavoritePlayers);

        public static void SaveAllPicutres() => FileRepo.SavePicturesFromPlayers(Config.FavoriteTeam.Players, Config.FavoriteTeam.Fifa_Code);
        public static void SaveFavoriteTeam(Team team) => Config.FavoriteTeam = team;
        public static void InsertFavoritePlayer(Player player) => Config.FavoritePlayers.Add(player);

        public static void SetPictureForPlayer(Player player, Bitmap picture) => Config.FavoriteTeam.Players.Find(x => x.name.Equals(player.name)).Picture = picture;
        public static void DeleteFavoritePlayers() => Config.FavoritePlayers.Clear();
        public static List<Player> GetFavoritePlayers() => new List<Player>(FileRepo.LoadPicutres(Config.FavoritePlayers, Config.FavoriteTeam?.Fifa_Code));        

        // API comunication
        public async static Task<List<Team>> GetTeams()
        {
            if (Config.TeamType == TeamType.NotSet)
            {
                return new List<Team>();
            }
            return await ApiRepo.GetAllResults(Config.GetURLAllResults());
        }
        public async static Task<List<Match>> GetMatchEvents() => await ApiRepo.GetTeamMatches(Config.GetURLTeamMatches(), Config.FavoriteTeam.Fifa_Code);

        public async static Task<List<Team>> GetTeamOpponents(string fifaCodeFromSelectedTeam) => await ApiRepo.GetFromSelectedTeamOpponents(Config.GetURLTeamMatches(), fifaCodeFromSelectedTeam, Config.GetURLAllResults());
        public async static Task<List<Player>> GetPlayers()
        {
            if (Config.FavoriteTeam?.Players != null)
            {
                return new List<Player>(FileRepo.LoadPicutres(Config.FavoriteTeam.Players, Config.FavoriteTeam.Fifa_Code));
            }
            if (Config.FavoriteTeam == null && Config.FavoriteTeam.Fifa_Code == null)
            {
                return new List<Player>();
            }
            Config.FavoriteTeam.Players = await ApiRepo.GetTeamPlayers(Config.GetURLTeamMatches(), Config.FavoriteTeam?.Fifa_Code);
            return FileRepo.LoadPicutres(Config.FavoriteTeam.Players, Config.FavoriteTeam?.Fifa_Code);
        }

        public async static Task<List<Team>> GetTeamStatistics(string fifaCode) => await ApiRepo.GetTeamResult(Config.GetURLTeamResult(), fifaCode);

        public async static Task<Match> GetMatchWinner(string firstFifaCode, string secondFifaCode)
        {
            Match singleMatch = await ApiRepo.GetSpecificMatch(firstFifaCode, secondFifaCode, Config.GetURLTeamMatches());
            singleMatch.home_team_statistics.starting_eleven = Utilities.CalculatePlayerStatisticsForSingleMatch(singleMatch.home_team_statistics.starting_eleven, singleMatch.home_team_events);
            singleMatch.away_team_statistics.starting_eleven = Utilities.CalculatePlayerStatisticsForSingleMatch(singleMatch.away_team_statistics.starting_eleven, singleMatch.away_team_events);
            return singleMatch;            
        }
                    
    }
}
