using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BLContext : DbContext
    {
        private   static string ConnString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
        public BLContext()
            : base("name=ConnString")
        {
           Database.SetInitializer<BLContext>(new DropCreateDatabaseIfModelChanges<BLContext>());
             // Database.SetInitializer<BLContext>(null);
        }
        //public DbSet<Category> Category { get; set; }
        //public DbSet<Product> Product { get; set; }
        public DbSet<SignIn> SignIn { get; set; }
        public DbSet<Enroll> Enroll { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new ProductMapping());
            //modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new EnrollMapping());
            modelBuilder.Configurations.Add(new SignInMapping());
            ///DomainMapping  所在的程序集一定要写对，因为目前在当前项目所以是采用的当前正在运行的程序集 如果你的mapping在单独的项目中 记得要加载对应的assembly
             ///这是重点
           //  var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                
           //.Where(type => !String.IsNullOrEmpty(type.Namespace))
           //.Where(type => type.BaseType != null && type.BaseType.BaseType != null && type.BaseType.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)); 
            
           // var tempTyp=Assembly.CreateQualifiedName
           //  foreach (var type in typesToRegister)
           //  {
           //      dynamic configurationInstance = Activator.CreateInstance(type);

           //      modelBuilder.Configurations.Add(configurationInstance);
           //  }
 
             base.OnModelCreating(modelBuilder);
        }
    }
}
