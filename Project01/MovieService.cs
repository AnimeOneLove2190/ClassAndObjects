using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class MovieService : IWatchable
    {
        readonly TechnicalService techService = new TechnicalService();
        public List<string> GetListOfNames(List<Movie> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetListOfNames");
                return null;
            }
            List<string> listOfNames = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                listOfNames.Add(list[i].Name);
            }
            return listOfNames;
        }
        public Movie GetMovieWithMinProductionYear(List<Movie> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetMovieWithMinProductionYear");
                return null;
            }
            Movie movieWithMinProductionYear = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (movieWithMinProductionYear.ProductionYear > list[i].ProductionYear)
                {
                    movieWithMinProductionYear = list[i];
                }
            }
            return movieWithMinProductionYear;
        }
        public Movie GetMovieWithMaxDuration(List<Movie> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetMovieWithMaxDuration");
                return null;
            }
            Movie movieWithMaxDuration = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (movieWithMaxDuration.Duration < list[i].Duration)
                {
                    movieWithMaxDuration = list[i];
                }
            }
            return movieWithMaxDuration;
        }
        public List<Movie> GetMoviesWithSelectedAgeLimit(List<Movie> list, int selectedAgeLimit)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetMoviesWithSelectedAgeLimit");
                return null;
            }
            List<Movie> moviesWithSelectedAgeLimit = new List<Movie>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].AgeLimit == selectedAgeLimit)
                {
                    moviesWithSelectedAgeLimit.Add(list[i]);
                }
            }
            return moviesWithSelectedAgeLimit;
        }
        public List<Movie> SortMoviesByProductionYear(List<Movie> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinAge");
                return null;
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j].ProductionYear > list[j + 1].ProductionYear)
                    {
                        Movie tempMovie = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tempMovie;
                    }
                }
            }
            return list;
        }
        public List<Movie> SortMoviesByPremiereDate(List<Movie> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в SortMoviesByPremiereDate");
                return null;
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j].PremiereDate > list[j + 1].PremiereDate)
                    {
                        Movie tempMovie = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tempMovie;
                    }
                }
            }
            return list;
        }
    }
}
