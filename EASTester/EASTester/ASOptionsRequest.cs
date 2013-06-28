
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
        private NetworkCredential credential = null;
        private string server = null;
        private bool useSSL = true;

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

