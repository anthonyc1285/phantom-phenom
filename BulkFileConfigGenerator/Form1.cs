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
            var configTemplate = checkedListBulkFiles.Text; // probably need a case/switch that sets the ID based on the file type selected and plugs in the file name
        
           
            //need a foreach loop that creates output text for each item selected. 
            txtOutput.Text = "<BulkFileItem> <BcpTimeout>PT0S</BcpTimeout> <ID>" + configTemplate + "</ID> <LocalFile>{13}\\" + local + "</LocalFile> <RemoteFIle>{0}\\" + remote + "</RemoteFile>"  ;
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBulkFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
