using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;



namespace PortalX_DCRM.Controllers
{
    public class TokenController : ApiController
    {
        public string Get(int id)
        {
            return "value";
        }
        
        [Authorize]
        [Route("api/token/ChangePassword")]
        [HttpPost] // There are HttpGet, HttpPost, HttpPut, HttpDelete.
        public string ChangePassword()
        {
            string userinfo = Common.getClaimInfo("Username");
            return "Changesd";
        }

        [Route("api/token/getToken")]
        [HttpPost] 
        public string getToken()
        {
            return "genToken";
        }


        


    }
}