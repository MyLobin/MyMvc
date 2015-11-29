using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    #region MyRegion
    //public class Category
    //{

    //    public string CategoryId { get; set; }
    //    public string CategoryName { get; set; }

    //    // [ForeignKey("ProductId")]
    //    public Product Product { get; set; }

    //}
    //public class Product
    //{

    //    public string ProductId { get; set; }

    //    public string ProductName { get; set; }
    //    public Category Category { get; set; }
    //} 
    #endregion

    public class Enroll
    {
        public string EnrollId { get; set; }

        public string SignInId { get; set; }
        public string EnrollName { get; set; }
        public virtual SignIn SignIn { get; set; }
    }
    public class SignIn
    {
        public string SignInId { get; set; }
        public string Operator { get; set; }
    }
}
