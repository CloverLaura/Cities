using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cities.Comparers
{
    public class PopulationComparer : IComparer<City>
    {
        public int Compare(City x, City y)
        {
           return Math.Sign(x.Population.CompareTo(y.Population));
        }
    }
}
