using System.ComponentModel.DataAnnotations;

namespace VidlyMVC.Models
{
    public class Genre
    {
        public short Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}