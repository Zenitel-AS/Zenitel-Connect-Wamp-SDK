using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LogManager;
using Wamp.Client;
using static Wamp.Client.WampClient;

namespace Zenitel.Connect.Wamp.Sdk
{
    public partial class ZenitelConnectWampGui : Form
    {

        private WampClient wampClient;
        private LoggingWindow loggingWindow = null;

        private string Zenitel_Connect_Wamp_SDK_Version = System.Diagnostics.FileVersionInfo.GetVersionInfo(
                                      System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;
        private string SW_Version;
        private string LogFilePath;
        private string LogFileName;


        /***********************************************************************************************************************/
        public ZenitelConnectWampGui()
        /***********************************************************************************************************************/
        {
            InitializeComponent();

            SW_Version = "Zenitel Connect WAMP SDK version " + Zenitel_Connect_Wamp_SDK_Version;
            this.Text = SW_Version;

            LogFilePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) +
                                 "\\Zenitel\\Zenitel_Connect_Wamp_SDK\\Log";

            LogFileName = "Zenitel_Connect_Wamp_";
            LogMan.Instance.CreateLog(true, 30, LogFilePath, LogFileName);
            addToLog(SW_Version);

            lblLogFileSavingLocation.Text = "Location: " + LogFilePath;


            wampClient = new WampClient();
            wampClient.OnConnectChanged += WampConnection_OnConnectChanged;
            wampClient.OnError += WampConnection_OnError;
            wampClient.OnChildLogString += _wampConnection_OnChildLogString;

            wampClient.OnWampCallStatusEvent += wampClient_OnWampCallStatusEvent;
            wampClient.OnWampCallLegStatusEvent += wampClient_OnWampCallLegStatusEvent;
            wampClient.OnWampDeviceRegistrationEvent += wampClient_OnWampDeviceRegistrationEvent;
            wampClient.OnWampOpenDoorEvent += wampClient_OnWampOpenDoorEvent;
            wampClient.OnWampDeviceGPIStatusEvent += wampClient_OnWampDeviceGPIStatusEvent;
            wampClient.OnWampDeviceGPOStatusEvent += wampClient_OnWampDeviceGPOStatusEvent;

            UpdateConnectState();

            chbxEncrypted.Checked = true;
            chbxUnencrypted.Checked = false;

            cmbxCallAction.Items.Add(WampClient.CallAction.setup.ToString());
            cmbxCallAction.Items.Add(WampClient.CallAction.answer.ToString());

            cmbxCallAction.SelectedIndex = 0;
        }


        #region  ----------  Button Handling Methods  ----------


        /***********************************************************************************************************************/
        /********************                              Authentication                                       ****************/
        /***********************************************************************************************************************/

        /***********************************************************************************************************************/
        private void btnWampConnect_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            addToLog("WAMP connect button activated");

            if (wampClient.IsConnected)
            {
                MessageBox.Show("WAMP already connected.");
            }
            else
            {
                wampClient.WampServerAddr = edtWAMPServerAddr.Text;
                wampClient.UserName = edtUserName.Text;
                wampClient.Password = edtPassword.Text;


                if (chbxUnencrypted.Checked)
                {
                    wampClient.WampPort = WampClient.WampUnencryptedPort;
                }
                else
                {
                    wampClient.WampPort = WampClient.WampEncryptedPort;
                }

                wampClient.WampRealm = edtWampRealm.Text;

                wampClient.Start();
            }
        }


