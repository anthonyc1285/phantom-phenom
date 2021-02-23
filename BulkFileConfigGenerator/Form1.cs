using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkFileConfigGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        public void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            var remote = remoteFileName.Text;
            var local = localFileName.Text;
            var configTemplate = checkedListBulkFiles.Text;
           

            txtOutput.Text = configTemplate + " is working? " + remote + " is the RemoteFile, and " + local + " is the LocalFile.";
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBulkFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
