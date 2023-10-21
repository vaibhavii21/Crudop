using System.ComponentModel.DataAnnotations;

namespace Crudop.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int PhoneNo { get; set; }
        public int Birthday { get; set; }      

    }
}
