using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EASTester
{
    public partial class HelpWindow : Form
    {
        private string _HelpFilePath = string.Empty;
        public HelpWindow()
        {
            InitializeComponent();
        }
        public HelpWindow(string HelpFilePath)
        {
            InitializeComponent();
            _HelpFilePath = HelpFilePath;
        }

        private void HelpWindow_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(_HelpFilePath);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }
    }
}
