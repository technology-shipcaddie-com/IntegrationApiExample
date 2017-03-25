using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Models
{
    public class AddressModel
    {
        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string CountryCode { get; set; }

        public int SystemCountryId { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public bool IsResidential { get; set; }

        public string AttentionOf { get; set; }

        public string CompanyName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }


        public string customerId { get; set; }

        public string organization { get; set; }


        public string countryName { get; set; }

        public string alfa2Code { get; set; }

        public bool cancel { get; set; }
    }
}
