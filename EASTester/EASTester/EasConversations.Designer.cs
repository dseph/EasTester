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
            this.lblResponseCode = new System.Windows.Forms.Label();
            this.txtStatusCode = new System.Windows.Forms.TextBox();
            this.lblStatusMeaning = new System.Windows.Forms.Label();
            this.txtStatusMeaning = new System.Windows.Forms.TextBox();
            this.lblStatusCause = new System.Windows.Forms.Label();
            this.txtStatusCause = new System.Windows.Forms.TextBox();
            this.lblStatusResolution = new System.Windows.Forms.Label();
            this.txtStatusResolution = new System.Windows.Forms.TextBox();
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
            this.txtDomain.Size = new System.Drawing.Size(254, 20);
            this.txtDomain.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.helpProvider1.SetHelpString(this.txtPassword, "User password.");
            this.txtPassword.Location = new System.Drawing.Point(68, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.helpProvider1.SetShowHelp(this.txtPassword, true);
            this.txtPassword.Size = new System.Drawing.Size(254, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUser
            // 
            this.helpProvider1.SetHelpString(this.txtUser, "User alias or smtp address.");
            this.txtUser.Location = new System.Drawing.Point(66, 74);
            this.txtUser.Name = "txtUser";
            this.helpProvider1.SetShowHelp(this.txtUser, true);
            this.txtUser.Size = new System.Drawing.Size(254, 20);
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
            this.txtServerUrl.Size = new System.Drawing.Size(228, 20);
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
            this.lblVersion.Location = new System.Drawing.Point(375, 44);
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
            this.cmboVersion.Location = new System.Drawing.Point(457, 42);
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
            this.txtRequest.Location = new System.Drawing.Point(5, 191);
            this.txtRequest.MaxLength = 0;
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequest.Size = new System.Drawing.Size(1024, 204);
            this.txtRequest.TabIndex = 14;
            this.txtRequest.WordWrap = false;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtResponse.Location = new System.Drawing.Point(5, 414);
            this.txtResponse.MaxLength = 0;
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(1024, 195);
            this.txtResponse.TabIndex = 15;
            this.txtResponse.WordWrap = false;
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(900, 150);
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
            this.label2.Location = new System.Drawing.Point(374, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Device Id:";
            // 
            // txtDeviceId
            // 
            this.helpProvider1.SetHelpString(this.txtDeviceId, "TheID of the device.");
            this.txtDeviceId.Location = new System.Drawing.Point(457, 74);
            this.txtDeviceId.Name = "txtDeviceId";
            this.helpProvider1.SetShowHelp(this.txtDeviceId, true);
            this.txtDeviceId.Size = new System.Drawing.Size(271, 20);
            this.txtDeviceId.TabIndex = 7;
            this.txtDeviceId.TextChanged += new System.EventHandler(this.txtDeviceId_TextChanged);
            // 
            // txtDeviceType
            // 
            this.helpProvider1.SetHelpString(this.txtDeviceType, "Device Type");
            this.txtDeviceType.Location = new System.Drawing.Point(457, 100);
            this.txtDeviceType.Name = "txtDeviceType";
            this.helpProvider1.SetShowHelp(this.txtDeviceType, true);
            this.txtDeviceType.Size = new System.Drawing.Size(271, 20);
            this.txtDeviceType.TabIndex = 8;
            this.txtDeviceType.TextChanged += new System.EventHandler(this.txtDeviceType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Device Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 133);
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
            this.cmboCommand.Location = new System.Drawing.Point(457, 126);
            this.cmboCommand.Name = "cmboCommand";
            this.cmboCommand.Size = new System.Drawing.Size(174, 21);
            this.cmboCommand.TabIndex = 9;
            this.cmboCommand.Text = "Command";
            this.cmboCommand.SelectedIndexChanged += new System.EventHandler(this.cmboCommand_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Request:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Response:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Location = new System.Drawing.Point(900, 119);
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
            this.chkUseSSL.Location = new System.Drawing.Point(823, 8);
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
            this.chkOverrideSslCertificateVerification.Location = new System.Drawing.Point(823, 31);
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
            this.txtPolicyKey.Location = new System.Drawing.Point(457, 153);
            this.txtPolicyKey.Name = "txtPolicyKey";
            this.helpProvider1.SetShowHelp(this.txtPolicyKey, true);
            this.txtPolicyKey.Size = new System.Drawing.Size(271, 20);
            this.txtPolicyKey.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 156);
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
            this.btnEncodingHelper.Location = new System.Drawing.Point(900, 89);
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
            // lblResponseCode
            // 
            this.lblResponseCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblResponseCode.AutoSize = true;
            this.lblResponseCode.Location = new System.Drawing.Point(3, 618);
            this.lblResponseCode.Name = "lblResponseCode";
            this.lblResponseCode.Size = new System.Drawing.Size(63, 13);
            this.lblResponseCode.TabIndex = 53;
            this.lblResponseCode.Text = "Resp Code:";
            // 
            // txtStatusCode
            // 
            this.txtStatusCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStatusCode.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtStatusCode.Location = new System.Drawing.Point(65, 615);
            this.txtStatusCode.Name = "txtStatusCode";
            this.txtStatusCode.Size = new System.Drawing.Size(59, 20);
            this.txtStatusCode.TabIndex = 54;
            // 
            // lblStatusMeaning
            // 
            this.lblStatusMeaning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatusMeaning.AutoSize = true;
            this.lblStatusMeaning.Location = new System.Drawing.Point(130, 618);
            this.lblStatusMeaning.Name = "lblStatusMeaning";
            this.lblStatusMeaning.Size = new System.Drawing.Size(51, 13);
            this.lblStatusMeaning.TabIndex = 55;
            this.lblStatusMeaning.Text = "Meaning:";
            // 
            // txtStatusMeaning
            // 
            this.txtStatusMeaning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusMeaning.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtStatusMeaning.Location = new System.Drawing.Point(187, 615);
            this.txtStatusMeaning.Name = "txtStatusMeaning";
            this.txtStatusMeaning.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatusMeaning.Size = new System.Drawing.Size(845, 20);
            this.txtStatusMeaning.TabIndex = 56;
            // 
            // lblStatusCause
            // 
            this.lblStatusCause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatusCause.AutoSize = true;
            this.lblStatusCause.Location = new System.Drawing.Point(13, 641);
            this.lblStatusCause.Name = "lblStatusCause";
            this.lblStatusCause.Size = new System.Drawing.Size(40, 13);
            this.lblStatusCause.TabIndex = 57;
            this.lblStatusCause.Text = "Cause:";
            // 
            // txtStatusCause
            // 
            this.txtStatusCause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStatusCause.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtStatusCause.Location = new System.Drawing.Point(65, 641);
            this.txtStatusCause.Multiline = true;
            this.txtStatusCause.Name = "txtStatusCause";
            this.txtStatusCause.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatusCause.Size = new System.Drawing.Size(401, 71);
            this.txtStatusCause.TabIndex = 58;
            // 
            // lblStatusResolution
            // 
            this.lblStatusResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatusResolution.AutoSize = true;
            this.lblStatusResolution.Location = new System.Drawing.Point(472, 641);
            this.lblStatusResolution.Name = "lblStatusResolution";
            this.lblStatusResolution.Size = new System.Drawing.Size(60, 13);
            this.lblStatusResolution.TabIndex = 59;
            this.lblStatusResolution.Text = "Resolution:";
            // 
            // txtStatusResolution
            // 
            this.txtStatusResolution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusResolution.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtStatusResolution.Location = new System.Drawing.Point(538, 641);
            this.txtStatusResolution.Multiline = true;
            this.txtStatusResolution.Name = "txtStatusResolution";
            this.txtStatusResolution.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatusResolution.Size = new System.Drawing.Size(494, 71);
            this.txtStatusResolution.TabIndex = 60;
            // 
            // frmRawEAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1044, 713);
            this.Controls.Add(this.txtStatusResolution);
            this.Controls.Add(this.lblStatusResolution);
            this.Controls.Add(this.txtStatusCause);
            this.Controls.Add(this.lblStatusCause);
            this.Controls.Add(this.txtStatusMeaning);
            this.Controls.Add(this.lblStatusMeaning);
            this.Controls.Add(this.txtStatusCode);
            this.Controls.Add(this.lblResponseCode);
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
        private System.Windows.Forms.Label lblResponseCode;
        private System.Windows.Forms.TextBox txtStatusCode;
        private System.Windows.Forms.Label lblStatusMeaning;
        private System.Windows.Forms.TextBox txtStatusMeaning;
        private System.Windows.Forms.Label lblStatusCause;
        private System.Windows.Forms.TextBox txtStatusCause;
        private System.Windows.Forms.Label lblStatusResolution;
        private System.Windows.Forms.TextBox txtStatusResolution;
    }
}

