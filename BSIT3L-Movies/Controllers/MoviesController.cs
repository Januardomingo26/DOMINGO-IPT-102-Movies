using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
            {
           new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1RsHdd0603EYkU-FYqBcxT-2NlEOjXOm6"},
               new MovieViewModel { Id = 2, Name = "The Lord of The Rings", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1nqslprJWVx6DyIIbFf3PZFLNY4HP71Gx"},
               new MovieViewModel { Id = 3, Name = "Terrifier", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1a-l6H_LDJN1xumDfGYiNByHX-U7sDBta"},
               new MovieViewModel { Id = 4, Name = "Star in Overagain", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1P-c6Bq3KRHMy2EnJdNmiuWkjMd5YN_Hu"},
               new MovieViewModel { Id = 5, Name = "Scream", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1RJxYChCCFY7DfGVWPJgmHk79ezagOfz0"},
               new MovieViewModel { Id = 6, Name = "Rings", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1daq71N6xNrxxrSuojBC69WT6SKn7_1dE"},
               new MovieViewModel { Id = 7, Name = "Noone", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1NZrCe3rLtY7VyOlZNKM4t4uy6JcTMCs0"},
               new MovieViewModel { Id = 8, Name = "Must Belove", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1eO9O2Kp0gV6uk55O86QQTCgVXfSkNwDa"},
               new MovieViewModel { Id = 9, Name = "Little Mermaid", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1Y5uTSjLTtzFQmWe-po2FBw44Hnh8Ye1i"},
               new MovieViewModel { Id = 10, Name = "In To The Woods", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1Stxgu1-I5OGNJi_GtW4O-O4Fv4r0_LKE"},
               new MovieViewModel { Id = 11, Name = "Harrypotter", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1If8eNstdXeTSGqLFhXxWiTTjmN__X7Bd"},
               new MovieViewModel { Id = 12, Name = "Diary ng Panget", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1R1eBPKEusLhIOPCf6CnkoinzE8T4CjCi"},
               new MovieViewModel { Id = 13, Name = "Bride Forrent", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1UtxlEgaXbUhXBADrVlvr2ZoOqdm8ANme"},
               new MovieViewModel { Id = 14, Name = "Avatar", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1ZKEuAf5wkS2sdyrzc-CgPZCjf2s7d2Iv"},
               new MovieViewModel { Id = 15, Name = "A second chance", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama", ImageUrl ="https://drive.google.com/uc?id=1d5RzFURrU8-sFhtDXjK-3Sg_gF8nXpoS"},

            };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}

