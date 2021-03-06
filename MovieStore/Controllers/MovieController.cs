﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using MovieStore.Models;
using MovieStore.ViewModels;

namespace MovieStore.Controllers
{
    public class MovieController : Controller
    {
        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genre);

            if (User.IsInRole(RoleName.CanManageMovies))
            {
                return View("List", movies);
            }
            else
            {
                return View("ReadOnlyList", movies);
            }
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ViewResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel(new MovieModel())
            {
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel(movie)
            {
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }


        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);

        }

        

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Save(MovieModel movie)
        {
        if (!ModelState.IsValid)
        {
            var viewModel = new MovieFormViewModel(movie)
                {
                    Genres = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
        }

        if (movie.Id == 0)
        {
        movie.DateAdded = DateTime.Now;
        _context.Movies.Add(movie);
        }
        else
        {
        var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
        movieInDb.Name = movie.Name;
        movieInDb.GenreId = movie.GenreId;
        movieInDb.NumberInStock = movie.NumberInStock;
        movieInDb.ReleaseDate = movie.ReleaseDate;
        }

        _context.SaveChanges();

        return RedirectToAction("Index", "Movie");
        }
    }
}
 