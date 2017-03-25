using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class DataBlock
    {
        public string dataSourceName { get; set; }
        public string packageIndex { get; set; }
        public string type { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public string data { get; set; }
        public string labelKey { get; set; }
        public string trackingNumber { get; set; }
    }

    public class PrintJob
    {
        public string printTemplateType { get; set; }
        public List<object> flags { get; set; }
        public List<DataBlock> dataBlocks { get; set; }
    }

    public class RootObject
    {
        public string shipmentId { get; set; }
        public List<PrintJob> printJobs { get; set; }
        public object odbcNotification { get; set; }
    }
}
