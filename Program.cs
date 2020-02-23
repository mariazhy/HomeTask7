using System;
using System.Collections.Generic;
using System.IO;

namespace Home_task_7
{
    class Program
    {
        static void Main(string[] args)
        {           
            ProcessingFlow fileProcessing = new ProcessingFlow();
            Dictionary<int, Country> myDictionary = fileProcessing.ReadFromFile();
            Console.WriteLine("Initial list with EU countries: ");
            fileProcessing.PrintFile(myDictionary);

            Console.WriteLine("Add Ukraine to the list. Enter Ukraine: ");
            string inputCountry = Console.ReadLine();
            Console.WriteLine("Enter isTelenorSupported = False or True: ");
            bool inputIsTelenorSupported = Convert.ToBoolean(Console.ReadLine());
            Country country = new Country(inputCountry, inputIsTelenorSupported);
            int key = myDictionary.Keys.Count;
            myDictionary.Add(++key, country);
            fileProcessing.WriteToFileAndDictionary(myDictionary);
            Console.WriteLine("Updated EU list with Ukraine: ");
            fileProcessing.PrintFile(myDictionary);

            Console.WriteLine("Set IsTelenorSupported = true for Denmark and Hungary:");
            Console.ReadKey();
            foreach (var row in myDictionary)
            {
                if (row.Value.Name.Equals("Denmark") || row.Value.Name.Equals("Hungary"))
                {
                    row.Value.IsTelenorSupported = true;
                }
            }
            fileProcessing.WriteToFileAndDictionary(myDictionary);
            Console.WriteLine("List of Countries with changed Denmark and Hungary: ");
            fileProcessing.PrintFile(myDictionary);

            Console.WriteLine("Print countries that have isTelenorSupported = False: ");
            Console.ReadKey();
            foreach (var row in myDictionary)
            {
                if (row.Value.IsTelenorSupported == false)
                {
                    Console.WriteLine("{0} - {1} {2}", row.Key, row.Value.Name, row.Value.IsTelenorSupported);
                }
            }
        }
    }
}
