using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisualSync;

namespace EASTester
{
    public partial class DecodeWbxmlBinaryFile : Form
    {
        private byte[] wbxmlBytes = null;
        //private string xmlString = null;

        public DecodeWbxmlBinaryFile()
        {
            InitializeComponent();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
 

        }

        private byte[] TurnLogDataToBytes(string LogData)
        {
            byte[] wbxml = null;

            return wbxml;
        }


      

        private void DecodeWbxmlFrames_Load(object sender, EventArgs e)
        {
            txtFile.Text  = Application.UserAppDataPath;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {

            txtEncoded.Text = string.Empty;
            txtEncoded.Update();
            txtDecoded.Text = string.Empty;
            txtDecoded.Update();


            // PickLoadFromFile
            string sFileName = txtFile.Text.Trim();
            try
            {
                if (System.IO.File.Exists(sFileName) == false)
                {
                    MessageBox.Show("The specified file does not exist.", "File does not exist.");
                }
                else
                {

                    //PickLoadFromFile

                    wbxmlBytes = System.IO.File.ReadAllBytes(sFileName);
                    ASCommandResponse commandResponse = new ASCommandResponse(wbxmlBytes);

                    txtEncoded.Text = MyHelpers.StringHelper.HexDumpFromByteArray(wbxmlBytes);

                    txtDecoded.Text = commandResponse.XMLString;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "Error loading file");
            }
            //wbxmlBytes
        }

        private void cmboVersion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            string sWorkingPath = txtFile.Text.Trim();
            string sInitialDirectory = string.Empty;
            string sSuggestedFilename = string.Empty;
            string sSelectedfile = string.Empty;

            sInitialDirectory = System.IO.Path.GetDirectoryName(sWorkingPath);
  
            sSuggestedFilename = System.IO.Path.GetFileName(sWorkingPath);
            if (MyHelpers.UserIoHelper.PickLoadFromFile(sInitialDirectory, sSuggestedFilename, ref  sSelectedfile))
            {
                txtFile.Text = sSelectedfile;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DecodeWbxmlBytesIntoXML oForm = new DecodeWbxmlBytesIntoXML();
            oForm.ShowDialog();
            oForm = null;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
 

    }
}
