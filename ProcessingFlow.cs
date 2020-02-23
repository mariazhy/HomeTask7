using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Home_task_7
{
    class ProcessingFlow
    {
        private Dictionary<int, Country> _myDictionary = new Dictionary<int, Country>();
        static string path = @"C:\Users\Мария\source\repos\Home task 7\Home task 7\EUcountries.txt";

        public Dictionary<int, Country> ReadFromFile()
        {
            string[] fileLines;
            int key = 0;
            using(StreamReader streamReader = new StreamReader(path, Encoding.Default))
            {
                string row = streamReader.ReadLine();
                do
                {
                    Country country = new Country();
                    fileLines = row.Split(',');
                    country.Name = fileLines[0];
                    country.IsTelenorSupported = Convert.ToBoolean(fileLines[1]);
                    _myDictionary.Add(key++, country);
                    row = streamReader.ReadLine();

                } while (row != null);
            }
            return _myDictionary;
        }

        public void WriteToFileAndDictionary(Dictionary<int, Country> dictionary)
        { 
            StreamWriter streamWriter = new StreamWriter(path);
            foreach(var row in dictionary) 
            {
                streamWriter.WriteLine($"{row.Value.Name},{row.Value.IsTelenorSupported}");
            }
            streamWriter.Close();
        }

        public void PrintFile(Dictionary<int, Country> dictionary)
        {
            foreach (var row in dictionary)
            {
                Console.WriteLine("{0} - {1} {2}", row.Key, row.Value.Name, row.Value.IsTelenorSupported);
            }
        }
    }
}
