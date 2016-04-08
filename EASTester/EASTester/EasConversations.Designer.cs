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
            this.components = new System.ComponentModel.Container();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtHexResponse = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDomain
            // 
            this.helpProvider1.SetHelpString(this.txtDomain, "Domain of the user. If you entered an  SMTP address into the User field, then lea" +
        "ve this field blank.");
            this.txtDomain.Location = new System.Drawing.Point(98, 132);
            this.txtDomain.Margin = new System.Windows.Forms.Padding(1);
            this.txtDomain.Name = "txtDomain";
            this.helpProvider1.SetShowHelp(this.txtDomain, true);
            this.txtDomain.Size = new System.Drawing.Size(211, 22);
            this.txtDomain.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.helpProvider1.SetHelpString(this.txtPassword, "User password.");
            this.txtPassword.Location = new System.Drawing.Point(99, 103);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.helpProvider1.SetShowHelp(this.txtPassword, true);
            this.txtPassword.Size = new System.Drawing.Size(211, 22);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUser
            // 
            this.helpProvider1.SetHelpString(this.txtUser, "User alias or smtp address.");
            this.txtUser.Location = new System.Drawing.Point(98, 73);
            this.txtUser.Margin = new System.Windows.Forms.Padding(1);
            this.txtUser.Name = "txtUser";
            this.helpProvider1.SetShowHelp(this.txtUser, true);
            this.txtUser.Size = new System.Drawing.Size(211, 22);
            this.txtUser.TabIndex = 5;
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(6, 137);
            this.lblDomain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(60, 17);
            this.lblDomain.TabIndex = 8;
            this.lblDomain.Text = "Domain:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(2, 109);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(6, 77);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(42, 17);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User:";
            // 
            // txtServerUrl
            // 
            this.helpProvider1.SetHelpString(this.txtServerUrl, "Mailbox domain or address.  Example: contoso.com");
            this.txtServerUrl.Location = new System.Drawing.Point(142, 46);
            this.txtServerUrl.Margin = new System.Windows.Forms.Padding(1);
            this.txtServerUrl.Name = "txtServerUrl";
            this.helpProvider1.SetShowHelp(this.txtServerUrl, true);
            this.txtServerUrl.Size = new System.Drawing.Size(167, 22);
            this.txtServerUrl.TabIndex = 3;
            this.txtServerUrl.TextChanged += new System.EventHandler(this.txtServerUrl_TextChanged);
            // 
            // ServerUrl
            // 
            this.ServerUrl.AutoSize = true;
            this.ServerUrl.Location = new System.Drawing.Point(6, 49);
            this.ServerUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerUrl.Name = "ServerUrl";
            this.ServerUrl.Size = new System.Drawing.Size(120, 17);
            this.ServerUrl.TabIndex = 2;
            this.ServerUrl.Text = "Mail domain/addr:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(318, 53);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(1);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(91, 17);
            this.lblVersion.TabIndex = 12;
            this.lblVersion.Text = "EAS Version:";
            // 
            // cmboVersion
            // 
            this.cmboVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboVersion.FormattingEnabled = true;
            this.cmboVersion.ItemHeight = 16;
            this.cmboVersion.Items.AddRange(new object[] {
            "16.0",
            "14.1",
            "14.0",
            "12.1",
            "12.0",
            "2.5"});
            this.cmboVersion.Location = new System.Drawing.Point(414, 46);
            this.cmboVersion.Margin = new System.Windows.Forms.Padding(4);
            this.cmboVersion.Name = "cmboVersion";
            this.cmboVersion.Size = new System.Drawing.Size(136, 24);
            this.cmboVersion.TabIndex = 13;
            this.cmboVersion.SelectedIndexChanged += new System.EventHandler(this.cmboVersion_SelectedIndexChanged);
            // 
            // txtRequest
            // 
            this.txtRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRequest.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequest.Location = new System.Drawing.Point(4, 30);
            this.txtRequest.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequest.MaxLength = 0;
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequest.Size = new System.Drawing.Size(1035, 159);
            this.txtRequest.TabIndex = 0;
            this.txtRequest.WordWrap = false;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(854, 96);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(172, 28);
            this.btnRun.TabIndex = 37;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Device Id:";
            // 
            // txtDeviceId
            // 
            this.helpProvider1.SetHelpString(this.txtDeviceId, "TheID of the device.");
            this.txtDeviceId.Location = new System.Drawing.Point(414, 75);
            this.txtDeviceId.Margin = new System.Windows.Forms.Padding(1);
            this.txtDeviceId.Name = "txtDeviceId";
            this.helpProvider1.SetShowHelp(this.txtDeviceId, true);
            this.txtDeviceId.Size = new System.Drawing.Size(136, 22);
            this.txtDeviceId.TabIndex = 15;
            this.txtDeviceId.TextChanged += new System.EventHandler(this.txtDeviceId_TextChanged);
            // 
            // txtDeviceType
            // 
            this.helpProvider1.SetHelpString(this.txtDeviceType, "Device Type");
            this.txtDeviceType.Location = new System.Drawing.Point(414, 103);
            this.txtDeviceType.Margin = new System.Windows.Forms.Padding(1);
            this.txtDeviceType.Name = "txtDeviceType";
            this.helpProvider1.SetShowHelp(this.txtDeviceType, true);
            this.txtDeviceType.Size = new System.Drawing.Size(136, 22);
            this.txtDeviceType.TabIndex = 17;
            this.txtDeviceType.TextChanged += new System.EventHandler(this.txtDeviceType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Device Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Command:";
            // 
            // cmboCommand
            // 
            this.cmboCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cmboCommand.Location = new System.Drawing.Point(414, 130);
            this.cmboCommand.Margin = new System.Windows.Forms.Padding(4);
            this.cmboCommand.Name = "cmboCommand";
            this.cmboCommand.Size = new System.Drawing.Size(136, 24);
            this.cmboCommand.TabIndex = 19;
            this.cmboCommand.SelectedIndexChanged += new System.EventHandler(this.cmboCommand_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Request:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(6, 1);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Response:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(854, 66);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(4);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(172, 28);
            this.btnOptions.TabIndex = 36;
            this.btnOptions.Text = "Submit Options Request";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // chkUseSSL
            // 
            this.chkUseSSL.AutoSize = true;
            this.chkUseSSL.Checked = true;
            this.chkUseSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseSSL.Location = new System.Drawing.Point(7, 164);
            this.chkUseSSL.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseSSL.Name = "chkUseSSL";
            this.chkUseSSL.Size = new System.Drawing.Size(89, 21);
            this.chkUseSSL.TabIndex = 10;
            this.chkUseSSL.Text = "Use SSL:";
            this.chkUseSSL.UseVisualStyleBackColor = true;
            // 
            // chkOverrideSslCertificateVerification
            // 
            this.chkOverrideSslCertificateVerification.AutoSize = true;
            this.chkOverrideSslCertificateVerification.Checked = true;
            this.chkOverrideSslCertificateVerification.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpProvider1.SetHelpString(this.chkOverrideSslCertificateVerification, "Check to assume that all certificates are valid.");
            this.chkOverrideSslCertificateVerification.Location = new System.Drawing.Point(7, 189);
            this.chkOverrideSslCertificateVerification.Margin = new System.Windows.Forms.Padding(4);
            this.chkOverrideSslCertificateVerification.Name = "chkOverrideSslCertificateVerification";
            this.helpProvider1.SetShowHelp(this.chkOverrideSslCertificateVerification, true);
            this.chkOverrideSslCertificateVerification.Size = new System.Drawing.Size(252, 21);
            this.chkOverrideSslCertificateVerification.TabIndex = 11;
            this.chkOverrideSslCertificateVerification.Text = "Override SSL certificate verification";
            this.chkOverrideSslCertificateVerification.UseVisualStyleBackColor = true;
            this.chkOverrideSslCertificateVerification.CheckedChanged += new System.EventHandler(this.chkOverrideSslCertificateVerification_CheckedChanged);
            // 
            // txtPolicyKey
            // 
            this.helpProvider1.SetHelpString(this.txtPolicyKey, "This is needed if there is a policy enforced.  Getting a  permanent policy key is" +
        " a two part process - see documentation on how to get it.");
            this.txtPolicyKey.Location = new System.Drawing.Point(414, 159);
            this.txtPolicyKey.Margin = new System.Windows.Forms.Padding(1);
            this.txtPolicyKey.Name = "txtPolicyKey";
            this.helpProvider1.SetShowHelp(this.txtPolicyKey, true);
            this.txtPolicyKey.Size = new System.Drawing.Size(136, 22);
            this.txtPolicyKey.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Policy Key:";
            // 
            // btnSaveExample
            // 
            this.btnSaveExample.Location = new System.Drawing.Point(123, 4);
            this.btnSaveExample.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveExample.Name = "btnSaveExample";
            this.btnSaveExample.Size = new System.Drawing.Size(112, 28);
            this.btnSaveExample.TabIndex = 45;
            this.btnSaveExample.Text = "Save Example";
            this.btnSaveExample.UseVisualStyleBackColor = true;
            this.btnSaveExample.Click += new System.EventHandler(this.btnSaveExample_Click);
            // 
            // btnLoadExample
            // 
            this.btnLoadExample.Location = new System.Drawing.Point(4, 4);
            this.btnLoadExample.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadExample.Name = "btnLoadExample";
            this.btnLoadExample.Size = new System.Drawing.Size(111, 28);
            this.btnLoadExample.TabIndex = 47;
            this.btnLoadExample.Text = "Load Example";
            this.btnLoadExample.UseVisualStyleBackColor = true;
            this.btnLoadExample.Click += new System.EventHandler(this.btnLoadExample_Click);
            // 
            // btnEncodingHelper
            // 
            this.btnEncodingHelper.Location = new System.Drawing.Point(854, 37);
            this.btnEncodingHelper.Margin = new System.Windows.Forms.Padding(4);
            this.btnEncodingHelper.Name = "btnEncodingHelper";
            this.btnEncodingHelper.Size = new System.Drawing.Size(172, 28);
            this.btnEncodingHelper.TabIndex = 35;
            this.btnEncodingHelper.Text = "Encoding Helper";
            this.btnEncodingHelper.UseVisualStyleBackColor = true;
            this.btnEncodingHelper.Click += new System.EventHandler(this.btnEncodingHelper_Click);
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(4, 4);
            this.btnLoadSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(110, 28);
            this.btnLoadSettings.TabIndex = 49;
            this.btnLoadSettings.Text = "Load Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(122, 4);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(112, 28);
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
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLoadExample);
            this.panel2.Controls.Add(this.btnSaveExample);
            this.panel2.Location = new System.Drawing.Point(255, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 36);
            this.panel2.TabIndex = 1;
            // 
            // lblStatusCause
            // 
            this.lblStatusCause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatusCause.AutoSize = true;
            this.lblStatusCause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatusCause.Location = new System.Drawing.Point(1, 610);
            this.lblStatusCause.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatusCause.Name = "lblStatusCause";
            this.lblStatusCause.Size = new System.Drawing.Size(244, 19);
            this.lblStatusCause.TabIndex = 0;
            this.lblStatusCause.Text = "Information on response status code:";
            // 
            // txtInfo
            // 
            this.txtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtInfo.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtInfo.Location = new System.Drawing.Point(1, 633);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfo.MaxLength = 0;
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(1039, 100);
            this.txtInfo.TabIndex = 1;
            // 
            // chkOverrideProxyCredentials
            // 
            this.chkOverrideProxyCredentials.Location = new System.Drawing.Point(584, 83);
            this.chkOverrideProxyCredentials.Margin = new System.Windows.Forms.Padding(4);
            this.chkOverrideProxyCredentials.Name = "chkOverrideProxyCredentials";
            this.chkOverrideProxyCredentials.Size = new System.Drawing.Size(249, 23);
            this.chkOverrideProxyCredentials.TabIndex = 27;
            this.chkOverrideProxyCredentials.Text = "Override Proxy Server Credentials";
            this.chkOverrideProxyCredentials.UseVisualStyleBackColor = true;
            this.chkOverrideProxyCredentials.CheckedChanged += new System.EventHandler(this.chkOverrideProxyCredentials_CheckedChanged);
            // 
            // txtProxyServerDomain
            // 
            this.txtProxyServerDomain.Enabled = false;
            this.txtProxyServerDomain.Location = new System.Drawing.Point(692, 173);
            this.txtProxyServerDomain.Margin = new System.Windows.Forms.Padding(1);
            this.txtProxyServerDomain.Name = "txtProxyServerDomain";
            this.txtProxyServerDomain.Size = new System.Drawing.Size(141, 22);
            this.txtProxyServerDomain.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 143);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(611, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Domain:";
            // 
            // txtProxyServerPassword
            // 
            this.txtProxyServerPassword.Enabled = false;
            this.txtProxyServerPassword.Location = new System.Drawing.Point(692, 142);
            this.txtProxyServerPassword.Margin = new System.Windows.Forms.Padding(1);
            this.txtProxyServerPassword.Name = "txtProxyServerPassword";
            this.txtProxyServerPassword.PasswordChar = '•';
            this.txtProxyServerPassword.Size = new System.Drawing.Size(141, 22);
            this.txtProxyServerPassword.TabIndex = 31;
            // 
            // txtProxyServerUserName
            // 
            this.txtProxyServerUserName.Enabled = false;
            this.txtProxyServerUserName.Location = new System.Drawing.Point(692, 111);
            this.txtProxyServerUserName.Margin = new System.Windows.Forms.Padding(1);
            this.txtProxyServerUserName.Name = "txtProxyServerUserName";
            this.txtProxyServerUserName.Size = new System.Drawing.Size(141, 22);
            this.txtProxyServerUserName.TabIndex = 29;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(611, 110);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(42, 17);
            this.lblUserName.TabIndex = 28;
            this.lblUserName.Text = "User:";
            // 
            // txtProxyServerPort
            // 
            this.txtProxyServerPort.Location = new System.Drawing.Point(692, 53);
            this.txtProxyServerPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtProxyServerPort.Name = "txtProxyServerPort";
            this.txtProxyServerPort.Size = new System.Drawing.Size(104, 22);
            this.txtProxyServerPort.TabIndex = 26;
            this.txtProxyServerPort.Text = "8888";
            // 
            // lblProxyPort
            // 
            this.lblProxyPort.Location = new System.Drawing.Point(581, 56);
            this.lblProxyPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyPort.Name = "lblProxyPort";
            this.lblProxyPort.Size = new System.Drawing.Size(87, 21);
            this.lblProxyPort.TabIndex = 25;
            this.lblProxyPort.Text = "Proxy Port:";
            // 
            // txtProxyServerName
            // 
            this.txtProxyServerName.Location = new System.Drawing.Point(692, 26);
            this.txtProxyServerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProxyServerName.Name = "txtProxyServerName";
            this.txtProxyServerName.Size = new System.Drawing.Size(104, 22);
            this.txtProxyServerName.TabIndex = 24;
            this.txtProxyServerName.Text = "127.0.0.1";
            // 
            // lblProxyServer
            // 
            this.lblProxyServer.Location = new System.Drawing.Point(581, 29);
            this.lblProxyServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProxyServer.Name = "lblProxyServer";
            this.lblProxyServer.Size = new System.Drawing.Size(103, 21);
            this.lblProxyServer.TabIndex = 23;
            this.lblProxyServer.Text = "Proxy Server:";
            // 
            // chkUseProxy
            // 
            this.chkUseProxy.AutoSize = true;
            this.chkUseProxy.Location = new System.Drawing.Point(563, 4);
            this.chkUseProxy.Margin = new System.Windows.Forms.Padding(4);
            this.chkUseProxy.Name = "chkUseProxy";
            this.chkUseProxy.Size = new System.Drawing.Size(144, 21);
            this.chkUseProxy.TabIndex = 22;
            this.chkUseProxy.Text = "Use Proxy Server:";
            this.chkUseProxy.UseVisualStyleBackColor = true;
            this.chkUseProxy.CheckedChanged += new System.EventHandler(this.chkUseProxy_CheckedChanged);
            // 
            // btnStatusCodeHelper
            // 
            this.btnStatusCodeHelper.Location = new System.Drawing.Point(854, 5);
            this.btnStatusCodeHelper.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatusCodeHelper.Name = "btnStatusCodeHelper";
            this.btnStatusCodeHelper.Size = new System.Drawing.Size(172, 28);
            this.btnStatusCodeHelper.TabIndex = 34;
            this.btnStatusCodeHelper.Text = "Status Code Helper";
            this.btnStatusCodeHelper.UseVisualStyleBackColor = true;
            this.btnStatusCodeHelper.Click += new System.EventHandler(this.btnStatusCodeHelper_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1035, 165);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1027, 136);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IE  Rendered";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(4, 4);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1015, 128);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtResponse);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1159, 136);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text  Rendered";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtResponse.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtResponse.Location = new System.Drawing.Point(4, 0);
            this.txtResponse.Margin = new System.Windows.Forms.Padding(4);
            this.txtResponse.MaxLength = 0;
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(1151, 136);
            this.txtResponse.TabIndex = 16;
            this.txtResponse.WordWrap = false;
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtHexResponse);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1159, 136);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hex";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtHexResponse
            // 
            this.txtHexResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHexResponse.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtHexResponse.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHexResponse.Location = new System.Drawing.Point(4, 2);
            this.txtHexResponse.Margin = new System.Windows.Forms.Padding(4);
            this.txtHexResponse.MaxLength = 0;
            this.txtHexResponse.Multiline = true;
            this.txtHexResponse.Name = "txtHexResponse";
            this.txtHexResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHexResponse.Size = new System.Drawing.Size(1151, 130);
            this.txtHexResponse.TabIndex = 17;
            this.txtHexResponse.WordWrap = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 217);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtRequest);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Size = new System.Drawing.Size(1043, 390);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 38;
            // 
            // frmRawEAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1047, 736);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblStatusCause);
            this.Controls.Add(this.txtInfo);
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
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEncodingHelper);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPolicyKey);
            this.Controls.Add(this.chkOverrideSslCertificateVerification);
            this.Controls.Add(this.chkUseSSL);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboCommand);
            this.Controls.Add(this.txtDeviceType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRun);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRawEAS";
            this.helpProvider1.SetShowHelp(this, false);
            this.Text = "EAS Conversations";
            this.Load += new System.EventHandler(this.frmRawEAS_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtHexResponse;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

