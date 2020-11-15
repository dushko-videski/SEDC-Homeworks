using System;
using System.Collections.Generic;
using System.Text;
using MovieSelector.Entities;

namespace MovieSelector.Helpers
{
    public class MovieHelper
    {
        public static List<Movie> GetAllMovies()
        {
            return new List<Movie>()
            {
                new Movie(){ Title = "The Godfather", Year = 1972, Rating = 9.2, Duration = 175 },
                new Movie(){ Title = "Schindler's List", Year = 1993, Rating = 8.9, Duration = 195 },
                new Movie(){ Title = "Forrest Gump", Year = 1994, Rating = 8.8, Duration = 142 },
                new Movie(){ Title = "The Shawshank Redemption", Year = 1994, Rating = 9.3, Duration = 142 },
                new Movie(){ Title = "The Girl with the Dragon Tattoo", Year = 2011, Rating = 7.8, Duration = 158 },
                new Movie(){ Title = "Saving Private Ryan", Year = 1998, Rating = 8.6, Duration = 169 },
                new Movie(){ Title = "Cast Away", Year = 2000, Rating = 7.8, Duration = 143 },
                new Movie(){ Title = "Fight Club", Year = 1999, Rating = 8.8, Duration = 139 },
                new Movie(){ Title = "Fury", Year = 2014, Rating = 7.6, Duration = 134 },
                new Movie(){ Title = "About Time", Year = 2013, Rating = 7.8, Duration = 100 },
            };

        }
    }
}
