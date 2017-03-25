using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class PrintRequestModel
    {
        public string PrintTemplateType { get; set; }
        public List<string> MyProperty { get; set; }
        public List<PrintRequestDataBlockGeneric> DataBlocks { get; set; }
    }
}
