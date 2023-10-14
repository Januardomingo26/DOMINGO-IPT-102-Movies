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
          new MovieViewModel { Id = 1, Name = "The Nun", Rating = "5", ReleaseYear = 2018, Genre = "Horror/Mystery", ytid="zwAM5UnGd2s", ImageUrl ="https://drive.google.com/uc?id=1Q_a4vpnZK2RUs7mHBJJpkR0dHxMpIIro" },
        new MovieViewModel { Id = 2, Name = "The Lord of The Rings", Rating = "9.0", ReleaseYear = 2001, ytid="V75dMMIW2B4", Genre = "Fantasy/Adventure", ImageUrl ="https://drive.google.com/uc?id=1zqk3yu_9sv0E2j7_ft0qUqUepiv2F4Jm" },
        new MovieViewModel { Id = 3, Name = "Terrifier", Rating = "5.6", ReleaseYear = 2017, Genre = "Horror/Thriller",ytid="fN5j1MtGO2Q", ImageUrl ="https://drive.google.com/uc?id=1e3kFbojVUmqlQhKEeB7-mL0daFX1H0tp" },
         new MovieViewModel { Id = 4, Name = "No One Gets Out Alive", Rating = "6.8", ReleaseYear = 2009, Genre = "Drama/Romance", ytid="sY2TLiK27g4", ImageUrl ="https://drive.google.com/uc?id=1sMFJIGGw2odj3O20xDKz7uZxjGngTZ6K" },
        new MovieViewModel { Id = 5, Name = "Must Belove", Rating = "6.1", ReleaseYear = 2013, Genre = "Romantic Comedy/Drama", ytid="Hp0JJNursT4", ImageUrl ="https://drive.google.com/uc?id=1eO9O2Kp0gV6uk55O86QQTCgVXfSkNwDa" },
        new MovieViewModel { Id = 6, Name = "Star in Overagain", Rating = "6.3", ReleaseYear = 2004, Genre = "Romance/Drama",ytid="TYKGY2NrBYY", ImageUrl ="https://drive.google.com/uc?id=1w5IpIxqSnkpyvmtR3V19GcPzT5522YRw" },
        new MovieViewModel { Id = 7, Name = "Harry Potter", Rating = "7.6", ReleaseYear = 2001, Genre = "Fantasy/Adventure", ytid="VyHV0BRtdxo",ImageUrl ="https://drive.google.com/uc?id=10TBmpgXsVweEUVQPifUKQEV9VelgEmf2" },
         new MovieViewModel { Id = 8, Name = "Little Mermaid", Rating = "7.6", ReleaseYear = 1989, Genre = "Animation/Family", ytid = "kpGo2_d3oYE", ImageUrl ="https://drive.google.com/uc?id=18o1yZJqXy18pSUWKEVeH2kOOCfrceC1X" },
        new MovieViewModel { Id = 9, Name = "Into The Woods", Rating = "5.9", ReleaseYear = 2014, Genre = "Fantasy/Musical", ytid = "7pjy5MK1X70", ImageUrl ="https://drive.google.com/uc?id=1Stxgu1-I5OGNJi_GtW4O-O4Fv4r0_LKE" },
        new MovieViewModel { Id = 10, Name = "Diary ng Panget", Rating = "6.4", ReleaseYear = 2014, Genre = "Romantic Comedy/Drama", ytid = "dCSKS3iurdk", ImageUrl ="https://drive.google.com/uc?id=1R1eBPKEusLhIOPCf6CnkoinzE8T4CjCi" },
        new MovieViewModel { Id = 11, Name = "Bride For Rent", Rating = "6.2", ReleaseYear = 2014, Genre = "Romantic Comedy/Drama", ytid = "IvMIwxZaGBg", ImageUrl ="https://drive.google.com/uc?id=1UtxlEgaXbUhXBADrVlvr2ZoOqdm8ANme" },
        new MovieViewModel { Id = 12, Name = "Avatar", Rating = "7.8", ReleaseYear = 2009, Genre = "Science Fiction/Adventure", ytid = "d9MyW72ELq0", ImageUrl ="https://drive.google.com/uc?id=14OlSONw39FiU9UHpda-7CKqul5ZMMZbC" },
        new MovieViewModel { Id = 13, Name = "A Second Chance", Rating = "7.1", ReleaseYear = 2015, Genre = "Romance/Drama", ytid = "1WRzppVKoDI", ImageUrl ="https://drive.google.com/uc?id=1d5RzFURrU8-sFhtDXjK-3Sg_gF8nXpoS" },
        new MovieViewModel { Id = 14, Name = "Scream", Rating = "7.2", ReleaseYear = 1996, Genre = "Horror/Slasher", ytid = "nRwLyKIBNU8", ImageUrl ="https://drive.google.com/uc?id=10oJpL3qobzvRmn27XEICSgqL6QQ93rHq" },
        new MovieViewModel { Id = 15, Name = "Rings", Rating = "4.5", ReleaseYear = 2017, Genre = "Horror", ytid = "uukQ_6szDm8", ImageUrl ="https://drive.google.com/uc?id=1P2Fk353pcAqs_kwV8CGgaNcv0Nz-9woO" },

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

