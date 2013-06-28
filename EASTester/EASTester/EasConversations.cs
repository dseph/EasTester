using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Xml;

using VisualSync;

namespace EASTester
{
    // http://msdn.microsoft.com/en-us/library/hh361570(EXCHG.140).aspx 
    public partial class frmRawEAS : Form
    {
 
        public frmRawEAS()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            bool bError = false;
            txtResponse.Text = string.Empty;
            txtResponse.Update();
 

            this.Cursor = Cursors.WaitCursor;


            // Create credentials for the user
            NetworkCredential cred = null;

            if (txtDomain.Text.Trim().Length != 0)
                cred = new NetworkCredential(txtDomain.Text.Trim() + "\\" + txtUser.Text.Trim(), txtPassword.Text.Trim());
            else
                cred = new NetworkCredential(txtUser.Text.Trim(), txtPassword.Text.Trim());

 
            try
            {
 
 

                // Initialize the command request
                ASCommandRequest commandRequest = new ASCommandRequest();
                commandRequest.Command = cmboCommand.Text.Trim(); // "Provision";
                commandRequest.Credentials = cred;
                commandRequest.DeviceID = txtDeviceId.Text.Trim(); // "TestDeviceID";
                commandRequest.DeviceType = txtDeviceType.Text.Trim();  // "TestDeviceType";
                commandRequest.ProtocolVersion = cmboVersion.Text.Trim();  //"14.1";
                commandRequest.Server = txtServerUrl.Text.Trim();  //"mail.contoso.com";
                commandRequest.UseEncodedRequestLine = true;
                commandRequest.User = txtUser.Text.Trim(); // "someuser";
                commandRequest.UseSSL = chkUseSSL.Checked;
                commandRequest.UseEncodedRequestLine = true;


                UInt32 iPolicyKey = 0;
                string sPolicyKey = txtPolicyKey.Text.Trim();
                if (sPolicyKey != string.Empty)
                {

                    try
                    {
                        iPolicyKey = Convert.ToUInt32(sPolicyKey);
                    }
                    catch (FormatException eFormat)
                    {
                        MessageBox.Show("The Policy Key needs to be all numbers.", "Entry Error");
                        string s = eFormat.Message; // defeat compile warning for not using eFormat
                        bError = true;
                    }
                    catch (OverflowException eOverflow)
                    {
                        MessageBox.Show("The Policy Key has too large of a value.");
                        string s = eOverflow.Message;  // defeat compile warning for not using eFormat
                        bError = true;
                    }
                    finally
                    {
                        if (iPolicyKey < UInt32.MaxValue)
                        {
                            commandRequest.PolicyKey = iPolicyKey;
                        }
                        else
                        {
                            MessageBox.Show("Policy Key is too large.");
                            bError = true;
                        }
                    }

                }
 
                // Create the XML payload
                commandRequest.XmlString = txtRequest.Text;

                if (bError == false)
                {
                    // Send the request
                    ASCommandResponse commandResponse = commandRequest.GetResponse();

                    if (commandResponse != null)
                    {

                        txtResponse.Text = commandResponse.XMLString;
                    }
                    else
                    {
                        txtResponse.Text = "";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            this.Cursor = Cursors.Default;

        }

        private string BuildUseEasUrl()
        {
            string sEasUrl = string.Empty;

            sEasUrl = txtServerUrl.Text.Trim() + "/Microsoft-Server-ActiveSync/default.eas";
            sEasUrl += "?Cmd=" + cmboCommand.Text.Trim();
            sEasUrl += "&DeviceId=" + txtDeviceId.Text.Trim();
            sEasUrl += "&DeviceType=" + txtDeviceType.Text.Trim();
            sEasUrl += " HTTP/1.1";

            return sEasUrl;
        }

        private void frmRawEAS_Load(object sender, EventArgs e)
        {
 

            ServicePointManager.ServerCertificateValidationCallback = CertificateValidationCallBack;

            cmboCommand.Text = "Provision";

            StringBuilder xmlBuilder = new StringBuilder();
            xmlBuilder.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n");
            xmlBuilder.Append("<Provision xmlns=\"Provision:\" xmlns:settings=\"Settings:\">\r\n");
            xmlBuilder.Append("    <settings:DeviceInformation>\r\n");
            xmlBuilder.Append("        <settings:Set>\r\n");
            xmlBuilder.Append("            <settings:Model>Test 1.0</settings:Model>\r\n");
            xmlBuilder.Append("            <settings:IMEI>012345678901234</settings:IMEI>\r\n");
            xmlBuilder.Append("            <settings:FriendlyName>My Test App</settings:FriendlyName>\r\n");
            xmlBuilder.Append("            <settings:OS>Test OS 1.0</settings:OS>\r\n");
            xmlBuilder.Append("            <settings:OSLanguage>English</settings:OSLanguage>\r\n");
            xmlBuilder.Append("            <settings:PhoneNumber>555-123-4567</settings:PhoneNumber>\r\n");
            xmlBuilder.Append("            <settings:MobileOperator>My Phone Company</settings:MobileOperator>\r\n");
            xmlBuilder.Append("            <settings:UserAgent>TestAgent</settings:UserAgent>\r\n");
            xmlBuilder.Append("        </settings:Set>\r\n");
            xmlBuilder.Append("    </settings:DeviceInformation>\r\n");
            xmlBuilder.Append("     <Policies>\r\n");
            xmlBuilder.Append("          <Policy>\r\n");
            xmlBuilder.Append("               <PolicyType>MS-EAS-Provisioning-WBXML</PolicyType> \r\n");
            xmlBuilder.Append("          </Policy>\r\n");
            xmlBuilder.Append("     </Policies>\r\n");
            xmlBuilder.Append("</Provision>");
            txtRequest.Text = xmlBuilder.ToString();
        }

        private void txtServerUrl_TextChanged(object sender, EventArgs e)
        {
            // 65.53.0.129 - test server
            // mail.microsoft.com
        }

        private void txtDeviceId_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDeviceType_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmboCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private bool CertificateValidationCallBack(
         object sender,
         System.Security.Cryptography.X509Certificates.X509Certificate certificate,
         System.Security.Cryptography.X509Certificates.X509Chain chain,
         System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {

            // Is overrride checkecked?
            if (chkOverrideSslCertificateVerification.Checked == true)
            {
                return true;
            }

            // If the certificate is a valid, signed certificate, return true.
            if (sslPolicyErrors == System.Net.Security.SslPolicyErrors.None)
            {
                return true;
            }

            // If thre are errors in the certificate chain, look at each error to determine the cause.
            if ((sslPolicyErrors & System.Net.Security.SslPolicyErrors.RemoteCertificateChainErrors) != 0)
            {
                if (chain != null && chain.ChainStatus != null)
                {
                    foreach (System.Security.Cryptography.X509Certificates.X509ChainStatus status in chain.ChainStatus)
                    {
                        if ((certificate.Subject == certificate.Issuer) &&
                           (status.Status == System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.UntrustedRoot))
                        {
                            // Self-signed certificates with an untrusted root are valid. 
                            continue;
                        }
                        else
                        {
                            if (status.Status != System.Security.Cryptography.X509Certificates.X509ChainStatusFlags.NoError)
                            {
                                // If there are any other errors in the certificate chain, the certificate is invalid,
                                // so the method returns false.
                                return false;
                            }
                        }
                    }
                }

                // When processing reaches this line, the only errors in the certificate chain are 
                // untrusted root errors for self-signed certifcates. These certificates are valid
                // for default Exchange server installations, so return true.
                return true;
            }
            else
            {
                // In all other cases, return false.
                return false;
            }
        }

        private void cmboVersion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExamples_Click(object sender, EventArgs e)
        {

        }

       

        private void btnOptions_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            // Create credentials for the user
            NetworkCredential cred = null; // new NetworkCredential("contoso\\deviceuser", "password");
            if (txtDomain.Text.Trim().Length != 0)
                cred = new NetworkCredential(txtDomain.Text.Trim() + "\\" + txtUser.Text.Trim(), txtPassword.Text.Trim());
            else
                cred = new NetworkCredential(txtUser.Text.Trim(), txtPassword.Text.Trim());
 

            //Initialize the OPTIONS request
            ASOptionsRequest optionsRequest = new ASOptionsRequest();
            optionsRequest.Server = txtServerUrl.Text.Trim();
            optionsRequest.UseSSL = chkUseSSL.Checked;
            optionsRequest.Credentials = cred;
 

            // Send the request
            ASOptionsResponse optionsResponse = optionsRequest.GetOptions();

            string sResult = string.Empty;
            StringBuilder s = new StringBuilder();
            if (optionsResponse != null)
            {
                s.Append(string.Format("Supported Versions: {0}\r\n", optionsResponse.SupportedVersions));
                s.Append(string.Format("Highest Supported Version: {0}\r\n", optionsResponse.HighestSupportedVersion));
                s.Append(string.Format("Supported Commands: {0}\r\n", optionsResponse.SupportedCommands));
            }
            txtResponse.Text = s.ToString();

            //Console.WriteLine("Supported Versions: {0}\r\n"", optionsResponse.SupportedVersions);
            //Console.WriteLine("Highest Supported Version: {0}\r\n", optionsResponse.HighestSupportedVersion);
            //Console.WriteLine("Supported Commands: {0}\r\n", optionsResponse.SupportedCommands);

             

            //txtResponse.Text = optionsResponse.XMLString;
            this.Cursor = Cursors.Default;
        }

      

        private void btnDecodeRequest_Click(object sender, EventArgs e)
        {
            
           
  
        }

        public string GetDisplayableHex(string xx)
        {
            string sRet = string.Empty;
 

            return sRet;
        }

        // code below taken from http://blogs.microsoft.co.il/blogs/mneiter/archive/2009/03/22/how-to-encoding-and-decoding-base64-strings-in-c.aspx
 
        
        public static string DecodeFrom64asUtf8(string encodedData)
        {
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
            string returnValue = System.Text.Encoding.UTF8.GetString(encodedDataAsBytes);
            return returnValue;

        }

        public static string DecodeFrom64asUtf7(string encodedData)
        {
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
            string returnValue = System.Text.Encoding.UTF7.GetString(encodedDataAsBytes);
            return returnValue;
        }
        public static string DecodeFrom64asUtf32(string encodedData)
        {
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
            string returnValue = System.Text.Encoding.UTF32.GetString(encodedDataAsBytes);
            return returnValue;
        }
        public static string DecodeFrom64asUnicode(string encodedData)
        {
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
            string returnValue = System.Text.Encoding.Unicode.GetString(encodedDataAsBytes);
            return returnValue;
        }

        public static string DecodeFrom64asAscii(string encodedData)
        {
            byte[] encodedDataAsBytes = System.Convert.FromBase64String(encodedData);
            string returnValue = System.Text.Encoding.ASCII.GetString(encodedDataAsBytes);
            return returnValue;
        }

      
 

        private void button2_Click(object sender, EventArgs e)
        {
            // http://support.microsoft.com/kb/308060
            //XmlWriter o = new writter
        }

        private void btnTestDecode_Click(object sender, EventArgs e)
        {
            DecodeWbxmlBinaryFile oForm = new DecodeWbxmlBinaryFile();
            oForm.ShowDialog();
            oForm = null;
        }

        private void txtResponse_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDecodeWbxmlBytesIntoXML_Click(object sender, EventArgs e)
        {
            DecodeWbxmlBytesIntoXML oForm = new DecodeWbxmlBytesIntoXML();
            oForm.ShowDialog();
            oForm = null;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkOverrideSslCertificateVerification_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExamples_Click_1(object sender, EventArgs e)
        {
            //ChooseExamples oForm = new ChooseExamples();
            //oForm.ShowDialog();
            //if (oForm.ChoseOK == true)
            //{
            //    this.txtRequest.Text = oForm.ChosenExample;
            //}
        }

        private void txtResultInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveExample_Click(object sender, EventArgs e)
        {
            string sInitialDirectory = Application.StartupPath + "\\Examples";

            string sSuggestedFilename = "*.xml";
            string sSelectedfile = string.Empty;
            string sFilter = "Text files (*.xml)|*.xml|All files (*.*)|*.*";

            if (MyHelpers.UserIoHelper.PickSaveFileToFolder(sInitialDirectory, sSuggestedFilename, ref  sSelectedfile, sFilter))
            {
                try
                {
                    System.IO.File.WriteAllText(sSelectedfile, txtRequest.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error writting file.");
                }

            }
        }

        private void btnLoadExample_Click(object sender, EventArgs e)
        {
            string sInitialDirectory = Application.StartupPath + "\\Examples";

            string sSuggestedFilename = "*.xml";
            string sSelectedfile = string.Empty;
            string sFilter = "Text files (*.xml)|*.xml|All files (*.*)|*.*";

            if (MyHelpers.UserIoHelper.PickLoadFromFile(sInitialDirectory, sSuggestedFilename, ref  sSelectedfile, sFilter))
            {
                try
                {

                    txtRequest.Text = System.IO.File.ReadAllText(sSelectedfile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error reading file.");
                }

            }
        }
 
 
 

 

    }
}
