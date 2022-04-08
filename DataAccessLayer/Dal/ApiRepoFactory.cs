using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dal
{
    public static class ApiRepoFactory
    {
        public static IGetable GetRepo() => new ApiRepo(); 
    }
}
