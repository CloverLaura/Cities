﻿using System;
using System.Collections.Generic;
using Cities.Comparers;

namespace Cities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<City> cities = CityDataImporter.LoadData();

            // TODO Swap out comparers as desired
            IComparer<City> comparer = new NameComparer();

            IComparer<City> stateComparer = new StateComparer();

            IComparer<City> populationComparer = new PopulationComparer();

            cities.Sort(populationComparer);

            //cities.Sort(stateComparer);

            //cities.Sort(comparer);


            PrintCities(cities);

            Console.ReadLine();
        }

        private static void PrintCities(List<City> cities)
        {
            Console.WriteLine(City.GetTableHeader());

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
