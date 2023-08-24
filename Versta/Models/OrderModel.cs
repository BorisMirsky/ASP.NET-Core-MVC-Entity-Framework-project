using Versta.Models;
using Versta.Entities;


namespace Versta.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int UniqueId { get; set; }
        public string? CityFrom { get; set; }
        public string? AdressFrom { get; set; }
        public string? CityTo { get; set; }
        public int? Weight { get; set; }
        public string? AdressTo { get; set; }
        public string? Date { get; set; }
        public OrderInfo? Order { get; set; }
        public IEnumerable<OrderInfo>? Orders { get; set; }
    }
}


