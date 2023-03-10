using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internshipForm.Model
{
    public class Employee
    {
        //svi propertiji moraju da budu virtual; nhibernate ih prepisuje (overriduje)
        public virtual int Id { get; protected set; }
        public virtual string Name { get; set; }
        public virtual string Email { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string DateOfBirth { get; set; }
        public virtual int MonthlySalary { get; set; }
        //modeliramo 1:N   ;  1 employee izvrsava vise taskova
        public virtual IList<Task> Tasks { get; set; }

        public Employee()
        {
            Tasks = new List<Task>();
        }

    }
}
