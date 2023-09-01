using System;
using System.Collections.Generic;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
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
            personTwo.Name = "Yuuki";
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

        }
    }
}
