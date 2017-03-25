using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class ShipAddressModel
    {
        public string CustomerId { get; set; }
        public string Organization { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string CountryName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsResident { get; set; }
        public string Alfa2Code { get; set; }
        public int CountryId { get; set; }
        public bool Cancel { get; set; }
    }
}
