using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class PersonService : IRecognizable
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
            Person personWithMinAge = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (personWithMinAge.Age > list[i].Age)
                {
                    personWithMinAge = list[i];
                }
            }
            return personWithMinAge;
        }
        public Person GetPersonWithMaxAge(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMaxAge");
                return null;
            }
            Person personWithMaxAge = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (personWithMaxAge.Age < list[i].Age)
                {
                    personWithMaxAge = list[i];
                }
            }
            return personWithMaxAge;
        }
        public Person GetPersonWithMinWeight(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinWeight");
                return null;
            }
            Person personWithMinWeight = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (personWithMinWeight.Weight > list[i].Weight)
                {
                    personWithMinWeight = list[i];
                }
            }
            return personWithMinWeight;
        }
        public Person GetPersonWithMaxWeight(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMaxWeight");
                return null;
            }
            Person personWithMaxWeight = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (personWithMaxWeight.Weight < list[i].Weight)
                {
                    personWithMaxWeight = list[i];
                }
            }
            return personWithMaxWeight;
        }
        public Person GetPersonWithMinHeight(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinAge");
                return null;
            }
            Person personWithMinHeight = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (personWithMinHeight.Height > list[i].Height)
                {
                    personWithMinHeight = list[i];
                }
            }
            return personWithMinHeight;
        }
        public Person GetPersonWithMaxHeight(List<Person> list)
        {
            if (list == null || list.Count == 0)
            {
                Console.WriteLine("Сработала защита в GetPersonWithMinAge");
                return null;
            }
            Person personWithMaxHeight = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (personWithMaxHeight.Height < list[i].Height)
                {
                    personWithMaxHeight = list[i];
                }
            }
            return personWithMaxHeight;
        }
        public List<Person> SortPersonByName(List<Person> list)
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
                    if ((string.Compare(list[j].Name, list[j + 1].Name)) > 0)
                    {
                        Person tempPerson = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tempPerson;
                    }
                }
            }
            return list;
        }
        public List<Person> SortPersonByAge(List<Person> list)
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
                    if (list[j].Age > list[j + 1].Age)
                    {
                        Person tempPerson = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tempPerson;
                    }
                }
            }
            return list;
        }
        public List<Person> SortPersonByWeight(List<Person> list)
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
                    if (list[j].Weight > list[j + 1].Weight)
                    {
                        Person tempPerson = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tempPerson;
                    }
                }
            }
            return list;
        }
        public List<Person> SortPersonByHeight(List<Person> list)
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
                    if (list[j].Height > list[j + 1].Height)
                    {
                        Person tempPerson = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = tempPerson;
                    }
                }
            }
            return list;
        }
    }
}
