using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestingEFCore.Model
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Please Enter Valid Address")]
        public string Email { get; set; }
        [StringLength(11)]
        public string? PhoneNumber { get; set; }
        public string RollNumber { get; set; }
    }
}
