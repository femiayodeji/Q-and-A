using System.ComponentModel.DataAnnotations;

namespace Qurious.Models{
    public class Enquiry{
        [Key]
        public int Id {get; set;}
        [Required]
        [MaxLength(250)]
        public string Question {get; set;}
        [Required]
        public string Answer {get; set;}
        public int? Difficulty {get; set;}
    }
}