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
using System.Collections;
using MyHelpers;
using EASTester.Helpers;

using VisualSync;

namespace EASTester
{
    // http://msdn.microsoft.com/en-us/library/hh361570(EXCHG.140).aspx 

    
    public partial class frmRawEAS : Form
    {

        string sOrigionalResponse = string.Empty;

        public frmRawEAS()
        {
            InitializeComponent();
        }

        private void HandleRun()
        {
            bool bError = false;
            txtResponse.Text = string.Empty;
            txtHexResponse.Text = string.Empty;
            sOrigionalResponse = string.Empty; ;
            txtResponse.Update();
            txtHexResponse.Update();
            txtInfo.Text = string.Empty;
            txtInfo.Update();
            MyHelpers.WebcontrolHelper.LoadInBrowserControl(ref webBrowser1, "");

            ClearStatusCodeInfo();

 

            this.Cursor = Cursors.WaitCursor;


            // Create credentials for the user
            NetworkCredential cred = null;

            if (this.chkUseCertAuth.Checked == false)
            {
                if (txtDomain.Text.Trim().Length != 0)
                    cred = new NetworkCredential(txtDomain.Text.Trim() + "\\" + txtUser.Text.Trim(), txtPassword.Text.Trim());
                else
                    cred = new NetworkCredential(txtUser.Text.Trim(), txtPassword.Text.Trim());
            }
            else
            {
                //if (txtDomain.Text.Trim().Length != 0)
                //    cred = new NetworkCredential(txtDomain.Text.Trim() + "\\" + txtUser.Text.Trim(), txtPassword.Text.Trim());
                //else
                //    cred = new NetworkCredential(txtUser.Text.Trim(), txtPassword.Text.Trim());
            }

            try
            {
                string sCommand = cmboCommand.Text.Trim();
                string[] Work = sCommand.Split(new Char[] { ' ' });
                string sUseCommand = Work[0];

                // Initialize the command request
                ASCommandRequest commandRequest = new ASCommandRequest();
                commandRequest.Command = sUseCommand; // Ex: "Provision";   cmboCommand.Text.Trim();
                commandRequest.Credentials = cred;
                commandRequest.UseCertificateAuthentication = this.chkUseCertAuth.Checked;
                commandRequest.CertificateFile = this.txtCertAuthFile.Text.Trim();
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


                if (chkUseProxy.Checked == true)
                {
                    commandRequest.SpecifyProxySettings = true;
                    commandRequest.ProxyServer = this.txtProxyServerName.Text.Trim();
                    commandRequest.ProxyPort = Convert.ToInt32(this.txtProxyServerPort.Text.Trim());

                    if (chkOverrideProxyCredentials.Checked == true)
                    {
                        commandRequest.OverrideProxyCredntials = true;
                        commandRequest.ProxyUser = txtProxyServerUserName.Text.Trim();
                        commandRequest.ProxyPassword = txtProxyServerUserName.Text.Trim();
                        commandRequest.ProxyDomain = txtProxyServerDomain.Text.Trim();
                    }

                }

                // Create the XML payload
                commandRequest.XmlString = txtRequest.Text;

                if (bError == false)
                {
                    // Send the request
                    ASCommandResponse commandResponse = commandRequest.GetResponse();

                     
                    float iisStatusCode = (float)commandResponse.HttpResponseStatusCode;
                    string StatusCode = iisStatusCode.ToString();
                    string Meaning = string.Empty;
                    string Cause = string.Empty;
                    string Resolution = string.Empty;
                    EASTester.EasHelp oHelp = new EASTester.EasHelp();
                    oHelp.GetHttpStatusInfo(StatusCode, ref Meaning, ref Cause, ref Resolution);
                    //MessageBox.Show("IIS Resposne Code: " + StatusCode + "\r\nDescription: " + Meaning);

                    string ResultStatusInfo = string.Empty;

                    ResultStatusInfo = "IIS Resposne Code: " + StatusCode + "  Description: " + Meaning + "\r\n";

                    if (commandResponse != null)
                    {
                        // Seen nulls returned - ex: conversation id, which is in a cdata as binary
                        string sCleaned = commandResponse.XMLString.Replace("\0", "");
  

                        string outputDoc = string.Empty;
                        try
                        {
                            XmlDocument oXmlDocument = null;
                            oXmlDocument = new XmlDocument();
                            oXmlDocument.LoadXml(sCleaned);

                         
                            //outputDoc = EasTesterUtilities.TransformXml(oXmlDocument);  // TODO: Get transformation to work.
                            outputDoc = sCleaned;  // Use old way until I can get it to transform.
                        
                
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error in XML repsonse transformation for display.");
                            bError = true;
                        }

                        if (bError == false)
                        {
                            MyHelpers.WebcontrolHelper.LoadInBrowserControl(ref webBrowser1, outputDoc);
                        }
                        //MyHelpers.WebcontrolHelper.LoadInBrowserControl(ref webBrowser1, sCleaned);
                        txtResponse.Text = sCleaned;

                        sOrigionalResponse = commandResponse.XMLString;
                        txtHexResponse.Text = MyHelpers.StringHelper.DumpString(sOrigionalResponse);

                        ResultStatusInfo += GetStatusCodeInfoFromEasXmlResponse(sCleaned);


                    }
                    else
                    {
                        txtResponse.Text = "";
                        txtHexResponse.Text = "";
                        MyHelpers.WebcontrolHelper.LoadInBrowserControl(ref webBrowser1, "");
                        sOrigionalResponse = string.Empty;

                    }

                    this.txtInfo.Text = ResultStatusInfo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

            this.Cursor = Cursors.Default;

        }

        private bool CheckEntryForRun()
        {
            StringBuilder sbEntryErrors = new StringBuilder();
            bool bNoEntryErrors = true;

            if (txtServerUrl.Text.Trim().Length == 0)
            {
                sbEntryErrors.AppendLine("Mail Domain or address is required.");
                bNoEntryErrors = false;
            }
            if (this.cmboVersion.Text.Trim().Length == 0)
            {
                sbEntryErrors.AppendLine("EAS Version must be set.");
                bNoEntryErrors = false;
            }
            if (txtDeviceId.Text.Trim().Length == 0)
            {
                sbEntryErrors.AppendLine("Device Id must be set.");
                bNoEntryErrors = false;
            }
            if (txtDeviceType.Text.Trim().Length == 0)
            {
                sbEntryErrors.AppendLine("Device Type must be set.");
                bNoEntryErrors = false;
            }

            if (this.chkUseCertAuth.Checked == true)
            {
                if (this.txtCertAuthFile.Text.Trim().Length == 0)
                {
                    sbEntryErrors.AppendLine("Certificate file must be selected.");
                    bNoEntryErrors = false;
                }
            }
            else
            {   
 
                if (txtUser.Text.Trim().Length == 0)
                {
                    sbEntryErrors.AppendLine("User is required.");
                    bNoEntryErrors = false;
                }
                if (txtPassword.Text.Trim().Length == 0)
                {
                    sbEntryErrors.AppendLine("Password is required.");
                    bNoEntryErrors = false;
                }
                if (txtUser.Text.Contains("@") == true && txtDomain.Text.Trim().Length != 0)
                {
                    sbEntryErrors.AppendLine("Don't enter a domain if you enter a UPN (or email address).");
                    bNoEntryErrors = false;
                }
            }
 
            if (bNoEntryErrors == false)
            {
                MessageBox.Show(sbEntryErrors.ToString(), "Entry Error");
            }

            return bNoEntryErrors;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (CheckEntryForRun() == true)
                HandleRun();

        }

        private void ClearStatusCodeInfo() 
        {
   
            this.txtInfo.Text = "";
 
            txtInfo.Update();
       
        }

        private string GetStatusCodeInfoFromEasXmlResponse(string sResponse)
        {
            XmlDocument doc = new XmlDocument();
            string sNodeQuery = string.Empty;
            string ResponseCodeToFind = string.Empty;
            string sReturn = string.Empty;

            if (sResponse.Length != 0)
            {

                ClearStatusCodeInfo();

                // in ms-ascmd - see:  
                //    1.2.3.162.2  FolderCreate
                //    2.2.3.162.3  FolderDelete
                //    2.2.3.162.4  FolderSync
                //    2.2.3.152.5  FolderUpdate
                //    2.2.3.162.6  GetItemEstimate
                //    2.2.3.162.7  ItemsOperation

                //doc.LoadXml(sResponse);
                //XmlNode root = doc.DocumentElement;
                //XmlNamespaceManager nsmgr = new XmlNamespaceManager(doc.NameTable);
                //nsmgr.AddNamespace("xprefix", "xmlns:folderhierarchy");
                //FoundNode = root.SelectSingleNode("descendant::bk:book[bk:author/bk:last-name='Kingsolver']", nsmgr);


                // Example response
                //<?xml version="1.0" encoding="utf-8"?>
                //<folderhierarchy:FolderSync xmlns:folderhierarchy="FolderHierarchy:">
                //  <folderhierarchy:Status>144</folderhierarchy:Status>
                //</folderhierarchy:FolderSync>

                //sNodeQuery = "//folderhierarchy:Status[text()=" + CodeToFind + "]";
                //FoundNode = doc.DocumentElement.SelectSingleNode(sNodeQuery).ParentNode;

                // TODO: Expand this to get different levels of stus codes to be used later when getting help from the help files.
                int iStart = 0;
                iStart = sResponse.IndexOf("Status>");
                iStart += 7;
                string sSub = sResponse.Substring(iStart, 20);
                int iEnd = sSub.Substring(0).IndexOf("<");
                ResponseCodeToFind = sSub.Substring(0, iEnd);

                EasHelp oEasHelp = new EasHelp();
                ArrayList oArrayList = null;

                //HelpInfo oHelpInfo = new HelpInfo();

                string sTopic = string.Empty;
                sTopic = cmboCommand.Text.Trim();

                oArrayList = oEasHelp.GetStatusHelp(ResponseCodeToFind, sTopic, sResponse);

                StringBuilder oSB = new StringBuilder();
                foreach (HelpInfo oHelpInfo in oArrayList)
                {
                    oSB.AppendFormat("Info for:  {0}\r\n", oHelpInfo.InfoFor);
                    oSB.AppendFormat("    StatusCode:  {0}  Meaning: {1}\r\n", oHelpInfo.StatusCode, oHelpInfo.Meaning);
                    oSB.AppendFormat("    Cause:  {0}\r\n", oHelpInfo.Cause);
                    oSB.AppendFormat("    Resolution:  {0}\r\n", oHelpInfo.Resolution);
                    oSB.AppendFormat("    Reference: {0}\r\n", oHelpInfo.ReferenceDoc);
                    //oSB.AppendFormat("-------------\r\n");
                }

                sReturn = oSB.ToString() + "\r\n";
            }
            else
            {

                sReturn = "The EAS response body was empty, so further information cannot be provided. \r\n";
            }

            sReturn += "Time: " + DateTime.Now.ToString();

            return sReturn;
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
            SetCertAuthCheckedState();

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

            SetProxyChecked();
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

            bool bEntryError = false;

            if (txtServerUrl.Text.Trim().Length == 0)
            {
                MessageBox.Show("Domain or address is required", "Entry Error");
                bEntryError = true;
            }

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

            //Set Proxy Settings if indicated
            if (chkUseProxy.Checked == true)
            {
                optionsRequest.SpecifyProxySettings = true;
                optionsRequest.ProxyServer = this.txtProxyServerName.Text.Trim();
                optionsRequest.ProxyPort = Convert.ToInt32(this.txtProxyServerPort.Text.Trim());

                if (chkOverrideProxyCredentials.Checked == true)
                {
                    optionsRequest.OverrideProxyCredntials = true;
                    optionsRequest.ProxyUser = txtProxyServerUserName.Text.Trim();
                    optionsRequest.ProxyPassword = txtProxyServerUserName.Text.Trim();
                    optionsRequest.ProxyDomain = txtProxyServerDomain.Text.Trim();
                }

            }

            if (bEntryError == false)
            {
                ASOptionsResponse optionsResponse = null;
                try
                {
                    // Send the request
                    optionsResponse = optionsRequest.GetOptions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error getting OPTIONS");
                }

                string sResult = string.Empty;
                StringBuilder s = new StringBuilder();
                if (optionsResponse != null)
                {
                    s.Append(string.Format("Supported Versions: {0}\r\n", optionsResponse.SupportedVersions));
                    s.Append(string.Format("Highest Supported Version: {0}\r\n", optionsResponse.HighestSupportedVersion));
                    s.Append(string.Format("Supported Commands: {0}\r\n", optionsResponse.SupportedCommands));
                }
                string sResponse = s.ToString();
                txtResponse.Text = sResponse;
                txtHexResponse.Text = MyHelpers.StringHelper.DumpString(sResponse);
                MyHelpers.WebcontrolHelper.LoadInBrowserControl(ref webBrowser1, sResponse);
                sOrigionalResponse = sResponse;
                txtInfo.Text = string.Empty;
            }

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
            string sFilter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

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
            string sFilter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

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

        private void btnEncodingHelper_Click(object sender, EventArgs e)
        {
            EncodeForm oForm = new EncodeForm();
            oForm.Show();
        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            string sFile = string.Empty;
            string sFilter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            string sConnectionSettings = string.Empty;
            ConnectionSetting oConnectionSetting = null;
            string sFileContents = string.Empty;

            if (UserIoHelper.PickLoadFromFile(Application.UserAppDataPath, "*.xml", ref sFile, sFilter))
            {
                try
                {
                    sFileContents = System.IO.File.ReadAllText(sFile );
                    oConnectionSetting = SerialHelper.DeserializeObjectFromString<ConnectionSetting>(sFileContents);
                    if (oConnectionSetting == null)
                        throw new Exception("Settings file cannot be deserialized.");
                    SetFormFromConnectionSettings(oConnectionSetting);
                }
                catch (Exception ex)
                {
           
                    // Moved display of error to deserialization routine.
                    // MessageBox.Show(ex.ToString(), "Error Loading File");

                }
 

            }
            oConnectionSetting = null;
        }


        private void SetFormFromConnectionSettings(ConnectionSetting oConnectionSetting)
        {
            try
            {
                this.txtServerUrl.Text = StringHelper.DeNullString(oConnectionSetting.MailDomain);

                this.chkUseCertAuth.Checked = oConnectionSetting.UseCertificateAuthentication;
                this.txtCertAuthFile.Text = StringHelper.DeNullString(oConnectionSetting.CertificateFile);

                this.txtUser.Text = StringHelper.DeNullString(oConnectionSetting.User);
                this.txtDomain.Text = StringHelper.DeNullString(oConnectionSetting.Domain);
                //this.txtPassword.Text = oConnectionSetting.Password;
                this.chkUseSSL.Checked = oConnectionSetting.UseSSL;

                //if (oConnectionSetting.OverrideSsslCertVerification == null)
                //    this.chkUseSSL.Checked = false;
                //else
                this.chkUseSSL.Checked = oConnectionSetting.UseSSL;

                //if (oConnectionSetting.OverrideSsslCertVerification == null)
                //    this.chkOverrideSslCertificateVerification.Checked = false;Now
                //else
                this.chkOverrideSslCertificateVerification.Checked = oConnectionSetting.OverrideSsslCertVerification;

               
                this.cmboVersion.Text = StringHelper.DeNullString(oConnectionSetting.EasVersion);
                this.txtDeviceId.Text = StringHelper.DeNullString(oConnectionSetting.DeviceId);
                this.txtDeviceType.Text = StringHelper.DeNullString(oConnectionSetting.DeviceType);
                this.cmboCommand.Text = StringHelper.DeNullString(oConnectionSetting.Command);
                this.txtPolicyKey.Text = StringHelper.DeNullString(oConnectionSetting.PolicyKey);

                //this.txtRequest.Text = StringHelper.DeNullString(oConnectionSetting.EasRequest).Replace("\n", "\r\n");


                byte[] oFromBytes = null;
                string sRequest = string.Empty;

 
                if ((oConnectionSetting.EncodedEasRequest == "") &&
                    (oConnectionSetting.EasRequest != ""))
                {
                    sRequest = StringHelper.DeNullString(oConnectionSetting.EasRequest).Replace("\n", "\r\n");

                }
                else
                {
                    try
                    {
                        oFromBytes = System.Convert.FromBase64String(oConnectionSetting.EncodedEasRequest);
                        sRequest = System.Text.ASCIIEncoding.ASCII.GetString(oFromBytes);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error");
                        sRequest = "";
                    }
                }
                this.txtRequest.Text = sRequest;

                // response:
                if ((oConnectionSetting.EncodedEasResponse == "") &&
                    (oConnectionSetting.EasResponse != ""))
                {
                    sOrigionalResponse = StringHelper.DeNullString(oConnectionSetting.EasResponse).Replace("\n", "\r\n");
                }
                else
                {                    
                    try
                    {
                        oFromBytes = System.Convert.FromBase64String(oConnectionSetting.EncodedEasResponse);
                        sOrigionalResponse = System.Text.ASCIIEncoding.ASCII.GetString(oFromBytes);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error");
                        sOrigionalResponse = "";
                    }
                }
                txtHexResponse.Text = MyHelpers.StringHelper.DumpString(sOrigionalResponse);

                string sCleaned = sOrigionalResponse.Replace("\0", "");

                this.txtResponse.Text = sCleaned;
                MyHelpers.WebcontrolHelper.LoadInBrowserControl(ref webBrowser1, sCleaned);

                this.txtInfo.Text = StringHelper.DeNullString(oConnectionSetting.EasResponseInfo).Replace("\n", "\r\n"); ;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading settings into form");
            }
 
        }

        //private string FixSetting(string sSetting)
        //{
        //    if (sSetting == null)
        //        return "";
        //    else
        //        return sSetting;

        //}


        private void SetConnectionSettingsFromForm(ref ConnectionSetting oConnectionSetting)
        {


            oConnectionSetting.MailDomain = this.txtServerUrl.Text;

            oConnectionSetting.UseCertificateAuthentication = chkUseCertAuth.Checked;
            oConnectionSetting.CertificateFile = this.txtCertAuthFile.Text;

            oConnectionSetting.User = this.txtUser.Text;
            oConnectionSetting.Domain = this.txtDomain.Text;
            //oConnectionSetting.Password = this.txtPassword.Text;
            oConnectionSetting.UseSSL = this.chkUseSSL.Checked;
            oConnectionSetting.OverrideSsslCertVerification = this.chkOverrideSslCertificateVerification.Checked;
            oConnectionSetting.EasVersion = this.cmboVersion.Text;
            oConnectionSetting.DeviceId = this.txtDeviceId.Text;
            oConnectionSetting.DeviceType = this.txtDeviceType.Text;
            oConnectionSetting.Command = this.cmboCommand.Text;
            oConnectionSetting.PolicyKey = this.txtPolicyKey.Text;

          
            byte[] oFromBytes = null;

            oFromBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(this.txtRequest.Text);
            oConnectionSetting.EncodedEasRequest  = System.Convert.ToBase64String(oFromBytes);
           // oConnectionSetting.EasRequest = this.txtRequest.Text;

            oFromBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(sOrigionalResponse);
            oConnectionSetting.EncodedEasResponse = System.Convert.ToBase64String(oFromBytes);
            //oConnectionSetting.EasResponse = sOrigionalResponse;
          
            oConnectionSetting.EasResponseInfo = this.txtInfo.Text;
             
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string sFile = string.Empty;
            string sFilter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";

            string sConnectionSettings = string.Empty;
            ConnectionSetting oConnectionSetting = new ConnectionSetting();

            SetConnectionSettingsFromForm(ref oConnectionSetting);

            if (UserIoHelper.PickSaveFileToFolder(Application.UserAppDataPath, "Connection Settings " + TimeHelper.NowMashup() + ".xml", ref sFile, sFilter))
            {
                sConnectionSettings = SerialHelper.SerializeObjectToString<ConnectionSetting>(oConnectionSetting);
                if (sConnectionSettings != string.Empty)
                {
                    try
                    {
                        System.IO.File.WriteAllText(sFile, sConnectionSettings);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Saving File");
                    }
                }
            }
        }

        private void chkUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            SetProxyChecked();
        }

        private void SetProxyChecked()
        {
            this.txtProxyServerName.Enabled = chkUseProxy.Checked;
            this.txtProxyServerPort.Enabled = chkUseProxy.Checked;
            this.chkOverrideProxyCredentials.Enabled = chkUseProxy.Checked;

            if (chkUseProxy.Checked == true)
            {
                if (chkOverrideProxyCredentials.Checked == true)
                {
                    txtProxyServerUserName.Enabled = true;
                    txtProxyServerPassword.Enabled = true;
                    txtProxyServerDomain.Enabled = true; 
                }
                else
                {
                    txtProxyServerUserName.Enabled = false;
                    txtProxyServerPassword.Enabled = false;
                    txtProxyServerDomain.Enabled = false; 
                }
            }
            else
            {
                txtProxyServerUserName.Enabled = false;
                txtProxyServerPassword.Enabled = false;
                txtProxyServerDomain.Enabled = false;
            }

        }

        private void chkOverrideProxyCredentials_CheckedChanged(object sender, EventArgs e)
        {
            SetProxyChecked();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnStatusCodeHelper_Click(object sender, EventArgs e)
        {
            InfoOnEasResponse oForm = new InfoOnEasResponse();
            oForm.ShowDialog();
        }

        private void txtResponse_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewInBrowser_Click(object sender, EventArgs e)
        {
            ViewInBrowser oForm = new ViewInBrowser();
            oForm.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string sHelpFile = string.Empty;
            sHelpFile = Application.StartupPath + "\\Help\\" + "Help.html";
           

            HelpWindow oForm = new HelpWindow(sHelpFile);
            oForm.Show();
        }

        private void txtPolicyKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkUseCertAuth_CheckedChanged(object sender, EventArgs e)
        {
            SetCertAuthCheckedState();
        }

        private void SetCertAuthCheckedState()
        {
            if (chkUseCertAuth.Checked == true)
            {
                this.txtCertAuthFile.Enabled = true;
                this.btnSelectCertFile.Enabled = true;

                this.txtUser.Enabled = false;
                this.txtPassword.Enabled = false;
                this.txtDomain.Enabled = false;

            }
            else
            {
                this.txtCertAuthFile.Enabled = false;
                this.btnSelectCertFile.Enabled = false;

                this.txtUser.Enabled = true;
                this.txtPassword.Enabled = true;
                this.txtDomain.Enabled = true;
            }
        }

        private void btnSelectCertFile_Click(object sender, EventArgs e)
        {
            string sFile = string.Empty;

            string sInitialDirectory = Application.StartupPath + "\\Examples";
 
            string sSuggestedFilename = "*.pfx";
            string sSelectedfile = string.Empty;
            string sFilter = "PFX files (*.pfx)|*.pfx|Cer files (*.cer)|*.cer|All files (*.*)|*.*";
 
            if (MyHelpers.UserIoHelper.PickLoadFromFile(sInitialDirectory, sSuggestedFilename, ref  sSelectedfile, sFilter))
            {
                txtCertAuthFile.Text = sSelectedfile;
            }
        }
 
    }

 
}
