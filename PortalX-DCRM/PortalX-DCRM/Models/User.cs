using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalX_DCRM.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool isValid { get; set; }
    }
}