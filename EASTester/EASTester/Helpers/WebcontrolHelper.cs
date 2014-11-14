using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace MyHelpers
{
    class WebcontrolHelper
    {

        public static void LoadInBrowserControl(ref WebBrowser oWebBrowser,  string sContent)
        {
            string sPath = Application.StartupPath + "\\temp";
            if (Directory.Exists(sPath) == false)
                Directory.CreateDirectory(sPath);

            string sXmlWorkFile = string.Empty;
            if (sContent.Contains("<?xml version=\"1.0\""))
                sXmlWorkFile = sPath + "\\work.xml";
            else
                sXmlWorkFile = sPath + "\\work.txt";
             
            System.IO.File.WriteAllText(sXmlWorkFile, sContent);

            oWebBrowser.Navigate(sXmlWorkFile);

        }

        public static void LoadInBrowserControl(ref WebBrowser oWebBrowser, string sContent, string sExtension)
        {
            string sPath = Application.StartupPath + "\\temp";
            if (Directory.Exists(sPath) == false)
                Directory.CreateDirectory(sPath);
            string sXmlWorkFile = sPath + "\\work." + sExtension;
            System.IO.File.WriteAllText(sXmlWorkFile, sContent);

            oWebBrowser.Navigate(sXmlWorkFile);

        }

    }
}
     