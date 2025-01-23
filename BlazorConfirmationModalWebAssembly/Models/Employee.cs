using System.ComponentModel.DataAnnotations;

namespace BlazorConfirmationModalWebAssembly.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
