using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    class Person
    {
        private string name { get; set; }
        private int age;
        private int weight;
        private int height;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    return;
                }
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                age = value;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                weight = value;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                height = value;
            }
        }
    }
}
