namespace EASTester
{
    partial class InfoOnEasResponse
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
            this.txtStatusCodeInfo = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmboCommand = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStatusCodeInfo
            // 
            this.txtStatusCodeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusCodeInfo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtStatusCodeInfo.Location = new System.Drawing.Point(12, 413);
            this.txtStatusCodeInfo.Multiline = true;
            this.txtStatusCodeInfo.Name = "txtStatusCodeInfo";
            this.txtStatusCodeInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtStatusCodeInfo.Size = new System.Drawing.Size(1000, 165);
            this.txtStatusCodeInfo.TabIndex = 5;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(12, 49);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(1000, 358);
            this.txtResponse.TabIndex = 4;
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
            this.cmboCommand.Location = new System.Drawing.Point(72, 5);
            this.cmboCommand.Name = "cmboCommand";
            this.cmboCommand.Size = new System.Drawing.Size(174, 21);
            this.cmboCommand.TabIndex = 1;
            this.cmboCommand.Text = "Command";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(263, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(41, 25);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(617, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Set the EAS command above and paste in an EAS XML response into the white window." +
    "  Click Go to get status code information.";
            // 
            // InfoOnEasResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1024, 581);
            this.Controls.Add(this.txtStatusCodeInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cmboCommand);
            this.Controls.Add(this.label1);
            this.Name = "InfoOnEasResponse";
            this.Text = "Information on EAS XML Response Status Code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStatusCodeInfo;
        private System.Windows.Forms.TextBox txtResponse;
        public System.Windows.Forms.ComboBox cmboCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label7;
    }
}