using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using VisualSync;

using System.Security.Cryptography.X509Certificates;
 
namespace VisualSync
{
    struct CommandParameter
    {
        public string Parameter;
        public string Value;
    }

    // Base class for ActiveSync command requests
    class ASCommandRequest
    {
        private bool specifyProxySettings = false;
        private string proxyServer = null;
        private int proxyPort = 80;
        private bool overrideProxyCredntials  = false;
        private string proxyUser = null;
        private string proxyPassword = null;
        private string proxyDomain = null;

        private NetworkCredential credential = null;
        private string server = null;
        private bool useCertificateAuthentication = false;
        private string certificateFile = null;
        private string certificatePassword = null;

        private bool useSSL = true;
        private byte[] wbxmlBytes = null;
        private string xmlString = null;
        private string protocolVersion = null;
        private string requestLine = null;
        private bool useEncodedRequestLine = true;
        private string command = null;
        private string user = null;
        private string deviceID = null;
        private string deviceType = null;
        private UInt32 policyKey = 0;
        private CommandParameter[] parameters = null;


        #region Property Accessors
        
        public bool SpecifyProxySettings
        {
            get
            {
                return specifyProxySettings;
            }
            set
            {
                specifyProxySettings = value;
            }
        }

        public string ProxyServer
        {
            get
            {
                return proxyServer;
            }
            set
            {
                proxyServer = value;
            }
        }

        public int ProxyPort
        {
            get
            {
                return proxyPort;
            }
            set
            {
                proxyPort = value;
            }
        }

        public bool OverrideProxyCredntials
        {
            get
            {
                return overrideProxyCredntials;
            }
            set
            {
                overrideProxyCredntials = value;
            }
        }

 

        public string ProxyUser
        {
            get
            {
                return proxyUser;
            }
            set
            {
                proxyUser = value;
            }
        }

        public string ProxyPassword
        {
            get
            {
                return proxyPassword;
            }
            set
            {
                proxyPassword = value;
            }
        }

        public string ProxyDomain
        {
            get
            {
                return proxyDomain;
            }
            set
            {
                proxyDomain = value;
            }
        }
        
        public NetworkCredential Credentials
        {
            get
            {
                return credential;
            }
            set
            {
                credential = value;
            }
        }

        public string Server
        {
            get
            {
                return server;
            }
            set
            {
                server = value;
            }
        }

        public bool UseCertificateAuthentication
        {
            get
            {
                return useCertificateAuthentication;
            }
            set
            {
                useCertificateAuthentication = value;
            }
        }

        public string CertificateFile
        {
            get
            {
                return certificateFile;
            }
            set
            {
                certificateFile = value;
            }
        }

        public string CertificatePassword
        {
            get
            {
                return certificatePassword;
            }
            set
            {
                certificatePassword = value;
            }
        }

        public bool UseSSL
        {
            get
            {
                return useSSL;
            }
            set
            {
                useSSL = value;
            }
        }

        public byte[] WbxmlBytes
        {
            get
            {
                return wbxmlBytes;
            }
            set
            {
                wbxmlBytes = value;
                // Loading WBXML bytes causes immediate decoding
                xmlString = DecodeWBXML(wbxmlBytes);
            }
        }

        public string XmlString
        {
            get
            {
                return xmlString;
            }
            set
            {
                xmlString = value;
                // Loading XML causes immediate encoding
                wbxmlBytes = EncodeXMLString(xmlString);
            }
        }

        public string ProtocolVersion
        {
            get
            {
                return protocolVersion;
            }
            set
            {
                protocolVersion = value;
            }
        }

        public string RequestLine
        {
            get
            {
                // Generate on demand
                BuildRequestLine();
                return requestLine;
            }
            set
            {
                requestLine = value;
            }
        }

        public bool UseEncodedRequestLine
        {
            get
            {
                return useEncodedRequestLine;
            }
            set
            {
                useEncodedRequestLine = value;
            }
        }

        public string Command
        {
            get
            {
                return command;
            }
            set
            {
                command = value;
            }
        }

        public string User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }

        public string DeviceID
        {
            get
            {
                return deviceID;
            }
            set
            {
                deviceID = value;
            }
        }

        public string DeviceType
        {
            get
            {
                return deviceType;
            }
            set
            {
                deviceType = value;
            }
        }

        public UInt32 PolicyKey
        {
            get
            {
                return policyKey;
            }
            set
            {
                policyKey = value;
            }
        }

        public CommandParameter[] CommandParameters
        {
            get
            {
                return parameters;
            }
            set
            {
                parameters = value;
            }
        }
        #endregion

