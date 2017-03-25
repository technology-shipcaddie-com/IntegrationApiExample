using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class ShipmentModelIntegration
    {
        public ShipmentModelIntegration()
        {
            Carriers = new List<CarrierModel>();
            Packages = new List<PackageModel>();
        }
        public AddressModel AddressFrom { get; set; }
        public AddressModel AddressTo { get; set; }
        public List<CarrierModel> Carriers { get; set; }
        public List<PackageModel> Packages { get; set; }
        public string PrintFormat { get; set; }
        public int ShipmentId { get; set; }
        public DateTime DateShipped { get; set; }
    }
}
