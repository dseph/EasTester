using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Xml;
using System.Windows.Forms;
using System.Collections;

namespace EASTester
{
    public class EasHelp
    {
        public ArrayList GetStatusHelp(string StatusCode, string sCommand, string sResponse)
        {
            HelpInfo oHelpInfo = new HelpInfo();
            ArrayList oArrayList = new ArrayList();
            string StatusFile = string.Empty;
            string Meaning = string.Empty;
            string Cause = string.Empty;
            string Resolution = string.Empty;

            string SpecificStatusFile = string.Empty;
            string DocReference = string.Empty; // "See: 2.2.3.162.2 in the ms-ascmd Exchange Protocol Documentation";
            string DocSuffix = " found in the Exchange Protocol Documentation.";


            
            // Provide general response code info
 
            switch (sCommand)
            {

                case "FolderCreate":
                    SpecificStatusFile = "FolderCreateStatus.xml";      // 2.2.3.162.2 in ms-ascmd
                    DocReference = "See: 2.2.3.162.2 in ms-ascmd" + DocSuffix;
                    break;
                case "FolderDelete":
                    SpecificStatusFile = "FolderDeleteStatus.xml";      // 2.2.3.162.3 in ms-ascmd
                    DocReference = "See: 2.2.3.162.3 in ms-ascmd" + DocSuffix;
                    break;
                case "FolderSync":
                    SpecificStatusFile = "FolderSyncStatus.xml";        // 2.2.3.162.4 in ms-ascmd
                    DocReference = "See: 2.2.3.162.4 in ms-ascmd" + DocSuffix;
                    break;
                case "FolderUpdate":
                    SpecificStatusFile = "FolderUpdateStatus.xml";      // 2.2.3.162.5 in ms-ascmd
                    DocReference = "See: 2.2.3.162.5 in ms-ascmd" + DocSuffix;
                    break;
                case "GetItemEstimate":
                    SpecificStatusFile = "GetItemEstimateStatus.xml";   // 2.2.3.162.6 in ms-ascmd
                    DocReference = "See: 2.2.3.162.6 in ms-ascmd" + DocSuffix;
                    break;
                case "ItemsOperations":
                    SpecificStatusFile = "ItemsOperationsStatus.xml";   // 2.2.3.162.7 in ms-ascmd
                    DocReference = "See: 2.2.3.162.7 in ms-ascmd" + DocSuffix;
                    break;
                case "MeetingResponse":
                    SpecificStatusFile = "MeetingResponseStatus.xml";  // 2.2.3.162.8 in ms-ascmd
                    DocReference = "See: 2.2.3.162.8 in ms-ascmd" + DocSuffix;
                    break;
                case "MoveItems":
                    SpecificStatusFile = "MoveItemsStatus.xml";  // 2.2.3.162.9 in ms-ascmd
                    DocReference = "See: 2.2.3.162.9 in ms-ascmd" + DocSuffix;
                    break;
                case "Ping":
                    SpecificStatusFile = "PingStatus.xml";  // 2.2.3.162.10 in ms-ascmd
                    DocReference = "See: 2.2.3.162.10 in ms-ascmd" + DocSuffix;
                    break;

                // 
                //case "ResolveRecipients":
                //    SpecificStatusFile = "ResolveRecipientsStatus - child of ResolveRecipients.xml";  // 2.2.3.162.11 in ms-ascmd
                //    DocReference = "See: 2.2.3.162.11 in ms-ascmd" + DocSuffix;
                //    break;
                //case "ResolveRecipients":
                //    SpecificStatusFile = "ResolveRecipientsStatus - child of Response.xml";  // 2.2.3.162.11 in ms-ascmd
                //    DocReference = "See: 2.2.3.162.11 in ms-ascmd" + DocSuffix;
                //    break;
                //case "ResolveRecipients":
                //    SpecificStatusFile = "ResolveRecipientsStatus - child of Availability.xml";  // 2.2.3.162.11 in ms-ascmd
                //    DocReference = "See: 2.2.3.162.11 in ms-ascmd" + DocSuffix;
                //    break;
                //case "ResolveRecipients":
                //    SpecificStatusFile = "ResolveRecipientsStatus - Child of Certificates.xml";  // 2.2.3.162.11 in ms-ascmd
                //    DocReference = "See: 2.2.3.162.11 in ms-ascmd" + DocSuffix;
                //    break;
                //case "ResolveRecipients":
                //    SpecificStatusFile = "ResolveRecipientsStatus - Child of Picture.xml";  // 2.2.3.162.11 in ms-ascmd
                //    DocReference = "See: 2.2.3.162.11 in ms-ascmd" + DocSuffix;
                //    break;
                //case "Search":
                //    SpecificStatusFile = "SearchStatus - Child of Search.xml";  // 2.2.3.162.12 in ms-ascmd
                //    DocReference = "See: 2.2.3.162.12 in ms-ascmd" + DocSuffix;
                //    break;
                //case "Search":
                //    SpecificStatusFile = "SearchStatus - Child of Store.xml";  // 2.2.3.162.12 in ms-ascmd
                //    DocReference = "See: 2.2.3.162.12 in ms-ascmd" + DocSuffix;
                //    break;
                //case "Search":
                //    SpecificStatusFile = "SearchStatus - Child of galPicture.xml";  // 2.2.3.162.12 in ms-ascmd - its gal:Picture
                //    DocReference = "See: 2.2.3.162.12 in ms-ascmd" + DocSuffix;
                //    break;
                //case "SendMail":  (Uses common status codes)
                //    In 2.2.3.162.15 in ms-ascmd it says to use the Common Status Codes in 2.2.4
                //    SpecificStatusFile = "SendMailStatus.xml";  // 2.2.3.162.13 in ms-ascmd
                //    DocReference = "See: 2.2.3.162.13 in ms-ascmd" + DocSuffix;
                //    break;
                //case "Settings":  // wow, this may be even more complex...
                //    SpecificStatusFile = "SettingsStatus.xml";  // 2.2.3.162.14 in ms-ascmd
                //    if (sResponse.Contains("<DevicePassword>"))
                //        SpecificStatusFile = "SettingsDevicePasswordStatus.xml";
                //    if (SpecificStatusFile.Contains("<DeviceInformation>"))
                //        SpecificStatusFile = "SettingsRightsManagementInformationGet_OofGet_OofSetxDevice_InformationSet_UserInformationGet_Status.xml.xml";
                //    if (SpecificStatusFile.Contains("<UserInformation>"))
                //        SpecificStatusFile = "SettingsRightsManagementInformationGet_OofGet_OofSetxDevice_InformationSet_UserInformationGet_Status.xml.xml";
                //    if (SpecificStatusFile.Contains("<OofState>"))
                //        SpecificStatusFile = "SettingsRightsManagementInformationGet_OofGet_OofSetxDevice_InformationSet_UserInformationGet_Status.xml.xml";
                //    if (SpecificStatusFile.Contains("<RightsManagementInformation"))
                //        SpecificStatusFile = "SettingsRightsManagementInformationGet_OofGet_OofSetxDevice_InformationSet_UserInformationGet_Status.xml.xml";
                ////    DocReference = "See: 2.2.3.162.14 in ms-ascmd" + DocSuffix;
                //    break;
                //case "SmartForward":   (Uses common status codes)
                //    In 2.2.3.162.15 in ms-ascmd it says to use the Common Status Codes in 2.2.4
                //case "SmartReply":     (Uses common status codes)
                //    In 2.2.3.162.15 in ms-ascmd it says to use the Common Status Codes in 2.2.4
                //    SpecificStatusFile = "SmartForwardAndReplyStatus.xml";  // 2.2.3.162.15 in ms-ascmd
                //    DocReference = "See: 2.2.3.162.15 in ms-ascmd";
                //    break;
                case "Sync":
                    SpecificStatusFile = "SyncStatus.xml"; // 2.2.3.162.16 in ms-ascmd
                    DocReference = "See: 2.2.3.162.16 in ms-ascmd";
                    break;
                case "ValidateCert":
                    SpecificStatusFile = "ValidateCertStatus.xml"; // 2.2.3.162.17 in ms-ascmd
                    DocReference = "See: 2.2.3.162.17 in ms-ascmd";
                    break;

                case "Provision":
                    //ProvisionStatus - Child of Provision.xml   
                    SpecificStatusFile = "ProvisionStatus - Child of Provision.xml"; // 3.1.5.2 in ms-asprov
                    DocReference = "See: 3.1.5.2 in ms-asprov";  //         
                    break;
                //case "Provision":
                //    if (sResponse.Contains("<Policy>")) // pcode     
                //    {
                //        SpecificStatusFile = "ProvisionStatus - Child of Policy.xml"; // 3.1.5.2 in ms-asprov
                //        DocReference = "See: 3.1.5.2 in ms-asprov";
                //    }
                //    if (sResponse.Contains("<Provision>")) // pcode
                //    {
                //        SpecificStatusFile = "ProvisionStatus - Child of Provision.xml"; // 3.1.5.2 in ms-asprov
                //        DocReference = "See: 3.1.5.2 in ms-asprov";
                //    }
                //    if (sResponse.Contains("<Provision>"))
                //    {
                //        SpecificStatusFile = "Provision_Provision_Status.xml"; // 2.2.2.53.2 in ms-asprov
                //        DocReference = "See: 2.2.2.53.2 in ms-asprov";
                //    }
                //    if (sResponse.Contains("<Policy>"))
                //    {
                //        SpecificStatusFile = "Provision_Policy_StatusChildOfPolicyResponse_Status.xml"; // 2.2.3.162.17 in ms-ascmd
                //        DocReference = "See: 2.2.2.53.1 in ms-asprov";
                //    }
                //    if (sResponse.Contains("<RemoteWipe>"))
                //    {
                //        SpecificStatusFile = "ProvisionStatus - Child of RepoteWipes.xml"; // 2.2.2.53.3 in ms-asprov
                //        DocReference = "See: 2.2.2.53.3 in ms-asprov";
                //    }
 
                //    break;
                ////case "Provision - Policy":
                ////    SpecificStatusFile = "Provision_Policy_StatusChildOfPolicyResponse_Status.xml"; // 2.2.3.162.17 in ms-ascmd
                ////    DocReference = "See: 2.2.2.53.1 in ms-ascmd";
                ////    break;
                ////case "Provision - Provision":
                ////    SpecificStatusFile = "Provision_Provision_Status.xml"; // 2.2.3.162.17 in ms-ascmd
                ////    DocReference = "See: 2.2.2.53.2 in ms-asprov";
                ////    break;
                ////case "Provision - RemoteWipe":
                ////    SpecificStatusFile = "Provision_RepoteWipe_Status.xml"; // 2.2.3.162.17 in ms-ascmd
                ////    DocReference = "See: 2.2.2.53.3 in ms-asprov";
                ////    break;
                default:
                    SpecificStatusFile = string.Empty;
                    DocReference = string.Empty;
                    break;
            }

            bool bDetailedInfoRetreived = false;

            if (SpecificStatusFile != string.Empty)
            {
                StatusFile = Application.StartupPath + "\\AppData\\" + SpecificStatusFile;
                if (GetStatusCodesFromFile(StatusFile, StatusCode, ref Meaning, ref Cause, ref Resolution))
                {
                    if (StatusCode == string.Empty)
                        DocReference = string.Empty;  // clear the string since there is no status code returned.

                    oHelpInfo = new HelpInfo();
                    oHelpInfo.InfoFor = sCommand;
                    oHelpInfo.Meaning = Meaning.Trim();
                    oHelpInfo.Cause = Cause.Trim();
                    oHelpInfo.StatusCode = StatusCode;
                    oHelpInfo.Resolution = Resolution.Trim();
                    oHelpInfo.ReferenceDoc = DocReference;
 
                    oArrayList.Add(oHelpInfo);

                    bDetailedInfoRetreived = true;

                }
            }
 
            // Provide common response code info.
            if (bDetailedInfoRetreived == false)
            {
                int iStatusCode = 0;
                if (Int32.TryParse(StatusCode, out iStatusCode))
                {
                    if (iStatusCode > 100)
                    {  
                        StatusFile = Application.StartupPath + "\\AppData\\CommonStatus.xml";
                        if (GetStatusCodesFromFile(StatusFile, StatusCode, ref Meaning, ref Cause, ref Resolution))
                        {
                            //SpecificStatusFile = "See: 2.2.4 in ms-ascmd";
                            DocReference = "See: 2.2.4 in ms-ascmd";
                            if (StatusCode == string.Empty)
                                DocReference = string.Empty;  // clear the string since there is no status code returned.

                            oHelpInfo = new HelpInfo();
                            oHelpInfo.InfoFor = "Common Status Codes";
                            oHelpInfo.Meaning = Meaning.Trim();
                            oHelpInfo.Cause = Cause.Trim();
                            oHelpInfo.StatusCode = StatusCode;
                            oHelpInfo.Resolution = Resolution.Trim();
                            oHelpInfo.ReferenceDoc = DocReference;
                            oArrayList.Add(oHelpInfo);
                        }
                    }
                }

 
            }

            return oArrayList;

        }

