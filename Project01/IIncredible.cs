using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    interface IIncredible
    {
        public void WriteList(List<string> list);
        public void BubbleSort(char[] charArray);
        public void BubbleSort(int[] numberArray);
        public void WriteList(List<Person> list);
        public void WriteGenres(List<Genre> list);
        public void WriteList(List<Movie> list);
        public void WriteMovie(Movie movie);
        public void BubbleSort(DateTime[] dateArray);

    }
}
