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
            Database.SetInitializer<ModelContext>(new DropCreateDatabaseIfModelChanges<ModelContext>());
        }
        public ModelContext(string connString) : base(connString)
        {
            Database.SetInitializer<ModelContext>(new DropCreateDatabaseIfModelChanges<ModelContext>());
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }
    }
}
