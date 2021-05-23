using System.Threading.Tasks;

namespace HtmlHelperReplacement.Services
{
    public interface ICleaningService
    {
        public string GetCleanString(string source);

        public Task<string> GetCleanStringAsync(string source);
    }
}
