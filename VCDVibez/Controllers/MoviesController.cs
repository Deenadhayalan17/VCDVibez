using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VCDVibez.Models;
using VCDVibez.ViewModel;

namespace VCDVibez.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            //var movie = new Movie() { Name="Iron Man & x man "} ;
            //// to pass data to view we can use View data and Viewbag too
            //var customers = new List<Customer>
            //{
            //    new Customer{ Name="Customer 1"},
            //    new Customer{ Name="Customer 2"}

            //};
            //var viewModel = new RandomMovieViewModel
            //{
            //    Movie = movie,
            //    Customers = customers
            //};
            //return View(viewModel);
            //return Content("Hi da");
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = '1', sort="mass" });
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
        public ActionResult Edit(int id)

        {
            return Content("id=" + id);
        }
        public ActionResult Index(int ?pageIndex, string sortBy)
        {
            //if (!pageIndex.HasValue)
            //{
            //    pageIndex = 1;
            //}
            //if (string.IsNullOrWhiteSpace(sortBy))
            //{
            //    sortBy = "Name";
            //}
            //return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
            var movies = GetMovies();

            return View(movies);

        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Iron-Man" },
                new Movie { Id = 2, Name = "Matrix" }
            };
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        // more constrains can be added 
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}