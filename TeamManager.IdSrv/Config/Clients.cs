using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thinktecture.IdentityServer.Core.Models;

namespace TeamManager.IdSrv.Config
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
            {
                new Client
                {
                    Enabled=true,
                    ClientName="TeamManager Web Client",
                    ClientId="mvc",
                    Flow=Flows.Hybrid,
                    RequireConsent=true,
                    RedirectUris=new List<string>
                    {

                    }
                }
            };
        }
    }
}