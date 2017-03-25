using Newtonsoft.Json;
using RestSharp;
using ShipCaddieApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Integration.REST_API_Methods
{
    public class RESTMethods
    {
        #region ShipCaddie REST or JSON API methods

        /// <summary>
        /// Get Token when provide a username and password
        /// </summary>
        /// <returns>Get unique token from shipcaddie server </returns>
        public Models.TokenModel GetToken()
        {
            //GET integration/v1/Token?username={username}&password={password} 
            try
            {
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
                    return rest_tokenModel;
                }
                else
                {
                    lbl_LabelMessage.Text = "Message";
                    ErrorLabel.Text = response.Content;
                    ErrorLabel.ForeColor = Color.Red;
                    return null;
                }
            }
            catch (Exception)
            {
                ErrorLabel.Text = "Please check your username and password";
                ErrorLabel.ForeColor = Color.Red;
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Return a list of object with the Client Contract Information Basically return all the Carrier Contracts, and for each carrier contract a list of supported Service levels</returns>
        public List<ShipCaddieApp.Models.ClientInformationModel> GetClientContractInformation()
        {
            //GET integration/v1/GetClientContractInformation
            var type = "";
            try
            {
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
                    ErrorLabel.Text = response.Content;
                    ErrorLabel.ForeColor = Color.Red;
                    return null;
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                var message = JsonConvert.DeserializeObject<Models.Message>(type);
                ErrorLabel.Text = message.developerMessage;
                ErrorLabel.ForeColor = Color.Red;
                return null;
            }
        }

        /// <summary>
        /// To get a list of  objects of service label on the basis of selected carrier
        /// </summary>
        /// <returns>Return the service label by specific CarrierId</returns>
        public List<ServiceLevelModel> GetClientContractInformation(int CarrierId)
        {
            //GET integration/v1/GetClientContractInformation
            var type = "";
            try
            {
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
                    ErrorLabel.Text = response.Content;
                    ErrorLabel.ForeColor = Color.Red;
                    return null;
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                var message = JsonConvert.DeserializeObject<Models.Message>(type);
                ErrorLabel.Text = message.developerMessage;
                ErrorLabel.ForeColor = Color.Red;
                return null;
            }
        }

        public void GetRate()
        {
            var type = "";
            try
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
                        ErrorLabel.Text = "Successfuly GetRates";
                        ErrorLabel.ForeColor = Color.Green;
                    }
                }
                else
                {
                    type = response.Content;
                    var message = JsonConvert.DeserializeObject<Models.Message>(type);
                    lbl_LabelMessage.Text = "Message";
                    ErrorLabel.Text = message.developerMessage;
                    ErrorLabel.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = ex.Message;
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        public void CreateLabel()
        {
            //POST integration/v1/GetLabels
            var type = "";
            try
            {
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
                        var label = item.dataBlocks.Select(x => x.data).FirstOrDefault();
                        txt_Labelkey.Text = item.dataBlocks.Select(x => x.labelKey).FirstOrDefault();
                        lbl_info.Text = "Please copy above Label key and paste in textbox below.";
                        pictureBox1.Image = Base64ToImage(label);
                    }
                    lbl_LabelMessage.Text = "Message";
                    ErrorLabel.Text = "Successfuly GetLabels";
                    ErrorLabel.ForeColor = Color.Green;
                }
                else
                {
                    lbl_LabelMessage.Text = "Message";
                    type = response.Content;
                    var message = JsonConvert.DeserializeObject<Models.Message>(type);
                    ErrorLabel.Text = message.developerMessage;
                    ErrorLabel.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                lbl_LabelMessage.Text = "Message";
                var message = JsonConvert.DeserializeObject<Models.Message>(type);
                ErrorLabel.Text = message.developerMessage;
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// To delete a generated label by passing unique 'labelKey'
        /// </summary>
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
            string message = Convert.ToString(JsonConvert.DeserializeObject<Models.Message>(response.Content));

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (var item in response.Data)
                {
                    ShipCaddieApp.Models.VoidLabelModel voidLabel = new Models.VoidLabelModel();
                    voidLabel.TrackingNumber = item.TrackingNumber;
                    voidLabel.Error = new ApiErrorModel()
                    {
                        Message = message,
                        IsSuccess = true
                    };
                    lst_voidLabel.Add(voidLabel);
                }
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = response.Content;
                ErrorLabel.ForeColor = Color.Red;
                ShipCaddieApp.Models.VoidLabelModel voidLabel = new Models.VoidLabelModel();
                voidLabel.TrackingNumber = null;
                voidLabel.Error = new ApiErrorModel()
                {
                    Message = message,
                    IsSuccess = false
                };
                lst_voidLabel.Add(voidLabel);
            }
            return lst_voidLabel;
        }

        /// <summary>
        /// Return token based on consumer resfresh token. The token is needed to access all endpoints into this integration package.
        /// </summary>
        /// <Return>Returns a token and refresh token</Return>
        public void RefreshToken(string refreshToken)
        {
            //GET integration/v1/RefreshToken?refreshToken={refreshToken}
            var _refreshToken = "f875112055794392909dd1a8aae24d75";
            RestClient client = new RestClient(Settings.BASE_URL);
            RestRequest request = new RestRequest("integration/v1/RefreshToken?refreshToken=" + _refreshToken, Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer.ContentType = "application/json";
            var response = client.Execute<ShipCaddieApp.Models.TokenModel>(request);
        }

        /// <summary>
        /// The object model (ShipmentModel) needs to be set by the endpoint consumer in order to get a Rate and Save the shipment into ShipCaddie
        /// </summary>
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
        }
        #endregion
    }
}
