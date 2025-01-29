using CarStore.Data.Data.Entities;
using System.ComponentModel;

namespace CarStore.Web.Models
{
    public class AddCarViewModel
    {
        [DisplayName("Car model")]
        public Guid CarModelId { get; set; }

        [DisplayName("Price")]
        public decimal? Price { get; set; }
        [DisplayName("Color")]
        public string? Color { get; set; }

        [DisplayName("Year")]
        public int? Year { get; set; }

        public List<CarModel> CarModels { get; set; } = new List<CarModel>();

    }
}
