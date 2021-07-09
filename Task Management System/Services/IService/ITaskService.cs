using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Management_Lib.Models;
using Task_Management_System.Repository;

namespace Task_Management_System.Services
{
    public interface ITaskService : IRepository<WorkTask, string>
    {
        WorkTask Update(WorkTask task);
        bool AddToGroup(WorkTask task, string groupId);
        void RemoveTaskFromGroup(WorkTask task);
        bool IsTaskInGroup(WorkTask task, string groupId);
    }
}
