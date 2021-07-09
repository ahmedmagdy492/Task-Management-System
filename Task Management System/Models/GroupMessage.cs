using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_Lib.Models
{
    public class GroupMessage : BaseModel<string>
    {
        public GroupMessage()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        public string Content { get; set; }
        public string SendDate { get; set; }
        public string SenderId { get; set; }
        public string GroupId { get; set; }

        public User Sender { get; set; }
        public Group Group { get; set; }
    }
}
