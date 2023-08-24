using Versta.Models;
using Versta.Entities;


namespace Versta.Models
{
    public class CreateNewOrderModel
    {
        public int Id { get; set; }
        public string? UniqueId { get; set; }
        public string? CityFrom { get; set; }
        public string? AdressFrom { get; set; }
        public string? CityTo { get; set; }
        public string? AdressTo { get; set; }
        public int? Weight { get; set; }
        public string? Date { get; set; }
    }
}

