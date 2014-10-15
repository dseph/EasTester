namespace EASTester
{
    partial class MainForm
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
            this.btnDecodeWbxmlBytesIntoXML = new System.Windows.Forms.Button();
            this.btnDecodeRawResponse = new System.Windows.Forms.Button();
            this.btsEasConversations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDecodeWbxmlBytesIntoXML
            // 
            this.btnDecodeWbxmlBytesIntoXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecodeWbxmlBytesIntoXML.Location = new System.Drawing.Point(147, 93);
            this.btnDecodeWbxmlBytesIntoXML.Name = "btnDecodeWbxmlBytesIntoXML";
            this.btnDecodeWbxmlBytesIntoXML.Size = new System.Drawing.Size(250, 27);
            this.btnDecodeWbxmlBytesIntoXML.TabIndex = 2;
            this.btnDecodeWbxmlBytesIntoXML.Text = "Convert WBXML bytes into XML";
            this.btnDecodeWbxmlBytesIntoXML.UseVisualStyleBackColor = true;
            this.btnDecodeWbxmlBytesIntoXML.Click += new System.EventHandler(this.btnDecodeWbxmlBytesIntoXML_Click);
            // 
            // btnDecodeRawResponse
            // 
            this.btnDecodeRawResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecodeRawResponse.Location = new System.Drawing.Point(147, 37);
            this.btnDecodeRawResponse.Name = "btnDecodeRawResponse";
            this.btnDecodeRawResponse.Size = new System.Drawing.Size(250, 29);
            this.btnDecodeRawResponse.TabIndex = 1;
            this.btnDecodeRawResponse.Text = "Decode WBXML binary file into XML";
            this.btnDecodeRawResponse.UseVisualStyleBackColor = true;
            this.btnDecodeRawResponse.Click += new System.EventHandler(this.btnDecodeRawResponse_Click);
            // 
            // btsEasConversations
            // 
            this.btsEasConversations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btsEasConversations.Location = new System.Drawing.Point(147, 143);
            this.btsEasConversations.Name = "btsEasConversations";
            this.btsEasConversations.Size = new System.Drawing.Size(250, 29);
            this.btsEasConversations.TabIndex = 3;
            this.btsEasConversations.Text = "EAS Conversations";
            this.btsEasConversations.UseVisualStyleBackColor = true;
            this.btsEasConversations.Click += new System.EventHandler(this.btsEasConversations_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(520, 241);
            this.Controls.Add(this.btsEasConversations);
            this.Controls.Add(this.btnDecodeWbxmlBytesIntoXML);
            this.Controls.Add(this.btnDecodeRawResponse);
            this.Name = "MainForm";
            this.Text = "EAS Tester";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDecodeWbxmlBytesIntoXML;
        private System.Windows.Forms.Button btnDecodeRawResponse;
        private System.Windows.Forms.Button btsEasConversations;
    }
}