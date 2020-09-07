namespace App
{
    partial class LoginForm
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
            this.UserNamelbl = new System.Windows.Forms.Label();
            this.Passlbl = new System.Windows.Forms.Label();
            this.UNameTB = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNamelbl
            // 
            this.UserNamelbl.AutoSize = true;
            this.UserNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNamelbl.Location = new System.Drawing.Point(54, 213);
            this.UserNamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserNamelbl.Name = "UserNamelbl";
            this.UserNamelbl.Size = new System.Drawing.Size(120, 24);
            this.UserNamelbl.TabIndex = 0;
            this.UserNamelbl.Text = "User Name:";
            // 
            // Passlbl
            // 
            this.Passlbl.AutoSize = true;
            this.Passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlbl.Location = new System.Drawing.Point(54, 268);
            this.Passlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Passlbl.Name = "Passlbl";
            this.Passlbl.Size = new System.Drawing.Size(106, 24);
            this.Passlbl.TabIndex = 1;
            this.Passlbl.Text = "Password:";
            // 
            // UNameTB
            // 
            this.UNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNameTB.Location = new System.Drawing.Point(172, 212);
            this.UNameTB.Margin = new System.Windows.Forms.Padding(2);
            this.UNameTB.Name = "UNameTB";
            this.UNameTB.Size = new System.Drawing.Size(196, 26);
            this.UNameTB.TabIndex = 2;
            this.UNameTB.TextChanged += new System.EventHandler(this.UNameTB_TextChanged);
            // 
            // PassTB
            // 
            this.PassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTB.Location = new System.Drawing.Point(172, 267);
            this.PassTB.Margin = new System.Windows.Forms.Padding(2);
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(196, 26);
            this.PassTB.TabIndex = 3;
            this.PassTB.UseSystemPasswordChar = true;
            this.PassTB.TextChanged += new System.EventHandler(this.PassTB_TextChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(172, 349);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(2);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(64, 28);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.Loginbtnclick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(421, 484);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.UNameTB);
            this.Controls.Add(this.Passlbl);
            this.Controls.Add(this.UserNamelbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Buying House Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNamelbl;
        private System.Windows.Forms.Label Passlbl;
        private System.Windows.Forms.TextBox UNameTB;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.Button loginbtn;
    }
}