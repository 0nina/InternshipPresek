using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Mapping;

namespace internshipForm.Mappings
{
    public class DocumentationMapping : ClassMap<Model.Documentation>
    {
        public DocumentationMapping()
        {
            Table("DOCUMENTATION");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            
            Map(x => x.ProjectName, "PROJECT_NAME");
            Map(x => x.Length, "LENGTH");
            Map(x => x.Language, "LANGUAGE");


            HasMany(x => x.Tasks).KeyColumn("DOCUMENT_NUMBER").LazyLoad();


        }
    }
}