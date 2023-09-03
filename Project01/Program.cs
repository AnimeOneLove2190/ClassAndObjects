using System;
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
        }
    }
}
