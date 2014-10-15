namespace EASTester
{
    partial class frmRawEAS
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
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtServerUrl = new System.Windows.Forms.TextBox();
            this.ServerUrl = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.cmboVersion = new System.Windows.Forms.ComboBox();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.txtDeviceType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmboCommand = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOptions = new System.Windows.Forms.Button();
            this.chkUseSSL = new System.Windows.Forms.CheckBox();
            this.chkOverrideSslCertificateVerification = new System.Windows.Forms.CheckBox();
            this.txtPolicyKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveExample = new System.Windows.Forms.Button();
            this.btnLoadExample = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btnEncodingHelper = new System.Windows.Forms.Button();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatusCause = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.chkOverrideProxyCredentials = new System.Windows.Forms.CheckBox();
            this.txtProxyServerDomain = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProxyServerPassword = new System.Windows.Forms.TextBox();
            this.txtProxyServerUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtProxyServerPort = new System.Windows.Forms.TextBox();
            this.lblProxyPort = new System.Windows.Forms.Label();
            this.txtProxyServerName = new System.Windows.Forms.TextBox();
            this.lblProxyServer = new System.Windows.Forms.Label();
            this.chkUseProxy = new System.Windows.Forms.CheckBox();
            this.btnStatusCodeHelper = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDomain
            // 
            this.helpProvider1.SetHelpString(this.txtDomain, "Domain of the user. If you entered an  SMTP address into the User field, then lea" +
        "ve this field blank.");
            this.txtDomain.Location = new System.Drawing.Point(68, 126);
            this.txtDomain.Name = "txtDomain";
            this.helpProvider1.SetShowHelp(this.txtDomain, true);
            this.txtDomain.Size = new System.Drawing.Size(219, 20);
            this.txtDomain.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.helpProvider1.SetHelpString(this.txtPassword, "User password.");
            this.txtPassword.Location = new System.Drawing.Point(68, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.helpProvider1.SetShowHelp(this.txtPassword, true);
            this.txtPassword.Size = new System.Drawing.Size(219, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUser
            // 
            this.helpProvider1.SetHelpString(this.txtUser, "User alias or smtp address.");
            this.txtUser.Location = new System.Drawing.Point(66, 74);
            this.txtUser.Name = "txtUser";
            this.helpProvider1.SetShowHelp(this.txtUser, true);
            this.txtUser.Size = new System.Drawing.Size(219, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(5, 126);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(46, 13);
            this.lblDomain.TabIndex = 15;
            this.lblDomain.Text = "Domain:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 99);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(9, 77);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "User:";
            // 
            // txtServerUrl
            // 
            this.helpProvider1.SetHelpString(this.txtServerUrl, "Mailbox domain or address.  Example: contoso.com");
            this.txtServerUrl.Location = new System.Drawing.Point(123, 42);
            this.txtServerUrl.Name = "txtServerUrl";
            this.helpProvider1.SetShowHelp(this.txtServerUrl, true);
            this.txtServerUrl.Size = new System.Drawing.Size(164, 20);
            this.txtServerUrl.TabIndex = 0;
            this.txtServerUrl.TextChanged += new System.EventHandler(this.txtServerUrl_TextChanged);
            // 
            // ServerUrl
            // 
            this.ServerUrl.AutoSize = true;
            this.ServerUrl.Location = new System.Drawing.Point(9, 45);
            this.ServerUrl.Name = "ServerUrl";
            this.ServerUrl.Size = new System.Drawing.Size(108, 13);
            this.ServerUrl.TabIndex = 18;
            this.ServerUrl.Text = "Mail domain/address:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(304, 43);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(69, 13);
            this.lblVersion.TabIndex = 25;
            this.lblVersion.Text = "EAS Version:";
            // 
            // cmboVersion
            // 
            this.cmboVersion.FormattingEnabled = true;
            this.cmboVersion.ItemHeight = 13;
            this.cmboVersion.Items.AddRange(new object[] {
            "14.1",
            "14.0",
            "12.1",
            "12.0",
            "2.5"});
            this.cmboVersion.Location = new System.Drawing.Point(386, 41);
            this.cmboVersion.Name = "cmboVersion";
            this.cmboVersion.Size = new System.Drawing.Size(95, 21);
            this.cmboVersion.TabIndex = 6;
            this.cmboVersion.Text = "14.1";
            this.cmboVersion.SelectedIndexChanged += new System.EventHandler(this.cmboVersion_SelectedIndexChanged);
            // 
            // txtRequest
            // 
            this.txtRequest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequest.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequest.Location = new System.Drawing.Point(5, 182);
            this.txtRequest.MaxLength = 0;
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequest.Size = new System.Drawing.Size(1073, 237);
            this.txtRequest.TabIndex = 14;
            this.txtRequest.WordWrap = false;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtResponse.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtResponse.Location = new System.Drawing.Point(5, 438);
            this.txtResponse.MaxLength = 0;
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(1073, 168);
            this.txtResponse.TabIndex = 15;
            this.txtResponse.WordWrap = false;
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(938, 152);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(132, 23);
            this.btnRun.TabIndex = 13;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Device Id:";
            // 
            // txtDeviceId
            // 
            this.helpProvider1.SetHelpString(this.txtDeviceId, "TheID of the device.");
            this.txtDeviceId.Location = new System.Drawing.Point(386, 73);
            this.txtDeviceId.Name = "txtDeviceId";
            this.helpProvider1.SetShowHelp(this.txtDeviceId, true);
            this.txtDeviceId.Size = new System.Drawing.Size(174, 20);
            this.txtDeviceId.TabIndex = 7;
            this.txtDeviceId.TextChanged += new System.EventHandler(this.txtDeviceId_TextChanged);
            // 
            // txtDeviceType
            // 
            this.helpProvider1.SetHelpString(this.txtDeviceType, "Device Type");
            this.txtDeviceType.Location = new System.Drawing.Point(386, 99);
            this.txtDeviceType.Name = "txtDeviceType";
            this.helpProvider1.SetShowHelp(this.txtDeviceType, true);
            this.txtDeviceType.Size = new System.Drawing.Size(174, 20);
            this.txtDeviceType.TabIndex = 8;
            this.txtDeviceType.TextChanged += new System.EventHandler(this.txtDeviceType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Device Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Command:";
            // 
            // cmboCommand
            // 
            this.cmboCommand.FormattingEnabled = true;
            this.cmboCommand.Items.AddRange(new object[] {
            "SendMail",
            "SmartForward",
            "SmartReply",
            "FolderSync",
            "FolderCreate",
            "FolderDelete",
            "FolderUpdate",
            "ItemOperations",
            "GetAttachment",
            "GetItemEstimate",
            "MeetingResponse",
            "MoveItems",
            "Ping",
            "Provision",
            "ResolveRecipients",
            "Search",
            "Settings",
            "Sync",
            "ValidateCert"});
            this.cmboCommand.Location = new System.Drawing.Point(386, 125);
            this.cmboCommand.Name = "cmboCommand";
            this.cmboCommand.Size = new System.Drawing.Size(174, 21);
            this.cmboCommand.TabIndex = 9;
            this.cmboCommand.Text = "Command";
            this.cmboCommand.SelectedIndexChanged += new System.EventHandler(this.cmboCommand_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Request:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Response:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Location = new System.Drawing.Point(938, 123);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(129, 23);
            this.btnOptions.TabIndex = 11;
            this.btnOptions.Text = "Submit Options Request";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // chkUseSSL
            // 
            this.chkUseSSL.AutoSize = true;
            this.chkUseSSL.Checked = true;
            this.chkUseSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseSSL.Location = new System.Drawing.Point(881, 10);
            this.chkUseSSL.Name = "chkUseSSL";
            this.chkUseSSL.Size = new System.Drawing.Size(71, 17);
            this.chkUseSSL.TabIndex = 4;
            this.chkUseSSL.Text = "Use SSL:";
            this.chkUseSSL.UseVisualStyleBackColor = true;
            // 
            // chkOverrideSslCertificateVerification
            // 
            this.chkOverrideSslCertificateVerification.AutoSize = true;
            this.chkOverrideSslCertificateVerification.Checked = true;
            this.chkOverrideSslCertificateVerification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpProvider1.SetHelpString(this.chkOverrideSslCertificateVerification, "Check to assume that all certificates are valid.");
            this.chkOverrideSslCertificateVerification.Location = new System.Drawing.Point(881, 33);
            this.chkOverrideSslCertificateVerification.Name = "chkOverrideSslCertificateVerification";
            this.helpProvider1.SetShowHelp(this.chkOverrideSslCertificateVerification, true);
            this.chkOverrideSslCertificateVerification.Size = new System.Drawing.Size(192, 17);
            this.chkOverrideSslCertificateVerification.TabIndex = 5;
            this.chkOverrideSslCertificateVerification.Text = "Override SSL certificate verification";
            this.chkOverrideSslCertificateVerification.UseVisualStyleBackColor = true;
            this.chkOverrideSslCertificateVerification.CheckedChanged += new System.EventHandler(this.chkOverrideSslCertificateVerification_CheckedChanged);
            // 
            // txtPolicyKey
            // 
            this.helpProvider1.SetHelpString(this.txtPolicyKey, "This is needed if there is a policy enforced.  Getting a  permanent policy key is" +
        " a two part process - see documentation on how to get it.");
            this.txtPolicyKey.Location = new System.Drawing.Point(386, 152);
            this.txtPolicyKey.Name = "txtPolicyKey";
            this.helpProvider1.SetShowHelp(this.txtPolicyKey, true);
            this.txtPolicyKey.Size = new System.Drawing.Size(174, 20);
            this.txtPolicyKey.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Policy Key:";
            // 
            // btnSaveExample
            // 
            this.btnSaveExample.Location = new System.Drawing.Point(109, 3);
            this.btnSaveExample.Name = "btnSaveExample";
            this.btnSaveExample.Size = new System.Drawing.Size(97, 23);
            this.btnSaveExample.TabIndex = 45;
            this.btnSaveExample.Text = "Save Example";
            this.btnSaveExample.UseVisualStyleBackColor = true;
            this.btnSaveExample.Click += new System.EventHandler(this.btnSaveExample_Click);
            // 
            // btnLoadExample
            // 
            this.btnLoadExample.Location = new System.Drawing.Point(3, 3);
            this.btnLoadExample.Name = "btnLoadExample";
            this.btnLoadExample.Size = new System.Drawing.Size(97, 23);
            this.btnLoadExample.TabIndex = 47;
            this.btnLoadExample.Text = "Load Example";
            this.btnLoadExample.UseVisualStyleBackColor = true;
            this.btnLoadExample.Click += new System.EventHandler(this.btnLoadExample_Click);
            // 
            // btnEncodingHelper
            // 
            this.btnEncodingHelper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncodingHelper.Location = new System.Drawing.Point(938, 91);
            this.btnEncodingHelper.Name = "btnEncodingHelper";
            this.btnEncodingHelper.Size = new System.Drawing.Size(129, 23);
            this.btnEncodingHelper.TabIndex = 48;
            this.btnEncodingHelper.Text = "Encoding Helper";
            this.btnEncodingHelper.UseVisualStyleBackColor = true;
            this.btnEncodingHelper.Click += new System.EventHandler(this.btnEncodingHelper_Click);
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(3, 3);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(105, 23);
            this.btnLoadSettings.TabIndex = 49;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(114, 4);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(104, 23);
            this.btnSaveSettings.TabIndex = 50;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLoadSettings);
            this.panel1.Controls.Add(this.btnSaveSettings);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 30);
            this.panel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLoadExample);
            this.panel2.Controls.Add(this.btnSaveExample);
            this.panel2.Location = new System.Drawing.Point(238, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 30);
            this.panel2.TabIndex = 52;
            // 
            // lblStatusCause
            // 
            this.lblStatusCause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatusCause.AutoSize = true;
            this.lblStatusCause.Location = new System.Drawing.Point(6, 609);
            this.lblStatusCause.Name = "lblStatusCause";
            this.lblStatusCause.Size = new System.Drawing.Size(147, 13);
            this.lblStatusCause.TabIndex = 57;
            this.lblStatusCause.Text = "Info on response status code:";
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtInfo.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtInfo.Location = new System.Drawing.Point(5, 625);
            this.txtInfo.MaxLength = 0;
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(1073, 102);
            this.txtInfo.TabIndex = 58;
            // 
            // chkOverrideProxyCredentials
            // 
            this.chkOverrideProxyCredentials.Location = new System.Drawing.Point(598, 82);
            this.chkOverrideProxyCredentials.Name = "chkOverrideProxyCredentials";
            this.chkOverrideProxyCredentials.Size = new System.Drawing.Size(268, 19);
            this.chkOverrideProxyCredentials.TabIndex = 66;
            this.chkOverrideProxyCredentials.Text = "Override Proxy Server Credentials";
            this.chkOverrideProxyCredentials.UseVisualStyleBackColor = true;
            this.chkOverrideProxyCredentials.CheckedChanged += new System.EventHandler(this.chkOverrideProxyCredentials_CheckedChanged);
            // 
            // txtProxyServerDomain
            // 
            this.txtProxyServerDomain.Enabled = false;
            this.txtProxyServerDomain.Location = new System.Drawing.Point(719, 158);
            this.txtProxyServerDomain.Name = "txtProxyServerDomain";
            this.txtProxyServerDomain.Size = new System.Drawing.Size(147, 20);
            this.txtProxyServerDomain.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 69;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "Domain:";
            // 
            // txtProxyServerPassword
            // 
            this.txtProxyServerPassword.Enabled = false;
            this.txtProxyServerPassword.Location = new System.Drawing.Point(719, 133);
            this.txtProxyServerPassword.Name = "txtProxyServerPassword";
            this.txtProxyServerPassword.PasswordChar = '•';
            this.txtProxyServerPassword.Size = new System.Drawing.Size(147, 20);
            this.txtProxyServerPassword.TabIndex = 70;
            // 
            // txtProxyServerUserName
            // 
            this.txtProxyServerUserName.Enabled = false;
            this.txtProxyServerUserName.Location = new System.Drawing.Point(719, 107);
            this.txtProxyServerUserName.Name = "txtProxyServerUserName";
            this.txtProxyServerUserName.Size = new System.Drawing.Size(147, 20);
            this.txtProxyServerUserName.TabIndex = 68;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(623, 114);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(32, 13);
            this.lblUserName.TabIndex = 67;
            this.lblUserName.Text = "User:";
            // 
            // txtProxyServerPort
            // 
            this.txtProxyServerPort.Location = new System.Drawing.Point(690, 56);
            this.txtProxyServerPort.Name = "txtProxyServerPort";
            this.txtProxyServerPort.Size = new System.Drawing.Size(176, 20);
            this.txtProxyServerPort.TabIndex = 64;
            this.txtProxyServerPort.Text = "8888";
            // 
            // lblProxyPort
            // 
            this.lblProxyPort.Location = new System.Drawing.Point(595, 58);
            this.lblProxyPort.Name = "lblProxyPort";
            this.lblProxyPort.Size = new System.Drawing.Size(77, 17);
            this.lblProxyPort.TabIndex = 63;
            this.lblProxyPort.Text = "Proxy Port:";
            // 
            // txtProxyServerName
            // 
            this.txtProxyServerName.Location = new System.Drawing.Point(690, 32);
            this.txtProxyServerName.Name = "txtProxyServerName";
            this.txtProxyServerName.Size = new System.Drawing.Size(176, 20);
            this.txtProxyServerName.TabIndex = 62;
            this.txtProxyServerName.Text = "127.0.0.1";
            // 
            // lblProxyServer
            // 
            this.lblProxyServer.Location = new System.Drawing.Point(595, 32);
            this.lblProxyServer.Name = "lblProxyServer";
            this.lblProxyServer.Size = new System.Drawing.Size(77, 17);
            this.lblProxyServer.TabIndex = 61;
            this.lblProxyServer.Text = "Proxy Server:";
            // 
            // chkUseProxy
            // 
            this.chkUseProxy.AutoSize = true;
            this.chkUseProxy.Location = new System.Drawing.Point(569, 6);
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.Size = new System.Drawing.Size(111, 17);
            this.chkUseProxy.TabIndex = 73;
            this.chkUseProxy.Text = "Use Proxy Server:";
            this.chkUseProxy.UseVisualStyleBackColor = true;
            this.chkUseProxy.CheckedChanged += new System.EventHandler(this.chkUseProxy_CheckedChanged);
            // 
            // btnStatusCodeHelper
            // 
            this.btnStatusCodeHelper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatusCodeHelper.Location = new System.Drawing.Point(938, 65);
            this.btnStatusCodeHelper.Name = "btnStatusCodeHelper";
            this.btnStatusCodeHelper.Size = new System.Drawing.Size(129, 23);
            this.btnStatusCodeHelper.TabIndex = 74;
            this.btnStatusCodeHelper.Text = "Status Code Helper";
            this.btnStatusCodeHelper.UseVisualStyleBackColor = true;
            this.btnStatusCodeHelper.Click += new System.EventHandler(this.btnStatusCodeHelper_Click);
            // 
            // frmRawEAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1082, 730);
            this.Controls.Add(this.btnStatusCodeHelper);
            this.Controls.Add(this.chkUseProxy);
            this.Controls.Add(this.chkOverrideProxyCredentials);
            this.Controls.Add(this.txtProxyServerDomain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtProxyServerPassword);
            this.Controls.Add(this.txtProxyServerUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtProxyServerPort);
            this.Controls.Add(this.lblProxyPort);
            this.Controls.Add(this.txtProxyServerName);
            this.Controls.Add(this.lblProxyServer);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblStatusCause);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEncodingHelper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPolicyKey);
            this.Controls.Add(this.chkOverrideSslCertificateVerification);
            this.Controls.Add(this.chkUseSSL);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboCommand);
            this.Controls.Add(this.txtDeviceType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.cmboVersion);
            this.Controls.Add(this.ServerUrl);
            this.Controls.Add(this.txtServerUrl);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Name = "frmRawEAS";
            this.Text = "EAS Conversations";
            this.Load += new System.EventHandler(this.frmRawEAS_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtDomain;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.TextBox txtServerUrl;
        private System.Windows.Forms.Label ServerUrl;
        private System.Windows.Forms.Label lblVersion;
        public System.Windows.Forms.ComboBox cmboVersion;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtDeviceId;
        public System.Windows.Forms.TextBox txtDeviceType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmboCommand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.CheckBox chkUseSSL;
        private System.Windows.Forms.CheckBox chkOverrideSslCertificateVerification;
        public System.Windows.Forms.TextBox txtPolicyKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveExample;
        private System.Windows.Forms.Button btnLoadExample;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button btnEncodingHelper;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStatusCause;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.CheckBox chkOverrideProxyCredentials;
        private System.Windows.Forms.TextBox txtProxyServerDomain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProxyServerPassword;
        private System.Windows.Forms.TextBox txtProxyServerUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtProxyServerPort;
        private System.Windows.Forms.Label lblProxyPort;
        private System.Windows.Forms.TextBox txtProxyServerName;
        private System.Windows.Forms.Label lblProxyServer;
        private System.Windows.Forms.CheckBox chkUseProxy;
        private System.Windows.Forms.Button btnStatusCodeHelper;
    }
}

