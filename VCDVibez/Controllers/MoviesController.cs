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
        }
    }
}