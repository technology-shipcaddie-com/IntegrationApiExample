using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class ServiceLevelModel
    {
        public int CarrierServiceLevelId { get; set; }
        public string CarrierServiceLevelName { get; set; }
        public decimal PackageWeightLimit { get; set; }
        public bool IsInternational { get; set; }
    }
}
