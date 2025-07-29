using System.Collections.Concurrent;
using WebService.Model;

namespace WebService.Services
{
    public class PlatformService
    {
        private readonly ConcurrentDictionary<string, List<AdvertisePlatform>> advertisePlatform;

        public void LoadAFromFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public List<string> GetLocation(string location)
        {
            throw new NotImplementedException();
        }
    }
}
