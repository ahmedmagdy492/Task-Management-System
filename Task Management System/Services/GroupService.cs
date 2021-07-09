using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Management_Lib.Data;
using Task_Management_Lib.Models;
using Task_Management_System.Repository;

namespace Task_Management_System.Services
{
    public class GroupService : Repository<Group, string>, IGroupService
    {
        public GroupService(AppDbContext context) : base(context)
        {
        }

        public Group Update(Group group)
        {
            _context.Entry(group).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return group;
        }
    }
}
