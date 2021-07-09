using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_Lib.Models
{
    public class WorkTask : BaseModel<string>
    {
        public WorkTask()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public string CreationDate { get; set; }
        public int Priority { get; set; }
        public int Status { get; set; }
        public int DisplayOrder { get; set; }
        public string UserId { get; set; }
        public string GroupId { get; set; }

        public User User { get; set; }
        public Group Group { get; set; }
        public ICollection<Attachment> Attachments { get; set; }
    }
}
