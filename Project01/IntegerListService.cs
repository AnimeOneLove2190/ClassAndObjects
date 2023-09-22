using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class IntegerListService : ICalculable
    {
        public List<int> GetEvenList(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetEvenList");
                return null;
            }
            List<int> evenList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    evenList.Add(list[i]);
                }
            }
            return evenList;
        }
        public List<int> GetOddList(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetOddList");
                return null;
            }
            List<int> oddList = new List<int>();
            for (int i = 0, j = 0; i < list.Count; i++)
            {
                if (!(list[i] % 2 == 0))
                {
                    oddList.Add(list[i]);
                    j++;
                }
            }
            return oddList;
        }
        public List<int> GetPositiveList(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPositiveList");
                return null;
            }
            List<int> positiveList = new List<int>();
            for (int i = 0, j = 0; i < list.Count; i++)
            {
                if (list[i] > 0)
                {
                    positiveList.Add(list[i]);
                    j++;
                }
            }
            return positiveList;
        }
        public List<int> GetNegativeList(List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetNegativeList");
                return null;
            }
            List<int> negativeList = new List<int>();
            for (int i = 0, j = 0; i < list.Count; i++)
            {
                if (list[i] < 0)
                {
                    negativeList.Add(list[i]);
                    j++;
                }
            }
            return negativeList;
        }
        public List<int> CreateList(int countOfElemetnts, int minValue, int maxValue)
        {
            if (countOfElemetnts <= 0)
            {
                Console.WriteLine("Сработала защита в CreateList");
                return null;
            }
            if (minValue > maxValue)
            {
                int tempStore = maxValue;
                maxValue = minValue;
                minValue = tempStore;
            }
            Random godOfNumbers = new Random();
            List<int> createdList = new List<int>();
            for (int i = 0; i < countOfElemetnts; i++)
            {
                createdList.Add(godOfNumbers.Next(minValue, maxValue));
            }
            return createdList;
        }
        public void WriteList (List<int> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в WriteList");
                return;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
