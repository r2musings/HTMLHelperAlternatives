using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HtmlHelperReplacement.Services
{
    public class CleaningService : ICleaningService
    {
        public string GetCleanString(string source)
        {
            return Regex.Replace(source, "[^A-Za-z]", "").ToLower().Replace("dirty", "clean");
        }

        public async Task<string> GetCleanStringAsync(string source)
        {
            return await Task.FromResult(GetCleanString(source));
        }
    }
}
