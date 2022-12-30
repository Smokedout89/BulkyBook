namespace BulkyBook.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Cover Type")]
        public string Name { get; set; }
    }
}