        public ASCommandResponse GetResponse()
        {

            string StatusCode = string.Empty;
            string Meaning = string.Empty;
            string Cause = string.Empty;
            string Resolution = string.Empty;
            EASTester.EasHelp oHelp = new EASTester.EasHelp();

            GenerateXMLPayload();

            //if (ProtocolVersion == null)
            //    throw new InvalidDataException("ASCommandRequest not initialized - Protocol version not specified.");

            //if (ProtocolVersion == null)
            //    throw new InvalidDataException("ASCommandRequest not initialized - EAS Protocol version must be set");

            //if (WbxmlBytes == null)
            //    throw new InvalidDataException("ASCommandRequest not initialized - Request is empty.");

            //if (Server == null)
            //    throw new InvalidDataException("ASCommandRequest not initialized - Server must be specified.");

            //if (Credentials == null && useCertificateAuthentication == false)
            //    throw new InvalidDataException("ASCommandRequest not initialized for authentication.");

            //if (useCertificateAuthentication == true && certificateFile.Length == 0)
            //    throw new InvalidDataException("ASCommandRequest not initialized - Certificate file must be specified.");

            string uriString = string.Format("{0}//{1}/Microsoft-Server-ActiveSync?{2}",
                useSSL ? "https:" : "http:", server, RequestLine);
            Uri serverUri = new Uri(uriString);

 
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(uriString);

            //bool bSettingCredsWasOK = false;
            if (useCertificateAuthentication == true)
            {
                //CredentialCache creds = new CredentialCache();
                //// Using Basic authentication
                //creds.Add(serverUri, "Basic", credential);
                //httpReq.Credentials = creds;

               

                // https://support.microsoft.com/en-us/kb/895971
                try
                {
                    //httpReq.UseDefaultCredentials = true;
                    X509Certificate Cert = null;
                    if (certificatePassword.Length != 0)
                        Cert = new X509Certificate(certificateFile, certificatePassword);
                    else
                        Cert = X509Certificate.CreateFromCertFile(certificateFile);
                     
                    //Cert = new X509Certificate(certificateFile, certificatePassword, X509KeyStorageFlags.xxx);

                    // Handle any certificate errors on the certificate from the server.
                    ServicePointManager.CertificatePolicy = new CertPolicy();
                    httpReq.ClientCertificates.Add(Cert);
                    //httpReq.ClientCertificates.Add(X509Certificate.CreateFromCertFile(certificateFile));
                    //bSettingCredsWasOK = true;
                }
                //catch (CryptographyException exCrypto)
                //{
                //    //System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                //    MessageBox.Show("Exception: \r\n" + ex.ToString(), "Error setting certificate authentication.");
                //    //bSettingCredsWasOK = false;
                //    //return null;
                //}
                catch (Exception ex)
                {
                    //System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                    MessageBox.Show("Exception: \r\n" + ex.ToString(), "Error setting certificate authentication.");
                    //bSettingCredsWasOK = false;
                    //return null;
                }
         
            }
            else
            {
                try
                {
                    CredentialCache creds = new CredentialCache();
                    // Using Basic authentication
                    creds.Add(serverUri, "Basic", credential);
                    httpReq.Credentials = creds;
                    //bSettingCredsWasOK = true;
                }
                catch (Exception ex)
                {
                    //System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
                    MessageBox.Show("Exception: \r\n" + ex.ToString(), "Error setting specified credentials.");
                    //bSettingCredsWasOK = false;
                    return null;
                }
         
            }
             
            httpReq.Method = "POST";
            httpReq.ContentType = "application/vnd.ms-sync.wbxml";

            if (SpecifyProxySettings == true)
            {
                WebProxy oWebProxy = null;
                oWebProxy = new WebProxy(ProxyServer, ProxyPort);
                //oWebProxy.BypassProxyOnLocal = BypassProxyForLocalAddress;

                if (OverrideProxyCredntials == true)
                {
                    if (ProxyUser.Trim().Length == 0)
                    {
                        oWebProxy.UseDefaultCredentials = true;
                    }
                    else
                    {
                        if (ProxyDomain.Trim().Length == 0)
                            oWebProxy.Credentials = new NetworkCredential(ProxyUser, ProxyPassword);
                        else
                            oWebProxy.Credentials = new NetworkCredential(ProxyUser, ProxyPassword, ProxyDomain);
                    }
                }
                else
                {
                    oWebProxy.UseDefaultCredentials = true;
                }

                httpReq.Proxy = oWebProxy;
            }

            if (!UseEncodedRequestLine)
            {
                httpReq.Headers.Add("MS-ASProtocolVersion", ProtocolVersion);
                httpReq.Headers.Add("X-MS-PolicyKey", PolicyKey.ToString());
            }

            try
            {
                Stream requestStream = httpReq.GetRequestStream();
                requestStream.Write(WbxmlBytes, 0, WbxmlBytes.Length);
                requestStream.Close();

                HttpWebResponse httpResp = (HttpWebResponse)httpReq.GetResponse();

                //float iisStatusCode = (float)httpResp.StatusCode;
                 

                ASCommandResponse response = WrapHttpResponse(httpResp);

                httpResp.Close();

                //StatusCode = iisStatusCode.ToString();
                //Meaning = string.Empty;
                //Cause = string.Empty;
                //Resolution = string.Empty;
                //oHelp.GetHttpStatusInfo(StatusCode, ref Meaning, ref Cause, ref Resolution);

                //MessageBox.Show("IIS Resposne Code: " + StatusCode + "\r\nDescription: " + Meaning);

                return response;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception: \r\n" + ex.ToString(), "Error");

                return null;
            }
        }

