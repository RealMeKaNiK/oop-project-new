using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Dal
{
    public interface IRepo
    {
        Config GetConfig();
        void SaveConfig(Config config);
    }
}
