using System;
using System.Collections.Generic;

namespace Assignment_DC.Visualization
{
    public class ConsoleDataTableVisualizer : ConsoleDataVisualizer, IDataVisualizer
    {
        public void Display(List<KeyValuePair<string, int>> data)
        {
            Console.WriteLine("TABLE OF MOST COMMON LETTER COMBINATIONS\n");
            var countOfTopWords = GetCountOfTop10Combos(data);

            foreach (var item in data)
            {
                var result = (((double)item.Value / countOfTopWords) * 100);
                Console.WriteLine(string.Format("|{0,-20}|{1,10}|", 
                    item.Key, string.Format("{0:0}%", result)));
            }
        }
    }
}
