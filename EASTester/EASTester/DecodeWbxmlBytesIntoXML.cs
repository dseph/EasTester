using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisualSync;

namespace EASTester
{
    public partial class DecodeWbxmlBytesIntoXML : Form
    {
        public byte[] LoadedBytes = null;
        public bool bChoseOK = false;

        public DecodeWbxmlBytesIntoXML()
        {
            
            InitializeComponent();
        }

        // Convert an array of ints WBXML into XML: 1, 2, 3, 4,    
        private void btnConvertfromIntArray_Click(object sender, EventArgs e)
        {
            txtEASDecoded.Text = "";
            txtTo.Text = "";
            txtToDump.Text = "";

            string sWork = string.Empty;
            sWork = txtFrom.Text;
            //bool bContinue = true;

            // weed out junk
            var sb = new StringBuilder(sWork.Length); 
            foreach (char i in sWork)
                if (i != '\n' && i != '\r' && i != '\t' && i != '\r' && i != '[' && i != ']' && i != ';')
                    sb.Append(i);
            sWork = sb.ToString();
            sWork = sWork.Replace("    ", " ");
            sWork = sWork.Replace("    ", " ");
            sWork = sWork.Replace("   ", " ");
            sWork = sWork.Replace("  ", " ");
 
            string sConverted = string.Empty;

            sb = new StringBuilder();
            string[] sItems = sWork.Split(',').Select(sValue => sValue.Trim()).ToArray();

            // Now build a clean string of hex values.  
            int iVal = 0;
            string sHex = string.Empty;

            foreach (string sNum in sItems)
            {
                iVal = int.Parse(sNum.Trim());

                sHex = string.Format("{00:X}", iVal).PadLeft(2, '0');
                sb.Append(sHex);
            }


            // With a clean string of hex values the rest of of the conversions can be done.
            string sHexString = sb.ToString();
            txtTo.Text = sHexString;
            ConvertFromHexString(sHexString);

       

        }

        private void ConvertFromHexString(string sHex)
        {
            StringBuilder sb = null;
            bool bContinue = true;
            string sHexStingErrors = string.Empty;
            string sToDump = string.Empty;
            string sEASDecoded = string.Empty;

            // Convert to two byte hex values with space delimiter.
            string sHexStrings = sHex;
            sb = new StringBuilder();
            int iCount = 0;
            foreach (char a in sHexStrings)
            {
                if ((a >= 'a' && a <= 'f') ||
                    (a >= 'A' && a <= 'F') ||
                    (a >= '0' && a <= '9'))
                {
                    sb.Append(a);
                    iCount += 1;
                    if (iCount == 2)
                    {
                        sb.Append(' ');
                        iCount = 0;
                    }

                }
                else
                {
                    sHexStingErrors += string.Format("Byte '{0}' at position {1} is not a hex digit and was replaced by 'X'.\r\n", a, iCount);
                    iCount += 1;
                    bContinue = false;
                }

            }

 
            if (bContinue == true)
            {

                sHexStrings = sb.ToString().TrimEnd();
                string StringByteErrors = string.Empty;
 
                string[] hexValuesSplit = sHexStrings.Split(' ');
                byte[] oBytes = new byte[hexValuesSplit.Length];
                int iCountBytes = 0;
                foreach (String hex in hexValuesSplit)
                {
                    if (hex.Length != 2)
                    {
                        StringByteErrors += string.Format("Byte pair '{0}' does not have two byte values.\r\n", hex);
                        bContinue = false;
                        break;
                    }
                    else
                        oBytes[iCountBytes] = Convert.ToByte(hex, 16);

                    iCountBytes++;
                }

                if (sHexStingErrors.Length != 0)
                {
                    sToDump = "Content up to bad byte pair: \r\n" + MyHelpers.StringHelper.HexDumpFromByteArray(oBytes); // Dump what we have
                    sToDump += "\r\n\r\n" + sHexStingErrors;
                }

                if (bContinue == true)
                {

                    sToDump = MyHelpers.StringHelper.HexDumpFromByteArray(oBytes);
                    ASCommandResponse commandResponse = new ASCommandResponse(oBytes);
                    sEASDecoded = commandResponse.XMLString;

                }
            }

            if (sHexStingErrors.Length != 0)
                txtTo.Text += "\r\n\r\n" + sHexStingErrors;
            txtToDump.Text = sToDump;
            txtEASDecoded.Text = sEASDecoded;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Convert to two byte hex values with space delimiter.

            StringBuilder sb = new StringBuilder();

            string sHexStrings = txtTo.Text;
            sb = new StringBuilder();
            int iCount = 0;
            foreach (char a in sHexStrings)
            {
                sb.Append(a);
                iCount += 1;
                if (iCount == 2)
                {
                    sb.Append(' ');
                    iCount = 0;
                }
            }
            sHexStrings = sb.ToString().TrimEnd(); ;
 

            string[] hexValuesSplit = sHexStrings.Split(' ');
 ;
            byte[] oBytes = new byte[hexValuesSplit.Length];
            int iCountBytes = 0;
            foreach (String hex in hexValuesSplit)
            {
                oBytes[iCountBytes] = Convert.ToByte(hex, 16);

                iCountBytes++;
            }

            LoadedBytes = oBytes;

            bChoseOK = true;

            this.Close();

 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadedBytes = null;
            bChoseOK = false;

            this.Close();
        }

