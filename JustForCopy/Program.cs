using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JustForCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            TestContext testContext = new TestContext();
            IRepository<Person> repository = new EfRepository<Person>(testContext);
            int i = repository.Insert(new Person { Id = "1", Name = "name" });
            var temp=repository.GetById("1");
            Console.WriteLine(temp.Name);
            

            Console.Read();
        }
    }

    public class BaseDomain { }//baseDomain
    public abstract class BaseDomainMapping<T> : EntityTypeConfiguration<T> where T : BaseDomain, new()
    {
        public BaseDomainMapping()
        {
            Init();
        }
        public abstract void Init();
        //{
        //    Console.WriteLine("Init");
        //}
    }

    [Table("Person")]
    public class Person : BaseDomain
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    public class PersonMapping : BaseDomainMapping<Person>
    {

        public override void Init()
        {
            //throw new NotImplementedException();
        }
    }

    public class TestContext : DbContext
    {
        private static TestContext _instance;
        public static TestContext Instance
        {
            get
            {
                if (_instance == null) { _instance = new TestContext(); };
                return _instance;
            }
        }
        private string _connectionString;
        public string ConnectionString
        {
            get { if(string.IsNullOrWhiteSpace(_connectionString)){_connectionString=ConfigurationManager.ConnectionStrings["testConn"].ConnectionString;}
            return _connectionString;
        
        }
            set{_connectionString=value;}
        }
        public TestContext() : base("name=testConn") { }
        public TestContext(string connectionString) : base(connectionString) { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !string.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.BaseType != null && type.BaseType.BaseType.IsGenericType && type.BaseType.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)).ToList();
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
    }

    public partial interface IRepository<T> where T : BaseDomain
    {
        T GetById(object id);
        int Insert(T entity);
    }
    public partial class EfRepository<T> : IRepository<T> where T : BaseDomain
    {
        private readonly DbContext _context;
        private IDbSet<T> _entities;
        public EfRepository(DbContext context)
        {
            this._context = context;
        }
        protected virtual IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }
        public virtual T GetById(object id)
        {
            return this.Entities.Find(id);
        }

        #region IRepository<T> 成员


        public int Insert(T entity)
        {
            this.Entities.Add(entity);
            return this._context.SaveChanges();
        }

        #endregion
    }
}
