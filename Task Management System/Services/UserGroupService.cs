using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Management_Lib.Models;

namespace Task_Management_System.Services
{
    public class UserGroupService : IUserGroupService
    {
        public bool AddUserToGroup(User user, Group group)
        {
            if(!IsUserInGroup(user, group))
            {
                group.Users.Add(user);
                return true;
            }
            return false;
        }

        public bool IsUserInGroup(User user, Group group)
        {
            return group.Users.Contains(user);
        }

        public bool RemoveUserFromGroup(User user, Group group)
        {
            if(IsUserInGroup(user, group))
            {
                group.Users.Remove(user);
                return true;
            }
            return false;
        }
    }
}