        private void frmLoadOtherEAS_Load(object sender, EventArgs e)
        {

        }

        // Convert Hex Array of WBXML to XML: e7, 46, 16, 26
        private void btnConvertfromHexArray_Click(object sender, EventArgs e)
        {

            txtEASDecoded.Text = "";
            txtTo.Text = "";
            txtToDump.Text = "";

            ConvertFromHexArray(txtFrom.Text);

     
        }

        // input string can be space or comma delimited
        private void ConvertFromHexArray(string sFrom)
        {
            string sWork = string.Empty;
            sWork = sFrom;
            string sHexStingErrors = string.Empty;
            bool bContinue = true;

            // weed out junk
            var sb = new StringBuilder(sWork.Length);
            foreach (char i in sWork)
                if (i != '\n' && i != '\r' && i != '\t' && i != '\r' && i != '[' && i != ']' && i != ';')
                    sb.Append(i);
            sWork = sb.ToString();
            sWork = sWork.Replace("    ", " ");
            sWork = sWork.Replace("    ", " ");
            sWork = sWork.Replace("   ", " ");
            sWork = sWork.Replace("  ", " ");
            sWork = sWork.Replace(" ", ",");

            sb = new StringBuilder();
            string[] sItems = sWork.Split(',').Select(sValue => sValue.Trim()).ToArray();

            string sHex = string.Empty;
            int iCount = 1;
            int iTest = 0;
            bool bTest = false;
            bool bError = false;

            foreach (string sNum in sItems)
            {
                sHex = sNum.Trim();

                if (bContinue == true)
                {
                    if (sHex == "")  // this would be encountered if the hex values did not fill a full line.
                    {
                        bContinue = false;
                    }
                }

                if (bContinue == true)
                {
                    if (sHex.Length > 2)
                    {
                        sHexStingErrors += string.Format("Hex digit'{0}' in position '{1} is more than 2 characters and has been replaced with 'XX'", sHex, sb.Length);
                        sHex = "XX";
                        bContinue = false;
                        bError = true;
                    }
                }

                if (bContinue == true)
                {
                    if (sHex.Length < 2)
                    {
                        sHexStingErrors += string.Format("Hex digit'{0}' in position '{1} is less than 2 characters and has been replaced with 'XX'", sHex, sb.Length);
                        sHex = "XX";
                        bContinue = false;
                        bError = true;
                    }
                }

                if (bContinue == true)
                {
                    bTest = Int32.TryParse(sHex, System.Globalization.NumberStyles.HexNumber, null, out iTest);
                    if (bTest == false)
                    {
                        sHexStingErrors += string.Format("Hex digit'{0}' in position '{1} is not hex 'XX'", sHex, sb.Length);
                        sHex = "XX";
                        bContinue = false;
                        bError = true;
                    }
                }

                sb.Append(sHex);
                iCount++;

                if (bContinue == false)
                    break;
            }

            // With a clean string of hex values the rest of of the conversions can be done.
            string sHexString = sb.ToString();
            txtTo.Text = sHexString;

            if (bError == false)
            {
                ConvertFromHexString(sHexString);
            }
            else
            {

                txtTo.Text += "\r\n\r\n" + sHexStingErrors;

            }
        }

         
        // Convert an int csv string to a hex csv string
        private void btnHexCsvFromIntCsv_Click(object sender, EventArgs e)
        {
            txtEASDecoded.Text = "";
            txtTo.Text = "";
            txtToDump.Text = "";

            string sWork = string.Empty;
            sWork = txtFrom.Text;
  

            // weed out junk
            var sb = new StringBuilder(sWork.Length);
            foreach (char i in sWork)
                if (i != '\n' && i != '\r' && i != '\t' && i != '\r' && i != '[' && i != ']' && i != ';')
                    sb.Append(i);
            sWork = sb.ToString();
            sWork = sWork.Replace("\t", " ");
            sWork = sWork.Replace("    ", " ");
            sWork = sWork.Replace("    ", " ");
            sWork = sWork.Replace("   ", " ");
            sWork = sWork.Replace("  ", " ");

            string sConverted = string.Empty;

            sb = new StringBuilder();
            string[] sItems = sWork.Split(',').Select(sValue => sValue.Trim()).ToArray();
            try
            {
                // Now build a clean string of hex values.  
                int iVal = 0;
                string sHex = string.Empty;
                bool bAfterFirst = false;
                foreach (string sNum in sItems)
                {
                    iVal = int.Parse(sNum.Trim());

                    if (bAfterFirst == true)
                        sb.Append(", ");
                    sHex = string.Format("{00:X}", iVal).PadLeft(2, '0');
                    sb.Append(sHex);

                    bAfterFirst = true;
                }
                txtTo.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("--------------------------");
                System.Diagnostics.Debug.WriteLine("Exception:");
                System.Diagnostics.Debug.WriteLine("  Message: " + ex.Message);
                System.Diagnostics.Debug.WriteLine("    Stack: " + ex.StackTrace);
                txtTo.Text = "Error during parsing. This is what was parsed so far: " + sb.ToString();
            }

            txtTo.Text = sb.ToString();
        }