        // See if a is the child of B. If not found return false.  If found then return true and set
        // the sStatus to the child's status.  This is needed in determining the status code of
        // child response elements for operateions such as ResolveRecipients, Search and Settings.
        private bool GetChildStatus(ref string sStatus, string sParent, string sChild, string sXml)
        {
            sStatus = "0";
            bool bFound = false;

            // ...

            return bFound;
        }

        public bool GetHttpStatusInfo(string StatusCode, ref string Meaning, ref string Cause, ref string Resolution)
        {
            
            string StatusFile = Application.StartupPath + "\\AppData\\HttpResponseCodes.xml";
            return GetStatusCodesFromFile(StatusFile, StatusCode, ref Meaning, ref Cause, ref Resolution);

            //if (GetStatusCodesFromFile(StatusFile, StatusCode, ref Meaning, ref Cause, ref Resolution))
            //{
            //    //SpecificStatusFile = "See: 2.2.4 in ms-ascmd";
            //    DocReference = "See: 2.2.4 in ms-ascmd";
            //    if (StatusCode == string.Empty)
            //        DocReference = string.Empty;  // clear the string since there is no status code returned.

            //    oHelpInfo = new HelpInfo();
            //    oHelpInfo.InfoFor = "Common Status Codes";
            //    oHelpInfo.Meaning = Meaning.Trim();
            //    oHelpInfo.Cause = Cause.Trim();
            //    oHelpInfo.StatusCode = StatusCode;
            //    oHelpInfo.Resolution = Resolution.Trim();
            //    oHelpInfo.ReferenceDoc = DocReference;
            //    oArrayList.Add(oHelpInfo);
            //}


            // HttpResponseCodes.xml
        }

