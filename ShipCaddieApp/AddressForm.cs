using RestSharp;
using ShipCaddieApp.Models;
using ShipCaddieApp.ShipCaddieAppXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipCaddieApp
{
    public partial class AddressForm : Form
    {
        #region Global Variables and class objects

        public static AddressModel _address = new AddressModel();

        public static ShipAddressModel _addressTo = new ShipAddressModel();
        public static ShipAddressModel _addressFrom = new ShipAddressModel();

        //To check the request type of Address coming from Main
        public static string AddressWay = "";
        //Access the User token from Main and pass here for authentication
        string _Rest_Access_Token = Main.rest_tokenModel.AccessToken;
        string _SOAP_Access_Token = Main.soap_tokenModel.access_token;

        #endregion

        #region Address Form Methods
        /// <summary>
        /// Constructor of AddressForm.
        /// </summary>
        public AddressForm()
        {
            InitializeComponent();
            callBindCountryforCode();
        }

        #region Main calling API method on the basis of selected value from format(JSON or SOAP) dropdown
        private void callBindCountryforCode()
        {
            var countryData = bindCountryforCode(); //Bind the country
            if (countryData != null)
            {
                ddlAddCountry.DataSource = countryData;
                var USA = countryData.Where(x => x.CountryId == 840).FirstOrDefault();
                ddlAddCountry.DisplayMember = "CountryName";
                ddlAddCountry.ValueMember = "CountryId";
                ddlAddCountry.SelectedItem = USA;
            }
        }
        #endregion

        #region REST API Method
        /// <summary>
        /// To bind the JSON country list by hitting the ShipCaddie API and bind in a dropdown
        /// </summary>
        /// <returns>Returnss a list of countries name</returns>
        private List<Models.SystemCountryModel> bindCountryforCode()
        {
            // GET integration/v1/GetCountrySystemInformation
            Cursor.Current = Cursors.WaitCursor;
            int _formatId = Main._formatTypeId;
            RestClient client = new RestClient(Settings.BASE_URL);
            RestRequest request = new RestRequest("integration/v1/GetCountrySystemInformation", Method.GET);
            if (_formatId == 1) // Id:1 - JSON
            {
                request.RequestFormat = DataFormat.Json;
                request.JsonSerializer.ContentType = "application/json";
            }
            else
            {
                request.RequestFormat = DataFormat.Xml;
                request.XmlSerializer.ContentType = "application/xml";
                request.AddHeader("Accept", "application/xml,text/plain,*/*");
            }
            request.AddHeader("Authorization", string.Format("Bearer {0}", _Rest_Access_Token));
            var response = client.Execute<List<Models.SystemCountryModel>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                List<Models.SystemCountryModel> lst_CM = new List<Models.SystemCountryModel>();
                foreach (var item in response.Data)
                {
                    Models.SystemCountryModel CM = new Models.SystemCountryModel();
                    CM.CountryId = item.CountryId;
                    CM.Alpha2CodeName = item.Alpha2CodeName;
                    CM.CountryName = item.CountryName;
                    lst_CM.Add(CM);
                }
                return lst_CM;
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region Shipment Address

        /// <summary>
        /// To save the address and pass into respective address model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAdd_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var getAddress = BindAddress(Main._addressWay);

            if (Main._addressWay == "ShipTo")
            {
                _addressTo.CustomerId = getAddress.customerId;
                _addressTo.Organization = getAddress.organization;
                _addressTo.Address1 = getAddress.Address1;
                _addressTo.Address2 = getAddress.Address2;
                _addressTo.City = getAddress.City;
                _addressTo.State = getAddress.State;
                _addressTo.Zip = getAddress.ZipCode;
                _addressTo.CountryName = getAddress.countryName;
                _addressTo.Phone = getAddress.PhoneNumber;
                _addressTo.Email = getAddress.Email;
                _addressTo.IsResident = getAddress.IsResidential;
                _addressTo.Alfa2Code = getAddress.alfa2Code;
                _addressTo.CountryId = getAddress.SystemCountryId;
                _addressTo.Cancel = getAddress.cancel;
            }
            else
            {
                _addressFrom.CustomerId = getAddress.customerId;
                _addressFrom.Organization = getAddress.organization;
                _addressFrom.Address1 = getAddress.Address1;
                _addressFrom.Address2 = getAddress.Address2;
                _addressFrom.City = getAddress.City;
                _addressFrom.State = getAddress.State;
                _addressFrom.Zip = getAddress.ZipCode;
                _addressFrom.CountryName = getAddress.countryName;
                _addressFrom.Phone = getAddress.PhoneNumber;
                _addressFrom.Email = getAddress.Email;
                _addressFrom.IsResident = getAddress.IsResidential;
                _addressFrom.Alfa2Code = getAddress.alfa2Code;
                _addressFrom.CountryId = getAddress.SystemCountryId;
                _addressFrom.Cancel = getAddress.cancel;
            }
        }

        private AddressModel BindAddress(string _addressWay)
        {
            int _formatId = Main._formatTypeId;
            _address.customerId = txtCID.Text;
            _address.organization = txtOrganization.Text;
            _address.Address1 = txtAdd1.Text;
            _address.Address2 = txtAdd2.Text;
            _address.City = txtCity.Text;
            _address.State = txtState.Text;
            _address.ZipCode = txtZip.Text;
            _address.countryName = ddlAddCountry.Text;
            _address.PhoneNumber = txtPhone.Text;
            _address.Email = txtEmail.Text;
            _address.IsResidential = chkResident.Checked;
            if (_formatId == 1)
            {
                _address.alfa2Code = ((Models.SystemCountryModel)ddlAddCountry.SelectedItem).Alpha2CodeName;
                _address.SystemCountryId = ((Models.SystemCountryModel)ddlAddCountry.SelectedItem).CountryId;
            }
            else
            {
                _address.alfa2Code = ((ShipCaddieAppXml.SystemCountryModel)ddlAddCountry.SelectedItem).alpha2CodeName;
                _address.SystemCountryId = ((ShipCaddieAppXml.SystemCountryModel)ddlAddCountry.SelectedItem).countryId;
            }
            _address.cancel = false;
            AddressWay = _addressWay;
            this.Hide();
            return _address;
        }

        //Return a ShipmentTo Address Model
        public static ShipAddressModel GetToAddress()
        {
            return _addressTo;
        }

        //Return a ShipmentFrom Address Model
        public static ShipAddressModel GetFromAddress()
        {
            return _addressFrom;
        }

        #endregion

        /// <summary>
        /// To cancel the Address input and clear close the AddressForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelAddd_Click(object sender, EventArgs e)
        {
            _address.cancel = true;
            this.Hide();
        }

        #region Phone Number validation
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void txtPhone_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, "  ^ [0-9]"))
            {
                txtPhone.Text = "";
            }
        }
        #endregion

        #endregion
    }
}
