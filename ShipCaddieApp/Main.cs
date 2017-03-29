using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers;
using ShipCaddieApp.Models;
using ShipCaddieApp.ShipCaddieAppXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ShipCaddieApp
{
    public partial class Main : Form
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

        #region Form(Main) constructor

        /// <summary>
        /// It is a Constructor of Form1 which call first when the Form1 is loaded.
        /// </summary>
        public Main()
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

        #region API Call

        #region ShipCaddie REST or JSON API methods. HELP LINK: http://YourcallbackURL/help#Integration

        /// <summary>
        /// Get Token when provide a username and password
        /// </summary>
        /// Method Help Link : http://YourCallbackURL/Help/Api/GET-integration-v1-Token_username_password
        /// <returns>Get unique token from shipcaddie server </returns>
        private Models.TokenModel GetToken()
        {
            //GET integration/v1/Token?username={username}&password={password}
            Cursor.Current = Cursors.WaitCursor;
            int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
            try
            {
                if (!string.IsNullOrEmpty(Settings.USER) && !string.IsNullOrEmpty(Settings.USER_PWD))
                {
                    RestClient client = new RestClient(Settings.BASE_URL);
                    RestRequest request = new RestRequest("integration/v1/Token?username=" + Settings.USER + "&password=" + Settings.USER_PWD, Method.GET);
                    if (selectedId == 1)
                    {
                        request.RequestFormat = DataFormat.Json;
                        request.JsonSerializer.ContentType = "application/json";
                    }
                    else
                    {
                        request.RequestFormat = DataFormat.Xml;
                        request.AddHeader("Accept", "application/xml,text/plain,*/*");
                        request.XmlSerializer.ContentType = "application/xml";
                    }
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
                        txtGToken.Text = response.Data.AccessToken; //Bind the access_token in token textbox
                        txtRefToken.Text = response.Data.RefreshToken; // Bind the refresh token in refresh token textbox
                        lbl_LabelMessage.Text = "Message: ";
                        ErrorLabel.Text = "Token is generated successfully";
                        ErrorLabel.ForeColor = Color.Green;
                        return rest_tokenModel;
                    }
                    else
                    {
                        lbl_LabelMessage.Text = "Message: ";
                        var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                        ErrorLabel.Text = message.developerMessage;
                        ErrorLabel.ForeColor = Color.Red;
                        return null;
                    }
                }
                else
                {
                    lbl_LabelMessage.Text = "Message: ";
                    ErrorLabel.Text = "Username/Password cannot be empty.Please check and try it again";
                    ErrorLabel.ForeColor = Color.Red;
                    soap_tokenModel.access_token = null;
                    return null;
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Please check the all input fields,all fields will be fill correctly.";
                ErrorLabel.ForeColor = Color.Red;
                return null;
            }

        }

        /// <summary>
        /// To get the Carrier contracts
        /// </summary>
        /// Method Help Link : http://YourCallbackURL/Help/Api/GET-integration-v1-GetClientContractInformation
        /// <returns>Return a list of object with the Client Contract Information Basically return all the Carrier Contracts, and for each carrier contract a list of supported Service levels</returns>
        private List<ShipCaddieApp.Models.ClientInformationModel> GetClientContractInformation()
        {
            //GET integration/v1/GetClientContractInformation
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                List<ShipCaddieApp.Models.ClientInformationModel> lst_CIM = new List<ShipCaddieApp.Models.ClientInformationModel>();
                RestClient client = new RestClient(Settings.BASE_URL);
                RestRequest request = new RestRequest("integration/v1/GetClientContractInformation", Method.GET);
                if (selectedId == 1)
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
                    lbl_LabelMessage.Text = "Message: ";
                    var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                    ErrorLabel.Text = message.developerMessage;
                    ErrorLabel.ForeColor = Color.Red;
                    return null;
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Please check the all input fields,all fields will be fill correctly.";
                ErrorLabel.ForeColor = Color.Red;
                return null;
            }
        }

        /// <summary>
        /// To get a list of  objects of service label on the basis of selected carrier
        /// </summary>
        /// Method Help Link : http://YourCallbackURL/Help/Api/GET-integration-v1-GetClientContractInformation
        /// <returns>Return the service label by specific CarrierId</returns>
        private List<ServiceLevelModel> GetClientContractInformation(int CarrierId)
        {
            //GET integration/v1/GetClientContractInformation
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                List<ServiceLevelModel> lst_CIM = new List<ServiceLevelModel>();
                RestClient client = new RestClient(Settings.BASE_URL);
                RestRequest request = new RestRequest("integration/v1/GetClientContractInformation", Method.GET);
                if (selectedId == 1) //1 JSON
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
                    lbl_LabelMessage.Text = "Message: ";
                    var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                    ErrorLabel.Text = message.developerMessage;
                    ErrorLabel.ForeColor = Color.Red;
                    return null;
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
        /// Get rates
        /// </summary>
        /// Method Help Link: http://YourCallbackURL/Help/Api/POST-integration-v1-GetRate
        private void GetRate()
        {
            // POST integration/v1/GetRate
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                RestClient client = new RestClient(Settings.BASE_URL);
                RestRequest request = new RestRequest("integration/v1/GetRate", Method.POST);
                if (selectedId == 1) //1 JSON
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
                        lbl_LabelMessage.Text = "Message: ";
                        ErrorLabel.Text = "Get the rates successfully.";
                        ErrorLabel.ForeColor = Color.Green;
                    }
                }
                else
                {
                    var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                    lbl_LabelMessage.Text = "Message: ";
                    ErrorLabel.Text = message.developerMessage;
                    ErrorLabel.ForeColor = Color.Red;
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
        /// To create and get a Shipment label
        /// </summary>
        /// Method Help Link: http://YourCallbackURL/Help/Api/POST-integration-v1-GetLabels
        private void CreateLabel()
        {
            //POST integration/v1/GetLabels
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                RestClient client = new RestClient(Settings.BASE_URL);
                RestRequest request = new RestRequest("integration/v1/GetLabels", Method.POST);
                if (selectedId == 1) //1 JSON
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

                request.AddHeader("Authorization", string.Format("Bearer {0}", rest_tokenModel.AccessToken));
                request.AddBody(CreateShipmentModel());
                var response = client.Execute<List<RootObject>>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    foreach (var item in response.Data)
                    {
                        if (item.printJobs != null)
                        {
                            txtTrackingBox.Text = item.shipmentId;
                            foreach (var item2 in item.printJobs)
                            {
                                var label = item2.dataBlocks.Select(x => x.data).FirstOrDefault();
                                txtGVoidLabel.Text = item2.dataBlocks.Select(x => x.labelKey).FirstOrDefault();
                                pictureBox1.Image = Base64ToImage(label);
                                lbl_LabelMessage.Text = "Message: ";
                                ErrorLabel.Text = "Successfully GetLabels";
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
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Please check the all input fields,all fields will be fill correctly.";
                ErrorLabel.ForeColor = Color.Red;
            }

        }

        /// <summary>
        /// To delete a generated label by passing unique 'labelKey'
        /// </summary>
        /// Method Help Link: http://YourCallbackURL/Help/Api/POST-integration-v1-VoidLabel_labelKey
        /// <Return>Returns a keyValue</Return>
        /// <Return Params>TrackingNumber: The tracking number of the package</Return>
        public List<ShipCaddieApp.Models.VoidLabelModel> VoidLabel(string labelkey)
        {
            //POST integration/v1/VoidLabel?labelKey={labelKey}
            try
            {
                List<ShipCaddieApp.Models.VoidLabelModel> lst_voidLabel = new List<Models.VoidLabelModel>();
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);

                RestClient client = new RestClient(Settings.BASE_URL);
                RestRequest request = new RestRequest("integration/v1/VoidLabel?labelKey={labelKey}", Method.POST);
                if (selectedId == 1) //1 JSON
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
                        txtTrackingNo.Text = item.TrackingNumber;
                        lblTrackingNo.Text = "Please copy and save above Tracking Number";
                        lbl_LabelMessage.Text = "Message: ";
                        ErrorLabel.Text = "Successfully get the Tracking number.";
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
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Please check the all input fields,all fields will be fill correctly.";
                ErrorLabel.ForeColor = Color.Red;
                throw ex;
            }
        }

        /// <summary>
        /// Return token based on consumer resfresh token. The token is needed to access all endpoints into this integration package.
        /// </summary>
        /// Method Help Link: http://YourCallbackURL/Help/Api/GET-integration-v1-RefreshToken_refreshToken
        /// <Return>Returns a token and refresh token</Return>
        public void RefreshToken()
        {
            //GET integration/v1/RefreshToken?refreshToken={refreshToken}
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                RestClient client = new RestClient(Settings.BASE_URL);
                RestRequest request = new RestRequest("integration/v1/RefreshToken?refreshToken=" + rest_tokenModel.RefreshToken, Method.GET);
                if (selectedId == 1)
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
                    lbl_LabelMessage.Text = "Message: ";
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
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Please try again.";
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// The object model (ShipmentModel) needs to be set by the endpoint consumer in order to get a Rate and Save the shipment into ShipCaddie
        /// </summary>
        /// Method Help Link: http://YourCallbackURL/Help/Api/POST-integration-v1-AddShipment
        /// <Return>The object model (ShipmentModel) needs to be set by the endpoint consumer in order to get a Rate and Save the shipment into ShipCaddieReturns a object of type ShipmentModel with the rate and accessorial charges (when available)</Return>
        public void AddShipment()
        {
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                RestClient client = new RestClient(Settings.BASE_URL);
                RestRequest request = new RestRequest("integration/v1/AddShipment", Method.POST);

                if (selectedId == 1) //JSON
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
                request.AddHeader("Authorization", string.Format("Bearer {0}", rest_tokenModel.AccessToken));
                request.AddBody(CreateShipmentModel());
                var response = client.Execute<List<ShipCaddieApp.Models.ShipmentModelIntegration>>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    foreach (var item in response.Data)
                    {
                        txtShipId.Text = item.ShipmentId.ToString();
                        lbl_LabelMessage.Text = "Message: ";
                        ErrorLabel.Text = "Get Shipment Id successfully.";
                        lblShipmentId.Text = "Please copy and save shipment id from above textbox.";
                        ErrorLabel.ForeColor = Color.Green;
                    }
                }
                else
                {
                    lbl_LabelMessage.Text = "Message: ";
                    var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                    ErrorLabel.Text = message.developerMessage;
                    ErrorLabel.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message + ".Unable to generate shipment id.";
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// TO get the shipment details
        /// </summary>
        /// Method Help Link: https://YourCallbackURL/Help/Api/GET-integration-v1-GetShipmentInfo_shipmentId
        /// <param name="_shipmentId">A unique shipment id</param>
        public void GetShipmentInfo(int _shipmentId)
        {
            //GET integration/v1/GetShipmentInfo?shipmentId={shipmentId}
            try
            {
                int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
                RestClient client = new RestClient(Settings.BASE_URL);
                RestRequest request = new RestRequest("integration/v1/GetShipmentInfo?shipmentId={shipmentId}", Method.GET);
                if (selectedId == 1) //JSON
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
                request.AddHeader("Authorization", string.Format("Bearer {0}", rest_tokenModel.AccessToken));
                request.AddParameter("shipmentId", _shipmentId, ParameterType.UrlSegment);
                var response = client.Execute<List<ShipCaddieApp.Models.ShipmentInfoModel.RootObject>>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    foreach (var item in response.Data)
                    {
                        if (item.labelList != null)
                        {
                            foreach (var item2 in item.labelList)
                            {
                                pictureBox2.Image = Base64ToImage(item2.labelData);
                                txtTrack.Text = item2.trackingNumber; //Get tracking number after call GetShipmentInfo method
                                lbl2TrackNo.Text = "Please save Tracking Number for future reference.";
                            }
                        }
                        else
                        {
                            lbl_LabelMessage.Text = "Message: ";
                            ErrorLabel.Text = "Not retreived any data related to shipment id. Please contact to app administartor.";
                            ErrorLabel.ForeColor = Color.Red;
                        }
                    }
                }
                else
                {
                    lbl_LabelMessage.Text = "Message: ";
                    var message = JsonConvert.DeserializeObject<Models.Message>(response.Content);
                    ErrorLabel.Text = message.developerMessage;
                    ErrorLabel.ForeColor = Color.Red;
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

        #region Generate token button events
        /// <summary>
        /// Generate a token and bind the contracts in Carrier Name after getting the access_token
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetToken_Click(object sender, EventArgs e)
        {
            EmptyHeaderMsg();
            Cursor.Current = Cursors.WaitCursor;
            Settings.BASE_URL = txtAPIUrl.Text;
            string _usrName = txtUN.Text.ToString();
            string _usrPwd = txtPwd.Text.ToString();
            txtUN.Text = "";
            txtPwd.Text = "";
            if (!string.IsNullOrEmpty(_usrName) && !string.IsNullOrEmpty(_usrPwd))
            {
                Settings.USER = _usrName;
                Settings.USER_PWD = _usrPwd;
                var getResposne = GetToken();
                if (getResposne != null)
                {
                    IsEnabledControls(true);
                    callClientContractInformation();
                }
            }
        }
        #endregion

        #region Convert base64 to Image
        /// <summary>
        /// To convert a base64 string into image related to shipping label 
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns>A shipment label</returns>
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
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
            item.Add(new SelectedTypeModel { Text = "JSON Request", Value = "1" });
            item.Add(new SelectedTypeModel { Text = "XML Request", Value = "2" });
            ddlSwitchAPI.DataSource = item;
            ddlSwitchAPI.SelectedIndex = 0;
            var selectedId = ((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value;
        }
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

        #endregion

        #region To Enable/Disable controls
        private void IsEnabledControls(bool IsActive)
        {
            lbShipFrom.Enabled = IsActive;
            lbShipTo.Enabled = IsActive;
            btnRefreshToken.Enabled = IsActive;
            lnlblRate.Enabled = IsActive;
            btnPrintLabel.Enabled = IsActive;
            btnVoidLabel.Enabled = IsActive;
            btnShipmentId.Enabled = IsActive;
            btnRefreshToken.Enabled = IsActive;
        }
        #endregion

        #region Change Switch dropdown value event to REST or SOAP
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
                //var _service = Convert.ToInt32(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value) as int?;
                //if (_service != null)
                //{
                //    var getResposne = GetToken();
                //    if (getResposne != null)
                //    {
                //        callClientContractInformation();
                //    }
                //}
                //Utilities.ResetAllControls(this);
                //FormInputPlaceholder();
            }
        }
        #endregion

        #region Form Load event
        /// <summary>
        /// Form1 Onload method to bind text in respective textboxes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FormInputPlaceholder();
        }

        private void FormInputPlaceholder()
        {
            Cursor.Current = Cursors.WaitCursor;
            txtGVoidLabel.Text = "Unique Label Key";
            txtTrackingNo.Text = "Tracking Number";
            txtlbs.Text = "Enter Lbs";
            txtOz.Text = "Enter Oz";
            txtHeight.Text = "Enter Height";
            txtWidth.Text = "Enter Width";
            txtLength.Text = "Enter Length";
            EmptyHeaderMsg();
        }

        private void EmptyHeaderMsg()
        {
            lbl_LabelMessage.Text = "";
            ErrorLabel.Text = "";
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
            EmptyHeaderMsg();
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
            EmptyHeaderMsg();
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
            var _carrier = ddlCarrierName.SelectedValue as int?;
            if (_carrier > 0)
            {
                int selectedValueId = Convert.ToInt32(ddlCarrierName.SelectedValue);
                _carrierClientContractId = selectedValueId;
                var serviceLevels = GetClientContractInformation(selectedValueId);
                if (serviceLevels != null)
                {
                    ddlServiceLabel.DataSource = serviceLevels;
                    ddlServiceLabel.DisplayMember = "CarrierServiceLevelName";
                    ddlServiceLabel.ValueMember = "CarrierServiceLevelId";
                }
            }
        }

        /// <summary>
        /// Get Carrier contracts details from REST/SOAP API
        /// </summary>
        private void callClientContractInformation()
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

        #region GetRate button event
        /// <summary>
        /// The object model (ShipmentModel) needs to be set by the endpoint consumer in order to get a Rate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///<result>Returns a object of type ShipmentModel with the rate and accessorial charges (when available)</result> 
        private void lnlblRate_Click(object sender, EventArgs e)
        {
            EmptyHeaderMsg();
            Cursor.Current = Cursors.WaitCursor;
            GetRate();
        }

        #endregion

        #region Print Label button event
        /// <summary>
        /// Object with the information needed to get the label(s)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <result>This method returns an object with the requested label(s)</result>
        private void btnPrintLabel_Click(object sender, EventArgs e)
        {
            EmptyHeaderMsg();
            Cursor.Current = Cursors.WaitCursor;
            CreateLabel();
        }
        #endregion

        #region Shipment Id button event
        private void btnShipmentId_Click(object sender, EventArgs e)
        {
            EmptyHeaderMsg();
            Cursor.Current = Cursors.WaitCursor;
            AddShipment();
        }
        #endregion

        #region Show and hide text in texboxes(Placeholder showing way is different in Windows form)

        private void txtlbs_Enter(object sender, EventArgs e)
        {
            if (txtlbs.Text == "Enter Lbs") { txtlbs.Text = ""; }
        }
        private void txtlbs_Leave(object sender, EventArgs e)
        {
            if (txtlbs.Text == "") { txtlbs.Text = "Enter Lbs"; }
        }

        private void txtOz_Enter(object sender, EventArgs e)
        {
            if (txtOz.Text == "Enter Oz") { txtOz.Text = ""; }
        }
        private void txtOz_Leave(object sender, EventArgs e)
        {
            if (txtOz.Text == "") { txtOz.Text = "Enter Oz"; }
        }

        private void txtLength_Enter(object sender, EventArgs e)
        {
            if (txtLength.Text == "Enter Length") { txtLength.Text = ""; }
        }
        private void txtLength_Leave(object sender, EventArgs e)
        {
            if (txtLength.Text == "") { txtLength.Text = "Enter Length"; }
        }

        private void txtWidth_Enter(object sender, EventArgs e)
        {
            if (txtWidth.Text == "Enter Width") { txtWidth.Text = ""; }
        }
        private void txtWidth_Leave(object sender, EventArgs e)
        {
            if (txtWidth.Text == "") { txtWidth.Text = "Enter Width"; }
        }

        private void txtHeight_Enter(object sender, EventArgs e)
        {
            if (txtHeight.Text == "Enter Height") { txtHeight.Text = ""; }
        }
        private void txtHeight_Leave(object sender, EventArgs e)
        {
            if (txtHeight.Text == "") { txtHeight.Text = "Enter Height"; }
        }

        private void txtGVoidLabel_Enter(object sender, EventArgs e)
        {
            if (txtGVoidLabel.Text == "Unique Label Key") { txtGVoidLabel.Text = ""; }
        }
        private void txtGVoidLabel_Leave(object sender, EventArgs e)
        {
            if (txtGVoidLabel.Text == "") { txtGVoidLabel.Text = "Unique Label Key"; }
        }

        private void txtTrackingNo_Enter(object sender, EventArgs e)
        {
            if (txtTrackingNo.Text == "Tracking Number") { txtTrackingNo.Text = ""; }
        }
        private void txtTrackingNo_Leave(object sender, EventArgs e)
        {
            if (txtTrackingNo.Text == "") { txtTrackingNo.Text = "Tracking Number"; }
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
            EmptyHeaderMsg();
            Cursor.Current = Cursors.WaitCursor;
            var uLabelKey = txtGVoidLabel.Text;
            //var succType = VoidLabel(q);
            VoidLabel(uLabelKey);
        }

        #endregion

        #region Get Shipment Info button event to get the shipment details

        private void btnGetShipment_Click(object sender, EventArgs e)
        {
            EmptyHeaderMsg();
            Cursor.Current = Cursors.WaitCursor;
            GetShipmentInfo(Convert.ToInt32(txtTrackingBox.Text));
        }

        #endregion

        #region Refresh Token button Event
        private void btnRefreshToken_Click(object sender, EventArgs e)
        {
            EmptyHeaderMsg();
            Cursor.Current = Cursors.WaitCursor;
            RefreshToken();
        }
        #endregion

        private void tabShipInfo_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
