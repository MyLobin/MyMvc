


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEF.Models
{
    [Table("Employees")]
  public  class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        [Column("Email")]
        public string EmailId { get; set; }
    }
}
