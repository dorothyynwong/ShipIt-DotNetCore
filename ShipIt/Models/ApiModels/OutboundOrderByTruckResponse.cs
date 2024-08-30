using System.Collections.Generic;

namespace ShipIt.Models.ApiModels
{
    public class OutboundOrderByTruckResponse : Response
    {
        public Truck Truck {get; set;}
        public OutboundOrderByTruckResponse(Truck truck)
        {
            Truck = truck;
            Success = true;
        }

        public OutboundOrderByTruckResponse()
        {} 
    }

}