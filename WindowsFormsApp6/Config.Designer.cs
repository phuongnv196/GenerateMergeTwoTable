namespace WindowsFormsApp6
{
    partial class Config
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstAccount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecondServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSecondAccount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSecondPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFirstPassword);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstAccount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirstServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Config";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSecondPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSecondServer);
            this.groupBox2.Controls.Add(this.txtSecondAccount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(238, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 114);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Second Config";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // txtFirstServer
            // 
            this.txtFirstServer.Location = new System.Drawing.Point(65, 29);
            this.txtFirstServer.Name = "txtFirstServer";
            this.txtFirstServer.Size = new System.Drawing.Size(148, 20);
            this.txtFirstServer.TabIndex = 1;
            this.txtFirstServer.Text = "DESKTOP-FVIKRQC\\SQLEXPRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account:";
            // 
            // txtFirstAccount
            // 
            this.txtFirstAccount.Location = new System.Drawing.Point(65, 55);
            this.txtFirstAccount.Name = "txtFirstAccount";
            this.txtFirstAccount.Size = new System.Drawing.Size(148, 20);
            this.txtFirstAccount.TabIndex = 1;
            this.txtFirstAccount.Text = "sa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // txtFirstPassword
            // 
            this.txtFirstPassword.Location = new System.Drawing.Point(65, 81);
            this.txtFirstPassword.Name = "txtFirstPassword";
            this.txtFirstPassword.PasswordChar = '*';
            this.txtFirstPassword.Size = new System.Drawing.Size(148, 20);
            this.txtFirstPassword.TabIndex = 1;
            this.txtFirstPassword.Text = "sa123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server:";
            // 
            // txtSecondServer
            // 
            this.txtSecondServer.Location = new System.Drawing.Point(65, 29);
            this.txtSecondServer.Name = "txtSecondServer";
            this.txtSecondServer.Size = new System.Drawing.Size(148, 20);
            this.txtSecondServer.TabIndex = 1;
            this.txtSecondServer.Text = "DESKTOP-FVIKRQC\\SQLEXPRESS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Account:";
            // 
            // txtSecondAccount
            // 
            this.txtSecondAccount.Location = new System.Drawing.Point(65, 55);
            this.txtSecondAccount.Name = "txtSecondAccount";
            this.txtSecondAccount.Size = new System.Drawing.Size(148, 20);
            this.txtSecondAccount.TabIndex = 1;
            this.txtSecondAccount.Text = "sa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password:";
            // 
            // txtSecondPassword
            // 
            this.txtSecondPassword.Location = new System.Drawing.Point(65, 81);
            this.txtSecondPassword.Name = "txtSecondPassword";
            this.txtSecondPassword.PasswordChar = '*';
            this.txtSecondPassword.Size = new System.Drawing.Size(148, 20);
            this.txtSecondPassword.TabIndex = 1;
            this.txtSecondPassword.Text = "sa123";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(195, 133);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 172);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFirstPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSecondPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSecondServer;
        private System.Windows.Forms.TextBox txtSecondAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirm;
    }
}