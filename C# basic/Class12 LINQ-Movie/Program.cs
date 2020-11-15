using MovieSelector.Entities;
using MovieSelector.Helpers;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MovieSelector
{
    class Program
    {
        static void Main(string[] args)
        {
            var allMovies = MovieHelper.GetAllMovies();

            //*Find all movies that their titles starts with "F"
            //--------------------------------------------------
            var moviesStartingWithF = allMovies
                                    .Where(movie => movie.Title.StartsWith("F"))
                                    .Select(movie => movie)
                                    .ToList();
            moviesStartingWithF.ForEach(movie => Console.WriteLine(movie.Title));
            Console.WriteLine("--->");
            var moviesStartingWithFQuerry = (from movie in allMovies
                                            where movie.Title.StartsWith("F")
                                            select movie).ToList();
            moviesStartingWithFQuerry.ForEach(movie => Console.WriteLine(movie.Title));
            Console.WriteLine("--------------------------------------");

            //* Find the NUMBER of movies that have rating higher than 7.5
            //-------------------------------------------------------------
            var numberOfMoivesWithRatingHihherThan7point5 = allMovies
                                                        .Where(movie => movie.Rating > 7.5)
                                                        .Count();
            Console.WriteLine(numberOfMoivesWithRatingHihherThan7point5);
            Console.WriteLine("--->");
            var numberOfMoivesWithRatingHihherThan7point5Querry = (from movie in allMovies
                                                                   where movie.Rating > 7.5
                                                                   select movie)
                                                                   .Count();
            Console.WriteLine(numberOfMoivesWithRatingHihherThan7point5Querry);
            Console.WriteLine("--------------------------------------");

            //* Find all movies TITLES with year of production before 2005
            //------------------------------------------------------------
            var allMoviesWithYearOfProductionBefore2005 = allMovies
                                                    .Where(movie => movie.Year < 2005)
                                                    .Select(movie => movie.Title)
                                                    .ToList();
            allMoviesWithYearOfProductionBefore2005.ForEach(title => Console.WriteLine(title));
            Console.WriteLine("--->");
            var allMoviesWithYearOfProductionBefore2005Querry = (from movie in allMovies
                                                                 where movie.Year < 2005
                                                                 select movie.Title)
                                                                .ToList();
            allMoviesWithYearOfProductionBefore2005Querry.ForEach(title => Console.WriteLine(title));
            Console.WriteLine("--------------------------------------");

            //* Find all movies TITLES and RATING that have rating higher then 8.0
            var moviesWithRatingHigherThan8 = allMovies
                                           .Where(movie => movie.Rating > 8)
                                           .Select(movie => new { Title = movie.Title, Raring = movie.Rating } )
                                           .ToList();
            moviesWithRatingHigherThan8.ForEach(titleRating => Console.WriteLine($"{titleRating.Title}:{ titleRating.Raring}"));
            Console.WriteLine("--->");
            var moviesWithRatingHigherThan8Querry = (from movie in allMovies
                                                     where movie.Rating > 8
                                                     select new { Title = movie.Title, Raring = movie.Rating })
                                                    .ToList();
            moviesWithRatingHigherThan8Querry.ForEach(titleRating => Console.WriteLine($"{titleRating.Title}:{ titleRating.Raring}"));
            Console.WriteLine("--------------------------------------");

            //* Find first 5 movies that have duration time longer then 2 hours
            var first5MoviesWithDurationLongerThan2h = allMovies
                                                    .Where(movie => movie.Duration > 120)
                                                    .Select(movie => movie)
                                                    .Take(5)
                                                    .ToList();
            first5MoviesWithDurationLongerThan2h.ForEach(movie => Console.WriteLine(movie.Title));
            Console.WriteLine("--->");
            var first5MoviesWithDurationLongerThan2hQuerry = (from movie in allMovies
                                                             where movie.Duration > 120
                                                             select movie)
                                                             .Take(5)
                                                             .ToList();
            first5MoviesWithDurationLongerThan2hQuerry.ForEach(movie => Console.WriteLine(movie.Title));
            Console.WriteLine("--------------------------------------");

            //* Find last 3 movies TITLES and DURATION that have duration less then 2.5 hours
            var last3MoviesWithDurationLassThan2point5h = allMovies
                                            .Where(movie => movie.Duration < 150)
                                            .Select(movie => new { Title = movie.Title, Duration = movie.Duration })
                                            .TakeLast(3)
                                            .ToList();
            last3MoviesWithDurationLassThan2point5h.ForEach(titleduration => Console.WriteLine($"{titleduration.Title}: {titleduration.Duration}"));
            Console.WriteLine("--->");
            var last3MoviesWithDurationLassThan2point5hQuerry = (from movie in allMovies
                                                                 where movie.Duration < 150
                                                                 select new { Title = movie.Title, Duration = movie.Duration })
                                                                .TakeLast(3)
                                                                .ToList();
            last3MoviesWithDurationLassThan2point5hQuerry.ForEach(titleduration => Console.WriteLine($"{titleduration.Title}: {titleduration.Duration}"));
            Console.WriteLine("--------------------------------");

            //* Find all movies TITLES and RATING and order them by DURATION(DESC) -no condition needed

            var orderMoviesByDurationDesc = allMovies
                                        .OrderByDescending(movie => movie.Duration)
                                        .Select(movie => new {Title = movie.Title, Rating = movie.Rating })
                                        .ToList();
            orderMoviesByDurationDesc.ForEach(titleRat => Console.WriteLine($"{titleRat.Title}-->{titleRat.Rating}"));
            Console.WriteLine("--->");
            var orderByDurationDescTitleRatingQuerry = (from movie in allMovies
                                                        orderby movie.Duration descending
                                                        select new { Title = movie.Title, Rating = movie.Rating })
                                                       .ToList();
            orderByDurationDescTitleRatingQuerry.ForEach(titleRat => Console.WriteLine($"{titleRat.Title}=>{titleRat.Rating}"));
            Console.WriteLine("--------------------------------");

            //* Find all movies with TITLES that don't start with A and TITLES include more than 7 characters
            var moviesNotStartOnAAndMoreThan7Char = allMovies
                                            .Where(movie => !movie.Title.StartsWith('A'))
                                            .Where(movie => movie.Title.Count() > 7)
                                            .Select(movie => movie.Title)
                                            .ToList();
            moviesNotStartOnAAndMoreThan7Char.ForEach(title => Console.WriteLine(title));
            Console.WriteLine("--->");
            var moviesNotStartOnAAndMoreThan7CharQuerry = (from movie in allMovies
                                                           where !movie.Title.StartsWith("A")
                                                           where movie.Title.Count() > 7
                                                           select movie.Title)
                                                          .ToList();
            moviesNotStartOnAAndMoreThan7CharQuerry.ForEach(title => Console.WriteLine(title));
            Console.WriteLine("----------------------------------");

            //* Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour
            //and 50min
            var moviesRatingHigher7point2DurationLess110 = allMovies
                                                        .Where(movie => movie.Rating > 7.2)
                                                        .Where(movie => movie.Duration < 110)
                                                        .Select(movie => movie)
                                                        .ToList();
            moviesRatingHigher7point2DurationLess110.ForEach(title => Console.WriteLine(title.Title));
            Console.WriteLine("--->");
            var moviesRatingHigher7point2DurationLess110Querry = (from movie in allMovies
                                                                  where movie.Rating > 7.2
                                                                  where movie.Duration < 110
                                                                  select movie)
                                                                 .ToList();
            moviesRatingHigher7point2DurationLess110Querry.ForEach(movie => Console.WriteLine(movie.Title));
            Console.WriteLine("-----------------------------------");

            //*Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION
            //longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)
            var multiSelectorsAscByTitle = allMovies
                                        .Where(movie => movie.Title.Count() < 10)
                                        .Where(movie => movie.Duration > 120)
                                        .Where(movie => movie.Rating > 6.7)
                                        .OrderBy(movie => movie.Title)
                                        .Select(movie => new { Title = movie.Title, Rating = movie.Rating})
                                        .ToList();
            multiSelectorsAscByTitle.ForEach(titleRat => Console.WriteLine($"{titleRat.Title}: {titleRat.Rating}"));
            Console.WriteLine("--->");
            var multiSelectorsAscByTitleQuerry = (from movie in allMovies
                                                  where movie.Title.Count() < 10
                                                  where movie.Duration > 120
                                                  where movie.Rating > 6.7
                                                  orderby movie.Title
                                                  select new { Title = movie.Title, Rating = movie.Rating })
                                                 .ToList();
            multiSelectorsAscByTitleQuerry.ForEach(titleRat => Console.WriteLine($"{titleRat.Title}->{titleRat.Rating}"));
            Console.WriteLine("-----------------------------------");
            
            
            Console.ReadLine();
        }
    }
}
