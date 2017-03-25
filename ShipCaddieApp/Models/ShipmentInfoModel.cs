using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class ShipmentInfoModel
    {
        //public int ShipmentId { get; set; }
        //public DateTime DateShippped { get; set; }
        //public List<LabelModel> LabelList { get; set; }



        public class LabelList
        {
            public string trackingNumber { get; set; }
            public string labelData { get; set; }
            public string labelDataType { get; set; }
        }

        public class RootObject
        {
            public int shipmentId { get; set; }
            public string dateShippped { get; set; }
            public List<LabelList> labelList { get; set; }
        }




    }
}
