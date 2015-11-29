using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BLContext context = new BLContext())
            {

                //var temp=context.Course.FirstOrDefault();
                //context.Course.Add(new Course { Id = 1, Name = "name", Description = "name1" });
                //context.Category.Add(new Category { CategoryId = "1", CategoryName = "cname" });
                //context.Product.Add(new Product
                //{
                //    ProductId = "1",
                //    ProductName = "aaa"
                //});
                // var rstInt=     context.SaveChanges();
                //context.Category.Add(new Category { CategoryId = "1", CategoryName = "c1", Product = new Product { ProductId = "1", ProductName = "p1" } });
              //  context.Product.Add(new Product { ProductId = "1", ProductName = "p1" });
                context.SaveChanges();
                //var category = context.Category.ToList();
                //var product = context.Product.ToList();
               
                //context.SignIn.Add(new SignIn
                //{
                //    SignInId = "2",
                //    Operator = "o2"
                //}); 
                //context.Enroll.Add(new Enroll { EnrollId = "2", EnrollName = "e1", SignIn = new SignIn { SignInId = "2", Operator = "o2" } });
                //context.SaveChanges();
                //XmlWriterSettings settings = new XmlWriterSettings();
                //settings.Indent = true;

                //using (XmlWriter writer = XmlWriter.Create(@"Model.edmx", settings))
                //{
                //    EdmxWriter.WriteEdmx(context, writer);
                //}      
            }
        }
    }
}
