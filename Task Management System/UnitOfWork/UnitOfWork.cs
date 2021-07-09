using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Management_Lib.Data;
using Task_Management_System.Services;

namespace Task_Management_System.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            UserService = new UserService(context);
            GroupService = new GroupService(context);
            TaskService = new TaskService(context);
            AttachmentService = new AttachmentService(context);
            MessageService = new MessageService(context);
            UserGroupService = new UserGroupService();
            _context = context;
        }

        public IUserService UserService { get; private set; }
        public IGroupService GroupService { get; private set; }
        public IAttachmentService AttachmentService { get; private set; }
        public ITaskService TaskService { get; private set; }
        public IMessageService MessageService { get; private set; }
        public IUserGroupService UserGroupService { get; private set; }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
