using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class VoidLabelModel
    {
        public string TrackingNumber { get; set; }

        public ApiErrorModel Error { get; set; }

        public int ExtensionData { get; set; }
    }
}
