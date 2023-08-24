namespace Versta.Entities
{
    public class OrderInfo
    {
        public int id { get; set; }
        public string? unique_id { get; set; }
        public string? city_from { get; set; }
        public string? address_from { get; set; }
        public string? city_to { get; set; }
        public string? address_to { get; set; }
        public int? weight { get; set; }
        public string? date { get; set; }
    }
}
