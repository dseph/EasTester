using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;

namespace EASTester
{
    public partial class InfoOnEasResponse : Form
    {
        public InfoOnEasResponse()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            string ResponseCodeToFind = string.Empty;
            string sResponse = txtResponse.Text.Trim();

            // TODO: Expand this to get different levels of stus codes to be used later when getting help from the help files.
            int iStart = 0;
            iStart = sResponse.IndexOf("Status>");
            iStart += 7;
            string sSub = sResponse.Substring(iStart, 20);
            int iEnd = sSub.Substring(0).IndexOf("<");
            ResponseCodeToFind = sSub.Substring(0, iEnd);

            EasHelp oEasHelp = new EasHelp();
            ArrayList oArrayList = null;

            oArrayList = oEasHelp.GetStatusHelp(ResponseCodeToFind, cmboCommand.Text.Trim(), sResponse);

            StringBuilder oSB = new StringBuilder();
            foreach (HelpInfo oHelpInfo in oArrayList)
            {
                oSB.AppendFormat("Info for:  {0}\r\n", oHelpInfo.InfoFor);
                oSB.AppendFormat("    StatusCode:  {0}\r\n", oHelpInfo.StatusCode);
                oSB.AppendFormat("    Meaning:  {0}\r\n", oHelpInfo.Meaning);
                oSB.AppendFormat("    Cause:  {0}\r\n", oHelpInfo.Cause);
                oSB.AppendFormat("    Resolution:  {0}\r\n", oHelpInfo.Resolution);
                oSB.AppendFormat("    Reference: {0}\r\n", oHelpInfo.ReferenceDoc);
                //oSB.AppendFormat("-------------\r\n");
            }

            this.txtStatusCodeInfo.Text = oSB.ToString();
        }

        private void btnGoCodeLookup_Click(object sender, EventArgs e)
        {

        }
    }
}
