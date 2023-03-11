using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static internshipForm.Model.Employee;
using static internshipForm.Model.Task;
using FluentNHibernate.Mapping;

namespace internshipForm.Mappings
{
    public class TaskMapping : ClassMap<internshipForm.Model.Task>
    {
        public TaskMapping()

        { //Mapiranje tabele
            Table("TASK");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Title, "TITLE");
            Map(x => x.Description, "DESCRIPTION");
            Map(x => x.DueDate, "DUE_DATE");

            //mapiranje veze 1:N Employee-Task
            References(x => x.Assignee).Column("ASSIGNEE").LazyLoad();


            //mapiranje veze 1:N Documentation-Task
            References(x => x.Documentation).Column("DOCUMENTATION_NUMBER").LazyLoad();

        }
    }
}
