using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _05CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05. Cities by Continent and Country
            //Create a program that reads continents, countries and their cities put them in a nested dictionary and prints them.

            Dictionary<string, Dictionary<string, List<string>>> continentDictionary =
                new Dictionary<string, Dictionary<string, List<string>>>();

            ContinentCountryCityInformation(continentDictionary);

            PrintContinentDictionary(continentDictionary);

        }

        static void ContinentCountryCityInformation(Dictionary<string, Dictionary<string, List<string>>> continentDictionary)
        {
            int numberOfContinentData = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfContinentData; i++)
            {
                string[] continentInfo = Console.ReadLine().Split(" ").ToArray();
                string continentName = continentInfo[0];
                string countryName = continentInfo[1];
                string cityName = continentInfo[2];

                if (!continentDictionary.ContainsKey(continentName))
                {
                    continentDictionary.Add(continentName, new Dictionary<string, List<string>>());
                }

                if (!continentDictionary[continentName].ContainsKey(countryName))
                {
                    continentDictionary[continentName].Add(countryName, new List<string>());
                }



                continentDictionary[continentName][countryName].Add(cityName);
            }
        }

        static void PrintContinentDictionary(Dictionary<string, Dictionary<string, List<string>>> continentDictionary)
        {
            foreach (var continent in continentDictionary)
            {
                Console.WriteLine($"{continent.Key}:   ");

                foreach (var country in continent.Value)
                {
                    Console.Write($"  {country.Key} -> ");
                    Console.WriteLine(string.Join(", ", country.Value));
                }
            }
        }
    }
}


