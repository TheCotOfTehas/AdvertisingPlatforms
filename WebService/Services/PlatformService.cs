using System.Collections.Concurrent;
using System.Collections.Generic;
using WebService.Model;
using System.IO;

namespace WebService.Services
{
    public class PlatformService
    {
        private readonly ConcurrentDictionary<string, List<AdvertisePlatform>> platforms = new();

        public void LoadFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var platforms = lines.Select(line =>
            {
                var parts = line.Split(',');
                return new AdvertisePlatform (parts[1].Trim(),parts[0].Trim());
            })
            .GroupBy(ap => ap.Location)
            .ToDictionary(g => g.Key, g => g.ToList());

            platforms.Clear();
            foreach (var kvp in platforms)
            {
                platforms[kvp.Key] = kvp.Value;
            }
        }

        public List<string> GetLocation(string location)
        {
            throw new NotImplementedException();
        }
    }
}
