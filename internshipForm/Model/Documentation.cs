using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internshipForm.Model
{
    public class Documentation
    {
        //protected set 
        public virtual int Id { get;  set; }
        public virtual string ProjectName { get; set; }
        public virtual int Length { get; set; }
        public virtual string Language { get; set; }

        //modeliramo 1:N   ;  1 dokumentacija sadrzi vise taskova

        public virtual IList<Task> Tasks { get; set; }
        public Documentation()
        {
            Tasks = new List<Task>();
        }

    }
}