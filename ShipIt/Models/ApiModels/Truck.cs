using System.Collections.Generic;

namespace ShipIt.Models.ApiModels
{
    public class Truck
    {
        public int TruckId { get; set; }
        public List<int> ProductId { get; set; }
    }
}