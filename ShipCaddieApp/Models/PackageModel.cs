using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class PackageModel
    {
        public PackageModel()
        {
            Items = new List<InventoryModel>();
            AccessorialCharges = new List<AccessorialChargeModel>();
        }
        public Size Dimension { get; set; }
        public decimal WeightOunces { get; set; }
        public decimal WeightPounds { get; set; }
        public string ReferenceField1 { get; set; }
        public string ReferenceField2 { get; set; }
        public List<AccessorialChargeModel> AccessorialCharges { get; set; }
        public List<InventoryModel> Items { get; set; }
    }
}
