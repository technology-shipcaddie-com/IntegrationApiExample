using ShipCaddieApp.ShipCaddieAppXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class CommonVoidModel
    {
        public string TrackingNumber { get; set; }
        public string Error { get; set; }
        public bool IsSuccess { get; set; }
        public TrackingNumber[] TrackingNumberList { get; set; }
    }
}
