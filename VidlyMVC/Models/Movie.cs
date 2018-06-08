using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public short GenreId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public short NumberInStock { get; set; }

        public short NumberAvailable { get; set; }
    }
}