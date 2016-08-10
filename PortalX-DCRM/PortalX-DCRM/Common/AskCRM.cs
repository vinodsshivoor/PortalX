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
        private static OrganizationService _orgService;
        private static CrmConnection _connection;

        public static User FindUser(string Username, string Password)
        {
            _connection = CrmConnection.Parse(Common.getCrmConnection());

            try
            {
                using (_orgService = new OrganizationService(_connection))
                {

                    QueryExpression query = new QueryExpression("contact");
                    query.ColumnSet.AddColumns("contactid", "portalx_username", "portalx_password", "portalx_isvalid");
                    query.Criteria = new FilterExpression();
                    query.Criteria.AddCondition("portalx_username", ConditionOperator.Equal, Username);
                    query.Criteria.AddCondition("portalx_password", ConditionOperator.Equal, Password);
                    

                    EntityCollection UserRecord = _orgService.RetrieveMultiple(query);

                    if (UserRecord.Entities.Count > 0)
                    {
                        return new User
                        {
                            Id = (Guid)UserRecord[0]["contactid"],
                            Username = UserRecord[0]["portalx_username"].ToString(),
                            Password = UserRecord[0]["portalx_password"].ToString(),
                            isValid = Convert.ToBoolean(UserRecord[0]["portalx_isvalid"])
                        };
                    }
                    else
                    {
                        return new User
                        {
                            Username = string.Empty,
                            Password = string.Empty,
                            isValid = false
                        };

                    }
                }

            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}