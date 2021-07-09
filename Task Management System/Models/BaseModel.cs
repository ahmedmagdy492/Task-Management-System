using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_Lib.Models
{
    public class BaseModel<TID>
    {
        public TID Id { get; set; }
    }
}
