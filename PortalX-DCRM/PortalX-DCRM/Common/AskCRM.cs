using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PortalX_DCRM.Models;
using Microsoft.Xrm.Client;
using Microsoft.Xrm.Client.Services;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace PortalX_DCRM
{
    public class AskCRM
    {
        public static User FindUser(string Username,string Password)
        {

            // TODO: User Authentication will be done here

            return new User
            {
                Username = "abc",
                Password = "xyz",
                isValid=true
            };
        }
    }
}