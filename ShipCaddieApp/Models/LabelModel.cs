using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class LabelModel
    {
        public string TrackingNumber { get; set; }
        public byte[] LabelData { get; set; }
        public string LabelDataType { get; set; }
    }
}