        //Implement the ICertificatePolicy interface.
        class CertPolicy : ICertificatePolicy
        {
            public bool CheckValidationResult(ServicePoint srvPoint,
        X509Certificate certificate, WebRequest request, int certificateProblem)
            {
                // You can do your own certificate checking.
                // You can obtain the error values from WinError.h.

                // Return true so that any certificate will work with this sample.
                return true;
            }
        }

        protected virtual ASCommandResponse WrapHttpResponse(HttpWebResponse httpResp)
        {
            return new ASCommandResponse(httpResp);
        }

        protected virtual void BuildRequestLine()
        {
            if (Command == null || User == null || DeviceID == null || DeviceType == null)
                throw new InvalidDataException("ASCommandRequest not initialized.");

            if (UseEncodedRequestLine == true)
            {
                EncodedRequest encRequest = new EncodedRequest();

                encRequest.ProtocolVersion = Convert.ToByte(Convert.ToSingle(ProtocolVersion) * 10);
                encRequest.SetCommandCode(Command);
                encRequest.SetLocale("en-us");
                encRequest.DeviceId = DeviceID;
                encRequest.DeviceType = DeviceType;
                encRequest.PolicyKey =  PolicyKey;

                encRequest.AddCommandParameter("User", user);

                if (CommandParameters != null)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        encRequest.AddCommandParameter(CommandParameters[i].Parameter, CommandParameters[i].Value);
                    }
                }

                RequestLine = encRequest.GetBase64EncodedString();
            }
            else
            {
                RequestLine = string.Format("Cmd={0}&User={1}&DeviceId={2}&DeviceType={3}",
                Command, User, DeviceID, DeviceType);

                if (CommandParameters != null)
                {
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        RequestLine = string.Format("{0}&{1}={2}", RequestLine,
                            CommandParameters[i].Parameter, CommandParameters[i].Value);
                    }
                }
            }
        }

        protected virtual void GenerateXMLPayload()
        {
            // For the base class, this is a no-op.
            // Classes that extend this class to implement
            // commands override this function to generate
            // the XML payload based on the command's request schema.
        }
        private string DecodeWBXML(byte[] wbxml)
        {
            try
            {
                ASWBXML decoder = new ASWBXML();
                decoder.LoadBytes(wbxml);
                return decoder.GetXml();
            }
            catch (Exception ex)
            {
                //VSError.ReportException(ex);
                MessageBox.Show("Exception: \r\n" + ex.ToString(), "Error");
                System.Diagnostics.Debug.WriteLine("--------------------------");
                System.Diagnostics.Debug.WriteLine("Exception:");
                System.Diagnostics.Debug.WriteLine("  Message: " + ex.Message);
                System.Diagnostics.Debug.WriteLine("    Stack: " + ex.StackTrace);
                return "";
            }
        }

        private byte[] EncodeXMLString(string stringXML)
        {
            try
            {
                ASWBXML encoder = new ASWBXML();
                encoder.LoadXml(stringXML);
                return encoder.GetBytes();
            }
            catch (Exception ex)
            {
                //VSError.ReportException(ex);
                MessageBox.Show("Exception: \r\n" + ex.ToString(), "Error");
                System.Diagnostics.Debug.WriteLine("--------------------------");
                System.Diagnostics.Debug.WriteLine("Exception:");
                System.Diagnostics.Debug.WriteLine("  Message: " + ex.Message);
                System.Diagnostics.Debug.WriteLine("    Stack: " + ex.StackTrace);
                return null;
            }
        }
    }

}

