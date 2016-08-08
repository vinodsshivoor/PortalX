using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace PortalX_DCRM
{
    public class Common
    {
        public static string GetClaimInfo(string key)
        {
            var identity = HttpContext.Current.Request.RequestContext.HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
                return identity.Claims.FirstOrDefault(o => o.Type.Equals(key)).Value;
            else
                return null;
        }
    }
}