        private bool GetStatusCodesFromFile(string StatusFile, string StatusCode, ref string Meaning, ref string Cause, ref string Resolution)
        {
            bool bRet = true;
            XmlDocument oXmlDocument = new XmlDocument();

            try
            {
                oXmlDocument.Load(StatusFile);

                XmlElement root = oXmlDocument.DocumentElement;
                XmlNode oXmlNode = null;

                Meaning = string.Empty;
                Cause = string.Empty;
                Resolution = string.Empty;

                try
                {
                    oXmlNode = root.SelectSingleNode("//Status[@ID='" + StatusCode + "']/Meaning");
                    if (oXmlNode != null)
                    {
                        Meaning = oXmlNode.InnerText;
                    }
                    else
                    {
                        bRet = false;
                    }
                }
                catch (Exception ex)
                {
                    string sJunk = ex.ToString(); 
                    Meaning = string.Empty;
                    bRet = false;
                }

                try
                {
                    oXmlNode = root.SelectSingleNode("//Status[@ID='" + StatusCode + "']/Cause");
                    if (oXmlNode != null)
                    {
                        Cause = oXmlNode.InnerText;
                    }
                }
                catch (Exception ex)
                {
                    string sJunk = ex.ToString();
                    Cause = string.Empty;
                }

                try
                {
                    oXmlNode = root.SelectSingleNode("//Status[@ID='" + StatusCode + "']/Resolution");
                    if (oXmlNode != null)
                    {
                        Resolution = oXmlNode.InnerText;
                    }
                }
                catch (Exception ex)
                {
                    string sJunk = ex.ToString(); 
                    Resolution = string.Empty;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.ToString(), "Could not load status file '" + StatusFile + "'.");

                bRet = false;
            }

            return bRet;

        }

 

    }

    public class HelpInfo
    {
        public string InfoFor = string.Empty;
        public string StatusCode = string.Empty;
        public string Meaning = string.Empty;
        public string Cause = string.Empty;
        public string Resolution = string.Empty;
        public string ReferenceDoc = string.Empty;
    }
}