        private void ConvertHexDumpToHexStream()
        {
            txtEASDecoded.Text = "";
            txtTo.Text = "";
            txtToDump.Text = "";

            string sWork = txtFrom.Text;
            sWork = sWork.Replace("\r\n", "\r");
 
            string[] sLines = sWork.Split('\r').Select(sValue => sValue.Trim()).ToArray();
            
            StringBuilder oSB = new StringBuilder();
            string sLine = string.Empty;
            string sWorkingLine = string.Empty;
            for (int iCount = 0; iCount < sLines.Length ; iCount ++ )
            {
                sWorkingLine = sLines[iCount].Trim();
                if (sWorkingLine.Length != 0)
                {
                    if (sWorkingLine.Length > 55)
                    {
                        sLine = sWorkingLine.Substring(6, 50).Trim() + " ";
                        oSB.AppendLine(sLine);
                    }
                    else
                    {
                        sLine = sWorkingLine.Substring(6, (sWorkingLine.Length - 6)).Trim() + " ";
                        oSB.AppendLine(sLine);
                    }
                }

  
            }

            sWork = oSB.ToString();
            ConvertFromHexArray(sWork);
        }

        // Convert a continious hex stream - no seperators or end of lines.
        private void btnConvertfromHexStream_Click(object sender, EventArgs e)
        {
            txtEASDecoded.Text = "";
            txtTo.Text = "";
            txtToDump.Text = "";

            ConvertFromHexString(txtFrom.Text.Trim());
             
        }

        private void btnHexDumpToHexStream_Click(object sender, EventArgs e)
        {
            txtEASDecoded.Text = "";
            txtTo.Text = "";
            txtToDump.Text = "";

            ConvertHexDumpToHexStream();
        }

        private void txtFrom_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
