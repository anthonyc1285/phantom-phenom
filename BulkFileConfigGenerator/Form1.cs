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

        public void btnClick_Click(object sender, EventArgs e)
        {
            //var configTemplate = checkedListBulkFiles.Text;
            var remote = remoteFileName.Text;
            var local = localFileName.Text;
            getBulkFileIDs(checkedListBulkFiles.Items.Count, remote, local);
           
        }



        private void label_Click(object sender, EventArgs e)
        {

        }

        public void checkedListBulkFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void getBulkFileIDs(int items, string remote, string local)
        {
            while(items > 0)
            {
                var s = " ";
                StringBuilder sb = new StringBuilder(s);

                for (int i = 0; i <= (items - 1); i++)
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
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "Advisor") 
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
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "Client")
                    {
                        var client = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Clients</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_Client_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_Client_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, client);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "InvestmentDepositAccounts")
                    {
                        var invDepAccount = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Accounts</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_InvestmentDepositAccounts_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_InvestmentDepositAccounts_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, invDepAccount);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "LifeInsuranceAnnuity")
                    {
                        var lifeInsAnnuityAccount = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Accounts</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_LifeInsAnnuityAccounts_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_LifeInsAnnuityAccounts_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, lifeInsAnnuityAccount);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "PandCInsAccounts")
                    {
                        var propCasInsAccount = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Accounts</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_PandCInsAccounts_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_PandCInsAccounts_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, propCasInsAccount);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "PersonalPropertyAccounts")
                    {
                        var personalPropAccount = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Accounts</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_PersonalPropertyAccounts_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_PersonalPropertyAccounts_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, personalPropAccount);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "RealEstateAccounts")
                    {
                        var realEstateAccount = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Accounts</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_RealEstateAccounts_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_RealEstateAccounts_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, realEstateAccount);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "StockOptionsAccounts")
                    {
                        var stockOpAccount = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Accounts</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_StockOptionsAccounts_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_StockOptionsAccounts_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, stockOpAccount);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "StockOptionsGrants")
                    {
                        var stockOpGrant = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Accounts</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_StockOptionsGrants_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_StockOptionsGrants_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, stockOpGrant);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "VehicleInsAccounts")
                    {
                        var vehicleInsAccount = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Accounts</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_VehicleInsAccounts_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_VehicleInsAccounts_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, vehicleInsAccount);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "DisabilityInsurance")
                    {
                        var disInsAccount = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Accounts</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_DisabilityInsurance_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_DisabilityInsurance_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, disInsAccount);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "MedicalInsurance")
                    {
                        var medInsAccount = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Accounts</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_MedicalInsurance_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_MedicalInsurance_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, medInsAccount);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "LiabilityAccounts")
                    {
                        var liabilityAccount = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Loan_Accounts</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_LiabilityAccounts_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_LiabilityAccounts_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, liabilityAccount);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "Holdings")
                    {
                        var holdings = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Holdings</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_Holdings_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_Holdings_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, holdings);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "BankTransactions") 
                    {
                        var bankTransactions = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Bank_Transactions</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_BankTransactions_" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_BankTransactions_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, bankTransactions);
                    }
                    else if (checkedListBulkFiles.GetItemChecked(i) && checkedListBulkFiles.Items[i].ToString() == "InvestmentTransactions")
                    {
                        var invTransactions = @"<BulkFileItem>" + "\n" +
                           @"<BcpTimeout>PT0S</BcpTimeout>" + "\n" +
                           @"<ID>Investment_Transactions</ID>" + "\n" +
                           @"<LocalFile>{13}\" + local + @"\{3:MMddyyyy}_InvestmentTransactions" + local + @".txt</LocalFile>" + "\n" +
                           @"<MaxRowsPerBatch i:nil=""true"" />" + "\n" +
                           @"<Optional>false</Optional>" + "\n" +
                           @"<RemoteFile>{0}\" + remote + @"\{3:MMddyyyy}_InvestmentTransactions_" + remote + @".txt</RemoteFile>" + "\n" +
                           @"<UploadFileDescription i:nil=""true"" />" + "\n" +
                           @"<UploadFileName i:nil=""true"" />" + "\n" +
                           @"</BulkFileItem>" + "\n";
                        sb.Insert(s.Length - 1, invTransactions);
                    }
                    

                }

                txtOutput.Text = sb.ToString();
                break;
            }

        }
    }
}
