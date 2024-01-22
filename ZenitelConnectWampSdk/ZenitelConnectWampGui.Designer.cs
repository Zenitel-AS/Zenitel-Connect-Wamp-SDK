﻿namespace Zenitel.Connect.Wamp.Sdk
{
    partial class ZenitelConnectWampGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZenitelConnectWampGui));
            this.btnWampConnect = new System.Windows.Forms.Button();
            this.btnWampDisconnect = new System.Windows.Forms.Button();
            this.lab_WAMPServerAddress = new System.Windows.Forms.Label();
            this.edtWAMPServerAddr = new System.Windows.Forms.TextBox();
            this.edtUserName = new System.Windows.Forms.TextBox();
            this.labUserName = new System.Windows.Forms.Label();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.edtWampRealm = new System.Windows.Forms.TextBox();
            this.labWampRealm = new System.Windows.Forms.Label();
            this.btnGETDeviceAccounts = new System.Windows.Forms.Button();
            this.btnPOSTCalls = new System.Windows.Forms.Button();
            this.btnDELETECalls = new System.Windows.Forms.Button();
            this.btnOpenLoggingWindow = new System.Windows.Forms.Button();
            this.cbxCallStatusEvent = new System.Windows.Forms.CheckBox();
            this.cbxCallLegStatusEvent = new System.Windows.Forms.CheckBox();
            this.cbxDeviceRegistrationEvent = new System.Windows.Forms.CheckBox();
            this.grbEvent = new System.Windows.Forms.GroupBox();
            this.cbxOpenDoorEvent = new System.Windows.Forms.CheckBox();
            this.cbxDeviceGPIStatusEvent = new System.Windows.Forms.CheckBox();
            this.cbxDeviceGPOStatusEvent = new System.Windows.Forms.CheckBox();
            this.tbxASubscriber = new System.Windows.Forms.TextBox();
            this.tbxBSubscriber = new System.Windows.Forms.TextBox();
            this.lblASubscriber = new System.Windows.Forms.Label();
            this.lblBSubscriber = new System.Windows.Forms.Label();
            this.gbxCallControl = new System.Windows.Forms.GroupBox();
            this.btnGETCallLegs = new System.Windows.Forms.Button();
            this.grpbxPOSTCalls = new System.Windows.Forms.GroupBox();
            this.btnPOSTOpenDoor = new System.Windows.Forms.Button();
            this.cmbxCallAction = new System.Windows.Forms.ComboBox();
            this.lblAction = new System.Windows.Forms.Label();
            this.btnGETCalls = new System.Windows.Forms.Button();
            this.btnDELETECallId = new System.Windows.Forms.Button();
            this.gbxSwaggerSystem = new System.Windows.Forms.GroupBox();
            this.btnGETNetInterface = new System.Windows.Forms.Button();
            this.gbxAuthentication = new System.Windows.Forms.GroupBox();
            this.chbxUnencrypted = new System.Windows.Forms.CheckBox();
            this.chbxEncrypted = new System.Windows.Forms.CheckBox();
            this.labEncryption = new System.Windows.Forms.Label();
            this.blConnectionStatus = new System.Windows.Forms.Label();
            this.tbxConnectionStatus = new System.Windows.Forms.TextBox();
            this.gbxDevice = new System.Windows.Forms.GroupBox();
            this.tbxGPIDevice = new System.Windows.Forms.TextBox();
            this.lblGPIDevice = new System.Windows.Forms.Label();
            this.tbxGPODevice = new System.Windows.Forms.TextBox();
            this.lblGPODevice = new System.Windows.Forms.Label();
            this.btnGETDeviceGPIOs = new System.Windows.Forms.Button();
            this.btnGETDeviceGPOs = new System.Windows.Forms.Button();
            this.btnPOSTDeviceGPO = new System.Windows.Forms.Button();
            this.grpbxRegistratedDevices = new System.Windows.Forms.GroupBox();
            this.btnClearList = new System.Windows.Forms.Button();
            this.dgrd_Registrations = new System.Windows.Forms.DataGridView();
            this.dgrdIP_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrdDeviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrdDirNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrdLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgrdState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxActiveCalls = new System.Windows.Forms.GroupBox();
            this.dgrdActiveCalls = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxLogging = new System.Windows.Forms.GroupBox();
            this.lblLogFileSavingLocation = new System.Windows.Forms.Label();
            this.cbxSaveLoggingToFile = new System.Windows.Forms.CheckBox();
            this.btnClearLoggingWindow = new System.Windows.Forms.Button();
            this.btnCloseLoggingWindow = new System.Windows.Forms.Button();
            this.gbxQueuedCalls = new System.Windows.Forms.GroupBox();
            this.dgrdQueuedCalls = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxNetInterfaces = new System.Windows.Forms.GroupBox();
            this.btnClearNetInterfaces = new System.Windows.Forms.Button();
            this.dgrdNetInterfaces = new System.Windows.Forms.DataGridView();
            this.NetMACaddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxRegisterService = new System.Windows.Forms.GroupBox();
            this.btnRegisterCalleeServices = new System.Windows.Forms.Button();
            this.grpbxPublishEvent = new System.Windows.Forms.GroupBox();
            this.btnNewUCTTime = new System.Windows.Forms.Button();
            this.grpbBroadcasting = new System.Windows.Forms.GroupBox();
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.lbAudioMessages = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbEvent.SuspendLayout();
            this.gbxCallControl.SuspendLayout();
            this.grpbxPOSTCalls.SuspendLayout();
            this.gbxSwaggerSystem.SuspendLayout();
            this.gbxAuthentication.SuspendLayout();
            this.gbxDevice.SuspendLayout();
            this.grpbxRegistratedDevices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_Registrations)).BeginInit();
            this.gbxActiveCalls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdActiveCalls)).BeginInit();
            this.gbxLogging.SuspendLayout();
            this.gbxQueuedCalls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdQueuedCalls)).BeginInit();
            this.gbxNetInterfaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdNetInterfaces)).BeginInit();
            this.gbxRegisterService.SuspendLayout();
            this.grpbxPublishEvent.SuspendLayout();
            this.grpbBroadcasting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWampConnect
            // 
            this.btnWampConnect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnWampConnect.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWampConnect.Location = new System.Drawing.Point(910, 23);
            this.btnWampConnect.Name = "btnWampConnect";
            this.btnWampConnect.Size = new System.Drawing.Size(100, 46);
            this.btnWampConnect.TabIndex = 0;
            this.btnWampConnect.Text = "WAMP Connect";
            this.btnWampConnect.UseVisualStyleBackColor = false;
            this.btnWampConnect.Click += new System.EventHandler(this.btnWampConnect_Click);
            // 
            // btnWampDisconnect
            // 
            this.btnWampDisconnect.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWampDisconnect.Location = new System.Drawing.Point(911, 79);
            this.btnWampDisconnect.Name = "btnWampDisconnect";
            this.btnWampDisconnect.Size = new System.Drawing.Size(98, 46);
            this.btnWampDisconnect.TabIndex = 1;
            this.btnWampDisconnect.Text = "WAMP Disconnect";
            this.btnWampDisconnect.UseVisualStyleBackColor = true;
            this.btnWampDisconnect.Click += new System.EventHandler(this.btnWampDisconnect_Click);
            // 
            // lab_WAMPServerAddress
            // 
            this.lab_WAMPServerAddress.AutoSize = true;
            this.lab_WAMPServerAddress.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_WAMPServerAddress.Location = new System.Drawing.Point(15, 46);
            this.lab_WAMPServerAddress.Name = "lab_WAMPServerAddress";
            this.lab_WAMPServerAddress.Size = new System.Drawing.Size(132, 14);
            this.lab_WAMPServerAddress.TabIndex = 3;
            this.lab_WAMPServerAddress.Text = "WAMP Server Address";
            // 
            // edtWAMPServerAddr
            // 
            this.edtWAMPServerAddr.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtWAMPServerAddr.Location = new System.Drawing.Point(15, 63);
            this.edtWAMPServerAddr.Name = "edtWAMPServerAddr";
            this.edtWAMPServerAddr.Size = new System.Drawing.Size(124, 23);
            this.edtWAMPServerAddr.TabIndex = 4;
            this.edtWAMPServerAddr.Text = "169.254.1.5";
            // 
            // edtUserName
            // 
            this.edtUserName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtUserName.Location = new System.Drawing.Point(151, 63);
            this.edtUserName.Name = "edtUserName";
            this.edtUserName.Size = new System.Drawing.Size(110, 23);
            this.edtUserName.TabIndex = 6;
            // 
            // labUserName
            // 
            this.labUserName.AutoSize = true;
            this.labUserName.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUserName.Location = new System.Drawing.Point(151, 46);
            this.labUserName.Name = "labUserName";
            this.labUserName.Size = new System.Drawing.Size(67, 14);
            this.labUserName.TabIndex = 5;
            this.labUserName.Text = "User Name";
            // 
            // edtPassword
            // 
            this.edtPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPassword.Location = new System.Drawing.Point(275, 63);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.Size = new System.Drawing.Size(110, 23);
            this.edtPassword.TabIndex = 8;
            this.edtPassword.UseSystemPasswordChar = true;
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPassword.Location = new System.Drawing.Point(275, 46);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(63, 14);
            this.labPassword.TabIndex = 7;
            this.labPassword.Text = "Password";
            // 
            // edtWampRealm
            // 
            this.edtWampRealm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtWampRealm.Location = new System.Drawing.Point(411, 63);
            this.edtWampRealm.Name = "edtWampRealm";
            this.edtWampRealm.Size = new System.Drawing.Size(110, 23);
            this.edtWampRealm.TabIndex = 12;
            this.edtWampRealm.Text = "zenitel";
            // 
            // labWampRealm
            // 
            this.labWampRealm.AutoSize = true;
            this.labWampRealm.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWampRealm.Location = new System.Drawing.Point(411, 46);
            this.labWampRealm.Name = "labWampRealm";
            this.labWampRealm.Size = new System.Drawing.Size(76, 14);
            this.labWampRealm.TabIndex = 11;
            this.labWampRealm.Text = "WAMP realm";
            // 
            // btnGETDeviceAccounts
            // 
            this.btnGETDeviceAccounts.Location = new System.Drawing.Point(20, 28);
            this.btnGETDeviceAccounts.Name = "btnGETDeviceAccounts";
            this.btnGETDeviceAccounts.Size = new System.Drawing.Size(110, 63);
            this.btnGETDeviceAccounts.TabIndex = 2;
            this.btnGETDeviceAccounts.Text = "GET \r\nDevice Accounts";
            this.btnGETDeviceAccounts.UseVisualStyleBackColor = true;
            this.btnGETDeviceAccounts.Click += new System.EventHandler(this.btnGETDevicesRegistered_Click);
            // 
            // btnPOSTCalls
            // 
            this.btnPOSTCalls.Location = new System.Drawing.Point(128, 15);
            this.btnPOSTCalls.Name = "btnPOSTCalls";
            this.btnPOSTCalls.Size = new System.Drawing.Size(118, 60);
            this.btnPOSTCalls.TabIndex = 15;
            this.btnPOSTCalls.Text = "POST\r\nCalls";
            this.btnPOSTCalls.UseVisualStyleBackColor = true;
            this.btnPOSTCalls.Click += new System.EventHandler(this.btn_EstablishConnection_Click);
            // 
            // btnDELETECalls
            // 
            this.btnDELETECalls.Location = new System.Drawing.Point(152, 175);
            this.btnDELETECalls.Name = "btnDELETECalls";
            this.btnDELETECalls.Size = new System.Drawing.Size(118, 60);
            this.btnDELETECalls.TabIndex = 16;
            this.btnDELETECalls.Text = "DELETE\r\nCalls";
            this.btnDELETECalls.UseVisualStyleBackColor = true;
            this.btnDELETECalls.Click += new System.EventHandler(this.btn_ClearConnection_Click);
            // 
            // btnOpenLoggingWindow
            // 
            this.btnOpenLoggingWindow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenLoggingWindow.Location = new System.Drawing.Point(16, 74);
            this.btnOpenLoggingWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenLoggingWindow.Name = "btnOpenLoggingWindow";
            this.btnOpenLoggingWindow.Size = new System.Drawing.Size(100, 54);
            this.btnOpenLoggingWindow.TabIndex = 23;
            this.btnOpenLoggingWindow.Text = "Open\r\nLogging Window";
            this.btnOpenLoggingWindow.UseVisualStyleBackColor = true;
            this.btnOpenLoggingWindow.Click += new System.EventHandler(this.btnOpenLoggingWindow_Click);
            // 
            // cbxCallStatusEvent
            // 
            this.cbxCallStatusEvent.AutoSize = true;
            this.cbxCallStatusEvent.Location = new System.Drawing.Point(17, 28);
            this.cbxCallStatusEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCallStatusEvent.Name = "cbxCallStatusEvent";
            this.cbxCallStatusEvent.Size = new System.Drawing.Size(145, 20);
            this.cbxCallStatusEvent.TabIndex = 27;
            this.cbxCallStatusEvent.Text = "Call Status Event";
            this.cbxCallStatusEvent.UseVisualStyleBackColor = true;
            this.cbxCallStatusEvent.CheckedChanged += new System.EventHandler(this.cbxCallStatusEvent_CheckedChanged);
            // 
            // cbxCallLegStatusEvent
            // 
            this.cbxCallLegStatusEvent.AutoSize = true;
            this.cbxCallLegStatusEvent.Location = new System.Drawing.Point(17, 64);
            this.cbxCallLegStatusEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCallLegStatusEvent.Name = "cbxCallLegStatusEvent";
            this.cbxCallLegStatusEvent.Size = new System.Drawing.Size(175, 20);
            this.cbxCallLegStatusEvent.TabIndex = 28;
            this.cbxCallLegStatusEvent.Text = "Call Leg Status Event";
            this.cbxCallLegStatusEvent.UseVisualStyleBackColor = true;
            this.cbxCallLegStatusEvent.CheckedChanged += new System.EventHandler(this.cbxCallQueueStatusEvent_CheckedChanged);
            // 
            // cbxDeviceRegistrationEvent
            // 
            this.cbxDeviceRegistrationEvent.AutoSize = true;
            this.cbxDeviceRegistrationEvent.Location = new System.Drawing.Point(17, 102);
            this.cbxDeviceRegistrationEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDeviceRegistrationEvent.Name = "cbxDeviceRegistrationEvent";
            this.cbxDeviceRegistrationEvent.Size = new System.Drawing.Size(210, 20);
            this.cbxDeviceRegistrationEvent.TabIndex = 29;
            this.cbxDeviceRegistrationEvent.Text = "Device Registration Event";
            this.cbxDeviceRegistrationEvent.UseVisualStyleBackColor = true;
            this.cbxDeviceRegistrationEvent.CheckedChanged += new System.EventHandler(this.cbxDeviceRegistrationEvent_CheckedChanged);
            // 
            // grbEvent
            // 
            this.grbEvent.Controls.Add(this.cbxOpenDoorEvent);
            this.grbEvent.Controls.Add(this.cbxDeviceGPIStatusEvent);
            this.grbEvent.Controls.Add(this.cbxDeviceGPOStatusEvent);
            this.grbEvent.Controls.Add(this.cbxCallStatusEvent);
            this.grbEvent.Controls.Add(this.cbxDeviceRegistrationEvent);
            this.grbEvent.Controls.Add(this.cbxCallLegStatusEvent);
            this.grbEvent.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEvent.Location = new System.Drawing.Point(1055, 159);
            this.grbEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEvent.Name = "grbEvent";
            this.grbEvent.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEvent.Size = new System.Drawing.Size(396, 320);
            this.grbEvent.TabIndex = 30;
            this.grbEvent.TabStop = false;
            this.grbEvent.Text = "Events";
            // 
            // cbxOpenDoorEvent
            // 
            this.cbxOpenDoorEvent.AutoSize = true;
            this.cbxOpenDoorEvent.Location = new System.Drawing.Point(17, 227);
            this.cbxOpenDoorEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxOpenDoorEvent.Name = "cbxOpenDoorEvent";
            this.cbxOpenDoorEvent.Size = new System.Drawing.Size(147, 20);
            this.cbxOpenDoorEvent.TabIndex = 32;
            this.cbxOpenDoorEvent.Text = "Open Door Event";
            this.cbxOpenDoorEvent.UseVisualStyleBackColor = true;
            this.cbxOpenDoorEvent.CheckedChanged += new System.EventHandler(this.cbxOpenDoor_CheckedChanged);
            // 
            // cbxDeviceGPIStatusEvent
            // 
            this.cbxDeviceGPIStatusEvent.AutoSize = true;
            this.cbxDeviceGPIStatusEvent.Location = new System.Drawing.Point(17, 187);
            this.cbxDeviceGPIStatusEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDeviceGPIStatusEvent.Name = "cbxDeviceGPIStatusEvent";
            this.cbxDeviceGPIStatusEvent.Size = new System.Drawing.Size(231, 20);
            this.cbxDeviceGPIStatusEvent.TabIndex = 31;
            this.cbxDeviceGPIStatusEvent.Text = "Device GPI Status Event (n/a)";
            this.cbxDeviceGPIStatusEvent.UseVisualStyleBackColor = true;
            this.cbxDeviceGPIStatusEvent.CheckedChanged += new System.EventHandler(this.cbxDeviceGPIStatusEvent_CheckedChanged);
            // 
            // cbxDeviceGPOStatusEvent
            // 
            this.cbxDeviceGPOStatusEvent.AutoSize = true;
            this.cbxDeviceGPOStatusEvent.Location = new System.Drawing.Point(17, 144);
            this.cbxDeviceGPOStatusEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxDeviceGPOStatusEvent.Name = "cbxDeviceGPOStatusEvent";
            this.cbxDeviceGPOStatusEvent.Size = new System.Drawing.Size(238, 20);
            this.cbxDeviceGPOStatusEvent.TabIndex = 30;
            this.cbxDeviceGPOStatusEvent.Text = "Device GPO Status Event (n/a)";
            this.cbxDeviceGPOStatusEvent.UseVisualStyleBackColor = true;
            this.cbxDeviceGPOStatusEvent.CheckedChanged += new System.EventHandler(this.cbxGPOStatusEvent_CheckedChanged);
            // 
            // tbxASubscriber
            // 
            this.tbxASubscriber.AutoCompleteCustomSource.AddRange(new string[] {
            "141",
            "142",
            "143",
            "144",
            "145"});
            this.tbxASubscriber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxASubscriber.Location = new System.Drawing.Point(19, 47);
            this.tbxASubscriber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxASubscriber.Name = "tbxASubscriber";
            this.tbxASubscriber.Size = new System.Drawing.Size(58, 23);
            this.tbxASubscriber.TabIndex = 32;
            this.tbxASubscriber.Text = "101";
            this.tbxASubscriber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxBSubscriber
            // 
            this.tbxBSubscriber.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBSubscriber.Location = new System.Drawing.Point(19, 107);
            this.tbxBSubscriber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxBSubscriber.Name = "tbxBSubscriber";
            this.tbxBSubscriber.Size = new System.Drawing.Size(58, 23);
            this.tbxBSubscriber.TabIndex = 33;
            this.tbxBSubscriber.Text = "102";
            this.tbxBSubscriber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblASubscriber
            // 
            this.lblASubscriber.AutoSize = true;
            this.lblASubscriber.Location = new System.Drawing.Point(16, 19);
            this.lblASubscriber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblASubscriber.Name = "lblASubscriber";
            this.lblASubscriber.Size = new System.Drawing.Size(102, 16);
            this.lblASubscriber.TabIndex = 34;
            this.lblASubscriber.Text = "A-Subscriber:";
            // 
            // lblBSubscriber
            // 
            this.lblBSubscriber.AutoSize = true;
            this.lblBSubscriber.Location = new System.Drawing.Point(18, 85);
            this.lblBSubscriber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBSubscriber.Name = "lblBSubscriber";
            this.lblBSubscriber.Size = new System.Drawing.Size(103, 16);
            this.lblBSubscriber.TabIndex = 35;
            this.lblBSubscriber.Text = "B-Subscriber:";
            // 
            // gbxCallControl
            // 
            this.gbxCallControl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxCallControl.Controls.Add(this.btnGETCallLegs);
            this.gbxCallControl.Controls.Add(this.grpbxPOSTCalls);
            this.gbxCallControl.Controls.Add(this.btnGETCalls);
            this.gbxCallControl.Controls.Add(this.btnDELETECallId);
            this.gbxCallControl.Controls.Add(this.btnDELETECalls);
            this.gbxCallControl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCallControl.Location = new System.Drawing.Point(194, 159);
            this.gbxCallControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCallControl.Name = "gbxCallControl";
            this.gbxCallControl.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCallControl.Size = new System.Drawing.Size(424, 320);
            this.gbxCallControl.TabIndex = 36;
            this.gbxCallControl.TabStop = false;
            this.gbxCallControl.Text = "Call Handling";
            // 
            // btnGETCallLegs
            // 
            this.btnGETCallLegs.Location = new System.Drawing.Point(19, 245);
            this.btnGETCallLegs.Name = "btnGETCallLegs";
            this.btnGETCallLegs.Size = new System.Drawing.Size(118, 60);
            this.btnGETCallLegs.TabIndex = 43;
            this.btnGETCallLegs.Text = "GET\r\nCall Legs";
            this.btnGETCallLegs.UseVisualStyleBackColor = true;
            this.btnGETCallLegs.Click += new System.EventHandler(this.btnGETCallQueueLegs_Click);
            // 
            // grpbxPOSTCalls
            // 
            this.grpbxPOSTCalls.Controls.Add(this.btnPOSTOpenDoor);
            this.grpbxPOSTCalls.Controls.Add(this.cmbxCallAction);
            this.grpbxPOSTCalls.Controls.Add(this.btnPOSTCalls);
            this.grpbxPOSTCalls.Controls.Add(this.lblAction);
            this.grpbxPOSTCalls.Controls.Add(this.tbxASubscriber);
            this.grpbxPOSTCalls.Controls.Add(this.tbxBSubscriber);
            this.grpbxPOSTCalls.Controls.Add(this.lblASubscriber);
            this.grpbxPOSTCalls.Controls.Add(this.lblBSubscriber);
            this.grpbxPOSTCalls.Location = new System.Drawing.Point(19, 16);
            this.grpbxPOSTCalls.Name = "grpbxPOSTCalls";
            this.grpbxPOSTCalls.Size = new System.Drawing.Size(392, 146);
            this.grpbxPOSTCalls.TabIndex = 42;
            this.grpbxPOSTCalls.TabStop = false;
            // 
            // btnPOSTOpenDoor
            // 
            this.btnPOSTOpenDoor.Location = new System.Drawing.Point(262, 15);
            this.btnPOSTOpenDoor.Name = "btnPOSTOpenDoor";
            this.btnPOSTOpenDoor.Size = new System.Drawing.Size(118, 60);
            this.btnPOSTOpenDoor.TabIndex = 42;
            this.btnPOSTOpenDoor.Text = "POST\r\n Open Door";
            this.btnPOSTOpenDoor.UseVisualStyleBackColor = true;
            this.btnPOSTOpenDoor.Click += new System.EventHandler(this.btnPOSTOpenDoor_Click);
            // 
            // cmbxCallAction
            // 
            this.cmbxCallAction.FormattingEnabled = true;
            this.cmbxCallAction.Location = new System.Drawing.Point(131, 107);
            this.cmbxCallAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbxCallAction.Name = "cmbxCallAction";
            this.cmbxCallAction.Size = new System.Drawing.Size(116, 24);
            this.cmbxCallAction.TabIndex = 41;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(130, 85);
            this.lblAction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(55, 16);
            this.lblAction.TabIndex = 40;
            this.lblAction.Text = "Action:";
            // 
            // btnGETCalls
            // 
            this.btnGETCalls.Location = new System.Drawing.Point(19, 175);
            this.btnGETCalls.Name = "btnGETCalls";
            this.btnGETCalls.Size = new System.Drawing.Size(118, 60);
            this.btnGETCalls.TabIndex = 4;
            this.btnGETCalls.Text = "GET\r\nCalls";
            this.btnGETCalls.UseVisualStyleBackColor = true;
            this.btnGETCalls.Click += new System.EventHandler(this.btnGetCalls_Click);
            // 
            // btnDELETECallId
            // 
            this.btnDELETECallId.Location = new System.Drawing.Point(152, 245);
            this.btnDELETECallId.Name = "btnDELETECallId";
            this.btnDELETECallId.Size = new System.Drawing.Size(118, 60);
            this.btnDELETECallId.TabIndex = 36;
            this.btnDELETECallId.Text = "DELETE\r\nCall Id";
            this.btnDELETECallId.UseVisualStyleBackColor = true;
            this.btnDELETECallId.Click += new System.EventHandler(this.btnClearConnectionId_Click);
            // 
            // gbxSwaggerSystem
            // 
            this.gbxSwaggerSystem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxSwaggerSystem.Controls.Add(this.btnGETNetInterface);
            this.gbxSwaggerSystem.Controls.Add(this.btnGETDeviceAccounts);
            this.gbxSwaggerSystem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSwaggerSystem.Location = new System.Drawing.Point(14, 159);
            this.gbxSwaggerSystem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxSwaggerSystem.Name = "gbxSwaggerSystem";
            this.gbxSwaggerSystem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxSwaggerSystem.Size = new System.Drawing.Size(154, 188);
            this.gbxSwaggerSystem.TabIndex = 37;
            this.gbxSwaggerSystem.TabStop = false;
            this.gbxSwaggerSystem.Text = "System";
            // 
            // btnGETNetInterface
            // 
            this.btnGETNetInterface.Location = new System.Drawing.Point(20, 104);
            this.btnGETNetInterface.Name = "btnGETNetInterface";
            this.btnGETNetInterface.Size = new System.Drawing.Size(110, 63);
            this.btnGETNetInterface.TabIndex = 3;
            this.btnGETNetInterface.Text = "GET\r\n Net Interfaces";
            this.btnGETNetInterface.UseVisualStyleBackColor = true;
            this.btnGETNetInterface.Click += new System.EventHandler(this.btnGETNetInterfaces_Click);
            // 
            // gbxAuthentication
            // 
            this.gbxAuthentication.Controls.Add(this.chbxUnencrypted);
            this.gbxAuthentication.Controls.Add(this.chbxEncrypted);
            this.gbxAuthentication.Controls.Add(this.labEncryption);
            this.gbxAuthentication.Controls.Add(this.blConnectionStatus);
            this.gbxAuthentication.Controls.Add(this.tbxConnectionStatus);
            this.gbxAuthentication.Controls.Add(this.btnWampDisconnect);
            this.gbxAuthentication.Controls.Add(this.btnWampConnect);
            this.gbxAuthentication.Controls.Add(this.lab_WAMPServerAddress);
            this.gbxAuthentication.Controls.Add(this.edtWAMPServerAddr);
            this.gbxAuthentication.Controls.Add(this.labUserName);
            this.gbxAuthentication.Controls.Add(this.edtUserName);
            this.gbxAuthentication.Controls.Add(this.edtWampRealm);
            this.gbxAuthentication.Controls.Add(this.labPassword);
            this.gbxAuthentication.Controls.Add(this.labWampRealm);
            this.gbxAuthentication.Controls.Add(this.edtPassword);
            this.gbxAuthentication.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAuthentication.Location = new System.Drawing.Point(13, 4);
            this.gbxAuthentication.Name = "gbxAuthentication";
            this.gbxAuthentication.Size = new System.Drawing.Size(1025, 145);
            this.gbxAuthentication.TabIndex = 38;
            this.gbxAuthentication.TabStop = false;
            this.gbxAuthentication.Text = "Authentication";
            // 
            // chbxUnencrypted
            // 
            this.chbxUnencrypted.AutoSize = true;
            this.chbxUnencrypted.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxUnencrypted.Location = new System.Drawing.Point(554, 79);
            this.chbxUnencrypted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbxUnencrypted.Name = "chbxUnencrypted";
            this.chbxUnencrypted.Size = new System.Drawing.Size(206, 21);
            this.chbxUnencrypted.TabIndex = 30;
            this.chbxUnencrypted.Text = "Unencrypted (Port 80/8087)";
            this.chbxUnencrypted.UseVisualStyleBackColor = true;
            this.chbxUnencrypted.CheckedChanged += new System.EventHandler(this.chbxUnencrypted_CheckedChanged);
            // 
            // chbxEncrypted
            // 
            this.chbxEncrypted.AutoSize = true;
            this.chbxEncrypted.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxEncrypted.Location = new System.Drawing.Point(554, 50);
            this.chbxEncrypted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbxEncrypted.Name = "chbxEncrypted";
            this.chbxEncrypted.Size = new System.Drawing.Size(198, 21);
            this.chbxEncrypted.TabIndex = 29;
            this.chbxEncrypted.Text = "Encrypted (Port 443/8086)";
            this.chbxEncrypted.UseVisualStyleBackColor = true;
            this.chbxEncrypted.CheckedChanged += new System.EventHandler(this.chbxEncrypted_CheckedChanged);
            // 
            // labEncryption
            // 
            this.labEncryption.AutoSize = true;
            this.labEncryption.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEncryption.Location = new System.Drawing.Point(551, 32);
            this.labEncryption.Name = "labEncryption";
            this.labEncryption.Size = new System.Drawing.Size(119, 14);
            this.labEncryption.TabIndex = 17;
            this.labEncryption.Text = "Encryption Selection";
            // 
            // blConnectionStatus
            // 
            this.blConnectionStatus.AutoSize = true;
            this.blConnectionStatus.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blConnectionStatus.Location = new System.Drawing.Point(783, 31);
            this.blConnectionStatus.Name = "blConnectionStatus";
            this.blConnectionStatus.Size = new System.Drawing.Size(108, 14);
            this.blConnectionStatus.TabIndex = 14;
            this.blConnectionStatus.Text = "Connection Status";
            // 
            // tbxConnectionStatus
            // 
            this.tbxConnectionStatus.Enabled = false;
            this.tbxConnectionStatus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConnectionStatus.Location = new System.Drawing.Point(786, 48);
            this.tbxConnectionStatus.Name = "tbxConnectionStatus";
            this.tbxConnectionStatus.Size = new System.Drawing.Size(110, 23);
            this.tbxConnectionStatus.TabIndex = 15;
            this.tbxConnectionStatus.Text = "Disconnected";
            // 
            // gbxDevice
            // 
            this.gbxDevice.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxDevice.Controls.Add(this.tbxGPIDevice);
            this.gbxDevice.Controls.Add(this.lblGPIDevice);
            this.gbxDevice.Controls.Add(this.tbxGPODevice);
            this.gbxDevice.Controls.Add(this.lblGPODevice);
            this.gbxDevice.Controls.Add(this.btnGETDeviceGPIOs);
            this.gbxDevice.Controls.Add(this.btnGETDeviceGPOs);
            this.gbxDevice.Controls.Add(this.btnPOSTDeviceGPO);
            this.gbxDevice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDevice.Location = new System.Drawing.Point(783, 159);
            this.gbxDevice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxDevice.Name = "gbxDevice";
            this.gbxDevice.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxDevice.Size = new System.Drawing.Size(254, 320);
            this.gbxDevice.TabIndex = 39;
            this.gbxDevice.TabStop = false;
            this.gbxDevice.Text = "Device (n/a)";
            // 
            // tbxGPIDevice
            // 
            this.tbxGPIDevice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGPIDevice.Location = new System.Drawing.Point(160, 209);
            this.tbxGPIDevice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxGPIDevice.Name = "tbxGPIDevice";
            this.tbxGPIDevice.Size = new System.Drawing.Size(58, 23);
            this.tbxGPIDevice.TabIndex = 37;
            this.tbxGPIDevice.Text = "101";
            this.tbxGPIDevice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGPIDevice
            // 
            this.lblGPIDevice.AutoSize = true;
            this.lblGPIDevice.Location = new System.Drawing.Point(158, 192);
            this.lblGPIDevice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGPIDevice.Name = "lblGPIDevice";
            this.lblGPIDevice.Size = new System.Drawing.Size(84, 16);
            this.lblGPIDevice.TabIndex = 38;
            this.lblGPIDevice.Text = "GPI Device";
            // 
            // tbxGPODevice
            // 
            this.tbxGPODevice.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxGPODevice.Location = new System.Drawing.Point(160, 128);
            this.tbxGPODevice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxGPODevice.Name = "tbxGPODevice";
            this.tbxGPODevice.Size = new System.Drawing.Size(58, 23);
            this.tbxGPODevice.TabIndex = 35;
            this.tbxGPODevice.Text = "101\r\n";
            this.tbxGPODevice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGPODevice
            // 
            this.lblGPODevice.AutoSize = true;
            this.lblGPODevice.Location = new System.Drawing.Point(158, 110);
            this.lblGPODevice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGPODevice.Name = "lblGPODevice";
            this.lblGPODevice.Size = new System.Drawing.Size(91, 16);
            this.lblGPODevice.TabIndex = 36;
            this.lblGPODevice.Text = "GPO Device";
            // 
            // btnGETDeviceGPIOs
            // 
            this.btnGETDeviceGPIOs.Location = new System.Drawing.Point(18, 187);
            this.btnGETDeviceGPIOs.Name = "btnGETDeviceGPIOs";
            this.btnGETDeviceGPIOs.Size = new System.Drawing.Size(128, 60);
            this.btnGETDeviceGPIOs.TabIndex = 4;
            this.btnGETDeviceGPIOs.Text = "GET\r\n Device GPIs";
            this.btnGETDeviceGPIOs.UseVisualStyleBackColor = true;
            this.btnGETDeviceGPIOs.Click += new System.EventHandler(this.btnGETDeviceGPIs_Click);
            // 
            // btnGETDeviceGPOs
            // 
            this.btnGETDeviceGPOs.Location = new System.Drawing.Point(18, 106);
            this.btnGETDeviceGPOs.Name = "btnGETDeviceGPOs";
            this.btnGETDeviceGPOs.Size = new System.Drawing.Size(128, 60);
            this.btnGETDeviceGPOs.TabIndex = 3;
            this.btnGETDeviceGPOs.Text = "GET\r\n Device GPOs";
            this.btnGETDeviceGPOs.UseVisualStyleBackColor = true;
            this.btnGETDeviceGPOs.Click += new System.EventHandler(this.btnGETDeviceGPOs_Click);
            // 
            // btnPOSTDeviceGPO
            // 
            this.btnPOSTDeviceGPO.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPOSTDeviceGPO.Location = new System.Drawing.Point(18, 29);
            this.btnPOSTDeviceGPO.Name = "btnPOSTDeviceGPO";
            this.btnPOSTDeviceGPO.Size = new System.Drawing.Size(128, 60);
            this.btnPOSTDeviceGPO.TabIndex = 2;
            this.btnPOSTDeviceGPO.Text = "POST \r\nDevice GPO";
            this.btnPOSTDeviceGPO.UseVisualStyleBackColor = true;
            this.btnPOSTDeviceGPO.Click += new System.EventHandler(this.btnPOSTDeviceGPO_Click);
            // 
            // grpbxRegistratedDevices
            // 
            this.grpbxRegistratedDevices.Controls.Add(this.btnClearList);
            this.grpbxRegistratedDevices.Controls.Add(this.dgrd_Registrations);
            this.grpbxRegistratedDevices.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxRegistratedDevices.Location = new System.Drawing.Point(13, 501);
            this.grpbxRegistratedDevices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxRegistratedDevices.Name = "grpbxRegistratedDevices";
            this.grpbxRegistratedDevices.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxRegistratedDevices.Size = new System.Drawing.Size(754, 259);
            this.grpbxRegistratedDevices.TabIndex = 40;
            this.grpbxRegistratedDevices.TabStop = false;
            this.grpbxRegistratedDevices.Text = "Registered Devices";
            // 
            // btnClearList
            // 
            this.btnClearList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearList.Location = new System.Drawing.Point(658, 213);
            this.btnClearList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(82, 32);
            this.btnClearList.TabIndex = 24;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // dgrd_Registrations
            // 
            this.dgrd_Registrations.AllowUserToAddRows = false;
            this.dgrd_Registrations.AllowUserToDeleteRows = false;
            this.dgrd_Registrations.AllowUserToResizeColumns = false;
            this.dgrd_Registrations.AllowUserToResizeRows = false;
            this.dgrd_Registrations.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgrd_Registrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrd_Registrations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgrdIP_Address,
            this.dgrdDeviceType,
            this.dgrdDirNo,
            this.dgrdName,
            this.dgrdLocation,
            this.dgrdState});
            this.dgrd_Registrations.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrd_Registrations.Location = new System.Drawing.Point(13, 20);
            this.dgrd_Registrations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgrd_Registrations.Name = "dgrd_Registrations";
            this.dgrd_Registrations.RowHeadersWidth = 51;
            this.dgrd_Registrations.RowTemplate.Height = 24;
            this.dgrd_Registrations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgrd_Registrations.Size = new System.Drawing.Size(727, 176);
            this.dgrd_Registrations.TabIndex = 16;
            // 
            // dgrdIP_Address
            // 
            this.dgrdIP_Address.HeaderText = "IP-Address";
            this.dgrdIP_Address.MinimumWidth = 6;
            this.dgrdIP_Address.Name = "dgrdIP_Address";
            this.dgrdIP_Address.Width = 125;
            // 
            // dgrdDeviceType
            // 
            this.dgrdDeviceType.HeaderText = "Device Type";
            this.dgrdDeviceType.MinimumWidth = 100;
            this.dgrdDeviceType.Name = "dgrdDeviceType";
            this.dgrdDeviceType.Width = 130;
            // 
            // dgrdDirNo
            // 
            this.dgrdDirNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgrdDirNo.HeaderText = "Dir. No";
            this.dgrdDirNo.MinimumWidth = 60;
            this.dgrdDirNo.Name = "dgrdDirNo";
            this.dgrdDirNo.Width = 78;
            // 
            // dgrdName
            // 
            this.dgrdName.HeaderText = "Name";
            this.dgrdName.MinimumWidth = 120;
            this.dgrdName.Name = "dgrdName";
            this.dgrdName.Width = 120;
            // 
            // dgrdLocation
            // 
            this.dgrdLocation.HeaderText = "Location";
            this.dgrdLocation.MinimumWidth = 120;
            this.dgrdLocation.Name = "dgrdLocation";
            this.dgrdLocation.Width = 120;
            // 
            // dgrdState
            // 
            this.dgrdState.HeaderText = "State";
            this.dgrdState.MinimumWidth = 180;
            this.dgrdState.Name = "dgrdState";
            this.dgrdState.Width = 180;
            // 
            // gbxActiveCalls
            // 
            this.gbxActiveCalls.Controls.Add(this.dgrdActiveCalls);
            this.gbxActiveCalls.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxActiveCalls.Location = new System.Drawing.Point(783, 501);
            this.gbxActiveCalls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxActiveCalls.Name = "gbxActiveCalls";
            this.gbxActiveCalls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxActiveCalls.Size = new System.Drawing.Size(668, 214);
            this.gbxActiveCalls.TabIndex = 41;
            this.gbxActiveCalls.TabStop = false;
            this.gbxActiveCalls.Text = "Active Calls";
            // 
            // dgrdActiveCalls
            // 
            this.dgrdActiveCalls.AllowUserToAddRows = false;
            this.dgrdActiveCalls.AllowUserToDeleteRows = false;
            this.dgrdActiveCalls.AllowUserToResizeColumns = false;
            this.dgrdActiveCalls.AllowUserToResizeRows = false;
            this.dgrdActiveCalls.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgrdActiveCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdActiveCalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source,
            this.Destination,
            this.CallState,
            this.CallId});
            this.dgrdActiveCalls.Location = new System.Drawing.Point(16, 20);
            this.dgrdActiveCalls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgrdActiveCalls.Name = "dgrdActiveCalls";
            this.dgrdActiveCalls.RowHeadersWidth = 51;
            this.dgrdActiveCalls.RowTemplate.Height = 24;
            this.dgrdActiveCalls.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgrdActiveCalls.Size = new System.Drawing.Size(637, 176);
            this.dgrdActiveCalls.TabIndex = 17;
            // 
            // Source
            // 
            this.Source.HeaderText = "Call from";
            this.Source.MinimumWidth = 130;
            this.Source.Name = "Source";
            this.Source.Width = 130;
            // 
            // Destination
            // 
            this.Destination.HeaderText = "Call to";
            this.Destination.MinimumWidth = 130;
            this.Destination.Name = "Destination";
            this.Destination.Width = 130;
            // 
            // CallState
            // 
            this.CallState.HeaderText = "Call State";
            this.CallState.MinimumWidth = 130;
            this.CallState.Name = "CallState";
            this.CallState.Width = 130;
            // 
            // CallId
            // 
            this.CallId.HeaderText = "Call ID";
            this.CallId.MinimumWidth = 250;
            this.CallId.Name = "CallId";
            this.CallId.Width = 300;
            // 
            // gbxLogging
            // 
            this.gbxLogging.Controls.Add(this.lblLogFileSavingLocation);
            this.gbxLogging.Controls.Add(this.cbxSaveLoggingToFile);
            this.gbxLogging.Controls.Add(this.btnClearLoggingWindow);
            this.gbxLogging.Controls.Add(this.btnCloseLoggingWindow);
            this.gbxLogging.Controls.Add(this.btnOpenLoggingWindow);
            this.gbxLogging.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLogging.Location = new System.Drawing.Point(1055, 9);
            this.gbxLogging.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxLogging.Name = "gbxLogging";
            this.gbxLogging.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxLogging.Size = new System.Drawing.Size(396, 140);
            this.gbxLogging.TabIndex = 42;
            this.gbxLogging.TabStop = false;
            this.gbxLogging.Text = "Logging";
            // 
            // lblLogFileSavingLocation
            // 
            this.lblLogFileSavingLocation.AutoSize = true;
            this.lblLogFileSavingLocation.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogFileSavingLocation.Location = new System.Drawing.Point(14, 47);
            this.lblLogFileSavingLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogFileSavingLocation.Name = "lblLogFileSavingLocation";
            this.lblLogFileSavingLocation.Size = new System.Drawing.Size(35, 14);
            this.lblLogFileSavingLocation.TabIndex = 27;
            this.lblLogFileSavingLocation.Text = "label1";
            // 
            // cbxSaveLoggingToFile
            // 
            this.cbxSaveLoggingToFile.AutoSize = true;
            this.cbxSaveLoggingToFile.Location = new System.Drawing.Point(16, 24);
            this.cbxSaveLoggingToFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSaveLoggingToFile.Name = "cbxSaveLoggingToFile";
            this.cbxSaveLoggingToFile.Size = new System.Drawing.Size(170, 20);
            this.cbxSaveLoggingToFile.TabIndex = 26;
            this.cbxSaveLoggingToFile.Text = "Save Logging to File";
            this.cbxSaveLoggingToFile.UseVisualStyleBackColor = true;
            this.cbxSaveLoggingToFile.CheckedChanged += new System.EventHandler(this.cbxSaveLoggingToFile_CheckedChanged);
            // 
            // btnClearLoggingWindow
            // 
            this.btnClearLoggingWindow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLoggingWindow.Location = new System.Drawing.Point(267, 74);
            this.btnClearLoggingWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearLoggingWindow.Name = "btnClearLoggingWindow";
            this.btnClearLoggingWindow.Size = new System.Drawing.Size(100, 54);
            this.btnClearLoggingWindow.TabIndex = 25;
            this.btnClearLoggingWindow.Text = "Clear\r\nLogging Window";
            this.btnClearLoggingWindow.UseVisualStyleBackColor = true;
            this.btnClearLoggingWindow.Click += new System.EventHandler(this.btnClearLoggingWindow_Click);
            // 
            // btnCloseLoggingWindow
            // 
            this.btnCloseLoggingWindow.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseLoggingWindow.Location = new System.Drawing.Point(149, 74);
            this.btnCloseLoggingWindow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseLoggingWindow.Name = "btnCloseLoggingWindow";
            this.btnCloseLoggingWindow.Size = new System.Drawing.Size(100, 54);
            this.btnCloseLoggingWindow.TabIndex = 24;
            this.btnCloseLoggingWindow.Text = "Close\r\nLogging Window";
            this.btnCloseLoggingWindow.UseVisualStyleBackColor = true;
            this.btnCloseLoggingWindow.Click += new System.EventHandler(this.btnCloseLoggingWindow_Click);
            // 
            // gbxQueuedCalls
            // 
            this.gbxQueuedCalls.Controls.Add(this.dgrdQueuedCalls);
            this.gbxQueuedCalls.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxQueuedCalls.Location = new System.Drawing.Point(783, 732);
            this.gbxQueuedCalls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxQueuedCalls.Name = "gbxQueuedCalls";
            this.gbxQueuedCalls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxQueuedCalls.Size = new System.Drawing.Size(668, 223);
            this.gbxQueuedCalls.TabIndex = 43;
            this.gbxQueuedCalls.TabStop = false;
            this.gbxQueuedCalls.Text = "Queued Calls";
            // 
            // dgrdQueuedCalls
            // 
            this.dgrdQueuedCalls.AllowUserToAddRows = false;
            this.dgrdQueuedCalls.AllowUserToDeleteRows = false;
            this.dgrdQueuedCalls.AllowUserToResizeColumns = false;
            this.dgrdQueuedCalls.AllowUserToResizeRows = false;
            this.dgrdQueuedCalls.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgrdQueuedCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdQueuedCalls.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgrdQueuedCalls.Location = new System.Drawing.Point(15, 24);
            this.dgrdQueuedCalls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgrdQueuedCalls.Name = "dgrdQueuedCalls";
            this.dgrdQueuedCalls.RowHeadersWidth = 51;
            this.dgrdQueuedCalls.RowTemplate.Height = 24;
            this.dgrdQueuedCalls.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgrdQueuedCalls.Size = new System.Drawing.Size(637, 185);
            this.dgrdQueuedCalls.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Call from";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 130;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 130;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Call to";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 130;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Call State";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 130;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Call ID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // gbxNetInterfaces
            // 
            this.gbxNetInterfaces.Controls.Add(this.btnClearNetInterfaces);
            this.gbxNetInterfaces.Controls.Add(this.dgrdNetInterfaces);
            this.gbxNetInterfaces.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNetInterfaces.Location = new System.Drawing.Point(14, 774);
            this.gbxNetInterfaces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxNetInterfaces.Name = "gbxNetInterfaces";
            this.gbxNetInterfaces.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxNetInterfaces.Size = new System.Drawing.Size(753, 180);
            this.gbxNetInterfaces.TabIndex = 44;
            this.gbxNetInterfaces.TabStop = false;
            this.gbxNetInterfaces.Text = "Net Interfaces";
            // 
            // btnClearNetInterfaces
            // 
            this.btnClearNetInterfaces.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearNetInterfaces.Location = new System.Drawing.Point(656, 136);
            this.btnClearNetInterfaces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearNetInterfaces.Name = "btnClearNetInterfaces";
            this.btnClearNetInterfaces.Size = new System.Drawing.Size(82, 32);
            this.btnClearNetInterfaces.TabIndex = 24;
            this.btnClearNetInterfaces.Text = "Clear List";
            this.btnClearNetInterfaces.UseVisualStyleBackColor = true;
            this.btnClearNetInterfaces.Click += new System.EventHandler(this.btnClearNetInterfaces_Click);
            // 
            // dgrdNetInterfaces
            // 
            this.dgrdNetInterfaces.AllowUserToAddRows = false;
            this.dgrdNetInterfaces.AllowUserToDeleteRows = false;
            this.dgrdNetInterfaces.AllowUserToResizeColumns = false;
            this.dgrdNetInterfaces.AllowUserToResizeRows = false;
            this.dgrdNetInterfaces.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgrdNetInterfaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdNetInterfaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NetMACaddr,
            this.NetName,
            this.NetState});
            this.dgrdNetInterfaces.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrdNetInterfaces.Location = new System.Drawing.Point(16, 24);
            this.dgrdNetInterfaces.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgrdNetInterfaces.Name = "dgrdNetInterfaces";
            this.dgrdNetInterfaces.RowHeadersWidth = 51;
            this.dgrdNetInterfaces.RowTemplate.Height = 24;
            this.dgrdNetInterfaces.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgrdNetInterfaces.Size = new System.Drawing.Size(722, 96);
            this.dgrdNetInterfaces.TabIndex = 16;
            // 
            // NetMACaddr
            // 
            this.NetMACaddr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.NetMACaddr.HeaderText = "MAC-addr";
            this.NetMACaddr.MinimumWidth = 160;
            this.NetMACaddr.Name = "NetMACaddr";
            this.NetMACaddr.Width = 160;
            // 
            // NetName
            // 
            this.NetName.HeaderText = "Name";
            this.NetName.MinimumWidth = 120;
            this.NetName.Name = "NetName";
            this.NetName.Width = 120;
            // 
            // NetState
            // 
            this.NetState.HeaderText = "State";
            this.NetState.MinimumWidth = 100;
            this.NetState.Name = "NetState";
            this.NetState.Width = 125;
            // 
            // gbxRegisterService
            // 
            this.gbxRegisterService.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxRegisterService.Controls.Add(this.btnRegisterCalleeServices);
            this.gbxRegisterService.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRegisterService.Location = new System.Drawing.Point(14, 366);
            this.gbxRegisterService.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxRegisterService.Name = "gbxRegisterService";
            this.gbxRegisterService.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxRegisterService.Size = new System.Drawing.Size(169, 113);
            this.gbxRegisterService.TabIndex = 45;
            this.gbxRegisterService.TabStop = false;
            this.gbxRegisterService.Text = "RegisterService";
            // 
            // btnRegisterCalleeServices
            // 
            this.btnRegisterCalleeServices.Location = new System.Drawing.Point(20, 21);
            this.btnRegisterCalleeServices.Name = "btnRegisterCalleeServices";
            this.btnRegisterCalleeServices.Size = new System.Drawing.Size(123, 67);
            this.btnRegisterCalleeServices.TabIndex = 2;
            this.btnRegisterCalleeServices.Text = "Provide\r\nCallee Services\r\n(UCT Time)";
            this.btnRegisterCalleeServices.UseVisualStyleBackColor = true;
            this.btnRegisterCalleeServices.Click += new System.EventHandler(this.btnRegisterCalleeServices_Click);
            // 
            // grpbxPublishEvent
            // 
            this.grpbxPublishEvent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbxPublishEvent.Controls.Add(this.btnNewUCTTime);
            this.grpbxPublishEvent.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbxPublishEvent.Location = new System.Drawing.Point(627, 159);
            this.grpbxPublishEvent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxPublishEvent.Name = "grpbxPublishEvent";
            this.grpbxPublishEvent.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxPublishEvent.Size = new System.Drawing.Size(152, 105);
            this.grpbxPublishEvent.TabIndex = 46;
            this.grpbxPublishEvent.TabStop = false;
            this.grpbxPublishEvent.Text = "Publish Event";
            // 
            // btnNewUCTTime
            // 
            this.btnNewUCTTime.Location = new System.Drawing.Point(10, 23);
            this.btnNewUCTTime.Name = "btnNewUCTTime";
            this.btnNewUCTTime.Size = new System.Drawing.Size(123, 67);
            this.btnNewUCTTime.TabIndex = 2;
            this.btnNewUCTTime.Text = "EVENT\r\nNew UCT Time";
            this.btnNewUCTTime.UseVisualStyleBackColor = true;
            this.btnNewUCTTime.Click += new System.EventHandler(this.btnNewUCTTime_Click);
            // 
            // grpbBroadcasting
            // 
            this.grpbBroadcasting.Controls.Add(this.lbGroups);
            this.grpbBroadcasting.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.grpbBroadcasting.Location = new System.Drawing.Point(627, 261);
            this.grpbBroadcasting.Name = "grpbBroadcasting";
            this.grpbBroadcasting.Size = new System.Drawing.Size(151, 114);
            this.grpbBroadcasting.TabIndex = 47;
            this.grpbBroadcasting.TabStop = false;
            this.grpbBroadcasting.Text = "Groups";
            // 
            // lbGroups
            // 
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.ItemHeight = 16;
            this.lbGroups.Location = new System.Drawing.Point(7, 21);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(138, 84);
            this.lbGroups.TabIndex = 0;
            // 
            // lbAudioMessages
            // 
            this.lbAudioMessages.FormattingEnabled = true;
            this.lbAudioMessages.ItemHeight = 16;
            this.lbAudioMessages.Location = new System.Drawing.Point(7, 22);
            this.lbAudioMessages.Name = "lbAudioMessages";
            this.lbAudioMessages.Size = new System.Drawing.Size(138, 84);
            this.lbAudioMessages.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAudioMessages);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(627, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 107);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Audio Messages";
            // 
            // ZenitelConnectWampGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1469, 862);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpbBroadcasting);
            this.Controls.Add(this.grpbxPublishEvent);
            this.Controls.Add(this.gbxRegisterService);
            this.Controls.Add(this.gbxNetInterfaces);
            this.Controls.Add(this.gbxQueuedCalls);
            this.Controls.Add(this.gbxLogging);
            this.Controls.Add(this.gbxActiveCalls);
            this.Controls.Add(this.grpbxRegistratedDevices);
            this.Controls.Add(this.gbxDevice);
            this.Controls.Add(this.gbxAuthentication);
            this.Controls.Add(this.gbxSwaggerSystem);
            this.Controls.Add(this.gbxCallControl);
            this.Controls.Add(this.grbEvent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ZenitelConnectWampGui";
            this.Text = "Zenitel Connect WAMP SDK";
            this.grbEvent.ResumeLayout(false);
            this.grbEvent.PerformLayout();
            this.gbxCallControl.ResumeLayout(false);
            this.grpbxPOSTCalls.ResumeLayout(false);
            this.grpbxPOSTCalls.PerformLayout();
            this.gbxSwaggerSystem.ResumeLayout(false);
            this.gbxAuthentication.ResumeLayout(false);
            this.gbxAuthentication.PerformLayout();
            this.gbxDevice.ResumeLayout(false);
            this.gbxDevice.PerformLayout();
            this.grpbxRegistratedDevices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrd_Registrations)).EndInit();
            this.gbxActiveCalls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdActiveCalls)).EndInit();
            this.gbxLogging.ResumeLayout(false);
            this.gbxLogging.PerformLayout();
            this.gbxQueuedCalls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdQueuedCalls)).EndInit();
            this.gbxNetInterfaces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrdNetInterfaces)).EndInit();
            this.gbxRegisterService.ResumeLayout(false);
            this.grpbxPublishEvent.ResumeLayout(false);
            this.grpbBroadcasting.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWampConnect;
        private System.Windows.Forms.Button btnWampDisconnect;
        private System.Windows.Forms.Label lab_WAMPServerAddress;
        private System.Windows.Forms.TextBox edtWAMPServerAddr;
        private System.Windows.Forms.TextBox edtUserName;
        private System.Windows.Forms.Label labUserName;
        private System.Windows.Forms.TextBox edtPassword;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.TextBox edtWampRealm;
        private System.Windows.Forms.Label labWampRealm;
        private System.Windows.Forms.Button btnGETDeviceAccounts;
        private System.Windows.Forms.Button btnPOSTCalls;
        private System.Windows.Forms.Button btnDELETECalls;
        private System.Windows.Forms.Button btnOpenLoggingWindow;
        private System.Windows.Forms.CheckBox cbxCallStatusEvent;
        private System.Windows.Forms.CheckBox cbxCallLegStatusEvent;
        private System.Windows.Forms.CheckBox cbxDeviceRegistrationEvent;
        private System.Windows.Forms.GroupBox grbEvent;
        private System.Windows.Forms.TextBox tbxASubscriber;
        private System.Windows.Forms.TextBox tbxBSubscriber;
        private System.Windows.Forms.Label lblASubscriber;
        private System.Windows.Forms.Label lblBSubscriber;
        private System.Windows.Forms.GroupBox gbxCallControl;
        private System.Windows.Forms.GroupBox gbxSwaggerSystem;
        private System.Windows.Forms.Button btnGETNetInterface;
        private System.Windows.Forms.Button btnGETCalls;
        private System.Windows.Forms.Button btnDELETECallId;
        private System.Windows.Forms.CheckBox cbxDeviceGPOStatusEvent;
        private System.Windows.Forms.CheckBox cbxDeviceGPIStatusEvent;
        private System.Windows.Forms.GroupBox gbxAuthentication;
        private System.Windows.Forms.GroupBox gbxDevice;
        private System.Windows.Forms.Button btnGETDeviceGPIOs;
        private System.Windows.Forms.Button btnGETDeviceGPOs;
        private System.Windows.Forms.Button btnPOSTDeviceGPO;
        private System.Windows.Forms.CheckBox cbxOpenDoorEvent;
        private System.Windows.Forms.Label blConnectionStatus;
        private System.Windows.Forms.TextBox tbxConnectionStatus;
        private System.Windows.Forms.GroupBox grpbxRegistratedDevices;
        private System.Windows.Forms.DataGridView dgrd_Registrations;
        private System.Windows.Forms.GroupBox gbxActiveCalls;
        private System.Windows.Forms.DataGridView dgrdActiveCalls;
        private System.Windows.Forms.Button btnClearList;
        private System.Windows.Forms.TextBox tbxGPIDevice;
        private System.Windows.Forms.Label lblGPIDevice;
        private System.Windows.Forms.TextBox tbxGPODevice;
        private System.Windows.Forms.Label lblGPODevice;
        private System.Windows.Forms.GroupBox gbxLogging;
        private System.Windows.Forms.CheckBox cbxSaveLoggingToFile;
        private System.Windows.Forms.Button btnClearLoggingWindow;
        private System.Windows.Forms.Button btnCloseLoggingWindow;
        private System.Windows.Forms.Label lblLogFileSavingLocation;
        private System.Windows.Forms.GroupBox gbxQueuedCalls;
        private System.Windows.Forms.DataGridView dgrdQueuedCalls;
        private System.Windows.Forms.GroupBox gbxNetInterfaces;
        private System.Windows.Forms.Button btnClearNetInterfaces;
        private System.Windows.Forms.DataGridView dgrdNetInterfaces;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetMACaddr;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetState;
        private System.Windows.Forms.ComboBox cmbxCallAction;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.CheckBox chbxUnencrypted;
        private System.Windows.Forms.CheckBox chbxEncrypted;
        private System.Windows.Forms.Label labEncryption;
        private System.Windows.Forms.GroupBox grpbxPOSTCalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallState;
        private System.Windows.Forms.DataGridViewTextBoxColumn CallId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnGETCallLegs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrdIP_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrdDeviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrdDirNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrdLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgrdState;
        private System.Windows.Forms.Button btnPOSTOpenDoor;
        private System.Windows.Forms.GroupBox gbxRegisterService;
        private System.Windows.Forms.Button btnRegisterCalleeServices;
        private System.Windows.Forms.GroupBox grpbxPublishEvent;
        private System.Windows.Forms.Button btnNewUCTTime;
        private System.Windows.Forms.GroupBox grpbBroadcasting;
        private System.Windows.Forms.ListBox lbAudioMessages;
        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

