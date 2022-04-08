using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dal
{
    public static class FileRepoFactory
    {
        public static FileRepo GetRepo() => new FileRepo();
    }
}
