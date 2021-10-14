using System;
using System.Collections.Generic;

namespace Assignment_DC.Visualization
{
    public class ConsoleDataBarChartVisualizer : ConsoleDataVisualizer, IDataVisualizer
    {
        public void Display(List<KeyValuePair<string, int>> data)
        {
            Console.WriteLine("\n\nBAR CHART OF MOST COMMON LETTER COMBINATIONS\n");
            var countOfTopWords = GetCountOfTop10Combos(data);

            var max = data[0].Key.Length;
            foreach (var item in data)
            {
                if (item.Key.Length > max)
                {
                    max = item.Key.Length;
                }
            }

            Draw(data, max, countOfTopWords);
        }

        private void Draw(List<KeyValuePair<string, int>> data, int max, int countOfTopWords)
        {
            foreach (var item in data)
            {
                var result = (((double)item.Value / countOfTopWords) * 100);
                Console.Write(item.Key.PadLeft(max));
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                for (var i = 0; i < result; i++)
                {
                    Console.Write(" ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
                Console.WriteLine(string.Format("{0:0}%", result));
                Console.WriteLine();
            }
        }
    }
}
