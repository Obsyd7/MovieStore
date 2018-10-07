using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MovieStore.Models;

namespace MovieStore.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreModel> Genres { get; set; }
        public MovieModel Movie { get; set; }
    }
}