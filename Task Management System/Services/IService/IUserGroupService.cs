using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Management_Lib.Models;

namespace Task_Management_System.Services
{
    public interface IUserGroupService
    {
        bool AddUserToGroup(User user, Group group);
        bool IsUserInGroup(User user, Group group);
        bool RemoveUserFromGroup(User user, Group group);
    }
}
