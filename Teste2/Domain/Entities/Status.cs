using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Status : Common
    {
        public int TaskStatusId { get; set; }
        public string Description { get; set; }

        public IEnumerable<InTask> Tasks { get; set; }
    }
}
