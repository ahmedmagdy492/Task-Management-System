using Task_Management_System.Services;

namespace Task_Management_System.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAttachmentService AttachmentService { get; }
        IGroupService GroupService { get; }
        IMessageService MessageService { get; }
        ITaskService TaskService { get; }
        IUserGroupService UserGroupService { get; }
        IUserService UserService { get; }

        bool Save();
    }
}