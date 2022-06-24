using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VCDVibez.Models;

namespace VCDVibez.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name="Iron Man"} ;

            return View(movie);
            //return Content("Hi da");
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = '1', sort="mass" });
        }
        public ActionResult Edit(int id)

        {
            return Content("id=" + id);
        }
        public ActionResult Index(int ?pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}