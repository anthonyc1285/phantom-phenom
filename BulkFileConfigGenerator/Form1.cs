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
            int i;
            var s = "";
            for (i = 0; i <= (checkedListBulkFiles.Items.Count - 1); i++)
            {
                if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "Relationship")
                {
                    s = @"<BulkFileItem>" + "\n" +
                        @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                        @"<ID>Reps</ID>" + "\n" + 
                        @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_Relationship_" + local + @".txt</LocalFile>" + "\n" + 
                        @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" + 
                        @"<Optional>false</Optional>" + "\n" + 
                        @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_Relationship_" + remote + @".txt</RemoteFile>" + "\n" + 
                        @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                        @"<UploadFileName i:nil=""true"" />" + "\n" + 
                        @"</BulkFileItem>";

                }
            }
            txtOutput.Text = s;
        }



        private void label_Click(object sender, EventArgs e)
        {

        }

        public void checkedListBulkFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
