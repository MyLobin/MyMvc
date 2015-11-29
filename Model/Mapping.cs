using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{


    #region MyRegion
    //public class ProductMapping:EntityTypeConfiguration<Product> {
    //    public ProductMapping()
    //    {
    //        this.HasKey(m => m.ProductId);
    //        this.HasRequired(m => m.Category)
    //            .WithOptional(m => m.Product);




    //        this.ToTable("Product", "Test");


    //    }
    //}
    //public class CategoryMapping:EntityTypeConfiguration<Category> {
    //    public CategoryMapping()
    //    {
    //        this.HasKey(m => m.CategoryId);
    //        //this.HasRequired(m => m.Product)
    //        //.WithMany(m => m.Capacity)
    //        //.HasForeignKey(m => m.ProductId);
    //        this.ToTable("Category", "Test");



    //    }
    //} 
    #endregion

    public class EnrollMapping : EntityTypeConfiguration<Enroll>
    {
        public EnrollMapping()
        {
            this.HasKey(m => m.EnrollId);
            this.HasRequired(m => m.SignIn)
                .WithMany()
                .HasForeignKey(m => m.SignInId);
        }
    }
    public class SignInMapping : EntityTypeConfiguration<SignIn>
    {
        public SignInMapping()
        {
            this.HasKey(m => m.SignInId);
        }
    }

}
