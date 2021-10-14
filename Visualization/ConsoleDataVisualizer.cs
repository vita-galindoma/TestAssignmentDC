using System.Collections.Generic;

namespace Assignment_DC.Visualization
{
    public class ConsoleDataVisualizer
    {
        public int GetCountOfTop10Combos(List<KeyValuePair<string, int>> listOfTop10Combos)
        {
            var countOfTopWords = 0;
            foreach (var item in listOfTop10Combos)
            {
                countOfTopWords += item.Value;
            }

            return countOfTopWords;
        }
    }
}
