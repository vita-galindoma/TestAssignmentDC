using System.Collections.Generic;
using Assignment_DC.ContentProcessing;

namespace Assignment_DC.ContentProcessing
{
    public class CombinationFilter : ICombinationFilter
    {
        private readonly IContentProvider _contentProvider;

        public CombinationFilter(IContentProvider contentProvider)
        {
            _contentProvider = contentProvider;
        }

        public List<KeyValuePair<string, int>> GetListOfTop10Combos()
        {
            var content = _contentProvider.GetContent();
            var normalizedContent = TextNormalization(content);
            var filteredContent = FilterValidCombinations(normalizedContent);
            var allCombos = GetMostCommonCombos(filteredContent);
            var top10Combos = GetListOfTop10Combos(allCombos);
            return top10Combos;
        }

        private string TextNormalization(string text)
        {
            var result = text.ToLower().Split(' ', '\t', '\n', '\r');
            return string.Join(" ", result);
        }

        private List<string> FilterValidCombinations(string text)
        {
            var listOfValidWords = new List<string>();
            var words = text.Split(' ');

            foreach (var x in words)
            {
                if (x.Length >= 3 && IsLetter(x))
                {
                    listOfValidWords.Add(x);
                }
            }
            return listOfValidWords;
        }

        private bool IsLetter(string s)
        {
            foreach (var x in s)
            {
                if (!char.IsLetter(x))
                    return false;
            }
            return true;
        }

        private List<KeyValuePair<string, int>> GetMostCommonCombos(List<string> validWords)
        {
            var commonCombosDict = new Dictionary<string, int>();
            foreach (var value in validWords)
            {
                if (commonCombosDict.ContainsKey(value))
                    commonCombosDict[value]++;
                else
                    commonCombosDict[value] = 1;
            }

            var listOfCombos = new List<KeyValuePair<string, int>>();
            foreach (var item in commonCombosDict)
            {
                listOfCombos.Add(item);
            }

            listOfCombos.Sort((a, b) => b.Value.CompareTo(a.Value));
            
            return listOfCombos;
        }

        private List<KeyValuePair<string, int>> GetListOfTop10Combos(List<KeyValuePair<string, int>> commonCombosList)
        {
            if (commonCombosList.Count < 10) return commonCombosList;
            var listOfTop10Combos = commonCombosList.GetRange(0, 10);
            return listOfTop10Combos;
        }
    }
}
