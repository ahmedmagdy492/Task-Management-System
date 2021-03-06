using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Management_Lib.Models
{
    public class User : BaseModel<string>
    {
        public User()
        {
            Id = Guid.NewGuid().ToString("N");
        }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<WorkTask> WorkTasks { get; set; }
        public ICollection<Group> Groups { get; set; }
        public ICollection<GroupMessage> Messages { get; set; }
    }
}
