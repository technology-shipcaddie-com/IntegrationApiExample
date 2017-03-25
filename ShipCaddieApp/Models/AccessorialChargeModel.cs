using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class AccessorialChargeModel
    {
        public AccessorialChargeModel()
        {
            Inputs = new List<Input>();
        }
        public string Name { get; set; }
        public decimal ChargeAmount { get; set; }
        public int Id { get; set; }
        public List<Input> Inputs { get; set; }
    }
}
