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
            Table("task");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "id").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Title, "title");
            Map(x => x.Description, "description");
            Map(x => x.DueDate, "dueDate");

            //mapiranje veze 1:N Prodavnica-Odeljenje
            References(x => x.Assignee).Column("assignee").LazyLoad();
        }
    }
}
