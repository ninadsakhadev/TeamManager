using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using Thinktecture.IdentityServer.Core;
using Thinktecture.IdentityServer.Core.Models;
using Thinktecture.IdentityServer.Core.Services.InMemory;

namespace TeamManager.IdSrv.Config
{
    public static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>(){
                new InMemoryUser
                {
                    Username="Ninad",
                    Password="password",
                    Subject="1",
                    Claims=new []
                    {
                        new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.GivenName,"Ninad"),
                        new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.FamilyName,"Sakhadev")
                    }
                },
                new InMemoryUser
                {
                    Username="Kiran",
                    Password="password",
                    Subject="1",
                    Claims=new []
                    {
                        new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.GivenName,"Kiran"),
                        new Claim(Thinktecture.IdentityServer.Core.Constants.ClaimTypes.FamilyName,"Attal")
                    }
                }
            };
        }
                    
    }
}