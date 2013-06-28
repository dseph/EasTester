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
            this.txtResultInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOptions = new System.Windows.Forms.Button();
            this.chkUseSSL = new System.Windows.Forms.CheckBox();
            this.chkOverrideSslCertificateVerification = new System.Windows.Forms.CheckBox();
            this.txtPolicyKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExamples = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(75, 99);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(254, 20);
            this.txtDomain.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(75, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(254, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(73, 47);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(254, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Location = new System.Drawing.Point(12, 99);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(46, 13);
            this.lblDomain.TabIndex = 15;
            this.lblDomain.Text = "Domain:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 72);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(16, 50);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "User:";
            // 
            // txtServerUrl
            // 
            this.txtServerUrl.Location = new System.Drawing.Point(163, 18);
            this.txtServerUrl.Name = "txtServerUrl";
            this.txtServerUrl.Size = new System.Drawing.Size(195, 20);
            this.txtServerUrl.TabIndex = 0;
            this.txtServerUrl.Text = "mail.contoso.com";
            this.txtServerUrl.TextChanged += new System.EventHandler(this.txtServerUrl_TextChanged);
            // 
            // ServerUrl
            // 
            this.ServerUrl.AutoSize = true;
            this.ServerUrl.Location = new System.Drawing.Point(16, 18);
            this.ServerUrl.Name = "ServerUrl";
            this.ServerUrl.Size = new System.Drawing.Size(141, 13);
            this.ServerUrl.TabIndex = 18;
            this.ServerUrl.Text = "Server mail domain/address:";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(378, 24);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(66, 13);
            this.lblVersion.TabIndex = 25;
            this.lblVersion.Text = "EAS Version";
            // 
            // cmboVersion
            // 
            this.cmboVersion.FormattingEnabled = true;
            this.cmboVersion.ItemHeight = 13;
            this.cmboVersion.Items.AddRange(new object[] {
            "15.0",
            "14.2",
            "14.1",
            "14.0",
            "12.1",
            "12.0",
            "2.5"});
            this.cmboVersion.Location = new System.Drawing.Point(460, 21);
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
            this.txtRequest.Location = new System.Drawing.Point(11, 206);
            this.txtRequest.MaxLength = 0;
            this.txtRequest.Multiline = true;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRequest.Size = new System.Drawing.Size(1009, 160);
            this.txtRequest.TabIndex = 14;
            this.txtRequest.WordWrap = false;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtResponse.Location = new System.Drawing.Point(11, 390);
            this.txtResponse.MaxLength = 0;
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(1009, 184);
            this.txtResponse.TabIndex = 15;
            this.txtResponse.WordWrap = false;
            this.txtResponse.TextChanged += new System.EventHandler(this.txtResponse_TextChanged);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Location = new System.Drawing.Point(837, 167);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(180, 23);
            this.btnRun.TabIndex = 13;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Device Id:";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(460, 48);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(271, 20);
            this.txtDeviceId.TabIndex = 7;
            this.txtDeviceId.Text = "SuperCoolPhone5";
            this.txtDeviceId.TextChanged += new System.EventHandler(this.txtDeviceId_TextChanged);
            // 
            // txtDeviceType
            // 
            this.txtDeviceType.Location = new System.Drawing.Point(460, 74);
            this.txtDeviceType.Name = "txtDeviceType";
            this.txtDeviceType.Size = new System.Drawing.Size(157, 20);
            this.txtDeviceType.TabIndex = 8;
            this.txtDeviceType.Text = "NewType";
            this.txtDeviceType.TextChanged += new System.EventHandler(this.txtDeviceType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Device Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Command:";
            // 
            // cmboCommand
            // 
            this.cmboCommand.FormattingEnabled = true;
            this.cmboCommand.Items.AddRange(new object[] {
            "Provision",
            "Sync",
            "GetItemEstimate",
            "FolderSync",
            "FolderDelete",
            "ItemOperations",
            "SmartForward",
            "SmartReply",
            "SendMail"});
            this.cmboCommand.Location = new System.Drawing.Point(460, 100);
            this.cmboCommand.Name = "cmboCommand";
            this.cmboCommand.Size = new System.Drawing.Size(95, 21);
            this.cmboCommand.TabIndex = 9;
            this.cmboCommand.Text = "Sync";
            this.cmboCommand.SelectedIndexChanged += new System.EventHandler(this.cmboCommand_SelectedIndexChanged);
            // 
            // txtResultInfo
            // 
            this.txtResultInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultInfo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtResultInfo.Location = new System.Drawing.Point(11, 591);
            this.txtResultInfo.MaxLength = 0;
            this.txtResultInfo.Multiline = true;
            this.txtResultInfo.Name = "txtResultInfo";
            this.txtResultInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultInfo.Size = new System.Drawing.Size(1000, 68);
            this.txtResultInfo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Request:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Response:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Response Info:";
            // 
            // btnOptions
            // 
            this.btnOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOptions.Location = new System.Drawing.Point(840, 8);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(177, 23);
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
            this.chkUseSSL.Location = new System.Drawing.Point(19, 131);
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
            this.chkOverrideSslCertificateVerification.Location = new System.Drawing.Point(19, 154);
            this.chkOverrideSslCertificateVerification.Name = "chkOverrideSslCertificateVerification";
            this.chkOverrideSslCertificateVerification.Size = new System.Drawing.Size(193, 17);
            this.chkOverrideSslCertificateVerification.TabIndex = 5;
            this.chkOverrideSslCertificateVerification.Text = "Override SSL Certificate verification";
            this.chkOverrideSslCertificateVerification.UseVisualStyleBackColor = true;
            this.chkOverrideSslCertificateVerification.CheckedChanged += new System.EventHandler(this.chkOverrideSslCertificateVerification_CheckedChanged);
            // 
            // txtPolicyKey
            // 
            this.txtPolicyKey.Location = new System.Drawing.Point(460, 128);
            this.txtPolicyKey.Name = "txtPolicyKey";
            this.txtPolicyKey.Size = new System.Drawing.Size(271, 20);
            this.txtPolicyKey.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Policy Key:";
            // 
            // btnExamples
            // 
            this.btnExamples.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExamples.Location = new System.Drawing.Point(837, 52);
            this.btnExamples.Name = "btnExamples";
            this.btnExamples.Size = new System.Drawing.Size(180, 23);
            this.btnExamples.TabIndex = 12;
            this.btnExamples.Text = "Examples";
            this.btnExamples.UseVisualStyleBackColor = true;
            this.btnExamples.Click += new System.EventHandler(this.btnExamples_Click_1);
            // 
            // frmRawEAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1029, 671);
            this.Controls.Add(this.btnExamples);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPolicyKey);
            this.Controls.Add(this.chkOverrideSslCertificateVerification);
            this.Controls.Add(this.chkUseSSL);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultInfo);
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
        private System.Windows.Forms.TextBox txtResultInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.CheckBox chkUseSSL;
        private System.Windows.Forms.CheckBox chkOverrideSslCertificateVerification;
        public System.Windows.Forms.TextBox txtPolicyKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExamples;
    }
}

