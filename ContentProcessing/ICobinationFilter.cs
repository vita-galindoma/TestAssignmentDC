using System.Collections.Generic;

namespace Assignment_DC.ContentProcessing
{
    public interface ICombinationFilter
    {
        List<KeyValuePair<string, int>> GetListOfTop10Combos();
    }
}
