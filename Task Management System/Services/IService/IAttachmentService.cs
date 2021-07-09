using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task_Management_Lib.Models;
using Task_Management_System.Repository;

namespace Task_Management_System.Services
{
    public interface IAttachmentService : IRepository<Attachment, string>
    {
    }
}
