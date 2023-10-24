using System.ComponentModel.DataAnnotations;

namespace Hillel_C_sharp_pro_homework_11.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Note name")]
        public string? Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string? Text { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string? Tags { get; set; }
    }
}