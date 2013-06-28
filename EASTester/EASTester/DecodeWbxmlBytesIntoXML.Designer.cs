namespace EASTester
{
    partial class DecodeWbxmlBytesIntoXML
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
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.btnConvertfromIntArray = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConvertfromHexArray = new System.Windows.Forms.Button();
            this.txtToDump = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEASDecoded = new System.Windows.Forms.RichTextBox();
            this.btnHexCsvFromIntCsv = new System.Windows.Forms.Button();
            this.btnConvertfromHexStream = new System.Windows.Forms.Button();
            this.btnHexDumpToHexStream = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrom.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(10, 51);
            this.txtFrom.MaxLength = 0;
            this.txtFrom.Multiline = true;
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFrom.Size = new System.Drawing.Size(912, 125);
            this.txtFrom.TabIndex = 6;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // txtTo
            // 
            this.txtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTo.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtTo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(10, 201);
            this.txtTo.MaxLength = 0;
            this.txtTo.Multiline = true;
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTo.Size = new System.Drawing.Size(912, 120);
            this.txtTo.TabIndex = 7;
            // 
            // btnConvertfromIntArray
            // 
            this.helpProvider1.SetHelpString(this.btnConvertfromIntArray, "Convert WBXML content in an integer array into XML.  Example: 1, 2, 3, 4,   ");
            this.btnConvertfromIntArray.Location = new System.Drawing.Point(12, 9);
            this.btnConvertfromIntArray.Name = "btnConvertfromIntArray";
            this.helpProvider1.SetShowHelp(this.btnConvertfromIntArray, true);
            this.btnConvertfromIntArray.Size = new System.Drawing.Size(132, 23);
            this.btnConvertfromIntArray.TabIndex = 1;
            this.btnConvertfromIntArray.Text = "Convert from Int array";
            this.btnConvertfromIntArray.UseVisualStyleBackColor = true;
            this.btnConvertfromIntArray.Click += new System.EventHandler(this.btnConvertfromIntArray_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(766, 607);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(847, 607);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConvertfromHexArray
            // 
            this.helpProvider1.SetHelpString(this.btnConvertfromHexArray, "Convert WBXML content contained in an array of hex values with space, semi-colon " +
                    "or comma separators into XML.");
            this.btnConvertfromHexArray.Location = new System.Drawing.Point(150, 9);
            this.btnConvertfromHexArray.Name = "btnConvertfromHexArray";
            this.helpProvider1.SetShowHelp(this.btnConvertfromHexArray, true);
            this.btnConvertfromHexArray.Size = new System.Drawing.Size(157, 23);
            this.btnConvertfromHexArray.TabIndex = 2;
            this.btnConvertfromHexArray.Text = "Convert from hex array";
            this.btnConvertfromHexArray.UseVisualStyleBackColor = true;
            this.btnConvertfromHexArray.Click += new System.EventHandler(this.btnConvertfromHexArray_Click);
            // 
            // txtToDump
            // 
            this.txtToDump.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToDump.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtToDump.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDump.Location = new System.Drawing.Point(10, 341);
            this.txtToDump.MaxLength = 0;
            this.txtToDump.Multiline = true;
            this.txtToDump.Name = "txtToDump";
            this.txtToDump.ReadOnly = true;
            this.txtToDump.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtToDump.Size = new System.Drawing.Size(912, 114);
            this.txtToDump.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Origional:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Hex Converted:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Hex Dump:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Decoded into EAS XML:";
            // 
            // txtEASDecoded
            // 
            this.txtEASDecoded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEASDecoded.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtEASDecoded.Location = new System.Drawing.Point(15, 477);
            this.txtEASDecoded.Name = "txtEASDecoded";
            this.txtEASDecoded.ReadOnly = true;
            this.txtEASDecoded.Size = new System.Drawing.Size(907, 112);
            this.txtEASDecoded.TabIndex = 9;
            this.txtEASDecoded.Text = global::EASTester.TemplateRequests.Provision;
            this.txtEASDecoded.WordWrap = false;
            // 
            // btnHexCsvFromIntCsv
            // 
            this.helpProvider1.SetHelpString(this.btnHexCsvFromIntCsv, "Convert an integer comma-delimited string into a hex comma-delimited string.");
            this.btnHexCsvFromIntCsv.Location = new System.Drawing.Point(477, 9);
            this.btnHexCsvFromIntCsv.Name = "btnHexCsvFromIntCsv";
            this.helpProvider1.SetShowHelp(this.btnHexCsvFromIntCsv, true);
            this.btnHexCsvFromIntCsv.Size = new System.Drawing.Size(171, 23);
            this.btnHexCsvFromIntCsv.TabIndex = 4;
            this.btnHexCsvFromIntCsv.Text = "Convert int CSV to hex CSV";
            this.btnHexCsvFromIntCsv.UseVisualStyleBackColor = true;
            this.btnHexCsvFromIntCsv.Click += new System.EventHandler(this.btnHexCsvFromIntCsv_Click);
            // 
            // btnConvertfromHexStream
            // 
            this.helpProvider1.SetHelpKeyword(this.btnConvertfromHexStream, global::EASTester.TemplateRequests.Provision);
            this.helpProvider1.SetHelpString(this.btnConvertfromHexStream, "Convert WBXML content in an undelmited hex string into XML.");
            this.btnConvertfromHexStream.Location = new System.Drawing.Point(313, 9);
            this.btnConvertfromHexStream.Name = "btnConvertfromHexStream";
            this.helpProvider1.SetShowHelp(this.btnConvertfromHexStream, true);
            this.btnConvertfromHexStream.Size = new System.Drawing.Size(158, 23);
            this.btnConvertfromHexStream.TabIndex = 3;
            this.btnConvertfromHexStream.Text = "Convert from Hex stream";
            this.btnConvertfromHexStream.UseVisualStyleBackColor = true;
            this.btnConvertfromHexStream.Click += new System.EventHandler(this.btnConvertfromHexStream_Click);
            // 
            // btnHexDumpToHexStream
            // 
            this.helpProvider1.SetHelpString(this.btnHexDumpToHexStream, "Convert hex dump in text format to a hex stream.  This may not work with all hex " +
                    "dumps in text format.");
            this.btnHexDumpToHexStream.Location = new System.Drawing.Point(654, 9);
            this.btnHexDumpToHexStream.Name = "btnHexDumpToHexStream";
            this.helpProvider1.SetShowHelp(this.btnHexDumpToHexStream, true);
            this.btnHexDumpToHexStream.Size = new System.Drawing.Size(171, 23);
            this.btnHexDumpToHexStream.TabIndex = 5;
            this.btnHexDumpToHexStream.Text = "Convert hex dump to hex stream";
            this.btnHexDumpToHexStream.UseVisualStyleBackColor = true;
            this.btnHexDumpToHexStream.Click += new System.EventHandler(this.btnHexDumpToHexStream_Click);
            // 
            // DecodeWbxmlBytesIntoXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(936, 642);
            this.Controls.Add(this.btnHexDumpToHexStream);
            this.Controls.Add(this.btnConvertfromHexStream);
            this.Controls.Add(this.btnHexCsvFromIntCsv);
            this.Controls.Add(this.txtEASDecoded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToDump);
            this.Controls.Add(this.btnConvertfromHexArray);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnConvertfromIntArray);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Name = "DecodeWbxmlBytesIntoXML";
            this.Text = "Decode WBMXL bytes into XML";
            this.Load += new System.EventHandler(this.frmLoadOtherEAS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnConvertfromIntArray;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConvertfromHexArray;
        private System.Windows.Forms.TextBox txtToDump;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtEASDecoded;
        private System.Windows.Forms.Button btnHexCsvFromIntCsv;
        private System.Windows.Forms.Button btnConvertfromHexStream;
        private System.Windows.Forms.Button btnHexDumpToHexStream;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}