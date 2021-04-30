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
            var configTemplate = checkedListBulkFiles.Text;
            getBulkFileIDs();
           
        }



        private void label_Click(object sender, EventArgs e)
        {

        }

        public void checkedListBulkFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void getBulkFileIDs()
        {
            while(checkedListBulkFiles.Items.Count > 0)
            {
                var remote = remoteFileName.Text;
                var local = localFileName.Text;
                var s = " ";
                StringBuilder sb = new StringBuilder(s);

                for (int i = 0; i <= (checkedListBulkFiles.Items.Count - 1); i++)
                {
                    if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "Relationship")
                    {
                        var relationship = @"<BulkFileItem>" + "\n" +
                            @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                            @"<ID>Reps</ID>" + "\n" +
                            @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_Relationship_" + local + @".txt</LocalFile>" + "\n" +
                            @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                            @"<Optional>false</Optional>" + "\n" +
                            @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_Relationship_" + remote + @".txt</RemoteFile>" + "\n" +
                            @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                            @"<UploadFileName i:nil=""true"" />" + "\n" +
                            @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, relationship);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "Advisor") //CHECK THE ID IN NEXUS
                    {   
                        var advisor = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Reps</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_Advisor_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_Advisor_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, advisor);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "BankTransactions") //CHECK THE ID IN NEXUS
                    {
                        var bankTransactions = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Transactions</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_BankTransactions_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_BankTransactions_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, bankTransactions);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "Client") //CHECK THE ID IN NEXUS
                    {
                        var client = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Rep_Clients</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_Client_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_Client_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, client);
                    }

                }

                txtOutput.Text = sb.ToString();
                break;
            }

        }
    }
}
