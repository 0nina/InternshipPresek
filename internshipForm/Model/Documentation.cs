﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internshipForm.Model
{
    public class Documentation
    {
        public virtual int Id { get; protected set; }
        public virtual string ProjectName { get; set; }
        public virtual int Length { get; set; }
        public virtual string Language { get; set; }

        // 1:N - 1 Documentation : multiple tasks
        public virtual IList<Task> Tasks { get; set; }
        public Documentation()
        {
            Tasks = new List<Task>();
        }

    }
}