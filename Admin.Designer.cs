namespace HospitalManagementSystem
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.lblName = new System.Windows.Forms.Label();
            this.pcbxMore = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnUpdateEmployee = new System.Windows.Forms.Button();
            this.bttnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnCreateAccount = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnDeleteAccount = new System.Windows.Forms.Button();
            this.panOptions = new System.Windows.Forms.Panel();
            this.bttnUpdatePassword = new System.Windows.Forms.Button();
            this.panPassword = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxRepeat = new System.Windows.Forms.TextBox();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxMore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panOptions.SuspendLayout();
            this.panPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.SteelBlue;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(1212, 11);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(24, 28);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "...";
            // 
            // pcbxMore
            // 
            this.pcbxMore.BackColor = System.Drawing.Color.SteelBlue;
            this.pcbxMore.Image = ((System.Drawing.Image)(resources.GetObject("pcbxMore.Image")));
            this.pcbxMore.Location = new System.Drawing.Point(1154, 30);
            this.pcbxMore.Name = "pcbxMore";
            this.pcbxMore.Size = new System.Drawing.Size(50, 50);
            this.pcbxMore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxMore.TabIndex = 43;
            this.pcbxMore.TabStop = false;
            this.pcbxMore.Click += new System.EventHandler(this.pcbxMore_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1308, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // bttnUpdateEmployee
            // 
            this.bttnUpdateEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnUpdateEmployee.Location = new System.Drawing.Point(105, 50);
            this.bttnUpdateEmployee.Name = "bttnUpdateEmployee";
            this.bttnUpdateEmployee.Size = new System.Drawing.Size(90, 30);
            this.bttnUpdateEmployee.TabIndex = 41;
            this.bttnUpdateEmployee.Text = "Update";
            this.bttnUpdateEmployee.UseVisualStyleBackColor = true;
            this.bttnUpdateEmployee.Click += new System.EventHandler(this.bttnUpdateEmployee_Click);
            // 
            // bttnLogOut
            // 
            this.bttnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnLogOut.Location = new System.Drawing.Point(1212, 50);
            this.bttnLogOut.Name = "bttnLogOut";
            this.bttnLogOut.Size = new System.Drawing.Size(90, 30);
            this.bttnLogOut.TabIndex = 40;
            this.bttnLogOut.Text = "Log out";
            this.bttnLogOut.UseVisualStyleBackColor = true;
            this.bttnLogOut.Click += new System.EventHandler(this.bttnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 35);
            this.label1.TabIndex = 39;
            this.label1.Text = "Account";
            // 
            // bttnCreateAccount
            // 
            this.bttnCreateAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnCreateAccount.Location = new System.Drawing.Point(9, 50);
            this.bttnCreateAccount.Name = "bttnCreateAccount";
            this.bttnCreateAccount.Size = new System.Drawing.Size(90, 30);
            this.bttnCreateAccount.TabIndex = 38;
            this.bttnCreateAccount.Text = "Create";
            this.bttnCreateAccount.UseVisualStyleBackColor = true;
            this.bttnCreateAccount.Click += new System.EventHandler(this.bttnCreateAccount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1363, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // bttnDeleteAccount
            // 
            this.bttnDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnDeleteAccount.Location = new System.Drawing.Point(201, 50);
            this.bttnDeleteAccount.Name = "bttnDeleteAccount";
            this.bttnDeleteAccount.Size = new System.Drawing.Size(90, 30);
            this.bttnDeleteAccount.TabIndex = 45;
            this.bttnDeleteAccount.Text = "Delete";
            this.bttnDeleteAccount.UseVisualStyleBackColor = true;
            this.bttnDeleteAccount.Click += new System.EventHandler(this.bttnDeleteAccount_Click);
            // 
            // panOptions
            // 
            this.panOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panOptions.Controls.Add(this.bttnUpdatePassword);
            this.panOptions.Location = new System.Drawing.Point(1013, 76);
            this.panOptions.Name = "panOptions";
            this.panOptions.Size = new System.Drawing.Size(176, 59);
            this.panOptions.TabIndex = 46;
            this.panOptions.Visible = false;
            // 
            // bttnUpdatePassword
            // 
            this.bttnUpdatePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnUpdatePassword.Location = new System.Drawing.Point(7, 13);
            this.bttnUpdatePassword.Name = "bttnUpdatePassword";
            this.bttnUpdatePassword.Size = new System.Drawing.Size(162, 30);
            this.bttnUpdatePassword.TabIndex = 47;
            this.bttnUpdatePassword.Text = "Change Password";
            this.bttnUpdatePassword.UseVisualStyleBackColor = true;
            this.bttnUpdatePassword.Click += new System.EventHandler(this.bttnUpdatePassword_Click);
            // 
            // panPassword
            // 
            this.panPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panPassword.Controls.Add(this.label3);
            this.panPassword.Controls.Add(this.txtbxRepeat);
            this.panPassword.Controls.Add(this.txtbxID);
            this.panPassword.Controls.Add(this.bttnUpdate);
            this.panPassword.Controls.Add(this.label4);
            this.panPassword.Controls.Add(this.label2);
            this.panPassword.Controls.Add(this.txtbxPassword);
            this.panPassword.Location = new System.Drawing.Point(1006, 148);
            this.panPassword.Name = "panPassword";
            this.panPassword.Size = new System.Drawing.Size(193, 275);
            this.panPassword.TabIndex = 47;
            this.panPassword.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 133;
            this.label3.Text = "Confirm";
            // 
            // txtbxRepeat
            // 
            this.txtbxRepeat.Location = new System.Drawing.Point(14, 173);
            this.txtbxRepeat.Name = "txtbxRepeat";
            this.txtbxRepeat.Size = new System.Drawing.Size(145, 27);
            this.txtbxRepeat.TabIndex = 132;
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(14, 44);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(145, 27);
            this.txtbxID.TabIndex = 131;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnUpdate.Location = new System.Drawing.Point(44, 210);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(94, 30);
            this.bttnUpdate.TabIndex = 130;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = false;
            this.bttnUpdate.UseWaitCursor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 129;
            this.label4.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 127;
            this.label2.Text = "Password";
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(14, 108);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(145, 27);
            this.txtbxPassword.TabIndex = 126;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panPassword);
            this.Controls.Add(this.panOptions);
            this.Controls.Add(this.bttnDeleteAccount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pcbxMore);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttnUpdateEmployee);
            this.Controls.Add(this.bttnLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnCreateAccount);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxMore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panOptions.ResumeLayout(false);
            this.panPassword.ResumeLayout(false);
            this.panPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private PictureBox pcbxMore;
        private PictureBox pictureBox2;
        private Button bttnUpdateEmployee;
        private Button bttnLogOut;
        private Label label1;
        private Button bttnCreateAccount;
        private PictureBox pictureBox1;
        private Button bttnDeleteAccount;
        private Panel panOptions;
        private Button bttnUpdatePassword;
        private Panel panPassword;
        private Button bttnUpdate;
        private Label label4;
        private Label label2;
        private TextBox txtbxPassword;
        private TextBox txtbxID;
        private Label label3;
        private TextBox txtbxRepeat;
    }
}