using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities.Comparers
{
    public class StateComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
            return string.Compare(x.State, y.State);
        }
    }
}
