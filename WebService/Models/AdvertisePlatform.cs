namespace WebService.Model
{
    public class AdvertisePlatform
    {
        public string Location { get; set; }
        public string Name { get; set; }

        public AdvertisePlatform(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }
}
