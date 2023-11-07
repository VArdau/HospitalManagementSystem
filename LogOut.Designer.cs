namespace HospitalManagementSystem
{
    partial class LogOut
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnYes = new System.Windows.Forms.Button();
            this.bttnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(17, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Are you sure?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "You are about to log out";
            // 
            // bttnYes
            // 
            this.bttnYes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnYes.Location = new System.Drawing.Point(83, 116);
            this.bttnYes.Name = "bttnYes";
            this.bttnYes.Size = new System.Drawing.Size(91, 42);
            this.bttnYes.TabIndex = 2;
            this.bttnYes.Text = "Yes";
            this.bttnYes.UseVisualStyleBackColor = true;
            this.bttnYes.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnNo
            // 
            this.bttnNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnNo.Location = new System.Drawing.Point(180, 116);
            this.bttnNo.Name = "bttnNo";
            this.bttnNo.Size = new System.Drawing.Size(91, 42);
            this.bttnNo.TabIndex = 3;
            this.bttnNo.Text = "No";
            this.bttnNo.UseVisualStyleBackColor = true;
            this.bttnNo.Click += new System.EventHandler(this.bttnNo_Click);
            // 
            // LogOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(365, 170);
            this.Controls.Add(this.bttnNo);
            this.Controls.Add(this.bttnYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogOut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button bttnYes;
        private Button bttnNo;
    }
}