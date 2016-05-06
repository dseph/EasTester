//using System;
//using System.Collections.Generic;

//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Xml;
//using VisualSync;

//namespace VisualSync
//{
//    class ASProvisionResponse : ASCommandResponse
//    {
//        public enum ProvisionStatus
//        {
//            Success = 1,
//            SyntaxError = 2,
//            ServerError = 3,
//            DeviceNotFullyProvisionable = 139,
//            LegacyDeviceOnStrictPolicy = 141,
//            ExternallyManagedDevicesNotAllowed = 145
//        }

//        private bool policyLoaded = false;
//        private ASPolicy policy = null;
//        private Int32 status = 0;

//        public ASProvisionResponse(HttpWebResponse httpResponse)
//            : base(httpResponse)
//        {
//            policy = new ASPolicy();
//            policyLoaded = policy.LoadXML(XmlString);
//            SetStatus();
//        }

//        #region Property Accessors

//        public bool PolicyLoaded
//        {
//            get
//            {
//                return policyLoaded;
//            }
//        }

//        public ASPolicy Policy
//        {
//            get
//            {
//                return policy;
//            }
//        }

//        public Int32 Status
//        {
//            get
//            {
//                return status;
//            }
//        }

//        #endregion

//        private void SetStatus()
//        {
//            XmlDocument responseXml = new XmlDocument();
//            responseXml.LoadXml(XmlString);

//            XmlNamespaceManager xmlNsMgr = new XmlNamespaceManager(responseXml.NameTable);
//            xmlNsMgr.AddNamespace("provision", "Provision");

//            XmlNode provisionNode = responseXml.SelectSingleNode(".//provision:Provision", xmlNsMgr);
//            XmlNode statusNode = null;
//            if (provisionNode != null)
//                statusNode = provisionNode.SelectSingleNode(".//provision:Status", xmlNsMgr);

//            if (statusNode != null)
//                status = XmlConvert.ToInt32(statusNode.InnerText);
//        }
//    }
//}