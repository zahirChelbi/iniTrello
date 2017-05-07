using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using System.Web.Security;

namespace iniTrello.Utils
{
    public class CustomRoleProvider : RoleProvider
    {
        public override string ApplicationName{ get; set; }


        public override bool IsUserInRole(string username, string roleName)
        {
            return true;
        }

        public override string[] GetRolesForUser(string username)
        {
            return new string[] { "admin", "superadmin" };
        }

        // -- Snip --

        public override string[] GetAllRoles()
        {
            return new string[] { "admin", "superadmin" };
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }
    }
}