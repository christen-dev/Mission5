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
            return View();
        }

        [HttpPost]
        public IActionResult Form(Movie response)
        {
            if (response.Lent == null)
            {
                response.Lent = "";
            }
            if (response.Notes == null)
            {
                response.Notes = "";
            }
            _context.Movies.Add(response); //add record to database
            _context.SaveChanges();
            return View(response);
        }
    }
}
