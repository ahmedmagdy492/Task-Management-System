using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Management_Lib.Data;
using Task_Management_Lib.Models;
using Task_Management_System.Repository;

namespace Task_Management_System.Services
{
    public class TaskService : Repository<WorkTask, string>, ITaskService
    {
        public TaskService(AppDbContext context) : base(context)
        {
        }

        public bool AddToGroup(WorkTask task, string groupId)
        {
            if(!IsTaskInGroup(task, groupId))
            {
                task.GroupId = groupId;
                return true;
            }
            return false;
        }

        public bool IsTaskInGroup(WorkTask task, string groupId)
        {
            if (task.GroupId == groupId)
                return true;
            return false;
        }

        public void RemoveTaskFromGroup(WorkTask task)
        {
            task.GroupId = null;
        }

        public WorkTask Update(WorkTask task)
        {
            _context.Entry(task).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return task;
        }
    }
}
