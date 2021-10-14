using System;
using System.IO;
using Assignment_DC.ContentProcessing;
using Assignment_DC.Visualization;


namespace Assignment_DC
{
    class Program
    {
        static void Main(string[] args)
        {
            IContentProvider provider = new ContentProvider();
            ICombinationFilter filter = new CombinationFilter(provider);

            var data = filter.GetListOfTop10Combos();

            IDataVisualizer tableDataVisualizer = new ConsoleDataTableVisualizer();
            IDataVisualizer tableDataBarChartVisualizer = new ConsoleDataBarChartVisualizer();

            tableDataVisualizer.Display(data);
            tableDataBarChartVisualizer.Display(data);

            Console.ReadKey();
        }
    }
}