using System.Collections.Generic;

namespace Assignment_DC.Visualization
{
    public interface IDataVisualizer
    {
        void Display(List<KeyValuePair<string, int>> data);
    }
}
