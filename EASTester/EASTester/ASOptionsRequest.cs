
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

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
            CredentialCache creds = new CredentialCache();
              // Using Basic authentication
            creds.Add(serverUri, "Basic", Credentials);

            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(strURI);
            httpReq.Credentials = creds; 
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

