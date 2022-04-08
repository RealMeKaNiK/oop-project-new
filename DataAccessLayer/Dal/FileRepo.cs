using DataAccessLayer.Model;
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

        public FileRepo() => CreateFileIfNotExists();

        private void CreateFileIfNotExists()
        {
            Directory.CreateDirectory(CONFIG_DIR);
            if (!File.Exists(CONFIG_PATH))
            {
                File.Create(CONFIG_PATH).Close();
            }
        }

        public Config GetConfig()
        {
            string line = File.ReadAllText(CONFIG_PATH);
            return Config.ParseFromFile(line);
        }

        public void SaveConfig(Config config) => File.WriteAllText(CONFIG_PATH, config.PrepareConfigForFile());
        
    }
}
