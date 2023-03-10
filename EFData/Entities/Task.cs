using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFData.Entities
{
    public class Task
    {
        private int Id { get; set; }
        private int Assignee { get; set; }
        private DateTime dueDate { get; set; }
        private string Description { get; set; }
    }
}
