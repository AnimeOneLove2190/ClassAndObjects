using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    interface IWatchable
    {
        public List<string> GetListOfNames(List<Movie> list);
        public Movie GetMovieWithMinProductionYear(List<Movie> list);
        public Movie GetMovieWithMaxDuration(List<Movie> list);
        public List<Movie> GetMoviesWithSelectedAgeLimit(List<Movie> list, int selectedAgeLimit);
        public List<Movie> SortMoviesByProductionYear(List<Movie> list);
        public List<Movie> SortMoviesByPremiereDate(List<Movie> list);

    }
}
