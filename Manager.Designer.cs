namespace HospitalManagementSystem
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.lblName = new System.Windows.Forms.Label();
            this.pcbxMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnUpdateEmployee = new System.Windows.Forms.Button();
            this.bttnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnViewEmployee = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panOptions = new System.Windows.Forms.Panel();
            this.bttnUpdatePassword = new System.Windows.Forms.Button();
            this.panPassword = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxRepeat = new System.Windows.Forms.TextBox();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxMenu)).BeginInit();
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
            this.lblName.Location = new System.Drawing.Point(1210, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(24, 28);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "...";
            // 
            // pcbxMenu
            // 
            this.pcbxMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pcbxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pcbxMenu.Image")));
            this.pcbxMenu.Location = new System.Drawing.Point(1154, 20);
            this.pcbxMenu.Name = "pcbxMenu";
            this.pcbxMenu.Size = new System.Drawing.Size(50, 50);
            this.pcbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxMenu.TabIndex = 35;
            this.pcbxMenu.TabStop = false;
            this.pcbxMenu.Click += new System.EventHandler(this.pcbxMenu_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1306, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // bttnUpdateEmployee
            // 
            this.bttnUpdateEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnUpdateEmployee.Location = new System.Drawing.Point(103, 51);
            this.bttnUpdateEmployee.Name = "bttnUpdateEmployee";
            this.bttnUpdateEmployee.Size = new System.Drawing.Size(90, 30);
            this.bttnUpdateEmployee.TabIndex = 33;
            this.bttnUpdateEmployee.Text = "Update";
            this.bttnUpdateEmployee.UseVisualStyleBackColor = true;
            this.bttnUpdateEmployee.Click += new System.EventHandler(this.bttnUpdateEmployee_Click);
            // 
            // bttnLogOut
            // 
            this.bttnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnLogOut.Location = new System.Drawing.Point(1210, 51);
            this.bttnLogOut.Name = "bttnLogOut";
            this.bttnLogOut.Size = new System.Drawing.Size(90, 30);
            this.bttnLogOut.TabIndex = 32;
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
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 35);
            this.label1.TabIndex = 31;
            this.label1.Text = "Employee";
            // 
            // bttnViewEmployee
            // 
            this.bttnViewEmployee.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnViewEmployee.Location = new System.Drawing.Point(7, 51);
            this.bttnViewEmployee.Name = "bttnViewEmployee";
            this.bttnViewEmployee.Size = new System.Drawing.Size(90, 30);
            this.bttnViewEmployee.TabIndex = 30;
            this.bttnViewEmployee.Text = "View";
            this.bttnViewEmployee.UseVisualStyleBackColor = true;
            this.bttnViewEmployee.Click += new System.EventHandler(this.bttnViewEmployee_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-9, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1363, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // panOptions
            // 
            this.panOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panOptions.Controls.Add(this.bttnUpdatePassword);
            this.panOptions.Location = new System.Drawing.Point(1028, 76);
            this.panOptions.Name = "panOptions";
            this.panOptions.Size = new System.Drawing.Size(176, 59);
            this.panOptions.TabIndex = 48;
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
            this.panPassword.Controls.Add(this.label5);
            this.panPassword.Controls.Add(this.txtbxPassword);
            this.panPassword.Location = new System.Drawing.Point(1020, 147);
            this.panPassword.Name = "panPassword";
            this.panPassword.Size = new System.Drawing.Size(193, 275);
            this.panPassword.TabIndex = 49;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 127;
            this.label5.Text = "Password";
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(14, 108);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(145, 27);
            this.txtbxPassword.TabIndex = 126;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.panPassword);
            this.Controls.Add(this.panOptions);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pcbxMenu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttnUpdateEmployee);
            this.Controls.Add(this.bttnLogOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnViewEmployee);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxMenu)).EndInit();
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
        private PictureBox pcbxMenu;
        private PictureBox pictureBox2;
        private Button bttnUpdateEmployee;
        private Button bttnLogOut;
        private Label label1;
        private Button bttnViewEmployee;
        private PictureBox pictureBox1;
        private Panel panOptions;
        private Button bttnUpdatePassword;
        private Panel panPassword;
        private Label label3;
        private TextBox txtbxRepeat;
        private TextBox txtbxID;
        private Button bttnUpdate;
        private Label label4;
        private Label label5;
        private TextBox txtbxPassword;
    }
}