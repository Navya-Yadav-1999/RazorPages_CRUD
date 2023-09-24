using System.ComponentModel.DataAnnotations;

namespace CRUDDemo
{
    public class Student
    {
        [Key]
        public int StudentNo { get; set; }

        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }
        public int Section { get; set; }

        [Required(ErrorMessage = "The Branch field is required.")]
        public string Branch { get; set; }

        [Required(ErrorMessage = "The EmailId field is required.")]
        public string EmailId { get; set; }
    }
}
