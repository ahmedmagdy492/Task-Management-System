using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_Lib.Models
{
    public class Group : BaseModel<string>
    {
        public Group()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        public string Name { get; set; }
        public string CreationDate { get; set; }

        public ICollection<WorkTask> WorkTasks { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<GroupMessage> Messages { get; set; }
    }
}
