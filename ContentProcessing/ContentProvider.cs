using System.IO;
using Assignment_DC.Configuration;
using Assignment_DC.ContentProcessing;

namespace Assignment_DC.ContentProcessing
{
    public class ContentProvider : IContentProvider
    {
        public string GetContent()
        {
            var config = ConfigurationProvider.GetConfig();
            return File.ReadAllText(config.ContentPath);
        }
    }
}
