using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace PortalX_DCRM
{
    public class Common
    {
        public static string getClaimInfo(string key)
        {
            var identity = HttpContext.Current.Request.RequestContext.HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
                return identity.Claims.FirstOrDefault(o => o.Type.Equals(key)).Value;
            else
                return null;
        }

        public static string getCrmConnection()
        {
            string url = "Url=" + ConfigurationManager.AppSettings["Url"].ToString();
            string userName = "Username=" + ConfigurationManager.AppSettings["Username"].ToString();
            string password = "Password=" + ConfigurationManager.AppSettings["Password"].ToString();
            return string.Format("{0};{1};{2};",url,userName,password);
           
        }
    }

    
}