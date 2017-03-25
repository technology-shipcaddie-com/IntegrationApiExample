using Newtonsoft.Json;
using RestSharp;
using ShipCaddieApp.Models;
using ShipCaddieApp.ShipCaddieAppXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipCaddieApp
{
    public partial class Form1 : Form
    {
        #region Class objects and Global variables

        #region Address Models
        //Ship From Global Variables
        ShipAddressModel addressFrom = new ShipAddressModel();
        //Ship To Global Variables
        ShipAddressModel addressTo = new ShipAddressModel();
        #endregion

        #region Token class objects of SOAP and REST
        #region REST API JSON class
        public static ShipCaddieApp.Models.TokenModel rest_tokenModel = new Models.TokenModel();
        #endregion

        #region SOAP API XML class
        public static ShipCaddieAppXml.TokenModel soap_tokenModel = new ShipCaddieAppXml.TokenModel();
        #endregion
        #endregion

        //To check the response of address coming from AddressTo or AddressForm
        public static string _addressWay = "";
        //To set the carrier id
        int _carrierClientContractId = 0;
        //To set the carrier related service id
        int _carrierServiceLevelId = 0;
        //Set the SOAP or REST id
        public static int _formatTypeId = 0;

        #endregion

        #region Form1 constructor
        /// <summary>
        /// It is a Constructor of Form1 which call first when the Form1 is loaded.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //Bind the Format type i.e, XML or JSON
            BindFormatType();
            IsEnabledControls(false);
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("The Caps Lock key is ON.");
            }
        }
        #endregion

        #region SOAP/REST API Method calls

        #region ShipCaddie REST or JSON API methods. HELP LINK: http://res.shipcaddie.com/help#Integration

        /// <summary>
        /// Get Token when provide a username and password
        /// </summary>
        /// Method Help Link : http://res.shipcaddie.com/Help/Api/GET-integration-v1-Token_username_password
        /// <returns>Get unique token from shipcaddie server </returns>
        private Models.TokenModel GetToken()
        {
            //GET integration/v1/Token?username={username}&password={password} 
            RestClient client = new RestClient(Settings.BASE_URL);
            RestRequest request = new RestRequest("integration/v1/Token?username=" + Settings.USER + "&password=" + Settings.USER_PWD, Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer.ContentType = "application/json";
            var response = client.Execute<ShipCaddieApp.Models.TokenModel>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                rest_tokenModel.AccessToken = response.Data.AccessToken;
                rest_tokenModel.refreshExpires = response.Data.refreshExpires;
                rest_tokenModel.RefreshIssued = response.Data.RefreshIssued;
                rest_tokenModel.RefreshToken = response.Data.RefreshToken;
                rest_tokenModel.TokenExpires = response.Data.TokenExpires;
                rest_tokenModel.TokenIssued = response.Data.TokenIssued;
                rest_tokenModel.TokenType = response.Data.TokenType;
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Token is generated successfully";
                ErrorLabel.ForeColor = Color.Green;
                return rest_tokenModel;
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                ErrorLabel.Text = message.developerMessage;
                ErrorLabel.ForeColor = Color.Red;
                return null;
            }
        }

        /// <summary>
        /// To get the Carrier contracts
        /// </summary>
        /// Method Help Link : http://res.shipcaddie.com/Help/Api/GET-integration-v1-GetClientContractInformation
        /// <returns>Return a list of object with the Client Contract Information Basically return all the Carrier Contracts, and for each carrier contract a list of supported Service levels</returns>
        private List<ShipCaddieApp.Models.ClientInformationModel> GetClientContractInformation()
        {
            //GET integration/v1/GetClientContractInformation

            List<ShipCaddieApp.Models.ClientInformationModel> lst_CIM = new List<ShipCaddieApp.Models.ClientInformationModel>();
            RestClient client = new RestClient(Settings.BASE_URL);
            RestRequest request = new RestRequest("integration/v1/GetClientContractInformation", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer.ContentType = "application/json";
            request.AddHeader("Authorization", string.Format("Bearer {0}", rest_tokenModel.AccessToken));
            var response = client.Execute<List<ShipCaddieApp.Models.ClientInformationModel>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (var item in response.Data)
                {
                    ShipCaddieApp.Models.ClientInformationModel CIM = new ShipCaddieApp.Models.ClientInformationModel();
                    CIM.AffillateName = item.AffillateName;
                    CIM.CarrierClientContractId = item.CarrierClientContractId;
                    CIM.CarrierName = item.CarrierName;
                    CIM.NickName = item.NickName;
                    CIM.ServiceLevels = item.ServiceLevels;
                    lst_CIM.Add(CIM);
                }
                return lst_CIM;
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                ErrorLabel.Text = message.developerMessage;
                ErrorLabel.ForeColor = Color.Red;
                return null;
            }
        }

        /// <summary>
        /// To get a list of  objects of service label on the basis of selected carrier
        /// </summary>
        /// Method Help Link : http://res.shipcaddie.com/Help/Api/GET-integration-v1-GetClientContractInformation
        /// <returns>Return the service label by specific CarrierId</returns>
        private List<ServiceLevelModel> GetClientContractInformation(int CarrierId)
        {
            //GET integration/v1/GetClientContractInformation

            List<ServiceLevelModel> lst_CIM = new List<ServiceLevelModel>();
            RestClient client = new RestClient(Settings.BASE_URL);
            RestRequest request = new RestRequest("integration/v1/GetClientContractInformation", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer.ContentType = "application/json";
            request.AddHeader("Authorization", string.Format("Bearer {0}", rest_tokenModel.AccessToken));
            var response = client.Execute<List<ShipCaddieApp.Models.ClientInformationModel>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (var item in response.Data)
                {
                    if (item.CarrierClientContractId == CarrierId)
                    {
                        foreach (var item2 in item.ServiceLevels)
                        {
                            ServiceLevelModel CIM = new ServiceLevelModel();
                            CIM.CarrierServiceLevelId = item2.CarrierServiceLevelId;
                            CIM.CarrierServiceLevelName = item2.CarrierServiceLevelName;
                            CIM.IsInternational = item2.IsInternational;
                            CIM.PackageWeightLimit = item2.PackageWeightLimit;
                            lst_CIM.Add(CIM);
                        }
                    }
                }
                return lst_CIM;
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                ErrorLabel.Text = message.developerMessage;
                ErrorLabel.ForeColor = Color.Red;
                return null;
            }
        }

        /// <summary>
        /// Get rates
        /// </summary>
        /// Method Help Link: http://res.shipcaddie.com/Help/Api/POST-integration-v1-GetRate
        private void GetRate()
        {
            // POST integration/v1/GetRate
            RestClient client = new RestClient(Settings.BASE_URL);
            RestRequest request = new RestRequest("integration/v1/GetRate", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer.ContentType = "application/json";
            request.AddHeader("Authorization", string.Format("Bearer {0}", rest_tokenModel.AccessToken));
            request.AddBody(CreateShipmentModel());
            var response = client.Execute<ShipCaddieApp.Models.ShipmentModelIntegration>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (var package in response.Data.Packages)
                {
                    dataGridView1.DataSource = package.AccessorialCharges.Select(x =>
                    new AccessorialChargeModel
                    {
                        Name = x.Name,
                        ChargeAmount = x.ChargeAmount,
                    }).ToList();
                    var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                    ErrorLabel.Text = message.developerMessage;
                    ErrorLabel.ForeColor = Color.Green;
                }
            }
            else
            {
                var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = message.developerMessage;
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// To create and get a Shipment label
        /// </summary>
        /// Method Help Link: http://res.shipcaddie.com/Help/Api/POST-integration-v1-GetLabels
        private void CreateLabel()
        {
            //POST integration/v1/GetLabels

            RestClient client = new RestClient(Settings.BASE_URL);
            RestRequest request = new RestRequest("integration/v1/GetLabels", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer.ContentType = "application/json";
            request.AddHeader("Authorization", string.Format("Bearer {0}", rest_tokenModel.AccessToken));
            request.AddBody(CreateShipmentModel());
            var response = client.Execute<List<RootObject>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (var item in response.Data)
                {
                    if (item.printJobs != null)
                    {
                        foreach (var item2 in item.printJobs)
                        {
                            var label = item2.dataBlocks.Select(x => x.data).FirstOrDefault();
                            txt_Labelkey.Text = item2.dataBlocks.Select(x => x.labelKey).FirstOrDefault();
                            lbl_info.Text = "Please copy above Label key and paste in textbox below.";
                            pictureBox1.Image = Base64ToImage(label);
                            lbl_LabelMessage.Text = "Message";
                            ErrorLabel.Text = "Successfuly GetLabels";
                            ErrorLabel.ForeColor = Color.Green;
                        }
                    }
                    else
                    {
                        lbl_LabelMessage.Text = "Message";
                        var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                        ErrorLabel.Text = message.developerMessage;
                        ErrorLabel.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                ErrorLabel.Text = message.developerMessage;
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// To delete a generated label by passing unique 'labelKey'
        /// </summary>
        /// Method Help Link: http://res.shipcaddie.com/Help/Api/POST-integration-v1-VoidLabel_labelKey
        /// <Return>Returns a keyValue</Return>
        /// <Return Params>TrackingNumber: The tracking number of the package</Return>
        public List<ShipCaddieApp.Models.VoidLabelModel> VoidLabel(string labelkey)
        {
            List<ShipCaddieApp.Models.VoidLabelModel> lst_voidLabel = new List<Models.VoidLabelModel>();
            //POST integration/v1/VoidLabel?labelKey={labelKey}
            RestClient client = new RestClient(Settings.BASE_URL);
            RestRequest request = new RestRequest("integration/v1/VoidLabel?labelKey={labelKey}", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer.ContentType = "application/json";
            request.AddHeader("Authorization", string.Format("Bearer {0}", rest_tokenModel.AccessToken));
            request.AddParameter("labelKey", labelkey, ParameterType.UrlSegment);
            var response = client.Execute<List<ShipCaddieApp.Models.VoidLabelModel>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (var item in response.Data)
                {
                    ShipCaddieApp.Models.VoidLabelModel voidLabel = new Models.VoidLabelModel();
                    voidLabel.TrackingNumber = item.TrackingNumber;
                    voidLabel.Error = new ApiErrorModel()
                    {
                        Message = null,
                        IsSuccess = true
                    };
                    lst_voidLabel.Add(voidLabel);
                    lblTrackingNumber.Text = "Please copy and save this Tracking Number :" + item.TrackingNumber;
                    lbl_LabelMessage.Text = "Message";
                    ErrorLabel.Text = "Successfuly get the Tracking number.";
                    ErrorLabel.ForeColor = Color.Green;
                }
                return lst_voidLabel;
            }
            else
            {
                string message = Convert.ToString(JsonConvert.DeserializeObject<Models.Message>(response.Content));
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = message;
                ErrorLabel.ForeColor = Color.Red;
                return null;
            }
        }

        /// <summary>
        /// Return token based on consumer resfresh token. The token is needed to access all endpoints into this integration package.
        /// </summary>
        /// Method Help Link: http://res.shipcaddie.com/Help/Api/GET-integration-v1-RefreshToken_refreshToken
        /// <Return>Returns a token and refresh token</Return>
        public void RefreshToken()
        {
            //GET integration/v1/RefreshToken?refreshToken={refreshToken}
            RestClient client = new RestClient(Settings.BASE_URL);
            RestRequest request = new RestRequest("integration/v1/RefreshToken?refreshToken=" + rest_tokenModel.RefreshToken, Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer.ContentType = "application/json";
            var response = client.Execute<ShipCaddieApp.Models.TokenModel>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                rest_tokenModel.AccessToken = response.Data.AccessToken;
                rest_tokenModel.refreshExpires = response.Data.refreshExpires;
                rest_tokenModel.RefreshIssued = response.Data.RefreshIssued;
                rest_tokenModel.RefreshToken = response.Data.RefreshToken;
                rest_tokenModel.TokenExpires = response.Data.TokenExpires;
                rest_tokenModel.TokenIssued = response.Data.TokenIssued;
                rest_tokenModel.TokenType = response.Data.TokenType;
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Token is refreshed successfully.";
                ErrorLabel.ForeColor = Color.Green;
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                ErrorLabel.Text = message.developerMessage;
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// The object model (ShipmentModel) needs to be set by the endpoint consumer in order to get a Rate and Save the shipment into ShipCaddie
        /// </summary>
        /// http://res.shipcaddie.com/Help/Api/POST-integration-v1-AddShipment
        /// <Return>The object model (ShipmentModel) needs to be set by the endpoint consumer in order to get a Rate and Save the shipment into ShipCaddieReturns a object of type ShipmentModel with the rate and accessorial charges (when available)</Return>
        public void AddShipment()
        {
            RestClient client = new RestClient(Settings.BASE_URL);
            RestRequest request = new RestRequest("integration/v1/AddShipment", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer.ContentType = "application/json";
            request.AddHeader("Authorization", string.Format("Bearer {0}", rest_tokenModel.AccessToken));
            request.AddBody(CreateShipmentModel());
            var response = client.Execute<List<ShipCaddieApp.Models.ShipmentModelIntegration>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (var item in response.Data)
                {
                    txtShipId.Text = item.ShipmentId.ToString();
                    lbl_LabelMessage.Text = "Message";
                    ErrorLabel.Text = "Shipment Id get successfully.";
                    lblShipmentId.Text = "Please copy and save the shipment id from above textbox.";
                    ErrorLabel.ForeColor = Color.Green;
                }
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                ErrorLabel.Text = message.developerMessage;
                ErrorLabel.ForeColor = Color.Red;
            }
        }
        #endregion

        #region ShipCaddie SOAP or XML API methods. HELP LINK : https://testshipcaddieapi.azurewebsites.net/ShipcaddieAPI.svc

        /// <summary>
        /// Generate a token on the basis of Userame and password
        /// </summary>
        /// <returns>Returns a token list with refresh and access token</returns>
        private ShipCaddieAppXml.TokenModel XMLGetToken()
        {
            ShipCaddieAPIClient client = new ShipCaddieAPIClient();
            var getTokenResposne = client.GetToken(Settings.USER, Settings.USER_PWD);
            // Always close the client.
            client.Close();
            if (getTokenResposne.access_token != null)
            {
                soap_tokenModel.access_token = getTokenResposne.access_token;
                soap_tokenModel.refreshExpires = getTokenResposne.refreshExpires;
                soap_tokenModel.refreshIssued = getTokenResposne.refreshIssued;
                soap_tokenModel.refresh_token = getTokenResposne.refresh_token;
                soap_tokenModel.tokenExpires = getTokenResposne.tokenExpires;
                soap_tokenModel.tokenIssued = getTokenResposne.tokenIssued;
                soap_tokenModel.token_type = getTokenResposne.token_type;
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Token is generated successfully.";
                ErrorLabel.ForeColor = Color.Green;
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Access_Token is empty,please check your username and password.";
                ErrorLabel.ForeColor = Color.Red;
                soap_tokenModel.access_token = null;
            }
            return soap_tokenModel;
        }

        /// <summary>
        /// Get the Client Contarct information i.e, Carrier names
        /// </summary>
        /// <returns>Returns a list of Carrier name</returns>
        private List<ShipCaddieAppXml.ClientInformationModel> XMLGetClientContractInformation()
        {
            List<ShipCaddieAppXml.ClientInformationModel> lst_ClientContract = new List<ShipCaddieAppXml.ClientInformationModel>();
            ShipCaddieAPIClient client = new ShipCaddieAPIClient();
            var getClientContract = client.GetClientContractInformation(soap_tokenModel.access_token);
            // Always close the client.
            client.Close();
            if (getClientContract != null)
            {
                foreach (var item in getClientContract)
                {
                    ShipCaddieAppXml.ClientInformationModel clientContract = new ShipCaddieAppXml.ClientInformationModel();
                    clientContract.affillateName = item.affillateName;
                    clientContract.carrierClientContractId = item.carrierClientContractId;
                    clientContract.carrierName = item.carrierName;
                    clientContract.nickName = item.nickName;
                    clientContract.serviceLevels = item.serviceLevels;
                    lst_ClientContract.Add(clientContract);
                }
                return lst_ClientContract;
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "No client contract information is found or may be not available for this account";
                ErrorLabel.ForeColor = Color.Red;
                return null;
            }
        }

        /// <summary>
        /// To get a list of Service Level
        /// </summary>
        /// <param name="CarrierId">Provide a unique CarrierId</param>
        /// <returns>Returns a Service Level list on the basis of CarrierId</returns>
        private List<ShipCaddieAppXml.Servicelevel> XMLGetClientContractServiceLevel(int CarrierId)
        {
            List<ShipCaddieAppXml.Servicelevel> lst_CIM = new List<ShipCaddieAppXml.Servicelevel>();
            ShipCaddieAPIClient client = new ShipCaddieAPIClient();
            var getClientContract = client.GetClientContractInformation(soap_tokenModel.access_token);
            // Always close the client.
            client.Close();
            if (getClientContract.Length > 0)
            {
                foreach (var item in getClientContract)
                {
                    if (item.carrierClientContractId == CarrierId)
                    {
                        foreach (var item2 in item.serviceLevels)
                        {
                            ShipCaddieAppXml.Servicelevel CIM = new ShipCaddieAppXml.Servicelevel();
                            CIM.carrierServiceLevelId = item2.carrierServiceLevelId;
                            CIM.carrierServiceLevelName = item2.carrierServiceLevelName;
                            CIM.isInternational = item2.isInternational;
                            CIM.packageWeightLimit = item2.packageWeightLimit;
                            lst_CIM.Add(CIM);
                        }
                    }
                }
                return lst_CIM;
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "No Service Level is found.. ";
                ErrorLabel.ForeColor = Color.Red;
                return null;
            }
        }

        /// <summary>
        /// Get the rate of the accessorial charges
        /// </summary>
        private void XMLGetRate()
        {
            ShipCaddieAPIClient client = new ShipCaddieAPIClient();
            var createShipment = XMLCreateShipmentModel();
            var getRates = client.GetRate(soap_tokenModel.access_token, createShipment);
            // Always close the client.
            client.Close();
            if (getRates.packages != null)
            {
                foreach (var package in getRates.packages)
                {
                    dataGridView1.DataSource = package.accessorialCharges.Select(x =>
                    new AccessorialChargeModel
                    {
                        Name = x.name,
                        ChargeAmount = Convert.ToDecimal(x.chargeAmount),
                    }).ToList();
                    ErrorLabel.Text = "Successfully GetRates";
                    ErrorLabel.ForeColor = Color.Green;
                }
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Not retreived any Rates/Rateslist.Ratelist is empty,please check again";
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Thus method generates a shipment label on the basis of Shipment model which consists different fields
        /// </summary>
        private void XMLCreateLabel()
        {
            ShipCaddieAPIClient client = new ShipCaddieAPIClient();
            var createShipment = XMLCreateShipmentModel();
            var getLabel = client.GetLabels(soap_tokenModel.access_token, createShipment);
            // Always close the client.
            client.Close();
            if (getLabel.Length > 0)
            {
                foreach (var item in getLabel)
                {
                    var label = item.dataBlocks.Select(x => x.dataSourceName).FirstOrDefault();
                    txt_Labelkey.Text = item.dataBlocks.Select(x => x.labelKey).FirstOrDefault();
                    lbl_info.Text = "Please copy above Label key and paste in textbox below.";
                    pictureBox1.Image = Base64ToImage(label);
                }
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Successfully get the Label";
                ErrorLabel.ForeColor = Color.Green;
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Something went wrong,please re-check again.";
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// To void the label
        /// </summary>
        /// <param name="labelkey">A unique label key</param>
        /// <returns>Returns a list of tracking number</returns>
        public List<ShipCaddieAppXml.VoidLabelModel> XMLVoidLabel(string labelkey)
        {
            ShipCaddieAPIClient client = new ShipCaddieAPIClient();
            var getLabel = client.VoidLabel(soap_tokenModel.access_token, labelkey);
            // Always close the client.
            client.Close();
            List<ShipCaddieAppXml.VoidLabelModel> lst_shipApp = new List<ShipCaddieAppXml.VoidLabelModel>();
            if (getLabel.Length > 0)
            {
                foreach (var item in getLabel)
                {
                    ShipCaddieAppXml.VoidLabelModel shipApp = new ShipCaddieAppXml.VoidLabelModel();
                    shipApp.TrackingNumberList = item.TrackingNumberList;
                    shipApp.ExtensionData = item.ExtensionData;
                    lst_shipApp.Add(shipApp);
                }
                return lst_shipApp;
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Label cannot be Void. TrackingNumber list is empty";
                ErrorLabel.ForeColor = Color.Red;
                return null;
            }
        }

        /// <summary>
        /// Refresh the existing token on the basis of passing refresh_token
        /// </summary>
        public void XMLRefreshToken()
        {
            ShipCaddieAPIClient client = new ShipCaddieAPIClient();
            var _refreshToken = client.RefreshToken(soap_tokenModel.refresh_token);
            // Always close the client.
            client.Close();
            if (_refreshToken.access_token != null)
            {
                soap_tokenModel.access_token = _refreshToken.access_token;
                soap_tokenModel.ExtensionData = _refreshToken.ExtensionData;
                soap_tokenModel.refresh_token = _refreshToken.refresh_token;
                soap_tokenModel.refreshExpires = _refreshToken.refreshExpires;
                soap_tokenModel.refreshIssued = _refreshToken.refreshIssued;
                soap_tokenModel.token_type = _refreshToken.token_type;
                soap_tokenModel.tokenExpires = _refreshToken.tokenExpires;
                soap_tokenModel.tokenIssued = _refreshToken.tokenIssued;
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "SOAP API :Token is successfully refreshed.";
                ErrorLabel.ForeColor = Color.Green;
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Token not refreshed.Something went wrong, please try again";
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// TO add the Shipment
        /// </summary>
        public void XMLAddShipment()
        {
            ShipCaddieAPIClient client = new ShipCaddieAPIClient();
            var _createXmlShipment = XMLCreateShipmentModel();
            var _refreshToken = client.AddShipment(soap_tokenModel.access_token, _createXmlShipment);
            // Always close the client.
            client.Close();
            if (_refreshToken.shipmentId > 0)
            {
                txtShipId.Text = _refreshToken.shipmentId.ToString();
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Shipment Id get successfully.";
                lblShipmentId.Text = "Please copy and save the shipment id from above textbox.";
                ErrorLabel.ForeColor = Color.Green;
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Something happens wrong. Not get any Shipment Id";
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        #endregion

        #region Main Methods to call JSON or XML on basis of selected value from dropdown

        /// <summary>
        /// Get Token from REST/SOAP API
        /// </summary>
        private void callTokenAPI()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                if (selectedId == 1) //1 JSON
                {
                    GetToken();
                }
                else
                {
                    XMLGetToken();
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Please check the all input fields,all fields will be fill correctly.";
                ErrorLabel.ForeColor = Color.Red;
            }

        }

        /// <summary>
        /// Get Carrier contracts details from REST/SOAP API
        /// </summary>
        private void callClientContractInformation()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                if (selectedId == 1) //1 JSON
                {
                    //Empty the Service Level dropdown
                    List<ShipCaddieApp.Models.ServiceLevelModel> _lstservice = new List<ServiceLevelModel>();
                    ShipCaddieApp.Models.ServiceLevelModel _service = new ServiceLevelModel();
                    _service.CarrierServiceLevelName = "--Select--";
                    _service.CarrierServiceLevelId = 0;
                    _lstservice.Add(_service);
                    ddlServiceLabel.DataSource = _lstservice;
                    ddlServiceLabel.DisplayMember = "CarrierServiceLevelName";
                    ddlServiceLabel.ValueMember = "CarrierServiceLevelId";
                    //

                    ddlCarrierName.DisplayMember = "CarrierName";
                    List<ShipCaddieApp.Models.ClientInformationModel> clientContract = new List<ShipCaddieApp.Models.ClientInformationModel>();
                    ShipCaddieApp.Models.ClientInformationModel contract = new ShipCaddieApp.Models.ClientInformationModel();
                    contract.CarrierClientContractId = 0;
                    contract.CarrierName = "--Select--";
                    clientContract.Add(contract);
                    clientContract.AddRange(GetClientContractInformation());// to get a list of carriers
                    if (clientContract != null)
                    {
                        ddlCarrierName.DataSource = clientContract;
                        ddlCarrierName.DisplayMember = "CarrierName";
                        ddlCarrierName.ValueMember = "CarrierClientContractId";
                    }
                }
                else
                {
                    //Empty the Service Level dropdown
                    List<ShipCaddieAppXml.Servicelevel> _lstservice = new List<Servicelevel>();
                    ShipCaddieAppXml.Servicelevel _service = new Servicelevel();
                    _service.carrierServiceLevelName = "--Select--";
                    _service.carrierServiceLevelId = 0;
                    _lstservice.Add(_service);
                    ddlServiceLabel.DataSource = _lstservice;
                    ddlServiceLabel.DisplayMember = "carrierServiceLevelName";
                    ddlServiceLabel.ValueMember = "carrierServiceLevelId";
                    //

                    ddlCarrierName.DisplayMember = "CarrierName";
                    List<ShipCaddieAppXml.ClientInformationModel> clientContract = new List<ShipCaddieAppXml.ClientInformationModel>();
                    ShipCaddieAppXml.ClientInformationModel contract = new ShipCaddieAppXml.ClientInformationModel();
                    contract.carrierClientContractId = 0;
                    contract.carrierName = "--Select--";
                    clientContract.Add(contract);
                    clientContract.AddRange(XMLGetClientContractInformation());// to get a list of carriers
                    if (clientContract != null)
                    {
                        ddlCarrierName.DataSource = clientContract;
                        ddlCarrierName.DisplayMember = "carrierName";
                        ddlCarrierName.ValueMember = "carrierClientContractId";
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Please check the all input fields,all fields will be fill correctly.";
                ErrorLabel.ForeColor = Color.Red;
                throw ex;
            }
        }

        /// <summary>
        /// Get Service Level on the basis of selected Carrier from REST/SOAP API
        /// </summary>
        /// <param name="carrierID">Unique CarrierID</param>
        /// <returns>Returns a List of Service level</returns>
        private dynamic callGetClientContractServiceLevel(int carrierID)
        {
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                if (selectedId == 1) //1 JSON
                {
                    return GetClientContractInformation(carrierID);
                }
                else
                {
                    return XMLGetClientContractServiceLevel(carrierID);
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Please check the all input fields,all fields will be fill correctly.";
                ErrorLabel.ForeColor = Color.Red;
                throw ex;
            }
        }

        /// <summary>
        /// Get the Rates of different Accessories Charge from REST/SOAP API
        /// </summary>
        private void callGetRates()
        {
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                if (selectedId == 1) //1 JSON
                {
                    GetRate();
                }
                else
                {
                    XMLGetRate();
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Please check the all input fields,all fields will be fill correctly.";
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Get and create a shipment label from REST/SOAP API
        /// </summary>
        private void callCreateLabels()
        {
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                if (selectedId == 1) //1 JSON
                {
                    CreateLabel();
                }
                else
                {
                    XMLCreateLabel();
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Please check the all input fields,all fields will be fill correctly.";
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Void the label on the basis of unique label key via REST/SOAP API
        /// </summary>
        /// <param name="_labelKey">A unique label key get at the time of create label</param>
        /// <returns>Returns a tracking number list</returns>
        private void callVoidLabel(string _labelKey)
        {
            try
            {
                List<CommonVoidModel> lst_CVM = new List<CommonVoidModel>();
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                if (selectedId == 1) //1 JSON
                {
                    VoidLabel(_labelKey);
                }
                else
                {
                    XMLVoidLabel(_labelKey);
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Please check the all input fields,all fields will be fill correctly.";
                ErrorLabel.ForeColor = Color.Red;

            }
        }

        /// <summary>
        /// Refresh the existing access_token, if user wants via REST/SOAP API method
        /// </summary>
        /// <param name="_labelKey">A unique access_token</param>
        /// <returns>Returns a new token list</returns>
        private void callRefreshToken()
        {
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                if (selectedId == 1)
                {
                    RefreshToken();
                }
                else
                {
                    XMLRefreshToken();
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Please try again.";
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// To get the shipment Id
        /// </summary>
        private void callAddShipment()
        {
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                if (selectedId == 1) //JSON
                {
                    AddShipment();
                }
                else
                {
                    XMLAddShipment();
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Unable to generate shipment id.";
                ErrorLabel.ForeColor = Color.Red;
            }
        }


        #endregion

        #endregion

        #region Events/Controls Method

        #region Carrier and Service Level dropdown events
        /// <summary>
        /// TO get a list of service labels on the basis of selected Carrier from carrier list dropdown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <Return>List of Service providers under selected carrier</Return>
        private void ddlCarrierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                var _carrier = ddlCarrierName.SelectedValue as int?;
                if (_carrier > 0)
                {
                    int selectedValueId = Convert.ToInt32(ddlCarrierName.SelectedValue);
                    _carrierClientContractId = selectedValueId;
                    var serviceLevels = callGetClientContractServiceLevel(selectedValueId);
                    if (serviceLevels != null)
                    {
                        ddlServiceLabel.DataSource = serviceLevels;
                        ddlServiceLabel.DisplayMember = "CarrierServiceLevelName";
                        ddlServiceLabel.ValueMember = "CarrierServiceLevelId";
                    }
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message;
                ErrorLabel.ForeColor = Color.Red;
            }
        }
        private void ddlServiceLabel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var _service = ddlServiceLabel.SelectedValue as int?;
            if (_service > 0)
            {
                int selectedCarrierServiceLevelId = Convert.ToInt32(ddlServiceLabel.SelectedValue);
                _carrierServiceLevelId = selectedCarrierServiceLevelId;
            }
        }
        #endregion

        #region Bind Shipment Address Information

        /// <summary>
        /// To display the address pop-up to user on click of 'Add ShipFrom Address' link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <Return>This method returns a shipping from address which is input by user/shipper</Return>
        private void lbShipFrom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _addressWay = "ShipFrom";
            _formatTypeId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
            AddressForm addressForm = new AddressForm();
            addressForm.ShowDialog(); // if you need non-modal window
            if (AddressForm._address.cancel != true)
            {
                lblErrorFrom.Text = "";
                GetAddressDetails();
                txtShipFrom.Text = addressFrom.CustomerId + Environment.NewLine + addressFrom.Organization + Environment.NewLine + addressFrom.Address1 + Environment.NewLine + addressFrom.Address2 + Environment.NewLine + addressFrom.City + Environment.NewLine + addressFrom.State + Environment.NewLine + addressFrom.Zip + Environment.NewLine + addressFrom.CountryName + Environment.NewLine + addressFrom.Phone + Environment.NewLine + addressFrom.Email + Environment.NewLine + addressFrom.IsResident;
            }
            else
            {
                lblErrorFrom.Text = "You need to provide address";
            }
        }

        /// <summary>
        /// To display the address pop-up to user on click of 'Add ShipTo address' link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <Return>Returns a shipping To address which is input by user/shipper</Return>
        private void lbShipTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            _addressWay = "ShipTo";
            _formatTypeId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
            AddressForm addressForm = new AddressForm();
            addressForm.ShowDialog(); // if you need non-modal window
            if (AddressForm._address.cancel != true)
            {
                lblErrorTo.Text = "";
                GetAddressDetails();
                txtShipTo.Text = addressTo.CustomerId + Environment.NewLine + addressTo.Organization + Environment.NewLine + addressTo.Address1 + Environment.NewLine + addressTo.Address2 + Environment.NewLine + addressTo.City + Environment.NewLine + addressTo.State + Environment.NewLine + addressTo.Zip + Environment.NewLine + addressTo.CountryName + Environment.NewLine + addressTo.Phone + Environment.NewLine + addressTo.Email + Environment.NewLine + addressTo.IsResident;
            }
            else
            {
                lblErrorTo.Text = "You need to provide address";
            }
        }

        /// <summary>
        /// To fetch the address(To and From on the basis of 'AddressWay') inputs from the form 2(AddressForm) and assign that values on global level in Form1.
        /// </summary>
        /// <Return></Return>
        #region Shippig Address Details
        private void GetAddressDetails()
        {
            if (AddressForm.AddressWay == "ShipTo")
            {
                addressTo = AddressForm.GetToAddress();
            }
            else
            {
                addressFrom = AddressForm.GetFromAddress();
            }
        }
        #endregion

        #endregion

        #region Shipment Model Method

        /// <summary>
        /// To Get a Shipment related details to pass in ShipCaddie REST API methods where ever it is required..
        /// </summary>
        /// <returns>A Shipment model</returns>
        #region REST API Request Shipment Model
        private ShipCaddieApp.Models.ShipmentModelIntegration CreateShipmentModel()
        {
            ShipCaddieApp.Models.ShipmentModelIntegration shipmentModel = new ShipCaddieApp.Models.ShipmentModelIntegration();
            shipmentModel.Carriers = new System.Collections.Generic.List<CarrierModel>();
            shipmentModel.Carriers.Add(new CarrierModel()
            {
                CarrierClientContractId = _carrierClientContractId,
                CarrierServiceLevelId = _carrierServiceLevelId
            });
            shipmentModel.AddressFrom = new AddressModel()
            {
                AttentionOf = addressFrom.CustomerId,
                CompanyName = addressFrom.Organization,
                Address1 = addressFrom.Address1,
                Address2 = addressFrom.Address2,
                City = addressFrom.City,
                State = addressFrom.State,
                ZipCode = addressFrom.Zip,
                CountryCode = addressFrom.Alfa2Code,
                SystemCountryId = addressFrom.CountryId,
                Email = addressFrom.Email,
                PhoneNumber = addressFrom.Phone,
                IsResidential = addressFrom.IsResident
            };

            shipmentModel.AddressTo = new AddressModel()
            {
                AttentionOf = addressTo.CustomerId,
                CompanyName = addressTo.Organization,
                Address1 = addressTo.Address1,
                Address2 = addressTo.Address2,
                City = addressTo.City,
                State = addressTo.State,
                ZipCode = addressTo.Zip,
                CountryCode = addressTo.Alfa2Code,
                SystemCountryId = addressTo.CountryId,
                Email = addressTo.Email,
                PhoneNumber = addressTo.Phone,
                IsResidential = addressTo.IsResident
            };

            PackageModel package = new PackageModel()
            {
                Dimension = new ShipCaddieApp.Models.Size()
                {
                    Height = Convert.ToInt32(txtHeight.Text), //4
                    Length = Convert.ToInt32(txtLength.Text), //5
                    Width = Convert.ToInt32(txtWidth.Text) //3
                },
                WeightOunces = Convert.ToDecimal(txtOz.Text),
                WeightPounds = Convert.ToDecimal(txtlbs.Text)
            };

            AccessorialChargeModel acc1 = new AccessorialChargeModel()
            {
                Name = chkInsurance.Text,
                Inputs = new List<ShipCaddieApp.Models.Input>()
            };
            acc1.Inputs.Add(new ShipCaddieApp.Models.Input()
            {
                Name = "AMOUNT",
                Value = txtChargeAmount.Text //"125.25"
            });

            if (chkCOD.Checked)
                package.AccessorialCharges.Add(acc1);

            AccessorialChargeModel acc2 = new AccessorialChargeModel()
            {
                Name = chkCOD.Text,
                Inputs = new List<ShipCaddieApp.Models.Input>()
            };
            acc2.Inputs.Add(new ShipCaddieApp.Models.Input()
            {
                Name = "TYPE",
                Value = ddlCOD.Text
            });

            if (chkSign.Checked)
                package.AccessorialCharges.Add(acc2);

            AccessorialChargeModel acc3 = new AccessorialChargeModel()
            {
                Name = chkSign.Text, //"SIGNATURE",
                Inputs = new List<ShipCaddieApp.Models.Input>()
            };
            acc3.Inputs.Add(new ShipCaddieApp.Models.Input()
            {
                Name = "TYPE",
                Value = ddlSign.Text //"SIGNATURE_ADULT"
            });

            if (chkSign.Checked)
                package.AccessorialCharges.Add(acc3);

            shipmentModel.PrintFormat = lblPrintFormat.Text; //"PNG_4x6";

            InventoryModel objInvent = new InventoryModel();
            objInvent.SKU = "SKU-DARIO-III";
            objInvent.Description = "Integration Item 3";
            objInvent.Price = 2;
            objInvent.Quantity = 2;
            objInvent.WeightOunces = 0;
            objInvent.WeightPounds = 2;
            objInvent.Name = "Integration Item 3";
            package.Items.Add(objInvent);
            shipmentModel.Packages.Add(package);
            return shipmentModel;
        }
        #endregion

        /// <summary>
        /// To Get a Shipment related details to pass in ShipCaddie SOAP API methods where ever it is required..
        /// </summary>
        /// <returns>A Shipment model</returns>
        #region SOAP API Request Shipment Model
        private ShipCaddieAppXml.ShipmentModelIntegration XMLCreateShipmentModel()
        {
            ShipCaddieAppXml.ShipmentModelIntegration shipmentModel = new ShipCaddieAppXml.ShipmentModelIntegration();

            ShipCaddieAppXml.Carrier[] carriers = new ShipCaddieAppXml.Carrier[1];
            ShipCaddieAppXml.Carrier carrier = new ShipCaddieAppXml.Carrier();
            carrier.carrierServiceLevelId = _carrierServiceLevelId;
            carrier.carrierClientContractId = _carrierClientContractId;
            carriers[0] = carrier;

            shipmentModel.carriers = carriers;

            shipmentModel.addressFrom = new ShipCaddieAppXml.Addressfrom()
            {
                attentionOf = addressFrom.CustomerId,
                companyName = addressFrom.Organization,
                address1 = addressFrom.Address1,
                address2 = addressFrom.Address2,
                city = addressFrom.City,
                state = addressFrom.State,
                zipCode = addressFrom.Zip,
                countryCode = addressFrom.Alfa2Code,
                systemCountryId = addressFrom.CountryId,
                email = addressFrom.Email,
                phoneNumber = addressFrom.Phone,
                isResidential = addressFrom.IsResident
            };

            shipmentModel.addressTo = new ShipCaddieAppXml.Addressto()
            {
                attentionOf = addressTo.CustomerId,
                companyName = addressTo.Organization,
                address1 = addressTo.Address1,
                address2 = addressTo.Address2,
                city = addressTo.City,
                state = addressTo.State,
                zipCode = addressTo.Zip,
                countryCode = addressTo.Alfa2Code,
                systemCountryId = addressTo.CountryId,
                email = addressTo.Email,
                phoneNumber = addressTo.Phone,
                isResidential = addressTo.IsResident
            };

            ShipCaddieAppXml.Package package = new ShipCaddieAppXml.Package()
             {
                 dimension = new ShipCaddieAppXml.Dimension()
                 {
                     height = Convert.ToInt32(txtHeight.Text), //4
                     length = Convert.ToInt32(txtLength.Text), //5
                     width = Convert.ToInt32(txtWidth.Text) //3
                 },
                 weightOunces = float.Parse(txtOz.Text),
                 weightPounds = float.Parse(txtlbs.Text)
             };

            package.accessorialCharges = new Accessorialcharge[3];

            ShipCaddieAppXml.Accessorialcharge acc1 = new Accessorialcharge()
             {
                 name = chkInsurance.Text,
                 inputs = new List<ShipCaddieAppXml.Input>().ToArray()
             };

            if (chkInsurance.Checked)
            {
                package.accessorialCharges[0] = getArrayInputs("AMOUNT", txtChargeAmount.Text);//AMOUNT
            }

            ShipCaddieAppXml.Accessorialcharge acc2 = new Accessorialcharge()
            {
                name = chkCOD.Text,
                inputs = new List<ShipCaddieAppXml.Input>().ToArray()
            };

            if (chkCOD.Checked)
            {
                package.accessorialCharges[1] = getArrayInputs("TYPE", ddlCOD.Text);//TYPE
            }

            ShipCaddieAppXml.Accessorialcharge acc3 = new Accessorialcharge()
               {
                   name = chkSign.Text, //"SIGNATURE",
                   inputs = new List<ShipCaddieAppXml.Input>().ToArray()
               };

            if (chkSign.Checked)
            {
                package.accessorialCharges[2] = getArrayInputs("TYPE", ddlSign.Text); //"SIGNATURE_ADULT"
            }

            shipmentModel.printFormat = lblPrintFormat.Text; //"PNG_4x6";

            ShipCaddieAppXml.Item objInvent = new Item();
            objInvent.sku = "SKU-DARIO-III";
            objInvent.description = "Integration Item 3";
            objInvent.price = 2;
            objInvent.quantity = 2;
            objInvent.weightOunces = 0;
            objInvent.weightPounds = 2;
            objInvent.name = "Integration Item 3";
            package.items = new Item[1];
            package.items[0] = objInvent;
            shipmentModel.packages = new Package[1];
            shipmentModel.packages[0] = package;
            return shipmentModel;
        }
        private static Accessorialcharge getArrayInputs(string name, dynamic value)
        {

            Accessorialcharge accessorialcharge = new Accessorialcharge();
            ShipCaddieAppXml.Input[] inputs = new ShipCaddieAppXml.Input[1];
            ShipCaddieAppXml.Input input = new ShipCaddieAppXml.Input();
            input.name = name;
            input.value = value;
            inputs[0] = input;
            accessorialcharge.inputs = inputs;
            return accessorialcharge;
        }
        #endregion

        #endregion

        #region Convert base64 to Image
        /// <summary>
        /// To convert a base64 string into image related to shipping label 
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns>A shipment label</returns>
        public Image Base64ToImage(string base64String)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        #endregion

        #region Show and hide text in texboxes(Placeholder showing way is different in Windows form)
        private void txtVoidLabel_Enter(object sender, EventArgs e)
        {
            if (txtVoidLabel.Text == "Paste your Unique labelKey")
            {
                txtVoidLabel.Text = "";
            }
        }
        private void txtVoidLabel_Leave(object sender, EventArgs e)
        {
            if (txtVoidLabel.Text == "")
            {
                txtVoidLabel.Text = "Paste your Unique labelKey";
            }
        }

        private void txtlbs_Enter(object sender, EventArgs e)
        {
            if (txtlbs.Text == "Enter Lbs")
            {
                txtlbs.Text = "";
            }
        }
        private void txtlbs_Leave(object sender, EventArgs e)
        {
            if (txtlbs.Text == "")
            {
                txtlbs.Text = "Enter Lbs";
            }
        }

        private void txtOz_Enter(object sender, EventArgs e)
        {
            if (txtOz.Text == "Enter Oz")
            {
                txtOz.Text = "";
            }
        }
        private void txtOz_Leave(object sender, EventArgs e)
        {
            if (txtOz.Text == "")
            {
                txtOz.Text = "Enter Oz";
            }
        }

        private void txtLength_Enter(object sender, EventArgs e)
        {
            if (txtLength.Text == "Enter Length")
            {
                txtLength.Text = "";
            }
        }
        private void txtLength_Leave(object sender, EventArgs e)
        {
            if (txtLength.Text == "")
            {
                txtLength.Text = "Enter Length";
            }
        }

        private void txtWidth_Enter(object sender, EventArgs e)
        {
            if (txtWidth.Text == "Enter Width")
            {
                txtWidth.Text = "";
            }
        }
        private void txtWidth_Leave(object sender, EventArgs e)
        {
            if (txtWidth.Text == "")
            {
                txtWidth.Text = "Enter Width";
            }
        }

        private void txtHeight_Enter(object sender, EventArgs e)
        {
            if (txtHeight.Text == "Enter Height")
            {
                txtHeight.Text = "";
            }
        }
        private void txtHeight_Leave(object sender, EventArgs e)
        {
            if (txtHeight.Text == "")
            {
                txtHeight.Text = "Enter Height";
            }
        }
        #endregion

        #region Void Label button event
        /// <summary>
        /// To call the Void Label method on click of void label button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoidLabel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var uLabelKey = txtVoidLabel.Text;
            //var succType = VoidLabel(q);
            callVoidLabel(uLabelKey);
        }
        #endregion

        #region Form Load event
        /// <summary>
        /// Form1 Onload method to bind text in respective textboxes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            FormInputPlaceholder();
        }

        private void FormInputPlaceholder()
        {
            Cursor.Current = Cursors.WaitCursor;
            txtVoidLabel.Text = "Paste your Unique labelKey";
            txtlbs.Text = "Enter Lbs";
            txtOz.Text = "Enter Oz";
            txtHeight.Text = "Enter Height";
            txtWidth.Text = "Enter Width";
            txtLength.Text = "Enter Length";
            lbl_LabelMessage.Text = "";
        }
        #endregion

        #region Action REST or SOAP dropdown event
        /// <summary>
        /// This event is call when user changed the value from switch dropdown
        /// </summary>
        bool first = true;
        private void ddlSwitchAPI_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (first == true)
            {
                first = false;
            }
            else
            {
                ErrorLabel.Text = "";
                lblShipmentId.Text = "";
                var _service = Convert.ToInt32(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value) as int?;
                if (_service != null)
                {
                    callTokenAPI();
                    callClientContractInformation();
                }
                Utilities.ResetAllControls(this);
                FormInputPlaceholder();
            }
        }
        #endregion

        #region GetRate button event
        /// <summary>
        /// The object model (ShipmentModel) needs to be set by the endpoint consumer in order to get a Rate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///<result>Returns a object of type ShipmentModel with the rate and accessorial charges (when available)</result> 
        private void lnlblRate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            callGetRates();
        }
        #endregion

        #region Print Label button event
        /// <summary>
        /// Object with the information needed to get the label(s)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <result>This method returns an object with the requested label(s)</result>
        private void lblPrintLabel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            callCreateLabels();
        }
        #endregion

        #region Refresh Token button Event
        private void btnRefreshToken_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            callRefreshToken();
        }
        #endregion

        #region Switch Request(Format type) dropdown values
        /// <summary>
        /// Bind the static values in 'Switch Request' dropdown(JSON or XML)
        /// </summary>
        private void BindFormatType()
        {
            Cursor.Current = Cursors.WaitCursor;
            List<SelectedTypeModel> item = new List<SelectedTypeModel>();
            item.Add(new SelectedTypeModel { Text = "JSON (REST API)", Value = "1" });
            item.Add(new SelectedTypeModel { Text = "XML (SOAP API)", Value = "2" });
            ddlSwitchAPI.DataSource = item;
            ddlSwitchAPI.SelectedIndex = 0;
            var selectedId = ((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value;
        }
        #endregion

        #region Generate token button events
        /// <summary>
        /// Generate a token and bind the contracts in Carrier Name after getting the access_token
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGToken_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            string _usrName = txtUN.Text.ToString();
            string _usrPwd = txtPwd.Text.ToString();
            txtUN.Text = "";
            txtPwd.Text = "";
            if (!string.IsNullOrEmpty(_usrName) && !string.IsNullOrEmpty(_usrPwd))
            {
                Settings.USER = _usrName;
                Settings.USER_PWD = _usrPwd;
                callTokenAPI();
                IsEnabledControls(true);
                callClientContractInformation();
            }
        }
        #endregion

        #region To Enable/Disable controls
        private void IsEnabledControls(bool IsActive)
        {
            lbShipFrom.Enabled = IsActive;
            lbShipTo.Enabled = IsActive;
            btnRefreshToken.Enabled = IsActive;
            lnlblRate.Enabled = IsActive;
            lblPrintLabel.Enabled = IsActive;
            btnVoidLabel.Enabled = IsActive;
            btnShipmentId.Enabled = IsActive;
        }
        #endregion

        #region Shipment Id button event
        private void btnShipmentId_Click(object sender, EventArgs e)
        {
            callAddShipment();
        }
        #endregion

        #endregion
    }
}
