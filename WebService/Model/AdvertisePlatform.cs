namespace WebService.Model
{
    public class AdvertisePlatform
    {
        public string Name { get; set; }
        public List<string> Locations { get; set; }

        public AdvertisePlatform(string name, List<string> locations)
        {
            Name = name;
            Locations = locations;
        }
    }
}
