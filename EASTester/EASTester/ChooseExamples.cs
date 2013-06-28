using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Resources;
using System.Windows.Forms;

namespace EASTester
{
    public partial class ChooseExamples : Form
    {
        public bool ChoseOK = false;
        public string ChosenExample = string.Empty;

        public ChooseExamples()
        {
            InitializeComponent();
        }

        private void Examples_Load(object sender, EventArgs e)
        {

            lvItems.Clear();
            lvItems.View = View.Details;
            lvItems.GridLines = true;
  
            lvItems.FullRowSelect = true;
            

            lvItems.Columns.Add("Command", 200, HorizontalAlignment.Left);
            lvItems.Columns.Add("Example",700, HorizontalAlignment.Left);
            //lvItems.Columns.Add("Comments", 100, HorizontalAlignment.Left);
    
            ListViewItem oListItem = null;

            oListItem = new ListViewItem("Provision - First Part", 0);
            oListItem.SubItems.Add(ExampleResources.Provision_First);
            lvItems.Items.AddRange(new ListViewItem[] { oListItem }); ;
            oListItem = null;

            oListItem = new ListViewItem("Provision - Second Part", 0);
            oListItem.SubItems.Add(ExampleResources.Provision_Second);
            lvItems.Items.AddRange(new ListViewItem[] { oListItem }); ;
            oListItem = null;


            oListItem = new ListViewItem("Settings", 0);
            oListItem.SubItems.Add(ExampleResources.Settings);
            lvItems.Items.AddRange(new ListViewItem[] { oListItem }); ;
            oListItem = null;

            oListItem = new ListViewItem("FolderSync", 0);
            oListItem.SubItems.Add(ExampleResources.FolderSync);
            lvItems.Items.AddRange(new ListViewItem[] { oListItem }); ;
            oListItem = null;

            //oListItem = new ListViewItem("FolderSync FolderHierarchy", 0);
            //oListItem.SubItems.Add(ExampleResources.FolderSync_FolderHierarchy);
            //lvItems.Items.AddRange(new ListViewItem[] { oListItem }); ;
            //oListItem = null;


            oListItem = new ListViewItem("FolderDelete", 0);
            oListItem.SubItems.Add(ExampleResources.FolderDelete);
            lvItems.Items.AddRange(new ListViewItem[] { oListItem }); ;
            oListItem = null;

            oListItem = new ListViewItem("GetItemEstimate", 0);
            oListItem.SubItems.Add(ExampleResources.GetItemEstimate);
            lvItems.Items.AddRange(new ListViewItem[] { oListItem }); ;
            oListItem = null;

 
 
 
        }

        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count > 0)
            {
                if (lvItems.SelectedItems[0] != null)
                {
                    ChosenExample = lvItems.SelectedItems[0].SubItems[1].Text;
                    this.textBox1.Text = ChosenExample;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ChoseOK = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ChoseOK = true;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
