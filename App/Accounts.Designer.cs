namespace App
{
    partial class Accounts
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
            this.Datelbl = new System.Windows.Forms.Label();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.HouseRentlbl = new System.Windows.Forms.Label();
            this.EmpSallbl = new System.Windows.Forms.Label();
            this.Utilities = new System.Windows.Forms.Label();
            this.HouseRenttb = new System.Windows.Forms.TextBox();
            this.Utilitiestb = new System.Windows.Forms.TextBox();
            this.EmpTotalSaltb = new System.Windows.Forms.TextBox();
            this.CostView = new System.Windows.Forms.DataGridView();
            this.ViewAllCostsbtn = new System.Windows.Forms.Button();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Logoutbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.totallbl = new System.Windows.Forms.Label();
            this.Totaltb = new System.Windows.Forms.TextBox();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.Billnolbl = new System.Windows.Forms.Label();
            this.BillnoTB = new System.Windows.Forms.TextBox();
            this.searchlbl = new System.Windows.Forms.Label();
            this.searchcosttb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CostView)).BeginInit();
            this.SuspendLayout();
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.Location = new System.Drawing.Point(28, 70);
            this.Datelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(38, 17);
            this.Datelbl.TabIndex = 0;
            this.Datelbl.Text = "Date";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "Aug",
            "Sept",
            "Oct",
            "Nov",
            "Dec"});
            this.MonthComboBox.Location = new System.Drawing.Point(72, 70);
            this.MonthComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(66, 21);
            this.MonthComboBox.TabIndex = 1;
            this.MonthComboBox.Text = "Month";
            this.MonthComboBox.SelectedIndexChanged += new System.EventHandler(this.MonthComboBox_SelectedIndexChanged);
            // 
            // HouseRentlbl
            // 
            this.HouseRentlbl.AutoSize = true;
            this.HouseRentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseRentlbl.Location = new System.Drawing.Point(28, 141);
            this.HouseRentlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HouseRentlbl.Name = "HouseRentlbl";
            this.HouseRentlbl.Size = new System.Drawing.Size(83, 17);
            this.HouseRentlbl.TabIndex = 3;
            this.HouseRentlbl.Text = "House Rent";
            // 
            // EmpSallbl
            // 
            this.EmpSallbl.AutoSize = true;
            this.EmpSallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpSallbl.Location = new System.Drawing.Point(28, 181);
            this.EmpSallbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmpSallbl.Name = "EmpSallbl";
            this.EmpSallbl.Size = new System.Drawing.Size(150, 17);
            this.EmpSallbl.TabIndex = 4;
            this.EmpSallbl.Text = "Employee Total Salary";
            // 
            // Utilities
            // 
            this.Utilities.AutoSize = true;
            this.Utilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utilities.Location = new System.Drawing.Point(28, 225);
            this.Utilities.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Utilities.Name = "Utilities";
            this.Utilities.Size = new System.Drawing.Size(53, 17);
            this.Utilities.TabIndex = 5;
            this.Utilities.Text = "Utilities";
            // 
            // HouseRenttb
            // 
            this.HouseRenttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseRenttb.Location = new System.Drawing.Point(176, 141);
            this.HouseRenttb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HouseRenttb.Name = "HouseRenttb";
            this.HouseRenttb.Size = new System.Drawing.Size(132, 21);
            this.HouseRenttb.TabIndex = 6;
            this.HouseRenttb.TextChanged += new System.EventHandler(this.HouseRenttb_TextChanged);
            // 
            // Utilitiestb
            // 
            this.Utilitiestb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Utilitiestb.Location = new System.Drawing.Point(177, 225);
            this.Utilitiestb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Utilitiestb.Name = "Utilitiestb";
            this.Utilitiestb.Size = new System.Drawing.Size(132, 21);
            this.Utilitiestb.TabIndex = 7;
            // 
            // EmpTotalSaltb
            // 
            this.EmpTotalSaltb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpTotalSaltb.Location = new System.Drawing.Point(176, 181);
            this.EmpTotalSaltb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmpTotalSaltb.Name = "EmpTotalSaltb";
            this.EmpTotalSaltb.Size = new System.Drawing.Size(132, 21);
            this.EmpTotalSaltb.TabIndex = 8;
            // 
            // CostView
            // 
            this.CostView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CostView.Location = new System.Drawing.Point(334, 89);
            this.CostView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CostView.Name = "CostView";
            this.CostView.ReadOnly = true;
            this.CostView.RowTemplate.Height = 24;
            this.CostView.Size = new System.Drawing.Size(311, 192);
            this.CostView.TabIndex = 9;
            this.CostView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccCellClick);
            // 
            // ViewAllCostsbtn
            // 
            this.ViewAllCostsbtn.Location = new System.Drawing.Point(334, 44);
            this.ViewAllCostsbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewAllCostsbtn.Name = "ViewAllCostsbtn";
            this.ViewAllCostsbtn.Size = new System.Drawing.Size(311, 24);
            this.ViewAllCostsbtn.TabIndex = 10;
            this.ViewAllCostsbtn.Text = "View All Costs";
            this.ViewAllCostsbtn.UseVisualStyleBackColor = true;
            this.ViewAllCostsbtn.CausesValidationChanged += new System.EventHandler(this.viewallbtnclick);
            this.ViewAllCostsbtn.Click += new System.EventHandler(this.viewcostbtnclick);
            // 
            // Insertbtn
            // 
            this.Insertbtn.Location = new System.Drawing.Point(31, 306);
            this.Insertbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(56, 19);
            this.Insertbtn.TabIndex = 11;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = true;
            this.Insertbtn.Click += new System.EventHandler(this.insertbtnclick);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(251, 306);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(56, 19);
            this.Deletebtn.TabIndex = 12;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.deletebtnclick);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(176, 306);
            this.Loadbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(56, 19);
            this.Loadbtn.TabIndex = 13;
            this.Loadbtn.Text = "Load";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.loadbtnclick);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(104, 306);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(56, 19);
            this.Updatebtn.TabIndex = 14;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.updatebtnclick);
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.BackColor = System.Drawing.Color.Red;
            this.Logoutbtn.Location = new System.Drawing.Point(589, 7);
            this.Logoutbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.Size = new System.Drawing.Size(56, 32);
            this.Logoutbtn.TabIndex = 15;
            this.Logoutbtn.Text = "LogOut";
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.logoutbtnclick);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(20, 375);
            this.backbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(56, 19);
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtnclick);
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Location = new System.Drawing.Point(31, 41);
            this.Refreshbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(264, 24);
            this.Refreshbtn.TabIndex = 17;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = true;
            this.Refreshbtn.Click += new System.EventHandler(this.refreshbtnclick);
            // 
            // totallbl
            // 
            this.totallbl.AutoSize = true;
            this.totallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totallbl.Location = new System.Drawing.Point(28, 265);
            this.totallbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totallbl.Name = "totallbl";
            this.totallbl.Size = new System.Drawing.Size(92, 17);
            this.totallbl.TabIndex = 18;
            this.totallbl.Text = "Total Amount";
            // 
            // Totaltb
            // 
            this.Totaltb.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Totaltb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totaltb.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Totaltb.Location = new System.Drawing.Point(177, 262);
            this.Totaltb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Totaltb.Name = "Totaltb";
            this.Totaltb.ReadOnly = true;
            this.Totaltb.Size = new System.Drawing.Size(132, 21);
            this.Totaltb.TabIndex = 19;
            // 
            // YearComboBox
            // 
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019"});
            this.YearComboBox.Location = new System.Drawing.Point(142, 70);
            this.YearComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(72, 21);
            this.YearComboBox.TabIndex = 20;
            this.YearComboBox.Text = "Year";
            // 
            // Billnolbl
            // 
            this.Billnolbl.AutoSize = true;
            this.Billnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Billnolbl.Location = new System.Drawing.Point(28, 104);
            this.Billnolbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Billnolbl.Name = "Billnolbl";
            this.Billnolbl.Size = new System.Drawing.Size(48, 17);
            this.Billnolbl.TabIndex = 21;
            this.Billnolbl.Text = "Bill No";
            // 
            // BillnoTB
            // 
            this.BillnoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillnoTB.Location = new System.Drawing.Point(177, 102);
            this.BillnoTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BillnoTB.Name = "BillnoTB";
            this.BillnoTB.Size = new System.Drawing.Size(132, 21);
            this.BillnoTB.TabIndex = 22;
            this.BillnoTB.TextChanged += new System.EventHandler(this.BillnoTB_TextChanged);
            // 
            // searchlbl
            // 
            this.searchlbl.AutoSize = true;
            this.searchlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchlbl.Location = new System.Drawing.Point(331, 293);
            this.searchlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchlbl.Name = "searchlbl";
            this.searchlbl.Size = new System.Drawing.Size(53, 17);
            this.searchlbl.TabIndex = 23;
            this.searchlbl.Text = "Search";
            // 
            // searchcosttb
            // 
            this.searchcosttb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchcosttb.Location = new System.Drawing.Point(382, 293);
            this.searchcosttb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchcosttb.Name = "searchcosttb";
            this.searchcosttb.Size = new System.Drawing.Size(264, 21);
            this.searchcosttb.TabIndex = 24;
            this.searchcosttb.TextChanged += new System.EventHandler(this.SearchTBValueChanged);
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(665, 410);
            this.Controls.Add(this.searchcosttb);
            this.Controls.Add(this.searchlbl);
            this.Controls.Add(this.BillnoTB);
            this.Controls.Add(this.Billnolbl);
            this.Controls.Add(this.YearComboBox);
            this.Controls.Add(this.Totaltb);
            this.Controls.Add(this.totallbl);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.Logoutbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.ViewAllCostsbtn);
            this.Controls.Add(this.CostView);
            this.Controls.Add(this.EmpTotalSaltb);
            this.Controls.Add(this.Utilitiestb);
            this.Controls.Add(this.HouseRenttb);
            this.Controls.Add(this.Utilities);
            this.Controls.Add(this.EmpSallbl);
            this.Controls.Add(this.HouseRentlbl);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.Datelbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Accounts";
            this.ShowIcon = false;
            this.Text = "Buying House Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.Accounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CostView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Label HouseRentlbl;
        private System.Windows.Forms.Label EmpSallbl;
        private System.Windows.Forms.Label Utilities;
        private System.Windows.Forms.TextBox HouseRenttb;
        private System.Windows.Forms.TextBox Utilitiestb;
        private System.Windows.Forms.TextBox EmpTotalSaltb;
        private System.Windows.Forms.DataGridView CostView;
        private System.Windows.Forms.Button ViewAllCostsbtn;
        private System.Windows.Forms.Button Insertbtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Loadbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Logoutbtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.TextBox Totaltb;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label Billnolbl;
        private System.Windows.Forms.TextBox BillnoTB;
        private System.Windows.Forms.Label searchlbl;
        private System.Windows.Forms.TextBox searchcosttb;
    }
}