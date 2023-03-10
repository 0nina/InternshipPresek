using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internshipForm.Model
{
    public class Task
    {

        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual string DueDate { get; set; }

        public virtual Employee Assignee { get; set; }

        //strani kljuc
    }
}
