using MyEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEF.Context
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=context")
        {

        }
        public ModelContext(string connString) : base(connString)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
