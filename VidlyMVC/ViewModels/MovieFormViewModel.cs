using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using VidlyMVC.Models;

namespace VidlyMVC.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public short? GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Range(1, 20)]
        [Required]
        [Display(Name = "Number in Stock")]
        public short? NumberInStock { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
        }
    }

}