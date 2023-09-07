﻿using System;
using System.Collections.Generic;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalService techService = new TechnicalService();
            PersonService personService = new PersonService();
            IntegerListService listService = new IntegerListService();
            List<int> randomList = listService.CreateList(10, -10, 10);
            listService.WriteList(randomList);
            Console.WriteLine("мяв");
            List<int> evenList = listService.GetEvenList(randomList);
            listService.WriteList(evenList);
            Console.WriteLine("мяв");
            List<int> oddList = listService.GetOddList(randomList);
            listService.WriteList(oddList);
            Console.WriteLine("мяв");
            List<int> positiveList = listService.GetPositiveList(randomList);
            listService.WriteList(positiveList);
            Console.WriteLine("мяв");
            List<int> negativeList = listService.GetNegativeList(randomList);
            listService.WriteList(negativeList);
            Console.WriteLine("мяв");
            Person personOne = new Person();
            personOne.Name = "Misato";
            personOne.Age = 29;
            personOne.Weight = 47;
            personOne.Height = 163;
            Person personTwo = new Person();
            personTwo.Name = "Asuna";
            personTwo.Age = 19;
            personTwo.Weight = 54;
            personTwo.Height = 168;
            Person personThree = new Person();
            personThree.Name = "Rafutaria";
            personThree.Age = 10;
            personThree.Weight = 56;
            personThree.Height = 170;
            Person personFour = new Person();
            personFour.Name = "Hanji";
            personFour.Age = 31;
            personFour.Weight = 60;
            personFour.Height = 170;
            Person personFive = new Person();
            personFive.Name = "Violet";
            personFive.Age = 18;
            personFive.Weight = 42;
            personFive.Height = 161;
            List<Person> waifuList = new List<Person>();
            waifuList.Add(personOne);
            waifuList.Add(personTwo);
            waifuList.Add(personThree);
            waifuList.Add(personFour);
            waifuList.Add(personFive);
            List<string> listOfNames = personService.GetListOfNames(waifuList);
            techService.WriteList(listOfNames);
            Console.WriteLine("мяв");
            Person personWithMinAge = personService.GetPersonWithMinAge(waifuList);
            Console.WriteLine(personWithMinAge.Name);
            Console.WriteLine("мяв");
            Person personWithMaxAge = personService.GetPersonWithMaxAge(waifuList);
            Console.WriteLine(personWithMaxAge.Name);
            Console.WriteLine("мяв");
            Person personWithMinWeight = personService.GetPersonWithMinWeight(waifuList);
            Console.WriteLine(personWithMinWeight.Name);
            Console.WriteLine("мяв");
            Person personWithMaxWeight = personService.GetPersonWithMaxWeight(waifuList);
            Console.WriteLine(personWithMaxWeight.Name);
            Console.WriteLine("мяв");
            Person personWithMinHeight = personService.GetPersonWithMinHeight(waifuList);
            Console.WriteLine(personWithMinHeight.Name);
            Console.WriteLine("мяв");
            Person personWithMaxHeight = personService.GetPersonWithMaxHeight(waifuList);
            Console.WriteLine(personWithMaxHeight.Name);
            Console.WriteLine("мяв");
            List<Person> nameSortList = personService.SortPersonByName(waifuList);
            techService.WriteList(nameSortList);
            Console.WriteLine("мяв");
            List<Person> ageSortList = personService.SortPersonByAge(waifuList);
            techService.WriteList(ageSortList);
            Console.WriteLine("мяв");
            List<Person> weightSortList = personService.SortPersonByWeight(waifuList);
            techService.WriteList(weightSortList);
            Console.WriteLine("мяв");
            //Quest??
            MovieService movieService = new MovieService();
            List<Genre> laputa = new List<Genre>();
            laputa.Add(Genre.anime);
            laputa.Add(Genre.multfilm);
            laputa.Add(Genre.fantasy);
            laputa.Add(Genre.adventure);
            laputa.Add(Genre.family);
            Movie movieOne = new Movie("Tenkuu no Shiro Laputa", 0, laputa, 125, 12, 1986, "Japan", new DateTime(1986, 8, 2));
            List<Genre> tigerAndFishKek = new List<Genre>();
            tigerAndFishKek.Add(Genre.anime);
            tigerAndFishKek.Add(Genre.multfilm);
            tigerAndFishKek.Add(Genre.melodrama);
            tigerAndFishKek.Add(Genre.drama);
            Movie movieTwo = new Movie("Josee to Tora to Sakana-tachi", 1, tigerAndFishKek, 99, 12, 2020, "Japan", new DateTime(2021, 9, 30));
            List<Genre> evangelion222 = new List<Genre>();
            evangelion222.Add(Genre.anime);
            evangelion222.Add(Genre.multfilm);
            evangelion222.Add(Genre.fantastic);
            evangelion222.Add(Genre.action);
            evangelion222.Add(Genre.drama);
            evangelion222.Add(Genre.postApocalyptic);
            Movie movieThree = new Movie("Evangelion: 2.0 You Can (Not) Advance", 2, evangelion222, 108, 16, 2009, "Japan", new DateTime(2009, 6, 27));
            List<Genre> yourName = new List<Genre>();
            yourName.Add(Genre.anime);
            yourName.Add(Genre.multfilm);
            yourName.Add(Genre.fantasy);
            yourName.Add(Genre.drama);
            yourName.Add(Genre.melodrama);
            Movie movieFour = new Movie("Kimi no na wa", 3, yourName, 110, 12, 2016, "Japan", new DateTime(2016, 7, 3));
            List<Genre> violetEvergarden = new List<Genre>();
            violetEvergarden.Add(Genre.anime);
            violetEvergarden.Add(Genre.multfilm);
            violetEvergarden.Add(Genre.drama);
            violetEvergarden.Add(Genre.melodrama);
            Movie movieFive = new Movie("Violet Evergarden: The Movie", 4, violetEvergarden, 140, 12, 2020, "Japan", new DateTime(2020, 09, 18));
            List<Genre> attackOnTitan = new List<Genre>();
            attackOnTitan.Add(Genre.anime);
            attackOnTitan.Add(Genre.multfilm);
            attackOnTitan.Add(Genre.fantastic);
            attackOnTitan.Add(Genre.drama);
            attackOnTitan.Add(Genre.action);
            attackOnTitan.Add(Genre.darkFantasy);
            attackOnTitan.Add(Genre.postApocalyptic);
            attackOnTitan.Add(Genre.cruelty);
            Movie movieSix = new Movie("Attack On Titan: Final", 5, attackOnTitan, 60, 18, 2022, "Japan,", new DateTime(2023, 3, 4));
            List<Movie> movies = new List<Movie>();
            movies.Add(movieOne);
            movies.Add(movieTwo);
            movies.Add(movieThree);
            movies.Add(movieFour);
            movies.Add(movieFive);
            movies.Add(movieSix);
            List<string> listOfMovieNames = movieService.GetListOfNames(movies);
            techService.WriteList(listOfMovieNames);
            Movie oldestMovie = movieService.GetMovieWithMinProductionYear(movies);
            techService.WriteMovie(oldestMovie);
            Movie longestMovie = movieService.GetMovieWithMaxDuration(movies);
            techService.WriteMovie(longestMovie);
            List<Movie> limitMovies = movieService.GetMoviesWithSelectedAgeLimit(movies, 18);
            techService.WriteList(limitMovies);
            List<Movie> sortProductionYearMovies = movieService.SortMoviesByProductionYear(movies);
            techService.WriteList(sortProductionYearMovies);
            List<Movie> sortPremiereDateMovies = movieService.SortMoviesByPremiereDate(movies);
            techService.WriteList(sortPremiereDateMovies);
            ClassA classA = new ClassA();
            ClassB classB = new ClassB();
        }
    }
}
