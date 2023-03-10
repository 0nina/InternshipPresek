using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFData.Entities
{
    public class Employee
    {
            private int Id { get; set; }
            private string Name { get; set; }
            private string Email { get; set; }
            private string PhoneNumber { get; set; }
            private DateTime DateOfBirth { get; set; }
            private int MonthlySalary { get; set; }
            //modeliramo 1:N   ;  1 employee izvrsava vise taskova
            private List<Task> Tasks { get; set; } = new List<Task>();

    }
}
