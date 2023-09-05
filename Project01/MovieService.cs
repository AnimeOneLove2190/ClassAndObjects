using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class MovieService
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
            int minAge = list[0].ProductionYear;
            for (int i = 0; i < list.Count; i++)
            {
                if (minAge > list[i].ProductionYear)
                {
                    minAge = list[i].ProductionYear;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ProductionYear == minAge)
                {
                    return list[i];
                }
            }
            return null;
        }
        public Movie GetMovieWithMaxDuration(List<Movie> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetMovieWithMaxDuration");
                return null;
            }
            int minValue = list[0].Duration;
            for (int i = 0; i < list.Count; i++)
            {
                if (minValue < list[i].Duration)
                {
                    minValue = list[i].Duration;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Duration == minValue)
                {
                    return list[i];
                }
            }
            return null;
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
            int[] numberArray = new int[list.Count];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = list[i].ProductionYear;
            }
            techService.BubbleSort(numberArray);
            List<Movie> ageSortList = new List<Movie>();
            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].ProductionYear == numberArray[i])
                    {
                        ageSortList.Add(list[j]);
                    }
                }
            }
            for (int i = 0; i < ageSortList.Count; i++)
            {
                for (int j = i + 1; j < ageSortList.Count; j++)
                {
                    if (ageSortList[i] == ageSortList[j])
                    {
                        ageSortList.RemoveAt(j);
                    }
                }
            }
            return ageSortList;
        }
        public List<Movie> SortMoviesByPremiereDate(List<Movie> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в SortMoviesByPremiereDate");
                return null;
            }
            DateTime[] dateArray = new DateTime[list.Count];
            for (int i = 0; i < dateArray.Length; i++)
            {
                dateArray[i] = list[i].PremiereDate;
            }
            techService.BubbleSort(dateArray);
            List<Movie> ageSortList = new List<Movie>();
            for (int i = 0; i < dateArray.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].PremiereDate == dateArray[i])
                    {
                        ageSortList.Add(list[j]);
                    }
                }
            }
            for (int i = 0; i < ageSortList.Count; i++)
            {
                for (int j = i + 1; j < ageSortList.Count; j++)
                {
                    if (ageSortList[i] == ageSortList[j])
                    {
                        ageSortList.RemoveAt(j);
                    }
                }
            }
            return ageSortList;
        }
    }
}
