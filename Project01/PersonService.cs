using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class PersonService
    {
        readonly TechnicalService techService = new TechnicalService();
        public List<string> GetListOfNames(List<Person> list)
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
        public Person GetPersonWithMinAge(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinAge");
                return null;
            }
            int minAge = list[0].Age;
            for (int i = 0; i < list.Count; i++)
            {
                if (minAge > list[i].Age)
                {
                    minAge = list[i].Age;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age == minAge)
                {
                    return list[i];
                }
            }
            return null;
        }
        public Person GetPersonWithMaxAge(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMaxAge");
                return null;
            }
            int maxAge = list[0].Age;
            for (int i = 0; i < list.Count; i++)
            {
                if (maxAge < list[i].Age)
                {
                    maxAge = list[i].Age;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Age == maxAge)
                {
                    return list[i];
                }
            }
            return null;
        }
        public Person GetPersonWithMinWeight(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinWeight");
                return null;
            }
            int minWeight = list[0].Weight;
            for (int i = 0; i < list.Count; i++)
            {
                if (minWeight > list[i].Weight)
                {
                    minWeight = list[i].Weight;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Weight == minWeight)
                {
                    return list[i];
                }
            }
            return null;
        }
        public Person GetPersonWithMaxWeight(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMaxWeight");
                return null;
            }
            int maxWeight = list[0].Weight;
            for (int i = 0; i < list.Count; i++)
            {
                if (maxWeight < list[i].Weight)
                {
                    maxWeight = list[i].Weight;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Weight == maxWeight)
                {
                    return list[i];
                }
            }
            return null;
        }
        public Person GetPersonWithMinHeight(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinAge");
                return null;
            }
            int minHeight = list[0].Height;
            for (int i = 0; i < list.Count; i++)
            {
                if (minHeight > list[i].Height)
                {
                    minHeight = list[i].Height;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Height == minHeight)
                {
                    return list[i];
                }
            }
            return null;
        }
        public Person GetPersonWithMaxHeight(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinAge");
                return null;
            }
            int maxHeight = list[0].Height;
            for (int i = 0; i < list.Count; i++)
            {
                if (maxHeight < list[i].Height)
                {
                    maxHeight = list[i].Height;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Height == maxHeight)
                {
                    return list[i];
                }
            }
            return null;
        }
        public List<Person> SortPersonByName(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinAge");
                return null;
            }
            char[] charArray = new char[list.Count];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = list[i].Name[0];
            }
            techService.BubbleSort(charArray);
            List<Person> nameSortList = new List<Person>();
            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].Name[0] == charArray[i])
                    {
                        nameSortList.Add(list[j]);
                    }
                }
            }
            for (int i = 0; i < nameSortList.Count; i++)
            {
                for (int j = i + 1; j < nameSortList.Count; j++)
                {
                    if (nameSortList[i] == nameSortList[j])
                    {
                        nameSortList.RemoveAt(j);
                    }
                }
            }
            return nameSortList;
        }
        public List<Person> SortPersonByAge(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinAge");
                return null;
            }
            int[] numberArray = new int[list.Count];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = list[i].Age;
            }
            techService.BubbleSort(numberArray);
            List<Person> ageSortList = new List<Person>();
            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].Age == numberArray[i])
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
        public List<Person> SortPersonByWeight(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinAge");
                return null;
            }
            int[] numberArray = new int[list.Count];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = list[i].Weight;
            }
            techService.BubbleSort(numberArray);
            List<Person> weightSortList = new List<Person>();
            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].Weight == numberArray[i])
                    {
                        weightSortList.Add(list[j]);
                    }
                }
            }
            for (int i = 0; i < weightSortList.Count; i++)
            {
                for (int j = i + 1; j < weightSortList.Count; j++)
                {
                    if (weightSortList[i] == weightSortList[j])
                    {
                        weightSortList.RemoveAt(j);
                    }
                }
            }
            return weightSortList;
        }
        public List<Person> SortPersonByHeight(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinAge");
                return null;
            }
            int[] numberArray = new int[list.Count];
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = list[i].Height;
            }
            techService.BubbleSort(numberArray);
            List<Person> heightSortList = new List<Person>();
            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[j].Height == numberArray[i])
                    {
                        heightSortList.Add(list[j]);
                    }
                }
            }
            for (int i = 0; i < heightSortList.Count; i++)
            {
                for (int j = i + 1; j < heightSortList.Count; j++)
                {
                    if (heightSortList[i] == heightSortList[j])
                    {
                        heightSortList.RemoveAt(j);
                    }
                }
            }
            return heightSortList;
        }
    }
}
