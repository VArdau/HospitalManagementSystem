namespace HospitalManagementSystem
{
    partial class UpdatePatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePatients));
            this.bttnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblExtraPhoneNumber = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtbxLastName = new System.Windows.Forms.TextBox();
            this.txtbxAddress = new System.Windows.Forms.TextBox();
            this.txtbxDOB = new System.Windows.Forms.TextBox();
            this.txtbxGender = new System.Windows.Forms.TextBox();
            this.txtbxBloodType = new System.Windows.Forms.TextBox();
            this.txtbxExtraNumber = new System.Windows.Forms.TextBox();
            this.txtbxNumber = new System.Windows.Forms.TextBox();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.txtbxFirstName = new System.Windows.Forms.TextBox();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.dgvPatientUpdate = new System.Windows.Forms.DataGridView();
            this.pcbxReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnLogOut
            // 
            this.bttnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnLogOut.Location = new System.Drawing.Point(1214, 56);
            this.bttnLogOut.Name = "bttnLogOut";
            this.bttnLogOut.Size = new System.Drawing.Size(90, 30);
            this.bttnLogOut.TabIndex = 16;
            this.bttnLogOut.Text = "Log out";
            this.bttnLogOut.UseVisualStyleBackColor = true;
            this.bttnLogOut.Click += new System.EventHandler(this.bttnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1363, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1310, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnUpdate.Location = new System.Drawing.Point(909, 539);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(94, 30);
            this.bttnUpdate.TabIndex = 92;
            this.bttnUpdate.Text = "Update";
            this.bttnUpdate.UseVisualStyleBackColor = false;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(559, 516);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 89;
            this.lblEmail.Text = "Email";
            // 
            // lblExtraPhoneNumber
            // 
            this.lblExtraPhoneNumber.AutoSize = true;
            this.lblExtraPhoneNumber.Location = new System.Drawing.Point(394, 516);
            this.lblExtraPhoneNumber.Name = "lblExtraPhoneNumber";
            this.lblExtraPhoneNumber.Size = new System.Drawing.Size(132, 20);
            this.lblExtraPhoneNumber.TabIndex = 88;
            this.lblExtraPhoneNumber.Text = "Ext Phone Number";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(1134, 444);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(108, 20);
            this.lblPhoneNumber.TabIndex = 87;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblBloodType
            // 
            this.lblBloodType.AutoSize = true;
            this.lblBloodType.Location = new System.Drawing.Point(1002, 444);
            this.lblBloodType.Name = "lblBloodType";
            this.lblBloodType.Size = new System.Drawing.Size(84, 20);
            this.lblBloodType.TabIndex = 86;
            this.lblBloodType.Text = "Blood Type";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(903, 444);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(57, 20);
            this.lblGender.TabIndex = 85;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(750, 444);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(94, 20);
            this.lblDOB.TabIndex = 84;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(484, 444);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 20);
            this.lblAddress.TabIndex = 83;
            this.lblAddress.Text = "Address";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(334, 444);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 20);
            this.lblLastName.TabIndex = 82;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(191, 444);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 20);
            this.lblFirstName.TabIndex = 81;
            this.lblFirstName.Text = "First Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(81, 444);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(24, 20);
            this.lblID.TabIndex = 80;
            this.lblID.Text = "ID";
            // 
            // txtbxLastName
            // 
            this.txtbxLastName.Location = new System.Drawing.Point(338, 467);
            this.txtbxLastName.Name = "txtbxLastName";
            this.txtbxLastName.Size = new System.Drawing.Size(108, 27);
            this.txtbxLastName.TabIndex = 79;
            // 
            // txtbxAddress
            // 
            this.txtbxAddress.Location = new System.Drawing.Point(484, 467);
            this.txtbxAddress.Name = "txtbxAddress";
            this.txtbxAddress.Size = new System.Drawing.Size(232, 27);
            this.txtbxAddress.TabIndex = 78;
            // 
            // txtbxDOB
            // 
            this.txtbxDOB.Location = new System.Drawing.Point(750, 467);
            this.txtbxDOB.Name = "txtbxDOB";
            this.txtbxDOB.PlaceholderText = "YYYY/MM/DD";
            this.txtbxDOB.Size = new System.Drawing.Size(112, 27);
            this.txtbxDOB.TabIndex = 77;
            // 
            // txtbxGender
            // 
            this.txtbxGender.Location = new System.Drawing.Point(903, 467);
            this.txtbxGender.Name = "txtbxGender";
            this.txtbxGender.Size = new System.Drawing.Size(59, 27);
            this.txtbxGender.TabIndex = 76;
            // 
            // txtbxBloodType
            // 
            this.txtbxBloodType.Location = new System.Drawing.Point(1002, 467);
            this.txtbxBloodType.Name = "txtbxBloodType";
            this.txtbxBloodType.Size = new System.Drawing.Size(84, 27);
            this.txtbxBloodType.TabIndex = 75;
            // 
            // txtbxExtraNumber
            // 
            this.txtbxExtraNumber.Location = new System.Drawing.Point(394, 539);
            this.txtbxExtraNumber.Name = "txtbxExtraNumber";
            this.txtbxExtraNumber.PlaceholderText = "0000000000";
            this.txtbxExtraNumber.Size = new System.Drawing.Size(89, 27);
            this.txtbxExtraNumber.TabIndex = 74;
            // 
            // txtbxNumber
            // 
            this.txtbxNumber.Location = new System.Drawing.Point(1134, 467);
            this.txtbxNumber.Name = "txtbxNumber";
            this.txtbxNumber.PlaceholderText = "0000000000";
            this.txtbxNumber.Size = new System.Drawing.Size(90, 27);
            this.txtbxNumber.TabIndex = 73;
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(559, 539);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(303, 27);
            this.txtbxEmail.TabIndex = 72;
            // 
            // txtbxFirstName
            // 
            this.txtbxFirstName.Location = new System.Drawing.Point(191, 467);
            this.txtbxFirstName.Name = "txtbxFirstName";
            this.txtbxFirstName.Size = new System.Drawing.Size(107, 27);
            this.txtbxFirstName.TabIndex = 71;
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(81, 467);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.PlaceholderText = "000000";
            this.txtbxID.ReadOnly = true;
            this.txtbxID.Size = new System.Drawing.Size(66, 27);
            this.txtbxID.TabIndex = 70;
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnSearch.Location = new System.Drawing.Point(1230, 112);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(94, 30);
            this.bttnSearch.TabIndex = 95;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(26, 114);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.PlaceholderText = "Search by ID";
            this.txtbxSearch.Size = new System.Drawing.Size(1198, 27);
            this.txtbxSearch.TabIndex = 94;
            // 
            // dgvPatientUpdate
            // 
            this.dgvPatientUpdate.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPatientUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientUpdate.Location = new System.Drawing.Point(12, 156);
            this.dgvPatientUpdate.Name = "dgvPatientUpdate";
            this.dgvPatientUpdate.RowHeadersWidth = 51;
            this.dgvPatientUpdate.RowTemplate.Height = 29;
            this.dgvPatientUpdate.Size = new System.Drawing.Size(1324, 260);
            this.dgvPatientUpdate.TabIndex = 93;
            this.dgvPatientUpdate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // pcbxReturn
            // 
            this.pcbxReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.pcbxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pcbxReturn.Image")));
            this.pcbxReturn.Location = new System.Drawing.Point(12, 24);
            this.pcbxReturn.Name = "pcbxReturn";
            this.pcbxReturn.Size = new System.Drawing.Size(40, 40);
            this.pcbxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxReturn.TabIndex = 96;
            this.pcbxReturn.TabStop = false;
            this.pcbxReturn.Click += new System.EventHandler(this.pcbxReturn_Click);
            // 
            // UpdatePatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.pcbxReturn);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.dgvPatientUpdate);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblExtraPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblBloodType);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtbxLastName);
            this.Controls.Add(this.txtbxAddress);
            this.Controls.Add(this.txtbxDOB);
            this.Controls.Add(this.txtbxGender);
            this.Controls.Add(this.txtbxBloodType);
            this.Controls.Add(this.txtbxExtraNumber);
            this.Controls.Add(this.txtbxNumber);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.txtbxFirstName);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttnLogOut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UpdatePatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdatePatientcs";
            this.Load += new System.EventHandler(this.Display);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bttnLogOut;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button bttnUpdate;
        private Label lblEmail;
        private Label lblExtraPhoneNumber;
        private Label lblPhoneNumber;
        private Label lblBloodType;
        private Label lblGender;
        private Label lblDOB;
        private Label lblAddress;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblID;
        private TextBox txtbxLastName;
        private TextBox txtbxAddress;
        private TextBox txtbxDOB;
        private TextBox txtbxGender;
        private TextBox txtbxBloodType;
        private TextBox txtbxExtraNumber;
        private TextBox txtbxNumber;
        private TextBox txtbxEmail;
        private TextBox txtbxFirstName;
        private TextBox txtbxID;
        private Button bttnSearch;
        private TextBox txtbxSearch;
        private DataGridView dgvPatientUpdate;
        private PictureBox pcbxReturn;
    }
}