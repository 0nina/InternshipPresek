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
            Table("EMPLOYEE");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            
            Map(x => x.Name, "NAME");
            Map(x => x.Email, "EMAIL");
            Map(x => x.PhoneNumber, "PHONE_NUMBER");
            Map(x => x.DateOfBirth, "DATE_OF_BIRTH");
            Map(x => x.MonthlySalary, "MONTHLY_SALARY");
            HasMany(x => x.Tasks).KeyColumn("ASSIGNEE").LazyLoad();
        }
    }
}
