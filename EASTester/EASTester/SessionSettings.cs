using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASTester
{
    public partial class SessionSettings : Form
    {
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
    }
}
