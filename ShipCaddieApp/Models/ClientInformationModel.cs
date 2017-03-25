using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class ClientInformationModel
    {
        public int CarrierClientContractId { get; set; }
        public string AffillateName { get; set; }
        public string CarrierName { get; set; }
        public string NickName { get; set; }
        public List<ServiceLevelModel> ServiceLevels { get; set; }
    }
}
