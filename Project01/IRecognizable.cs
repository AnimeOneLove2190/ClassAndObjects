using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    interface IRecognizable
    {
        public List<string> GetListOfNames(List<Person> list);
        public Person GetPersonWithMinAge(List<Person> list);
        public Person GetPersonWithMaxAge(List<Person> list);
        public Person GetPersonWithMinWeight(List<Person> list);
        public Person GetPersonWithMaxWeight(List<Person> list);
        public Person GetPersonWithMinHeight(List<Person> list);
        public Person GetPersonWithMaxHeight(List<Person> list);
        public List<Person> SortPersonByName(List<Person> list);
        public List<Person> SortPersonByAge(List<Person> list);
        public List<Person> SortPersonByWeight(List<Person> list);
        public List<Person> SortPersonByHeight(List<Person> list);
    }
}
