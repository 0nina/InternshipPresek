using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internshipForm.Mappings
{
    internal class EmployeeMapping : ClassMap<Model.Employee>
    {
        public EmployeeMapping()
        {
            Table("employee");

            //tako se mapira primarni kljuc i koristicu trigger za generisanje primarnog kljuca
            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity();
            
            Map(x => x.Name, "name");
            Map(x => x.Email, "email");
            Map(x => x.PhoneNumber, "phoneNumber");
            Map(x => x.DateOfBirth, "dateOfBirth");
            Map(x => x.MonthlySalary, "monthlySalary");
            HasMany(x => x.Tasks).KeyColumn("assignee").LazyLoad();
        }
    }
}
