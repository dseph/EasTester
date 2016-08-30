using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EASTester
{
    public partial class SessionSettings : Form
    {
        //string sPathTemplate = Application.StartupPath + "\\AppTemplateXML";
       // private string sPathTemplateProvisionPart1 = Application.StartupPath  +"\\TemplateProvisionpart1.xml";
        //private string sPathTemplateProvisionPart2 = Application.StartupPath + "\\TemplateProvisionpart2.xml";

        public string TemplateProvisionPart1 = string.Empty;
        public string TemplateProvisionPart2 = string.Empty;
        public bool bChoseOK = false;

        public SessionSettings()
        {
            InitializeComponent();
        }

        public SessionSettings(string sPart1, string sPart2)
        {
            InitializeComponent();

            TemplateProvisionPart1 = sPart1;
            TemplateProvisionPart2 = sPart2;

            txtProvisionPart1.Text = TemplateProvisionPart1;
            txtProvisionPart2.Text = TemplateProvisionPart2;
        }

        private void SessionSettings_Load(object sender, EventArgs e)
        {
 
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TemplateProvisionPart1 = txtProvisionPart1.Text;
            TemplateProvisionPart2 = txtProvisionPart2.Text;
            bChoseOK = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bChoseOK = false;
            this.Close();
             
        }

        private void btnDefaultProvisionPart1_Click(object sender, EventArgs e)
        {
            string sPathTemplate = Application.StartupPath + "\\AppTemplateXML";
            string sPathTemplateProvisionPart1 = sPathTemplate + "\\TemplateProvisionpart1.xml";
           
            txtProvisionPart1.Text = File.ReadAllText(sPathTemplateProvisionPart1);
             
 
        }

        private void btnDefaultProvisionPart2_Click(object sender, EventArgs e)
        {
            string sPathTemplate = Application.StartupPath + "\\AppTemplateXML";
             
            string sPathTemplateProvisionPart2 = sPathTemplate + "\\TemplateProvisionpart2.xml";
 
            txtProvisionPart2.Text = File.ReadAllText(sPathTemplateProvisionPart2);
        }
    }
}
