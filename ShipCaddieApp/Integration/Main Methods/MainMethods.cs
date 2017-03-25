using ShipCaddieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCaddieApp.Integration.Main_Methods
{
    public class MainMethods
    {

        #region Main Methods to call JSON or XML on basis of selected value from dropdown

        public void callTokenAPI()
        {
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
            { }

        }

        public void callClientContractInformation()
        {
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
                throw ex;
            }
        }

        public dynamic callGetClientContractServiceLevel(int carrierID)
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
                throw ex;
            }
        }

        public void callGetRates()
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

        public void callCreateLabels()
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

        public List<CommonVoidModel> callVoidLabel(string _labelKey)
        {
            List<CommonVoidModel> lst_CVM = new List<CommonVoidModel>();
            int selectedId = Convert.ToInt16(((SelectedTypeModel)ddlSwitchAPI.SelectedItem).Value);
            if (selectedId == 1) //1 JSON
            {
                var _voidLabel = VoidLabel(_labelKey);
                foreach (var item in _voidLabel)
                {
                    CommonVoidModel CVM = new CommonVoidModel();
                    CVM.TrackingNumber = item.TrackingNumber;
                    CVM.Error = item.Error.Message;
                    CVM.IsSuccess = item.Error.IsSuccess;
                    lst_CVM.Add(CVM);
                }
            }
            else
            {
                var _xmlVoidLabel = XMLVoidLabel(_labelKey);

                for (int i = 0; i < _xmlVoidLabel.Count; i++)
                {
                    for (int j = 0; j < _xmlVoidLabel[i].TrackingNumberList.Length; j++)
                    {
                        CommonVoidModel CVM = new CommonVoidModel();
                        CVM.TrackingNumber = _xmlVoidLabel[i].TrackingNumberList[j].trackingNumber;
                        lst_CVM.Add(CVM);
                    }
                }
            }
            return lst_CVM;
        }

        #endregion


    }
}
