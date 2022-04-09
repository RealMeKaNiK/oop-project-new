using DataAccessLayer.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dal
{
    public class FileRepo : IRepo
    {
        private const string CONFIG_DIR = @"..\..\..\Config";
        private const string CONFIG_PATH = CONFIG_DIR + @"\config.txt";

        private const string CONFIG_FAVORITE_PLAYERS = CONFIG_DIR + @"\favPlayers.txt";

        public FileRepo() => CreateFileIfNotExists();

        private void CreateFileIfNotExists()
        {
            Directory.CreateDirectory(CONFIG_DIR);
            if (!File.Exists(CONFIG_PATH) || !File.Exists(CONFIG_FAVORITE_PLAYERS))
            {
                File.Create(CONFIG_PATH).Close();
                File.Create(CONFIG_FAVORITE_PLAYERS).Close();
            }
        }

        public Config GetConfig()
        {
            string line = File.ReadAllText(CONFIG_PATH);
            return Config.ParseFromFile(line);
        }

        public static List<Player> LoadFavoritePlayersFromFile()
        {
            List<Player> players = JsonConvert.DeserializeObject<List<Player>>(File.ReadAllText(CONFIG_FAVORITE_PLAYERS));
            if (players == null)
            {
                return new List<Player>();
            }
            return players;
        } 

        public void SaveConfig(Config config) => File.WriteAllText(CONFIG_PATH, config.PrepareConfigForFile());

        public void SaveFavoritePlayers(List<Player> players) => File.WriteAllText(CONFIG_FAVORITE_PLAYERS, JsonConvert.SerializeObject(players));      
    }
}
