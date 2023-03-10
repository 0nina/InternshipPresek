using EFData.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFData.DataAccess
{
    public class EmployeesContext : DbContext
    {
        public EmployeesContext(DbContextOptions options) : base(options)
        {
           
        }
        //setting the tables 
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }

       
    }

}
