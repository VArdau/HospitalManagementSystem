namespace HospitalManagementSystem
{
    partial class UpdatePassword
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
            this.bttnUpdatePassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnUpdatePassword
            // 
            this.bttnUpdatePassword.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnUpdatePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnUpdatePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnUpdatePassword.Location = new System.Drawing.Point(354, 52);
            this.bttnUpdatePassword.Name = "bttnUpdatePassword";
            this.bttnUpdatePassword.Size = new System.Drawing.Size(94, 30);
            this.bttnUpdatePassword.TabIndex = 125;
            this.bttnUpdatePassword.Text = "Update";
            this.bttnUpdatePassword.UseVisualStyleBackColor = false;
            this.bttnUpdatePassword.UseWaitCursor = true;
            this.bttnUpdatePassword.Click += new System.EventHandler(this.bttnUpdatePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 124;
            this.label4.Text = "ID";
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(55, 54);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.PlaceholderText = "000000";
            this.txtbxID.Size = new System.Drawing.Size(66, 27);
            this.txtbxID.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 122;
            this.label1.Text = "Password";
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(203, 54);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(145, 27);
            this.txtbxPassword.TabIndex = 121;
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 133);
            this.Controls.Add(this.bttnUpdatePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxPassword);
            this.Name = "UpdatePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bttnUpdatePassword;
        private Label label4;
        private TextBox txtbxID;
        private Label label1;
        private TextBox txtbxPassword;
    }
}