using Microsoft.AspNetCore.Mvc;
using Rent_it.Models;
using Rent_it.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Rent_it.Controllers
{
    public class MoviesController : Controller



        

    {



        private DataContext _context;

        public MoviesController()
        {
            _context = new DataContext();
        }




        public ViewResult Index()
        {

            var movies = _context.Movies.Include(c => c.Genre).ToList();




            return View(movies);
        }





        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return NotFound();

            return View(movie);

        }

        //movies/edit/1 or..
        //movies/edit?id=1
        public IActionResult Edit(int editId)
        {
            return Content("Id=" + editId);
        }



        public IActionResult AddMovie()
        {

           

            return View("AddMovie");
        }


        // movies
        /*        public ActionResult Index(int? pageIndex , String sortBy)// int? pageIndex can be null
                {
                    if (!pageIndex.HasValue)
                    {
                        pageIndex = 1;
                    }
                    if (String.IsNullOrWhiteSpace(sortBy))
                    {
                        sortBy = "Name";
                    }

                    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

                }*/

        /*       [Route("movies/released/{year}/{month:regex(\\d{2}):range(1)}")]*/
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

       


    }

}
