namespace EASTester
{
    partial class SessionSettings
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
            this.txtProvisionPart1 = new System.Windows.Forms.TextBox();
            this.txtProvisionPart2 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDefaultProvisionPart1 = new System.Windows.Forms.Button();
            this.btnDefaultProvisionPart2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProvisionPart1
            // 
            this.txtProvisionPart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProvisionPart1.Location = new System.Drawing.Point(9, 34);
            this.txtProvisionPart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProvisionPart1.Multiline = true;
            this.txtProvisionPart1.Name = "txtProvisionPart1";
            this.txtProvisionPart1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProvisionPart1.Size = new System.Drawing.Size(770, 171);
            this.txtProvisionPart1.TabIndex = 0;
            // 
            // txtProvisionPart2
            // 
            this.txtProvisionPart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProvisionPart2.Location = new System.Drawing.Point(9, 244);
            this.txtProvisionPart2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProvisionPart2.Multiline = true;
            this.txtProvisionPart2.Name = "txtProvisionPart2";
            this.txtProvisionPart2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProvisionPart2.Size = new System.Drawing.Size(770, 142);
            this.txtProvisionPart2.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(577, 402);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 27);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(687, 402);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Provision Part 1 Template:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Provision Part 2 Template:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 387);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note:  ##PolicyKey## in part 2 needs to not be modified.";
            // 
            // btnDefaultProvisionPart1
            // 
            this.btnDefaultProvisionPart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultProvisionPart1.Location = new System.Drawing.Point(683, 2);
            this.btnDefaultProvisionPart1.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefaultProvisionPart1.Name = "btnDefaultProvisionPart1";
            this.btnDefaultProvisionPart1.Size = new System.Drawing.Size(92, 27);
            this.btnDefaultProvisionPart1.TabIndex = 7;
            this.btnDefaultProvisionPart1.Text = "Default";
            this.btnDefaultProvisionPart1.UseVisualStyleBackColor = true;
            this.btnDefaultProvisionPart1.Click += new System.EventHandler(this.btnDefaultProvisionPart1_Click);
            // 
            // btnDefaultProvisionPart2
            // 
            this.btnDefaultProvisionPart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultProvisionPart2.Location = new System.Drawing.Point(683, 213);
            this.btnDefaultProvisionPart2.Margin = new System.Windows.Forms.Padding(2);
            this.btnDefaultProvisionPart2.Name = "btnDefaultProvisionPart2";
            this.btnDefaultProvisionPart2.Size = new System.Drawing.Size(92, 27);
            this.btnDefaultProvisionPart2.TabIndex = 8;
            this.btnDefaultProvisionPart2.Text = "Default";
            this.btnDefaultProvisionPart2.UseVisualStyleBackColor = true;
            this.btnDefaultProvisionPart2.Click += new System.EventHandler(this.btnDefaultProvisionPart2_Click);
            // 
            // SessionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(786, 437);
            this.Controls.Add(this.btnDefaultProvisionPart2);
            this.Controls.Add(this.btnDefaultProvisionPart1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtProvisionPart2);
            this.Controls.Add(this.txtProvisionPart1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SessionSettings";
            this.Text = "Session Settings";
            this.Load += new System.EventHandler(this.SessionSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProvisionPart1;
        private System.Windows.Forms.TextBox txtProvisionPart2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDefaultProvisionPart1;
        private System.Windows.Forms.Button btnDefaultProvisionPart2;
    }
}