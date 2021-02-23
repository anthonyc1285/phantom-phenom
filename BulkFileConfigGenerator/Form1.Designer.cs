namespace BulkFileConfigGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.remoteFileName = new System.Windows.Forms.TextBox();
            this.localFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.checkedListBulkFiles = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // remoteFileName
            // 
            this.remoteFileName.Location = new System.Drawing.Point(36, 430);
            this.remoteFileName.Name = "remoteFileName";
            this.remoteFileName.Size = new System.Drawing.Size(626, 26);
            this.remoteFileName.TabIndex = 0;
            // 
            // localFileName
            // 
            this.localFileName.Location = new System.Drawing.Point(36, 533);
            this.localFileName.Name = "localFileName";
            this.localFileName.Size = new System.Drawing.Size(626, 26);
            this.localFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Remote Directory: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Local Directory: ";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(196, 678);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(204, 74);
            this.btnClick.TabIndex = 4;
            this.btnClick.Text = "Submit";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(32, 834);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(83, 20);
            this.label.TabIndex = 5;
            this.label.Text = "Copy Text:";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(36, 885);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(746, 26);
            this.txtOutput.TabIndex = 6;
            // 
            // checkedListBulkFiles
            // 
            this.checkedListBulkFiles.CheckOnClick = true;
            this.checkedListBulkFiles.ColumnWidth = 300;
            this.checkedListBulkFiles.FormattingEnabled = true;
            this.checkedListBulkFiles.Items.AddRange(new object[] {
            "Advisor",
            "BankTransactions",
            "Client",
            "DisabilityInsurance",
            "Holdings",
            "InvestmentDepositAccounts",
            "InvestmentTransactions",
            "LiabilityAccounts",
            "LifeInsuranceAnnuity",
            "MedicalInsurance",
            "PandCInsAccounts",
            "PersonalPropertyAccounts",
            "RealEstateAccounts",
            "Relationship",
            "StockOptionsAccounts",
            "StockOptionsGrants",
            "VehicleInsAccounts"});
            this.checkedListBulkFiles.Location = new System.Drawing.Point(36, 149);
            this.checkedListBulkFiles.MultiColumn = true;
            this.checkedListBulkFiles.Name = "checkedListBulkFiles";
            this.checkedListBulkFiles.Size = new System.Drawing.Size(626, 193);
            this.checkedListBulkFiles.Sorted = true;
            this.checkedListBulkFiles.TabIndex = 7;
            this.checkedListBulkFiles.SelectedIndexChanged += new System.EventHandler(this.checkedListBulkFiles_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Bulk Files: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 998);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkedListBulkFiles);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.localFileName);
            this.Controls.Add(this.remoteFileName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox remoteFileName;
        private System.Windows.Forms.TextBox localFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.CheckedListBox checkedListBulkFiles;
        private System.Windows.Forms.Label label3;
    }
}

