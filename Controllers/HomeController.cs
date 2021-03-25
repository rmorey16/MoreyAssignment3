using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoreyAssignment3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MoreyAssignment3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieDBContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //adding movie
        public IActionResult MovieForm()
        {
            return View();
        }
        [HttpPost]
        //add a movie to the list
        public IActionResult MovieForm(EntryResponse appResponse)
        {
            if (ModelState.IsValid)
            {
                _context.Entries.Add(appResponse);
                _context.SaveChanges();
                //TempStorage.Create(appResponse);
                return View("Confirmation", appResponse);
            }
            else
            {
                return View();
            }
        }


        public IActionResult MovieList()
        {
            return View(_context.Entries);
        }

        public IActionResult MyPodcast()
        {
            return View();
        }
        //editing the list
        //public IActionResult Update(int movieId)
        //{
          //  EntryResponse movie = _context.Entries.Where(e => e.MovieId == movieId).FirstOrDefault();
          //  return View(movie);
      //  }
        [HttpPost]
        //works to populate
        public IActionResult Edit(int movieId)
        {
            EntryResponse movie = _context.Entries.Where(m => m.MovieId == movieId).FirstOrDefault();

            ViewBag.EntryResponse = movie;

            return View("Edit", ViewBag.EntryResponse);
        }
        [HttpPost]
        public IActionResult Edit2(EntryResponse entry) { 

            _context.Entries.Update(entry);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }
        [HttpPost]
        //deleting from the list
        public IActionResult Delete(string title)
        {
            EntryResponse movie = _context.Entries.Where(m => m.Title == title).FirstOrDefault();

            _context.Entries.Remove(movie);
            _context.SaveChanges();
            //EntryResponse entry = TempStorage.AllMovies.Where(e => e.Title == title).FirstOrDefault();
            //TempStorage.Delete(entry);
            return RedirectToAction("MovieList");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
