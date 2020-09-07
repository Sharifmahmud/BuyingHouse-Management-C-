namespace App
{
    partial class ManagementForm
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
            this.manageempbtn = new System.Windows.Forms.Button();
            this.orderbtn = new System.Windows.Forms.Button();
            this.accountsbtn = new System.Windows.Forms.Button();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.welcomelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // manageempbtn
            // 
            this.manageempbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.manageempbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageempbtn.Location = new System.Drawing.Point(54, 177);
            this.manageempbtn.Name = "manageempbtn";
            this.manageempbtn.Size = new System.Drawing.Size(113, 76);
            this.manageempbtn.TabIndex = 0;
            this.manageempbtn.Text = "Manage Employees";
            this.manageempbtn.UseVisualStyleBackColor = false;
            this.manageempbtn.Click += new System.EventHandler(this.manageempclick);
            // 
            // orderbtn
            // 
            this.orderbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.orderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderbtn.Location = new System.Drawing.Point(220, 177);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(113, 76);
            this.orderbtn.TabIndex = 1;
            this.orderbtn.Text = "Order";
            this.orderbtn.UseVisualStyleBackColor = false;
            this.orderbtn.Click += new System.EventHandler(this.orderclick);
            // 
            // accountsbtn
            // 
            this.accountsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.accountsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsbtn.Location = new System.Drawing.Point(400, 177);
            this.accountsbtn.Name = "accountsbtn";
            this.accountsbtn.Size = new System.Drawing.Size(113, 76);
            this.accountsbtn.TabIndex = 2;
            this.accountsbtn.Text = "Accounts";
            this.accountsbtn.UseVisualStyleBackColor = false;
            this.accountsbtn.Click += new System.EventHandler(this.Accountsclick);
            // 
            // logoutbtn
            // 
            this.logoutbtn.BackColor = System.Drawing.Color.Red;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.Location = new System.Drawing.Point(430, 414);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(99, 41);
            this.logoutbtn.TabIndex = 3;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = false;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtnclick);
            // 
            // welcomelbl
            // 
            this.welcomelbl.AutoSize = true;
            this.welcomelbl.Font = new System.Drawing.Font("Poor Richard", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelbl.Location = new System.Drawing.Point(176, 71);
            this.welcomelbl.Name = "welcomelbl";
            this.welcomelbl.Size = new System.Drawing.Size(136, 37);
            this.welcomelbl.TabIndex = 4;
            this.welcomelbl.Text = "Welcome";
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(573, 486);
            this.Controls.Add(this.welcomelbl);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.accountsbtn);
            this.Controls.Add(this.orderbtn);
            this.Controls.Add(this.manageempbtn);
            this.Name = "ManagementForm";
            this.ShowIcon = false;
            this.Text = "Buying House Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manageempbtn;
        private System.Windows.Forms.Button orderbtn;
        private System.Windows.Forms.Button accountsbtn;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label welcomelbl;
    }
}