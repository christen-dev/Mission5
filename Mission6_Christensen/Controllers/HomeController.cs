using Microsoft.AspNetCore.Mvc;
using Mission6_Christensen.Models;
using System.Diagnostics;

namespace Mission6_Christensen.Controllers
{

    public class HomeController : Controller
    {
        private MovieContext _context;

        public HomeController(MovieContext temp)
        {
            _context = temp;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Form(Movies response)
        {
            ViewBag.Categories = _context.Categories.ToList();
            if (response.LentTo == null)
            {
                response.LentTo = "";
            }
            if (response.Notes == null)
            {
                response.Notes = "";
            }
            _context.Movies.Add(response); //add record to database
            _context.SaveChanges();
            return View("Form");
        }

        public IActionResult MovieList(Movies response)
        {
            ViewBag.Categories = _context.Categories.ToList();
            if (response.Director == null)
            {
                response.Director = "";
            }
            if (response.Rating == null)
            {
                response.Rating = "";
            }
            if (response.LentTo == null)
            {
                response.LentTo = "0";
            }
            if (response.Notes == null)
            {
                response.Notes = "";
            }
            var movies = _context.Movies
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList();
            return View("Form", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movies updated) 
        {
            _context.Update(updated);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            ViewBag.Categories = _context.Categories.ToList();
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View("Confirmation", recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movies deleted)
        {
            _context.Remove(deleted);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
