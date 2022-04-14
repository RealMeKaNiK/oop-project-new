using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dal
{
    public static class JsonParserRepoFactory
    {
        public static IGetable GetJsonParserRepo() => new JsonParserRepo();
    }
}
