using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInfoDemo.Models
{
    public class Student
    {
        [Key]
        [Column("stuid",TypeName ="int")]
        [Required]
        [DisplayName("Student ID")]
        public int sid { get; set; }
        [Column("stuname", TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Student Name")]
        public string name { get; set; }
        [Column("stugender", TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Gender")]
        public string gender { get; set; }
        [Column("stuDob", TypeName = "date")]
        [Required]
        [DisplayName("Date of Birth")]
        public DateOnly dob { get; set; }
        [Column("stuemail", TypeName = "varchar(100)")]
        [Required]
        [DisplayName("Email")]
        public string email { get; set; }
        [Column("stuphone", TypeName = "varchar(10)")]
        [Required]
        [DisplayName("Mobile No")]
        public string phone { get; set; }
    }
}
