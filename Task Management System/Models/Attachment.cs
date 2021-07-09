using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_Lib.Models
{
    public class Attachment : BaseModel<string>
    {
        public Attachment()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        public string Url { get; set; }
        public string TaskId { get; set; }

        public WorkTask WorkTask { get; set; }
    }
}
