using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    interface ICalculable
    {
        public List<int> GetEvenList(List<int> list);
        public List<int> GetOddList(List<int> list);
        public List<int> GetPositiveList(List<int> list);
        public List<int> GetNegativeList(List<int> list);

    }
}
