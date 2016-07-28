using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EASTester
{
    public class ConnectionSetting
    {
  
        public string MailDomain = string.Empty;

        public bool UseCertificateAuthentication = false;
        public string CertificateFile = string.Empty;

        public string User = string.Empty;
        public string Domain = string.Empty;
        public string Password = string.Empty;

        public bool UseSSL = false;
        public bool OverrideSsslCertVerification = false;

        public string EasVersion = string.Empty;

        public string DeviceId = string.Empty;
        public string DeviceType = string.Empty;
        public string Command = string.Empty;
        public string PolicyKey = string.Empty;

        public string EasRequest = string.Empty;   // use for the requests from saves prior to changing to encoding the request
        public string EasResponse = string.Empty; // use for the response from saves prior to changing to encoding the response


        public string EasResponseInfo = string.Empty;

        public string EncodedEasRequest = string.Empty;   // Request may contain cdata or other content with non-ascii characters - so encode.
        public string EncodedEasResponse = string.Empty;  // Response may contain cdata or other content with non-ascii characters - so encode.

        public string TemplateProvisionPart1 = string.Empty;   
        public string TemplateProvisionPart2 = string.Empty;   


    }



}
