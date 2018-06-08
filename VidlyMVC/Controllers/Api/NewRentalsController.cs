using System;
using System.Linq;
using System.Web.Http;
using VidlyMVC.Dtos;
using VidlyMVC.Models;

namespace VidlyMVC.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRentalDto)
        {
            var customer = _context.Customers.Single(u => u.Id == newRentalDto.CustomerId);
            var movies = _context.Movies.Where(u => newRentalDto.MovieIds.Contains(u.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available.");
                }
                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
                _context.SaveChanges();
            }

            return Ok();
        }
    }
}