        /***********************************************************************************************************************/
        private void btnWampDisconnect_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            wampClient.Stop();
            tbxConnectionStatus.Text = "Disconnected";
        }


        /***********************************************************************************************************************/
        /**********************                              System                                           ******************/
        /***********************************************************************************************************************/


        /***********************************************************************************************************************/
        private void btnGETDevicesRegistered_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    List<WampClient.wamp_device_registration_element> devices;
                    devices = wampClient.requestRegisteredDevices();

                    if (devices != null)
                    {
                        string txt = "SDK. Registered Devices:";
                        addToLog(txt);
                        foreach (WampClient.wamp_device_registration_element dev in devices)
                        {
                            txt = ("IP-Address: " + dev.device_ip + ". Device-type: " + dev.device_type + ". Dir-no: " + dev.dirno +
                                   ". Location: " + dev.location + ". Name: " + dev.name + ". Status: " + dev.state);
                            addToLog(txt);
                        }

                        dgrd_Registrations.Rows.Clear();

                        foreach (WampClient.wamp_device_registration_element dev in devices)
                        {
                            string[] row = { dev.device_ip, dev.device_type, dev.dirno, dev.name, dev.location, dev.state };

                            dgrd_Registrations.Rows.Add(row);
                        }
                    }
                    else
                    {
                        addToLog("No Devices Registered.");
                    }
                }
                else
                {
                    MessageBox.Show("WAMP is NOT connected.");
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in btnGETDevicesRegistered_Click: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void btnGETNetInterfaces_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    List<WampClient.wamp_interface_list> interfaceList;
                    interfaceList = wampClient.requestInterfaceList();

                    if (interfaceList != null)
                    {
                        dgrdNetInterfaces.Rows.Clear();

                        string txt = "SDK. Interface List:";
                        addToLog(txt);
                        foreach (WampClient.wamp_interface_list intf in interfaceList)
                        {
                            txt = ("MAC-Addr: " + intf.address + ". IF-Name: " + intf.ifname + ". OperState: " + intf.operstate);
                            addToLog(txt);

                            // Insert new interface element
                            string[] row = { intf.address, intf.ifname, intf.operstate };
                            dgrdNetInterfaces.Rows.Add(row);

                        }
                    }
                    else
                    {
                        addToLog("No Interfaces Available.");
                    }
                }
                else
                {
                    MessageBox.Show("WAMP is NOT connected.");
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in btnbtnGETNetInterfaces_Click: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        /**********************                            Call Handling                                      ******************/
        /***********************************************************************************************************************/


        /***********************************************************************************************************************/
        private void btnGetCalls_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    List<WampClient.wamp_call_element> callList;
                    callList = wampClient.requestCallList("", "", "");

                    if (callList != null)
                    {
                        if (callList.Count > 0)
                        {
                            string txt = "SDK. Call List:";
                            addToLog(txt);

                            foreach (WampClient.wamp_call_element call in callList)
                            {
                                txt = ("from_dirno: " + call.from_dirno + ". id: " + call.call_id + ". state: " + call.state + ". to_dirno: " + call.to_dirno);
                                addToLog(txt);
                            }


                            foreach (WampClient.wamp_call_element call in callList)
                            {
                                txt = ("from_dirno: " + call.from_dirno + ". id: " + call.call_id + ". state: " + call.state + ". to_dirno: " + call.to_dirno);


                                WampClient.wamp_call_element newCall = new WampClient.wamp_call_element();
                                newCall.from_dirno = call.from_dirno;
                                newCall.to_dirno = call.to_dirno;
                                newCall.state = call.state;
                                newCall.call_id = call.call_id;

                                bool found = false;
                                int i = 0;
                                int i_save = 0;

                                while ((i < (dgrdActiveCalls.Rows.Count)) && (!found))
                                {
                                    if (string.Compare(dgrdActiveCalls.Rows[i].Cells[3].Value.ToString(), newCall.call_id) == 0)
                                    {
                                        found = true;
                                        i_save = i;
                                    }
                                    i++;
                                }

                                if (found)
                                {
                                    LogMan.Instance.Log(string.Format("Call Found at index: {0}", i_save));

                                    if ((string.Compare(newCall.state, "call_ended") == 0) ||
                                         (string.Compare(newCall.state, "canceled") == 0))
                                    {
                                        dgrdActiveCalls.Rows.RemoveAt(i_save);
                                    }
                                    else
                                    {
                                        if (newCall.from_dirno != string.Empty)
                                        {
                                            dgrdActiveCalls.Rows[i_save].Cells[0].Value = newCall.from_dirno;
                                        }
                                        if (newCall.to_dirno != string.Empty)
                                        {
                                            dgrdActiveCalls.Rows[i_save].Cells[1].Value = newCall.to_dirno;
                                        }
                                        if (newCall.state != string.Empty)
                                        {
                                            dgrdActiveCalls.Rows[i_save].Cells[2].Value = newCall.state;
                                        }
                                    }
                                }
                                else
                                {
                                    if (string.Compare(newCall.state, "call_ended") == 0)
                                    {
                                        // Call already cleared
                                    }
                                    else
                                    {
                                        // Insert new call
                                        string[] row = { newCall.from_dirno, newCall.to_dirno, newCall.state, newCall.call_id };
                                        dgrdActiveCalls.Rows.Add(row);
                                    }
                                }
                            }
                        }
                        else
                        {
                            dgrdActiveCalls.Rows.Clear();
                        }
                    }
                    else
                    {
                        addToLog("No Calls Established.");
                    }
                }
                else
                {
                    MessageBox.Show("WAMP is NOT connected.");
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in btnGetCalls_Click: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void btn_EstablishConnection_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    string aSub = tbxASubscriber.Text;
                    string bSub = tbxBSubscriber.Text;
                    string act = cmbxCallAction.SelectedItem.ToString();

                    WampClient.wamp_response wampResp = wampClient.PostCalls(aSub, bSub, act);

                    addToLog("btn_EstablishConnection_Click: Wamp Response  = " + wampResp.WampResponse.ToString());
                    addToLog("btn_EstablishConnection_Click: CompletionText = " + wampResp.CompletionText);
                }
                else
                {
                    MessageBox.Show("WAMP Connection not established.");
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in btn_EstablishConnection_Click: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void btn_ClearConnection_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    bool singleRowSelected = false;

                    DataGridViewSelectedRowCollection selRow = dgrdActiveCalls.SelectedRows;

                    if ((selRow != null) && (selRow.Count == 1))
                    {
                        singleRowSelected = true;
                    }
                    else
                    {
                        selRow = dgrdQueuedCalls.SelectedRows;
                        if ((selRow != null) && (selRow.Count == 1))
                        {
                            singleRowSelected = true;
                        }
                    }

                    if (singleRowSelected)
                    {
                        string source = selRow[0].Cells[0].Value.ToString();
                        WampClient.wamp_response wampResp = wampClient.DeleteCalls(source);
                        addToLog("btn_ClearConnection_Click: Wamp Response  = " + wampResp.WampResponse.ToString());
                        addToLog("btn_ClearConnection_Click: CompletionText = " + wampResp.CompletionText);
                    }
                    else
                    {
                        string message = "No Connection Selected";
                        string title = "Clear Down Error";
                        MessageBox.Show(message, title);
                    }
                }
                else
                {
                    MessageBox.Show("WAMP Connection not established.");
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in btn_ClearConnection_Click: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void btnClearConnectionId_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    bool singleRowSelected = false;
                    DataGridViewSelectedRowCollection selRow = dgrdActiveCalls.SelectedRows;

                    if ((selRow != null) && (selRow.Count == 1))
                    {
                        singleRowSelected = true;
                    }
                    else
                    {
                        selRow = dgrdQueuedCalls.SelectedRows;
                        if ((selRow != null) && (selRow.Count == 1))
                        {
                            singleRowSelected = true;
                        }
                    }

                    if (singleRowSelected)
                    {
                        string callId = selRow[0].Cells[3].Value.ToString();
                        WampClient.wamp_response wampResp = wampClient.DeleteCallId(callId);

                        addToLog("btnClearConnectionId_Click: Wamp Response  = " + wampResp.WampResponse.ToString());
                        addToLog("btnClearConnectionId_Click: CompletionText = " + wampResp.CompletionText);
                    }
                    else
                    {
                        string message = "No Connection Selected";
                        string title = "Clear Down Error";
                        MessageBox.Show(message, title);
                    }
                }
                else
                {
                    MessageBox.Show("WAMP Connection not established.");
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in btnClearConnectionId_Click: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void btnGETCallQueueLegs_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    List<WampClient.wamp_call_leg_element> callQueueLegList;

                    callQueueLegList = wampClient.requestCallLegs("", "", "", "", "", "", "");

                    if (callQueueLegList != null)
                    {
                        if (callQueueLegList.Count > 0)
                        {
                            string txt = "btnGETCallQueueLegs_Click. Calls Queued List:";
                            addToLog(txt);

                            foreach (WampClient.wamp_call_leg_element callQueued in callQueueLegList)
                            {
                                txt = "SDK. Call Leg State Update: " +
                                    "  call_id " + callQueued.call_id +
                                    ". call_type: " + callQueued.call_type +
                                    ". channel: " + callQueued.channel +
                                    ". dirno: " + callQueued.dirno +
                                    ". from_dirno: " + callQueued.from_dirno +
                                    ". leg_id: " + callQueued.leg_id +
                                    ". leg_role: " + callQueued.leg_role +

                                    ". priority: " + callQueued.priority +
                                    ". reason: " + callQueued.reason +
                                    ". state: " + callQueued.state +
                                    ". to_dirno: " + callQueued.to_dirno;

                                addToLog(txt);

                                bool found = false;
                                int i = 0;
                                int i_save = 0;

                                while ((i < (dgrdQueuedCalls.Rows.Count)) && (!found))
                                {
                                    if ((string.Compare(dgrdQueuedCalls.Rows[i].Cells[0].Value.ToString(), callQueued.from_dirno) == 0) &&
                                         (string.Compare(dgrdQueuedCalls.Rows[i].Cells[1].Value.ToString(), callQueued.dirno) == 0))
                                    {
                                        found = true;
                                        i_save = i;
                                    }
                                    i++;
                                }

                                if (found)
                                {
                                    addToLog(string.Format("Call Found at index: {0}", i_save));


                                    if (callQueued.leg_role.Equals("callee"))
                                    {
                                        if (callQueued.state.Equals("in_call") ||
                                             callQueued.state.Equals("ended"))
                                        {
                                            dgrdQueuedCalls.Rows.RemoveAt(i_save);
                                        }
                                        else
                                        {
                                            if (!string.IsNullOrEmpty(callQueued.from_dirno))
                                            {
                                                dgrdQueuedCalls.Rows[i_save].Cells[0].Value = callQueued.from_dirno;
                                            }
                                            if (!string.IsNullOrEmpty(callQueued.dirno))
                                            {
                                                dgrdQueuedCalls.Rows[i_save].Cells[1].Value = callQueued.dirno;
                                            }
                                            if (!string.IsNullOrEmpty(callQueued.state))
                                            {
                                                dgrdQueuedCalls.Rows[i_save].Cells[2].Value = callQueued.state;
                                            }
                                            if (!string.IsNullOrEmpty(callQueued.call_id))
                                            {
                                                dgrdQueuedCalls.Rows[i_save].Cells[3].Value = callQueued.call_id;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    if (callQueued.leg_role.Equals("callee"))
                                    {

                                        if (!callQueued.state.Equals("ended"))
                                        {
                                            string[] row = { callQueued.from_dirno, callQueued.dirno, callQueued.state, callQueued.call_id };
                                            dgrdQueuedCalls.Rows.Add(row);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            dgrdQueuedCalls.Rows.Clear();
                        }

                    }
                    else
                    {
                        string txt = "SDK. Call Leg List is empty.";
                        addToLog(txt);
                    }
                }
                else
                {
                    MessageBox.Show("WAMP Connection not established.");
                }
            }

            catch (Exception ex)
            {
                string txt = "Exception in btnGetCallLegs_Click: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        /**********************                                Device                                         ******************/
        /***********************************************************************************************************************/


        /***********************************************************************************************************************/
        private void btnPOSTDeviceGPO_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    string deviceId = "dirno=" + tbxGPODevice.Text;
                    string gpoId = "id=relay1";

                    wampClient.PostDeviceGPO(deviceId, gpoId);
                }
                else
                {
                    MessageBox.Show("WAMP Connection not established.");
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in btnPOSTDeviceGPO_Click: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void btnGETDeviceGPOs_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    List<WampClient.wamp_device_gpio_element> gpoElements;

                    string devId = "dirno=" + tbxGPODevice.Text;
                    gpoElements = wampClient.requestDevicesGPOs(devId, "");

                    if (gpoElements != null)
                    {
                        string txt = "SDK. Get all/some GPOs:";
                        addToLog(txt);

                        foreach (WampClient.wamp_device_gpio_element GpoElem in gpoElements)
                        {
                            txt = ("Id: " + GpoElem.id + ". State: " + GpoElem.state + ". Type: " + GpoElem.type);
                            addToLog(txt);
                        }
                    }
                    else
                    {
                        string txt = "SDK. GPO elements is empty.";
                        addToLog(txt);
                    }
                }
                else
                {
                    MessageBox.Show("WAMP Connection not established.");
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in btnGETDeviceGPOs_Click: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void btnGETDeviceGPIs_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    List<WampClient.wamp_device_gpio_element> gpiElements;

                    string devId = "dirno=%3D" + tbxGPIDevice.Text;
                    gpiElements = wampClient.requestDevicesGPIs(devId, "relay1");


                    if (gpiElements != null)
                    {
                        string txt = "SDK. Get all/some GPIs:";
                        addToLog(txt);

                        foreach (WampClient.wamp_device_gpio_element GpiElem in gpiElements)
                        {
                            txt = ("Id: " + GpiElem.id + ". State: " + GpiElem.state + ". Type: " + GpiElem.type);
                            addToLog(txt);
                        }
                    }
                    else
                    {
                        string txt = "SDK. GPI elements is empty.";
                        addToLog(txt);
                    }
                }
                else
                {
                    MessageBox.Show("WAMP Connection not established.");
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in btnClearConnectionId_Click: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        /**********************                                Events                                         ******************/
        /***********************************************************************************************************************/


        /***********************************************************************************************************************/
        private void cbxCallStatusEvent_CheckedChanged(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (cbxCallStatusEvent.Checked)
                {
                    addToLog("Call Status Event is check mark set.");

                    if (!wampClient.TraceCallEventIsEnabled())
                    {
                        addToLog("Enable Call Status Event.");
                        if (wampClient.IsConnected)
                        {
                            wampClient.TraceCallEvent();
                        }
                        else
                        {
                            cbxCallStatusEvent.Checked = false;
                            MessageBox.Show("WAMP Connection not established.");
                        }
                    }
                }
                else
                {
                    addToLog("Call Status Event check mark cleared.");

                    if (wampClient.TraceCallEventIsEnabled())
                    {
                        addToLog("Disable Call Status Event.");
                        wampClient.TraceCallEventDispose();
                    }
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in cbxCallStatusEvent_CheckedChanged: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void cbxCallQueueStatusEvent_CheckedChanged(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (cbxCallLegStatusEvent.Checked)
                {
                    addToLog("Call Leg Status Event is check mark set.");

                    if (!wampClient.TraceCallLegEventIsEnabled())
                    {
                        addToLog("Enable Call Leg Status Event.");
                        if (wampClient.IsConnected)
                        {
                            wampClient.TraceCallLegEvent();
                        }
                        else
                        {
                            cbxCallLegStatusEvent.Checked = false;
                            MessageBox.Show("WAMP Connection not established.");
                        }
                    }
                }
                else
                {
                    addToLog("Call Leg Status Event check mark cleared.");
                    if (wampClient.TraceCallLegEventIsEnabled())
                    {
                        addToLog("Disable Call Leg Status Event.");
                        wampClient.TraceCallLegEventDispose();
                    }
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in cbxCallQueueStatusEvent_CheckedChanged: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void cbxDeviceRegistrationEvent_CheckedChanged(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (cbxDeviceRegistrationEvent.Checked)
                {
                    addToLog("Device Registration Status Event check mark set.");

                    if (!wampClient.TraceDeviceRegistrationIsEnabled())
                    {
                        addToLog("Enable Device Registration Status Event.");
                        if (wampClient.IsConnected)
                        {
                            wampClient.TraceDeviceRegistrationEvent();
                        }
                        else
                        {
                            cbxDeviceRegistrationEvent.Checked = false;
                            MessageBox.Show("WAMP Connection not established.");
                        }
                    }
                }
                else
                {
                    addToLog("Device Registration Status Event check mark cleared.");
                    if (wampClient.TraceDeviceRegistrationIsEnabled())
                    {
                        addToLog("Disable Device Registration Status Event.");
                        wampClient.TraceDeviceRegistrationEventDispose();
                    }
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in cbxDeviceRegistrationEvent_CheckedChanged: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void cbxGPOStatusEvent_CheckedChanged(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (cbxDeviceGPOStatusEvent.Checked)
                {
                    addToLog("Device GPO Staus Event check mark set.");

                    if (!wampClient.TraceDeviceGPOStatusEventIsEnabled())
                    {
                        addToLog("Enable Device GPO Status Event.");
                        if (wampClient.IsConnected)
                        {
                            wampClient.TraceDeviceGPOStatusEvent(tbxGPODevice.Text);
                        }
                        else
                        {
                            cbxDeviceGPOStatusEvent.Checked = false;
                            MessageBox.Show("WAMP Connection not established.");
                        }
                    }
                }
                else
                {
                    addToLog("Device GPO Status Event check mark cleared.");

                    if (wampClient.TraceDeviceGPOStatusEventIsEnabled())
                    {
                        addToLog("Disable Device GPO Status Event.");
                        wampClient.TraceDeviceGPOStatusEventDispose();
                    }
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in cbxGPOStatusEvent_CheckedChanged: " + ex.ToString();
                addToLog(txt);
            }
        }


        /*****************************************************************************************/
        private void cbxDeviceGPIStatusEvent_CheckedChanged(object sender, EventArgs e)
        /*****************************************************************************************/
        {
            try
            {
                if (cbxDeviceGPIStatusEvent.Checked)
                {
                    addToLog("Device GPI Staus Event check mark set.");

                    if (!wampClient.TraceDeviceGPIStatusEventIsEnabled())
                    {
                        addToLog("Enable Device GPI Status Event.");
                        if (wampClient.IsConnected)
                        {
                            wampClient.TraceDeviceGPIStatusEvent(tbxGPIDevice.Text);
                        }
                        else
                        {
                            cbxDeviceGPIStatusEvent.Checked = false;
                            MessageBox.Show("WAMP Connection not established.");
                        }
                    }
                }
                else
                {
                    addToLog("Device GPI Status Event check mark cleared.");

                    if (wampClient.TraceDeviceGPIStatusEventIsEnabled())
                    {
                        addToLog("Disable Device GPI Status Event.");
                        wampClient.TraceDeviceGPIStatusEventDispose();
                    }
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in cbxDeviceGPIStatusEvent_CheckedChanged: " + ex.ToString();
                addToLog(txt);
            }
        }


        /*****************************************************************************************/
        private void cbxOpenDoor_CheckedChanged(object sender, EventArgs e)
        /*****************************************************************************************/
        {
            try
            {
                if (cbxOpenDoorEvent.Checked)
                {
                    addToLog("Open Door Event check mark set.");

                    if (!wampClient.TraceOpenDoorEventIsEnabled())
                    {
                        addToLog("Enable Open Door Event.");
                        if (wampClient.IsConnected)
                        {
                            wampClient.TraceOpenDoorEvent();
                        }
                        else
                        {
                            cbxOpenDoorEvent.Checked = false;
                            MessageBox.Show("WAMP Connection not established.");
                        }
                    }
                }
                else
                {
                    addToLog("Open Door Event check mark cleared.");

                    if (wampClient.TraceOpenDoorEventIsEnabled())
                    {
                        addToLog("Disable Open Door Event.");
                        wampClient.TraceDeviceGPOStatusEventDispose();
                    }
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in cbxOpenDoor_CheckedChanged: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void btnClearList_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            dgrd_Registrations.Rows.Clear();
        }

        #endregion

        #region  ----------  Event Handling  Methods  ----------

        /***********************************************************************************************************************/
        private void wampClient_OnWampOpenDoorEvent(object sender, WampClient.wamp_open_door_event doorOpenEvent)
        /***********************************************************************************************************************/
        {
            string txt = "SDK. Device Open Door Event: from_dirno: " + doorOpenEvent.from_dirno + ". from_name: " + doorOpenEvent.from_name +
                                                    ". door_dirno: " + doorOpenEvent.door_dirno + ". door_name: " + doorOpenEvent.door_name;
            addToLog(txt);
        }




        /*****************************************************************************************/
        private void wampClient_OnWampDeviceGPOStatusEvent(object sender, WampClient.wamp_device_gpio_element e)
        /*****************************************************************************************/
        {
            try
            {
                string txt = "SDK. GPO Event: id: " + e.id + ". state: " + e.state + ". Type: " + e.type;
            }
            catch (Exception ex)
            {
                string txt = "Exception in _wampConnection_OnWampDeviceGPOStatusEvent: " + ex.ToString();
                addToLog(txt);
            }
        }


        /*****************************************************************************************/
        private void wampClient_OnWampDeviceGPIStatusEvent(object sender, WampClient.wamp_device_gpio_element e)
        /*****************************************************************************************/
        {
            try
            {
                string txt = "SDK. GPI Event: id: " + e.id + ". state: " + e.state + ". Type: " + e.type;

            }
            catch (Exception ex)
            {
                string txt = "Exception in _wampConnection_OnWampDeviceGPIStatusEvent: " + ex.ToString();
                addToLog(txt);
            }
        }


        private delegate void _wampConnection_OnWampDeviceRegistrationEventCallBack(object sender, WampClient.wamp_device_registration_element regUpd);

        /***********************************************************************************************************************/
        private void wampClient_OnWampDeviceRegistrationEvent(object sender, WampClient.wamp_device_registration_element regUpd)
        /***********************************************************************************************************************/
        {
            if (this.dgrd_Registrations.InvokeRequired)
            {
                _wampConnection_OnWampDeviceRegistrationEventCallBack cb =
                    new _wampConnection_OnWampDeviceRegistrationEventCallBack(wampClient_OnWampDeviceRegistrationEvent);

                this.Invoke(cb, new object[] { sender, regUpd });
            }
            else
            {
                if (regUpd != null)
                {
                    string txt = "SDK-Event. Device Registration Update: Dir-no " + regUpd.dirno + ". State: " + regUpd.state;
                    addToLog(txt);

                    bool found = false;
                    int i = 0;
                    int i_save = 0;

                    while ((i < (dgrd_Registrations.Rows.Count)) && (!found))
                    {
                        if (string.Compare(dgrd_Registrations.Rows[i].Cells[0].Value.ToString(), regUpd.dirno) == 0)
                        {
                            found = true;
                            i_save = i;
                        }
                        i++;
                    }

                    if (found)
                    {
                        dgrd_Registrations.Rows.RemoveAt(i_save);
                        string[] row = { regUpd.dirno, regUpd.name, regUpd.location, regUpd.state };
                        dgrd_Registrations.Rows.Add(row);
                    }
                }
            }
        }


        private delegate void _wampConnection_OnWampCallStatusEventCallBack(object sender, WampClient.wamp_call_element callUpd);

        /***********************************************************************************************************************/
        private void wampClient_OnWampCallStatusEvent(object sender, WampClient.wamp_call_element callUpd)
        /***********************************************************************************************************************/
        {
            try
            {
                if (this.dgrdActiveCalls.InvokeRequired)
                {
                    _wampConnection_OnWampCallStatusEventCallBack cb =
                        new _wampConnection_OnWampCallStatusEventCallBack(wampClient_OnWampCallStatusEvent);

                    this.Invoke(cb, new object[] { sender, callUpd });
                }
                else
                {
                    string txt = "SDK-Event. Call State Update: Call from " + callUpd.from_dirno + " to dir-no " + callUpd.to_dirno +
                         ". State = " + callUpd.state + ". id = " + callUpd.call_id;

                    addToLog(txt);

                    bool found = false;
                    int i = 0;
                    int i_save = 0;

                    if (callUpd.call_type.Equals("normal_call"))
                    {
                        addToLog("Normal Call");

                        while ((i < dgrdActiveCalls.Rows.Count) && (!found))
                        {
                            if (string.Compare(dgrdActiveCalls.Rows[i].Cells[3].Value.ToString(), callUpd.call_id) == 0)
                            {
                                found = true;
                                i_save = i;
                            }
                            i++;
                        }

                        if (found)
                        {
                            addToLog(string.Format("Call Found at index: {0}", i_save));

                            if (callUpd.state.Equals("ended"))
                            {
                                dgrdActiveCalls.Rows.RemoveAt(i_save);
                            }
                            else
                            {
                                addToLog("Normal Call - Update call.");

                                // Update call found
                                if (!string.IsNullOrEmpty(callUpd.from_dirno))
                                {
                                    dgrdActiveCalls.Rows[i_save].Cells[0].Value = callUpd.from_dirno;
                                }
                                if (!string.IsNullOrEmpty(callUpd.to_dirno))
                                {
                                    dgrdActiveCalls.Rows[i_save].Cells[1].Value = callUpd.to_dirno_current;
                                }
                                if (!string.IsNullOrEmpty(callUpd.state))
                                {
                                    dgrdActiveCalls.Rows[i_save].Cells[2].Value = callUpd.state;
                                }
                                if (!string.IsNullOrEmpty(callUpd.call_id))
                                {
                                    dgrdActiveCalls.Rows[i_save].Cells[3].Value = callUpd.call_id;
                                }
                            }
                        }
                        else
                        {
                            addToLog("Normal Call - New call.");

                            // This is a new call
                            if (!callUpd.state.Equals("ended"))
                            {
                                addToLog("Normal Call - Not a call ended.");

                                // Do not insert a call that has already been removed
                                // See if transfered from queueud call to narmal call

                                found = false;
                                i = 0;
                                i_save = 0;


                                // See if call id is in the queued calls
                                while ((i < dgrdQueuedCalls.Rows.Count) && (!found))
                                {
                                    if (string.Compare(dgrdQueuedCalls.Rows[i].Cells[3].Value.ToString(), callUpd.call_id) == 0)
                                    {

                                        if ((string.Compare(dgrdQueuedCalls.Rows[i].Cells[0].Value.ToString(), callUpd.from_dirno) == 0) &&
                                            (string.Compare(dgrdQueuedCalls.Rows[i].Cells[1].Value.ToString(), callUpd.to_dirno) == 0))
                                        {
                                            found = true;
                                            i_save = i;
                                        }
                                    }
                                    i++;
                                }

                                if (found)
                                {
                                    addToLog("Normal Call. Call removed from queued calls.");
                                    dgrdQueuedCalls.Rows.RemoveAt(i_save);
                                }
                                else
                                {
                                    addToLog("Normal Call - Not in the queued calls.");
                                }

                                string[] row = { callUpd.from_dirno, callUpd.to_dirno_current, callUpd.state, callUpd.call_id };
                                dgrdActiveCalls.Rows.Add(row);
                            }
                        }
                    }

                    else if (callUpd.call_type.Equals("queue_call"))
                    {
                        found = false;
                        i = 0;
                        i_save = 0;

                        while ((i < dgrdQueuedCalls.Rows.Count) && (!found))
                        {
                            if ((string.Compare(dgrdQueuedCalls.Rows[i].Cells[0].Value.ToString(), callUpd.from_dirno) == 0) &&
                                (string.Compare(dgrdQueuedCalls.Rows[i].Cells[1].Value.ToString(), callUpd.to_dirno) == 0))
                            {
                                found = true;
                                i_save = i;
                            }
                            i++;
                        }

                        if (found)
                        {
                            addToLog(string.Format("Call Found at index: {0}", i_save));

                            if (callUpd.state.Equals("in_call") ||
                                callUpd.state.Equals("ended"))
                            {
                                addToLog("Queued Call. Call is removed.");
                                dgrdQueuedCalls.Rows.RemoveAt(i_save);
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(callUpd.from_dirno))
                                {
                                    dgrdQueuedCalls.Rows[i_save].Cells[0].Value = callUpd.from_dirno;
                                }
                                if (!string.IsNullOrEmpty(callUpd.to_dirno))
                                {
                                    dgrdQueuedCalls.Rows[i_save].Cells[1].Value = callUpd.to_dirno;
                                }
                                if (!string.IsNullOrEmpty(callUpd.state))
                                {
                                    dgrdQueuedCalls.Rows[i_save].Cells[2].Value = callUpd.state;
                                }
                                if (!string.IsNullOrEmpty(callUpd.call_id))
                                {
                                    dgrdQueuedCalls.Rows[i_save].Cells[3].Value = callUpd.call_id;
                                }
                            }
                        }
                        else
                        {
                            if (!callUpd.state.Equals("ended"))
                            {
                                string[] row = { callUpd.from_dirno, callUpd.to_dirno, callUpd.state, callUpd.call_id };
                                dgrdQueuedCalls.Rows.Add(row);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in _wampConnection_OnWampCallStatusEvent: " + ex.ToString();
                addToLog(txt);
            }
        }


        private delegate void _wampConnection_OnWampCallLegStatusEventCallBack(object sender, WampClient.wamp_call_leg_element callLegStatus);

        /***********************************************************************************************************************/
        private void wampClient_OnWampCallLegStatusEvent(object sender, WampClient.wamp_call_leg_element callLegStatus)
        /***********************************************************************************************************************/
        {
            try
            {
                if (InvokeRequired)
                {
                    _wampConnection_OnWampCallLegStatusEventCallBack cb =
                       new _wampConnection_OnWampCallLegStatusEventCallBack(wampClient_OnWampCallLegStatusEvent);

                    this.Invoke(cb, new object[] { sender, callLegStatus });
                }
                else
                {
                    string txt = "SDK. Call Leg State Update: " +
                                 "  call_id " + callLegStatus.call_id +
                                 ". call_type: " + callLegStatus.call_type +
                                 ". channel: " + callLegStatus.channel +
                                 ". dirno: " + callLegStatus.dirno +
                                 ". from_dirno: " + callLegStatus.from_dirno +
                                 ". leg_id: " + callLegStatus.leg_id +
                                 ". leg_role: " + callLegStatus.leg_role +
                                 ". priority: " + callLegStatus.priority +
                                 ". reason: " + callLegStatus.reason +
                                 ". state: " + callLegStatus.state +
                                 ". to_dirno: " + callLegStatus.to_dirno;

                    addToLog(txt);


                    bool found = false;
                    int i = 0;
                    int i_save = 0;

                    if (callLegStatus.call_type.Equals("normal_call"))
                    {
                        addToLog("Normal Call");

                        if (callLegStatus.leg_role.Equals("callee"))
                        {

                            while ((i < dgrdActiveCalls.Rows.Count) && (!found))
                            {
                                if (string.Compare(dgrdActiveCalls.Rows[i].Cells[3].Value.ToString(), callLegStatus.call_id) == 0)
                                {
                                    found = true;
                                    i_save = i;
                                }
                                i++;
                            }

                            if (found)
                            {
                                addToLog(string.Format("Normal Call Found at index: {0}", i_save));

                                if (callLegStatus.state.Equals("ended"))
                                {
                                    addToLog("Normal Call - Ended");
                                    dgrdActiveCalls.Rows.RemoveAt(i_save);
                                }
                                else
                                {
                                    addToLog("Normal Call - Update call.");

                                    // Update call found
                                    if (!string.IsNullOrEmpty(callLegStatus.from_dirno))
                                    {
                                        dgrdActiveCalls.Rows[i_save].Cells[0].Value = callLegStatus.from_dirno;
                                    }
                                    if (!string.IsNullOrEmpty(callLegStatus.to_dirno))
                                    {
                                        dgrdActiveCalls.Rows[i_save].Cells[1].Value = callLegStatus.to_dirno;
                                    }
                                    if (!string.IsNullOrEmpty(callLegStatus.state))
                                    {
                                        dgrdActiveCalls.Rows[i_save].Cells[2].Value = callLegStatus.state;
                                    }
                                    if (!string.IsNullOrEmpty(callLegStatus.call_id))
                                    {
                                        dgrdActiveCalls.Rows[i_save].Cells[3].Value = callLegStatus.call_id;
                                    }
                                    found = false;
                                    i = 0;
                                    i_save = 0;


                                    // See if call id is in the queued calls
                                    while ((i < dgrdQueuedCalls.Rows.Count) && (!found))
                                    {
                                        if (string.Compare(dgrdQueuedCalls.Rows[i].Cells[3].Value.ToString(), callLegStatus.call_id) == 0)
                                        {

                                            if ((string.Compare(dgrdQueuedCalls.Rows[i].Cells[0].Value.ToString(), callLegStatus.from_dirno) == 0) &&
                                                 (string.Compare(dgrdQueuedCalls.Rows[i].Cells[1].Value.ToString(), callLegStatus.dirno) == 0))
                                            {
                                                found = true;
                                                i_save = i;
                                            }
                                        }
                                        i++;
                                    }

                                    if (found)
                                    {
                                        addToLog("Normal Call. Call removed from queued calls.");
                                        dgrdQueuedCalls.Rows.RemoveAt(i_save);
                                    }
                                    else
                                    {
                                        addToLog("Normal Call - Not in the queued calls.");
                                    }
                                }
                            }
                            else
                            {
                                addToLog("Normal Call - New call.");

                                // This is a new call
                                if (!callLegStatus.state.Equals("ended"))
                                {
                                    addToLog("Normal Call - Not a call ended.");

                                    // Do not insert a call that has already been removed
                                    // See if transfered from queueud call to narmal call

                                    found = false;
                                    i = 0;
                                    i_save = 0;


                                    // See if call id is in the queued calls
                                    while ((i < dgrdQueuedCalls.Rows.Count) && (!found))
                                    {
                                        if (string.Compare(dgrdQueuedCalls.Rows[i].Cells[3].Value.ToString(), callLegStatus.call_id) == 0)
                                        {

                                            if ((string.Compare(dgrdQueuedCalls.Rows[i].Cells[0].Value.ToString(), callLegStatus.from_dirno) == 0) &&
                                                 (string.Compare(dgrdQueuedCalls.Rows[i].Cells[1].Value.ToString(), callLegStatus.dirno) == 0))
                                            {
                                                found = true;
                                                i_save = i;
                                            }
                                        }
                                        i++;
                                    }

                                    if (found)
                                    {
                                        addToLog("Normal Call. Call removed from queued calls.");
                                        dgrdQueuedCalls.Rows.RemoveAt(i_save);
                                    }
                                    else
                                    {
                                        addToLog("Normal Call - Not in the queued calls.");
                                    }

                                    string[] row = { callLegStatus.from_dirno, callLegStatus.dirno, callLegStatus.state, callLegStatus.call_id };
                                    dgrdActiveCalls.Rows.Add(row);
                                }
                            }
                        }
                        else
                        {
                            found = false;

                            // See if call id is in the queued calls
                            while ((i < dgrdQueuedCalls.Rows.Count) && (!found))
                            {
                                if (string.Compare(dgrdQueuedCalls.Rows[i].Cells[3].Value.ToString(), callLegStatus.call_id) == 0)
                                {
                                    found = true;
                                    i_save = i;
                                }
                                i++;
                            }

                            if (found)
                            {
                                if (callLegStatus.state.Equals("in_call"))
                                {
                                    addToLog("Normal Call - Queued call answered");
                                    dgrdQueuedCalls.Rows.RemoveAt(i_save);
                                }
                            }
                        }
                    }

                    else if (callLegStatus.call_type.Equals("queue_call"))
                    {
                        addToLog("Normal Call");

                        if (callLegStatus.leg_role.Equals("callee"))
                        {
                            found = false;
                            i = 0;
                            i_save = 0;

                            while ((i < dgrdQueuedCalls.Rows.Count) && (!found))
                            {
                                if ((string.Compare(dgrdQueuedCalls.Rows[i].Cells[0].Value.ToString(), callLegStatus.from_dirno) == 0) &&
                                     (string.Compare(dgrdQueuedCalls.Rows[i].Cells[1].Value.ToString(), callLegStatus.dirno) == 0))
                                {
                                    found = true;
                                    i_save = i;
                                }
                                i++;
                            }

                            if (found)
                            {
                                addToLog(string.Format("Call Found at index: {0}", i_save));

                                if (callLegStatus.state.Equals("in_call") ||
                                     callLegStatus.state.Equals("ended"))
                                {
                                    addToLog("Queued Call. Call is removed.");
                                    dgrdQueuedCalls.Rows.RemoveAt(i_save);
                                }
                                else
                                {
                                    if (!string.IsNullOrEmpty(callLegStatus.from_dirno))
                                    {
                                        dgrdQueuedCalls.Rows[i_save].Cells[0].Value = callLegStatus.from_dirno;
                                    }
                                    if (!string.IsNullOrEmpty(callLegStatus.dirno))
                                    {
                                        dgrdQueuedCalls.Rows[i_save].Cells[1].Value = callLegStatus.dirno;
                                    }
                                    if (!string.IsNullOrEmpty(callLegStatus.state))
                                    {
                                        dgrdQueuedCalls.Rows[i_save].Cells[2].Value = callLegStatus.state;
                                    }
                                    if (!string.IsNullOrEmpty(callLegStatus.call_id))
                                    {
                                        dgrdQueuedCalls.Rows[i_save].Cells[3].Value = callLegStatus.call_id;
                                    }
                                }
                            }
                            else
                            {
                                if (!callLegStatus.state.Equals("ended"))
                                {
                                    string[] row = { callLegStatus.from_dirno, callLegStatus.dirno, callLegStatus.state, callLegStatus.call_id };
                                    dgrdQueuedCalls.Rows.Add(row);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in btnGetCallQueued_Clic: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void _wampConnection_OnChildLogString(object sender, string e)
        /***********************************************************************************************************************/
        {
            addToLog(e);
        }


        /***********************************************************************************************************************/
        private void WampConnection_OnConnectChanged(object sender, bool e)
        /***********************************************************************************************************************/
        {
            UpdateConnectState();
        }


        private delegate void WampConnection_OnErrorCallBack(object sender, string e);

        /***********************************************************************************************************************/
        private void WampConnection_OnError(object sender, string e)
        /***********************************************************************************************************************/
        {
            if (InvokeRequired)
            {
                WampConnection_OnErrorCallBack callBack = new WampConnection_OnErrorCallBack(WampConnection_OnError);
                this.Invoke(callBack, new object[] { sender, e });
            }
            else
            {

            }
        }


        /***********************************************************************************************************************/
        protected override void OnClosed(EventArgs e)
        /***********************************************************************************************************************/
        {
            if (wampClient.IsConnected)
            {
                wampClient.Stop();
            }
            base.OnClosed(e);
        }

        #endregion

        /***********************************************************************************************************************/
        private void UpdateConnectState()
        /***********************************************************************************************************************/
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(UpdateConnectState));
                return;
            }

            if (wampClient.IsConnected)
            {
                tbxConnectionStatus.Text = "Connected";

                btnWampConnect.Enabled = false;
                btnWampDisconnect.Enabled = true;
                btnGETDeviceAccounts.Enabled = true;

                btnGETDeviceAccounts.Enabled = true;
                btnGETNetInterface.Enabled = true;
                btnPOSTCalls.Enabled = true;
                btnDELETECalls.Enabled = true;
                btnDELETECallId.Enabled = true;
                btnGETCalls.Enabled = true;
                btnPOSTOpenDoor.Enabled = true;

                btnGETCallLegs.Enabled = true;

                // Currently not available
                //btnPOSTDeviceGPO.Enabled = true;
                //btnGETDeviceGPOs.Enabled = true;
                //btnGETDeviceGPIOs.Enabled = true;

                //Clear Check Marks
                cbxCallLegStatusEvent.Checked = false;
                cbxCallStatusEvent.Checked = false;
                cbxDeviceRegistrationEvent.Checked = false;

                cbxDeviceGPOStatusEvent.Checked = false;
                cbxDeviceGPIStatusEvent.Checked = false;
                cbxOpenDoorEvent.Checked = false;

                //Enable Check Fields
                cbxCallLegStatusEvent.Enabled = true;
                cbxCallStatusEvent.Enabled = true;
                cbxDeviceRegistrationEvent.Enabled = true;

                // Currently not available
                //cbxDeviceGPOStatusEvent.Enabled = true;
                //cbxDeviceGPIStatusEvent.Enabled = true;

                cbxOpenDoorEvent.Enabled = true;

                if (cbxCallStatusEvent.Checked)
                {
                    addToLog("Subscribe Call Events.");
                    wampClient.TraceCallEvent();
                }
                if (cbxCallLegStatusEvent.Checked)
                {
                    addToLog("Subscribe Call Leg Events.");
                    wampClient.TraceCallLegEvent();
                }
                if (cbxDeviceRegistrationEvent.Checked)
                {
                    addToLog("Subscribe Device Registration Events.");
                    wampClient.TraceDeviceRegistrationEvent();
                }
                try
                {
                    lbAudioMessages.Items.Clear();
                    AudioMessageWrapper messageWrapper = wampClient.requestAudioMessages();
                    foreach (wamp_audio_messages_element msg in messageWrapper.AudioMessages)
                    {
                        string displayText = $"{msg.dirno} - {msg.filename}";
                        lbAudioMessages.Items.Add(displayText);
                    }
                }
                catch (Exception ex)
                {

                }
                try
                {
                    lbGroups.Items.Clear();
                    foreach (wamp_group_element group in wampClient.requestGroups("", false))
                    {
                        string displayText = $"{group.dirno} - {group.displayname}";
                        lbGroups.Items.Add(displayText);
                    }
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                btnWampConnect.Enabled = true;
                btnWampDisconnect.Enabled = false;
                btnGETDeviceAccounts.Enabled = false;

                btnGETDeviceAccounts.Enabled = false;
                btnGETNetInterface.Enabled = false;
                btnPOSTCalls.Enabled = false;
                btnDELETECalls.Enabled = false;
                btnDELETECallId.Enabled = false;
                btnGETCalls.Enabled = false;
                btnPOSTOpenDoor.Enabled = false;

                btnGETCallLegs.Enabled = false;

                btnPOSTDeviceGPO.Enabled = false;
                btnGETDeviceGPOs.Enabled = false;
                btnGETDeviceGPIOs.Enabled = false;

                //Enable Check Fields
                cbxCallLegStatusEvent.Enabled = false;
                cbxCallStatusEvent.Enabled = false;
                cbxDeviceRegistrationEvent.Enabled = false;

                cbxDeviceGPOStatusEvent.Enabled = false;
                cbxDeviceGPIStatusEvent.Enabled = false;
                cbxOpenDoorEvent.Enabled = false;
            }
        }


        private delegate void addToLogCallBack(string txt);

        /***********************************************************************************************************************/
        private void addToLog(string txt)
        /***********************************************************************************************************************/
        {
            if (cbxSaveLoggingToFile.Checked)
            {
                LogMan.Instance.Log(txt);
            }

            if (loggingWindow != null)
            {
                loggingWindow.addToLog(txt);
            }
        }

        /***********************************************************************************************************************/
        private void cbxSaveLoggingToFile_CheckedChanged(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            if (cbxSaveLoggingToFile.Checked)
            {
                LogMan.Instance.CreateLog(true, 30, LogFilePath, LogFileName);
                addToLog(SW_Version);
            }
        }

        /***********************************************************************************************************************/
        private void btnOpenLoggingWindow_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            if (loggingWindow == null)
            {
                loggingWindow = new LoggingWindow();
                loggingWindow.Show();
            }
            else
            {
                MessageBox.Show("Logging Windows already Opened.");
            }
        }


        /***********************************************************************************************************************/
        private void btnCloseLoggingWindow_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            if (loggingWindow != null)
            {
                loggingWindow.Close();
                loggingWindow = null;
            }
            else
            {
                MessageBox.Show("Logging Windows already Closed.");
            }
        }


        /***********************************************************************************************************************/
        private void btnClearLoggingWindow_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            if (loggingWindow != null)
            {
                loggingWindow.ClearWindow();
            }
        }


        /***********************************************************************************************************************/
        private void btnClearNetInterfaces_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            dgrdNetInterfaces.Rows.Clear();
        }


        /***********************************************************************************************************************/
        private void chbxEncrypted_CheckedChanged(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            if (chbxEncrypted.Checked)
            {
                chbxUnencrypted.Checked = false;
            }
            else
            {
                chbxUnencrypted.Checked = true;
            }
        }


        /***********************************************************************************************************************/
        private void chbxUnencrypted_CheckedChanged(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            if (chbxUnencrypted.Checked)
            {
                chbxEncrypted.Checked = false;
            }
            else
            {
                chbxEncrypted.Checked = true;
            }

        }


        /***********************************************************************************************************************/
        private void btnPOSTOpenDoor_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    string aSub = tbxASubscriber.Text;

                    WampClient.wamp_response wampResp = wampClient.PostOpenDoor(aSub);

                    addToLog("btnPOSTOpenDoor_Click: Wamp Response  = " + wampResp.WampResponse.ToString());
                    addToLog("btnPOSTOpenDoor_Click: CompletionText = " + wampResp.CompletionText);
                }
                else
                {
                    MessageBox.Show("WAMP Connection not established.");
                }
            }
            catch (Exception ex)
            {
                string txt = "Exception in btnPOSTOpenDoor_Click: " + ex.ToString();
                addToLog(txt);
            }

        }


        /***********************************************************************************************************************/
        private async void btnRegisterCalleeServices_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    addToLog("btnRegisterCalleeServices_Click.");
                    await wampClient.RegisterCalleeServices();
                    addToLog("btnRegisterCalleeServices_Click completed.");
                }
                else
                {
                    MessageBox.Show("WAMP is NOT connected.");
                }
            }

            catch (Exception ex)
            {
                string txt = "btnRegisterCalleeServices_Click: " + ex.ToString();
                addToLog(txt);
            }
        }


        /***********************************************************************************************************************/
        private void btnNewUCTTime_Click(object sender, EventArgs e)
        /***********************************************************************************************************************/
        {
            try
            {
                if (wampClient.IsConnected)
                {
                    wampClient.Publish_NewUCTTime();
                }
                else
                {
                    MessageBox.Show("WAMP is NOT connected.");
                }
            }

            catch (Exception ex)
            {
                string txt = "btnNewUCTTime_Clic: " + ex.ToString();
                addToLog(txt);
            }
        }

    }
}
