using System.Collections.Generic;
using VidlyMVC.Models;

namespace VidlyMVC.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }
    }
}