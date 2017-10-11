using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InTask : Common
    {
        public int InTaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TaskStatusId { get; set; }
        public virtual Status Status { get; set; }

    }
}
