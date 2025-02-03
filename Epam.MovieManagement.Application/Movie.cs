using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.MovieManagement.Application
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleasedYear { get; set; }
        public string Director { get; set; }

        public Movie()
        {
        }
        public Movie(int movieId, string title, string genre, int year, string director)
        {
            MovieId = movieId;
            Title = title;
            Genre = genre;
            ReleasedYear = year;
            Director = director;
        }


    }
}
