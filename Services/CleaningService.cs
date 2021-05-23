using System.Threading;
using System.Threading.Tasks;

namespace HtmlHelperReplacement.Services
{
    public class CleaningService : ICleaningService
    {
        public string GetCleanString(string source)
        {
            Thread.Sleep(1);
            
            return $"{source}_CLEANED";
        }

        public async Task<string> GetCleanStringAsync(string source)
        {
            Thread.Sleep(1);
            
            return await Task.FromResult($"{source}_CLEANED");
        }
    }
}
