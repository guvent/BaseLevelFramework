using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace Common.CrossCuttingConcerns.Security.Web
{
    public class SecurityUtilities
    {
        public identity FormsAuthTicketToidentity(FormsAuthenticationTicket ticket)
        {
            var identity = new identity
            {
                Id = Setid(ticket),
                Name = SetName(ticket),
                Email = SetEmail(ticket),
                Roles = SetRoles(ticket),
                FirstName = SetFirstName(ticket),
                LastName = SetLastName(ticket),
                AuthenticationType = SetAuthType(ticket),
                IsAuthenticated = SetIsAuthenticated(ticket)
            };
            return identity;
        }

        private bool SetIsAuthenticated(FormsAuthenticationTicket ticket)
        {
            return true;
        }

        private string SetAuthType(FormsAuthenticationTicket ticket)
        {
            return "Forms";
        }

        private string SetLastName(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[3];
        }

        private string SetFirstName(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[2];
        }

        private string[] SetRoles(FormsAuthenticationTicket ticket)
        {

            string[] data = ticket.UserData.Split('|');
            string[] roles = data[1].Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries);
            return roles;
        }

        private string SetEmail(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return data[0];
        }

        private string SetName(FormsAuthenticationTicket ticket)
        {
            return ticket.Name;
        }

        private Guid Setid(FormsAuthenticationTicket ticket)
        {
            string[] data = ticket.UserData.Split('|');
            return new Guid(data[4]);
        }
    }
}
