namespace App
{
    partial class Orders
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
            this.OrderNoLbl = new System.Windows.Forms.Label();
            this.CostLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.OrderTypeLbl = new System.Windows.Forms.Label();
            this.ClientNumLbl = new System.Windows.Forms.Label();
            this.OrderTable = new System.Windows.Forms.DataGridView();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Label();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.InsertBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.OrderNoTb = new System.Windows.Forms.TextBox();
            this.OrderTypeTb = new System.Windows.Forms.TextBox();
            this.CostTb = new System.Windows.Forms.TextBox();
            this.QualityTb = new System.Windows.Forms.TextBox();
            this.ClientNumberTb1 = new System.Windows.Forms.TextBox();
            this.ClientNumberTb2 = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.clientnamelbl = new System.Windows.Forms.Label();
            this.clientnametb = new System.Windows.Forms.TextBox();
            this.clientemaillbl = new System.Windows.Forms.Label();
            this.clientemailtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderNoLbl
            // 
            this.OrderNoLbl.AutoSize = true;
            this.OrderNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderNoLbl.Location = new System.Drawing.Point(31, 129);
            this.OrderNoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderNoLbl.Name = "OrderNoLbl";
            this.OrderNoLbl.Size = new System.Drawing.Size(77, 20);
            this.OrderNoLbl.TabIndex = 0;
            this.OrderNoLbl.Text = "Order No:";
            // 
            // CostLbl
            // 
            this.CostLbl.AutoSize = true;
            this.CostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLbl.Location = new System.Drawing.Point(31, 255);
            this.CostLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CostLbl.Name = "CostLbl";
            this.CostLbl.Size = new System.Drawing.Size(46, 20);
            this.CostLbl.TabIndex = 1;
            this.CostLbl.Text = "Cost:";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.Location = new System.Drawing.Point(31, 214);
            this.QuantityLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(72, 20);
            this.QuantityLbl.TabIndex = 2;
            this.QuantityLbl.Text = "Quantity:";
            // 
            // OrderTypeLbl
            // 
            this.OrderTypeLbl.AutoSize = true;
            this.OrderTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderTypeLbl.Location = new System.Drawing.Point(31, 170);
            this.OrderTypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OrderTypeLbl.Name = "OrderTypeLbl";
            this.OrderTypeLbl.Size = new System.Drawing.Size(91, 20);
            this.OrderTypeLbl.TabIndex = 3;
            this.OrderTypeLbl.Text = "Order Type:";
            // 
            // ClientNumLbl
            // 
            this.ClientNumLbl.AutoSize = true;
            this.ClientNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNumLbl.Location = new System.Drawing.Point(31, 317);
            this.ClientNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClientNumLbl.Name = "ClientNumLbl";
            this.ClientNumLbl.Size = new System.Drawing.Size(113, 20);
            this.ClientNumLbl.TabIndex = 4;
            this.ClientNumLbl.Text = "Client Number:";
            // 
            // OrderTable
            // 
            this.OrderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderTable.Location = new System.Drawing.Point(359, 85);
            this.OrderTable.Margin = new System.Windows.Forms.Padding(2);
            this.OrderTable.Name = "OrderTable";
            this.OrderTable.RowTemplate.Height = 24;
            this.OrderTable.Size = new System.Drawing.Size(367, 157);
            this.OrderTable.TabIndex = 5;
            this.OrderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderCellClick);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.Red;
            this.LogoutBtn.Location = new System.Drawing.Point(701, 2);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(56, 34);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "LogOut";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.logoutbtnclick);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(22, 396);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(80, 32);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.backbtnclick);
            // 
            // SearchBtn
            // 
            this.SearchBtn.AutoSize = true;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(356, 247);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(49, 15);
            this.SearchBtn.TabIndex = 8;
            this.SearchBtn.Text = "Search:";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTb
            // 
            this.SearchTb.Location = new System.Drawing.Point(405, 247);
            this.SearchTb.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(322, 20);
            this.SearchTb.TabIndex = 9;
            this.SearchTb.TextChanged += new System.EventHandler(this.Searchtbchange);
            // 
            // InsertBtn
            // 
            this.InsertBtn.Location = new System.Drawing.Point(34, 347);
            this.InsertBtn.Margin = new System.Windows.Forms.Padding(2);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(56, 25);
            this.InsertBtn.TabIndex = 10;
            this.InsertBtn.Text = "Insert";
            this.InsertBtn.UseVisualStyleBackColor = true;
            this.InsertBtn.Click += new System.EventHandler(this.insertbtnclick);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(217, 347);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(56, 25);
            this.LoadBtn.TabIndex = 11;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.loadbtnclick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(156, 347);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(56, 25);
            this.DeleteBtn.TabIndex = 12;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.deletebtnclick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(95, 347);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(56, 25);
            this.UpdateBtn.TabIndex = 13;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.updatebtnclick);
            // 
            // OrderNoTb
            // 
            this.OrderNoTb.Location = new System.Drawing.Point(122, 129);
            this.OrderNoTb.Margin = new System.Windows.Forms.Padding(2);
            this.OrderNoTb.Name = "OrderNoTb";
            this.OrderNoTb.Size = new System.Drawing.Size(140, 20);
            this.OrderNoTb.TabIndex = 14;
            this.OrderNoTb.TextChanged += new System.EventHandler(this.OrderNoTb_TextChanged);
            // 
            // OrderTypeTb
            // 
            this.OrderTypeTb.Location = new System.Drawing.Point(124, 173);
            this.OrderTypeTb.Margin = new System.Windows.Forms.Padding(2);
            this.OrderTypeTb.Name = "OrderTypeTb";
            this.OrderTypeTb.Size = new System.Drawing.Size(138, 20);
            this.OrderTypeTb.TabIndex = 14;
            // 
            // CostTb
            // 
            this.CostTb.Location = new System.Drawing.Point(124, 255);
            this.CostTb.Margin = new System.Windows.Forms.Padding(2);
            this.CostTb.Name = "CostTb";
            this.CostTb.Size = new System.Drawing.Size(138, 20);
            this.CostTb.TabIndex = 15;
            // 
            // QualityTb
            // 
            this.QualityTb.Location = new System.Drawing.Point(124, 214);
            this.QualityTb.Margin = new System.Windows.Forms.Padding(2);
            this.QualityTb.Name = "QualityTb";
            this.QualityTb.Size = new System.Drawing.Size(138, 20);
            this.QualityTb.TabIndex = 16;
            // 
            // ClientNumberTb1
            // 
            this.ClientNumberTb1.Location = new System.Drawing.Point(137, 320);
            this.ClientNumberTb1.Margin = new System.Windows.Forms.Padding(2);
            this.ClientNumberTb1.Name = "ClientNumberTb1";
            this.ClientNumberTb1.ReadOnly = true;
            this.ClientNumberTb1.Size = new System.Drawing.Size(35, 20);
            this.ClientNumberTb1.TabIndex = 17;
            this.ClientNumberTb1.Text = "+880";
            this.ClientNumberTb1.TextChanged += new System.EventHandler(this.ClientNumberTb1_TextChanged);
            // 
            // ClientNumberTb2
            // 
            this.ClientNumberTb2.Location = new System.Drawing.Point(179, 320);
            this.ClientNumberTb2.Margin = new System.Windows.Forms.Padding(2);
            this.ClientNumberTb2.Name = "ClientNumberTb2";
            this.ClientNumberTb2.Size = new System.Drawing.Size(83, 20);
            this.ClientNumberTb2.TabIndex = 18;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(34, 46);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(238, 25);
            this.RefreshBtn.TabIndex = 19;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.refreshbtnclick);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(359, 55);
            this.ViewBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(367, 25);
            this.ViewBtn.TabIndex = 20;
            this.ViewBtn.Text = "View All Orders";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.viewallbtnclick);
            // 
            // clientnamelbl
            // 
            this.clientnamelbl.AutoSize = true;
            this.clientnamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientnamelbl.Location = new System.Drawing.Point(31, 85);
            this.clientnamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientnamelbl.Name = "clientnamelbl";
            this.clientnamelbl.Size = new System.Drawing.Size(99, 20);
            this.clientnamelbl.TabIndex = 21;
            this.clientnamelbl.Text = "Client Name:";
            // 
            // clientnametb
            // 
            this.clientnametb.Location = new System.Drawing.Point(122, 89);
            this.clientnametb.Margin = new System.Windows.Forms.Padding(2);
            this.clientnametb.Name = "clientnametb";
            this.clientnametb.Size = new System.Drawing.Size(140, 20);
            this.clientnametb.TabIndex = 22;
            // 
            // clientemaillbl
            // 
            this.clientemaillbl.AutoSize = true;
            this.clientemaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientemaillbl.Location = new System.Drawing.Point(31, 289);
            this.clientemaillbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.clientemaillbl.Name = "clientemaillbl";
            this.clientemaillbl.Size = new System.Drawing.Size(96, 20);
            this.clientemaillbl.TabIndex = 23;
            this.clientemaillbl.Text = "Client Email:";
            // 
            // clientemailtb
            // 
            this.clientemailtb.Location = new System.Drawing.Point(122, 289);
            this.clientemailtb.Margin = new System.Windows.Forms.Padding(2);
            this.clientemailtb.Name = "clientemailtb";
            this.clientemailtb.Size = new System.Drawing.Size(138, 20);
            this.clientemailtb.TabIndex = 24;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(766, 437);
            this.Controls.Add(this.clientemailtb);
            this.Controls.Add(this.clientemaillbl);
            this.Controls.Add(this.clientnametb);
            this.Controls.Add(this.clientnamelbl);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.ClientNumberTb2);
            this.Controls.Add(this.ClientNumberTb1);
            this.Controls.Add(this.QualityTb);
            this.Controls.Add(this.CostTb);
            this.Controls.Add(this.OrderTypeTb);
            this.Controls.Add(this.OrderNoTb);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.InsertBtn);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.OrderTable);
            this.Controls.Add(this.ClientNumLbl);
            this.Controls.Add(this.OrderTypeLbl);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.CostLbl);
            this.Controls.Add(this.OrderNoLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Orders";
            this.ShowIcon = false;
            this.Text = "Buying House Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrderNoLbl;
        private System.Windows.Forms.Label CostLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Label OrderTypeLbl;
        private System.Windows.Forms.Label ClientNumLbl;
        private System.Windows.Forms.DataGridView OrderTable;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label SearchBtn;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Button InsertBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox OrderNoTb;
        private System.Windows.Forms.TextBox OrderTypeTb;
        private System.Windows.Forms.TextBox CostTb;
        private System.Windows.Forms.TextBox QualityTb;
        private System.Windows.Forms.TextBox ClientNumberTb1;
        private System.Windows.Forms.TextBox ClientNumberTb2;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Label clientnamelbl;
        private System.Windows.Forms.TextBox clientnametb;
        private System.Windows.Forms.Label clientemaillbl;
        private System.Windows.Forms.TextBox clientemailtb;
    }
}