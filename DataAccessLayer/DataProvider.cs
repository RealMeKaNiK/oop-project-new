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
    }
}
