using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamManager.Constants
{
    public class TeamManagerConstants
    {
        public const string TeamManagerAPI = "http://localhost:1267/";
        public const string TeamManagerClient = "https://localhost:44300/";
        public const string IdSrvIssuerUri = "https://teammanageridsrv3/embedded";
        public const string IdSrv = "https://localhost:44300/identity";
        public const string IdSrvToken = IdSrv + "/connect/token";
        public const string IdSrvAuthorize = IdSrv + "/connect/authorize";
        //test
    }
}
