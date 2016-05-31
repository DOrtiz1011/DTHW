using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DTHW
{
    class KeyCounts
    {
        private Dictionary<string, int> CountsByName { get; set; }
        private string InputFile { get; set; }

        public KeyCounts(string inputFile)
        {
            InputFile = inputFile;

            if (CountsByName != null)
            {
                CountsByName.Clear();
                CountsByName = null;
            }

            CountsByName = new Dictionary<string, int>();

            ReadInputFile();
        }

        private void ReadInputFile()
        {
            foreach (var word in File.ReadAllLines(InputFile).ToList())
            {
                var inputs = word.Split(',');
                var name = inputs[0];
                var value = Convert.ToInt32(inputs[1]);

                AddToDictionary(name, value);
            }
        }

        private void AddToDictionary(string name, int value)
        {
            if (CountsByName.ContainsKey(name))
            {
                CountsByName[name] += value;
            }
            else
            {
                CountsByName.Add(name, value);
            }
        }

        public void PrintResults()
        {
            const string format = "The total for {0} is {1}";
            var stringBuiler = new StringBuilder();

            foreach (var keyValuePair in CountsByName)
            {
                stringBuiler.AppendLine(string.Format(format, keyValuePair.Key, keyValuePair.Value));
            }

            Console.WriteLine(stringBuiler.ToString());
        }
    }
}
