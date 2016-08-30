
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace VisualSync
{
    class ASOptionsRequest
    {
        private bool specifyProxySettings = false;
        private string proxyServer = null;
        private int proxyPort = 80;
        private bool overrideProxyCredntials = false;
        private string proxyUser = null;
        private string proxyPassword = null;
        private string proxyDomain = null;

        private bool useCertificateAuthentication = false;
        private string certificateFile = null;
        private string certificatePassword = null;

        private NetworkCredential credential = null;
        private string server = null;
        private bool useSSL = true;

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

        public ASOptionsResponse GetOptions()
        {

            if (credential == null || server == null)
                throw new InvalidDataException("ASOptionsRequest not initialized.");

            string strURI = string.Format("{0}//{1}/Microsoft-Server-ActiveSync", UseSSL ? "https:" : "http:", Server);
            Uri serverUri = new Uri(strURI);
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(strURI);

            if (useCertificateAuthentication == true)
            {
                try
                { 
                    httpReq.UseDefaultCredentials = false;
                    X509Certificate oX509Certificate = null;
                    oX509Certificate = new X509Certificate(certificateFile, certificatePassword);
                    httpReq.ClientCertificates.Add(oX509Certificate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: \r\n" + ex.ToString(), "Error setting certificate authentication.");
                    return null;
                }
            }
            else
            {
                try
                {
                    CredentialCache creds = new CredentialCache();
                    creds.Add(serverUri, "Basic", Credentials);  // Using Basic authentication
                    httpReq.Credentials = creds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: \r\n" + ex.ToString(), "Error setting specified credentials.");
                    return null;
                }
            }
     
            httpReq.Method = "OPTIONS";

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

            try
            {
                HttpWebResponse httpResp = (HttpWebResponse)httpReq.GetResponse();

                ASOptionsResponse response = new ASOptionsResponse(httpResp);


                httpResp.Close();

                return response;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error calling GetOptions");
                //VSError.ReportException(ex);
                return null;
            }
        }
    }
}

