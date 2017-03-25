using ShipCaddieApp.ShipCaddieAppXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Integration.SOAP_API_Methods
{
    public class SOAPMethods
    {
        #region ShipCaddie SOAP or XML API methods

        public ShipCaddieAppXml.TokenModel XMLGetToken()
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
            }
            else
            {
                soap_tokenModel.access_token = null;
            }
            return soap_tokenModel;
        }

        public List<ShipCaddieAppXml.ClientInformationModel> XMLGetClientContractInformation()
        {
            List<ShipCaddieAppXml.ClientInformationModel> lst_ClientContract = new List<ShipCaddieAppXml.ClientInformationModel>();
            try
            {
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
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ShipCaddieAppXml.Servicelevel> XMLGetClientContractServiceLevel(int CarrierId)
        {
            try
            {
                List<ShipCaddieAppXml.Servicelevel> lst_CIM = new List<ShipCaddieAppXml.Servicelevel>();
                ShipCaddieAPIClient client = new ShipCaddieAPIClient();
                var getClientContract = client.GetClientContractInformation(soap_tokenModel.access_token);
                // Always close the client.
                client.Close();
                if (getClientContract != null)
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
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void XMLGetRate()
        {
            ShipCaddieAPIClient client = new ShipCaddieAPIClient();
            var createShipment = XMLCreateShipmentModel();
            var getRates = client.GetRate(soap_tokenModel.access_token, createShipment);
            // Always close the client.
            client.Close();
            if (getRates != null)
            {
                foreach (var package in getRates.packages)
                {
                    dataGridView1.DataSource = package.accessorialCharges.Select(x =>
                    new AccessorialChargeModel
                    {
                        Name = x.name,
                        ChargeAmount = Convert.ToDecimal(x.chargeAmount),
                    }).ToList();
                    ErrorLabel.Text = "Successfuly GetRates";
                    ErrorLabel.ForeColor = Color.Green;
                }
            }
            else
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Something is wrong";
                ErrorLabel.ForeColor = Color.Red;
            }
        }

        public void XMLCreateLabel()
        {
            ShipCaddieAPIClient client = new ShipCaddieAPIClient();
            var createShipment = XMLCreateShipmentModel();
            var getLabel = client.GetLabels(soap_tokenModel.access_token, createShipment);
            // Always close the client.
            client.Close();
            if (getLabel != null)
            {
                foreach (var item in getLabel)
                {
                    var label = item.dataBlocks.Select(x => x.dataSourceName).FirstOrDefault();
                    txt_Labelkey.Text = item.dataBlocks.Select(x => x.labelKey).FirstOrDefault();
                    lbl_info.Text = "Please copy above Label key and paste in textbox below.";
                    pictureBox1.Image = Base64ToImage(label);
                }
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Successfuly GetLabels";
                ErrorLabel.ForeColor = Color.Green;
            }
            {
                lbl_LabelMessage.Text = "Message";
                ErrorLabel.Text = "Something is Wrong, Please recheck again";
                ErrorLabel.ForeColor = Color.Red;
            }
        }

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
            }
            else
            {
                ShipCaddieAppXml.VoidLabelModel shipApp = new ShipCaddieAppXml.VoidLabelModel();
                shipApp.TrackingNumberList = null;
                shipApp.ExtensionData = null;
                lst_shipApp.Add(shipApp);
            }
            return lst_shipApp;
        }

        public void XMLRefreshToken(string refreshToken)
        {
            ShipCaddieAPIClient client = new ShipCaddieAPIClient();
            var _refreshToken = client.RefreshToken(soap_tokenModel.access_token);
            // Always close the client.
            client.Close();
            soap_tokenModel.access_token = _refreshToken.access_token;
            soap_tokenModel.ExtensionData = _refreshToken.ExtensionData;
            soap_tokenModel.refresh_token = _refreshToken.refresh_token;
            soap_tokenModel.refreshExpires = _refreshToken.refreshExpires;
            soap_tokenModel.refreshIssued = _refreshToken.refreshIssued;
            soap_tokenModel.token_type = _refreshToken.token_type;
            soap_tokenModel.tokenExpires = _refreshToken.tokenExpires;
            soap_tokenModel.tokenIssued = _refreshToken.tokenIssued;
        }

        public void XMLAddShipment()
        {
            ShipCaddieAPIClient client = new ShipCaddieAPIClient();
            var _createXmlShipment = XMLCreateShipmentModel();
            var _refreshToken = client.AddShipment(soap_tokenModel.access_token, _createXmlShipment);
            // Always close the client.
            client.Close();
        }

        #endregion
    }
}
