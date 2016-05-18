namespace EASTester
{
    partial class EncodeForm
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
            this.cmboFrom = new System.Windows.Forms.ComboBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmboFrom
            // 
            this.cmboFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboFrom.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.cmboFrom.FormattingEnabled = true;
            this.cmboFrom.Location = new System.Drawing.Point(4, 18);
            this.cmboFrom.Margin = new System.Windows.Forms.Padding(5);
            this.cmboFrom.Name = "cmboFrom";
            this.cmboFrom.Size = new System.Drawing.Size(920, 30);
            this.cmboFrom.TabIndex = 0;
            this.cmboFrom.SelectedIndexChanged += new System.EventHandler(this.cmboFrom_SelectedIndexChanged);
            // 
            // txtFrom
            // 
            this.txtFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFrom.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtFrom.Location = new System.Drawing.Point(0, 0);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(5);
            this.txtFrom.MaxLength = 0;
            this.txtFrom.Multiline = true;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFrom.Size = new System.Drawing.Size(1007, 319);
            this.txtFrom.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(938, 11);
            this.btnGo.Margin = new System.Windows.Forms.Padding(5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(66, 37);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTo.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.txtTo.Location = new System.Drawing.Point(0, 0);
            this.txtTo.Margin = new System.Windows.Forms.Padding(5);
            this.txtTo.MaxLength = 0;
            this.txtTo.Multiline = true;
            this.txtTo.Name = "txtTo";
            this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTo.Size = new System.Drawing.Size(1007, 316);
            this.txtTo.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(4, 56);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtFrom);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtTo);
            this.splitContainer1.Size = new System.Drawing.Size(1007, 639);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 6;
            // 
            // EncodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1012, 695);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cmboFrom);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EncodeForm";
            this.Text = "Encoding Helper";
            this.Load += new System.EventHandler(this.EncodeForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}