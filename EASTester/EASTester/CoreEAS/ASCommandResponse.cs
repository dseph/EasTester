using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using VisualSync;

namespace VisualSync
{
    class ASCommandResponse
    {
        private byte[] wbxmlBytes = null;
        private string xmlString = null;

        private HttpStatusCode httpResponseStatusCode =   HttpStatusCode.OK;
        string httpResponseStatusDescription = string.Empty;

        public byte[] WBXMLBytes
        {
            get
            {
                return wbxmlBytes;
            }
        }

        public string XMLString
        {
            get
            {
                return xmlString;
            }
        }


        public HttpStatusCode HttpResponseStatusCode
        {
            get
            {
                return httpResponseStatusCode;
            }
            set
            {
                httpResponseStatusCode = value;
            }
        }

        public string HttpResponseStatusDescription
        {
            get
            {
                return httpResponseStatusDescription;
            }
            set
            {
                httpResponseStatusDescription = value;
            }
        }

        public XmlDocument XmlDoc;

 

        public ASCommandResponse(HttpWebResponse httpResponse)
        {
            Stream responseStream = httpResponse.GetResponseStream();
            List<byte> bytes = new List<byte>();
            byte[] byteBuffer = new byte[256];
            int count = 0;

            count = responseStream.Read(byteBuffer, 0, 256);
            while (count > 0)
            {
                bytes.AddRange(byteBuffer);

                if (count < 256)
                {
                    int excess = 256 - count;
                    bytes.RemoveRange(bytes.Count - excess, excess);
                }

                count = responseStream.Read(byteBuffer, 0, 256);
            }

            wbxmlBytes = bytes.ToArray();
            if (bytes.Count == 0)
                xmlString = string.Empty;  // in the case the response body was empty.
            else
                xmlString = DecodeWBXML(wbxmlBytes);

            HttpResponseStatusCode = httpResponse.StatusCode;
            HttpResponseStatusDescription = httpResponse.StatusDescription;

        }

        public ASCommandResponse(byte[] wbxml)
        {
            wbxmlBytes = wbxml;

            ASWBXML decoder = new ASWBXML();

            if (wbxml.Length > 0)
            {
                decoder.LoadBytes(wbxml);
                xmlString = decoder.GetXml();
                //xmlString = DecodeWBXML(wbxmlBytes);

                // Decode with smart view parsing
                decoder.LoadBytes(wbxml, true);
                XmlDoc = decoder.GetXmlDoc();

            }

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
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error calling DecodeWBXML");
                //VSError.ReportException(ex);
                return "";
            }
        }

 
    }
}
