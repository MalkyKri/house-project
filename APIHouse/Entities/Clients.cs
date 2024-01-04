namespace APIHouse.Entities
{
    public class Clients
    {
        public string IdClient { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public Houses House { get; set; }
    }
}
