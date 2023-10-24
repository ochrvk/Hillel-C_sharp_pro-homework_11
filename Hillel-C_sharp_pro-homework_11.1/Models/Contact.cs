using System.ComponentModel.DataAnnotations;

namespace Hillel_C_sharp_pro_homework_11.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Note name")]
        public string? Name { get; set; }

        [Required]
        [Phone]
        public string? Phone { get; set; }

        [Phone]
        public string? AdditionalPhone { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
    }
}