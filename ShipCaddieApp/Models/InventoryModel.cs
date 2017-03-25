using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class InventoryModel
    {
        public string SKU { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal WeightOunces { get; set; }
        public decimal WeightPounds { get; set; }
        public string HarmonizeCode { get; set; }
        public Size Dimension { get; set; }
    }
}
