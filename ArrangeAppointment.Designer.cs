namespace HospitalManagementSystem
{
    partial class ArrangeAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrangeAppointment));
            this.pcbxReturn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbxStaff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbxDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxPatient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCreateAppointment = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.bttnCreate = new System.Windows.Forms.Button();
            this.cbxTime = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxReturn
            // 
            this.pcbxReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.pcbxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pcbxReturn.Image")));
            this.pcbxReturn.Location = new System.Drawing.Point(13, 24);
            this.pcbxReturn.Name = "pcbxReturn";
            this.pcbxReturn.Size = new System.Drawing.Size(40, 40);
            this.pcbxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxReturn.TabIndex = 83;
            this.pcbxReturn.TabStop = false;
            this.pcbxReturn.Click += new System.EventHandler(this.pcbxReturn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1311, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            // 
            // bttnLogOut
            // 
            this.bttnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnLogOut.Location = new System.Drawing.Point(1215, 56);
            this.bttnLogOut.Name = "bttnLogOut";
            this.bttnLogOut.Size = new System.Drawing.Size(90, 30);
            this.bttnLogOut.TabIndex = 81;
            this.bttnLogOut.Text = "Log out";
            this.bttnLogOut.UseVisualStyleBackColor = true;
            this.bttnLogOut.Click += new System.EventHandler(this.bttnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1363, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // txtbxStaff
            // 
            this.txtbxStaff.Location = new System.Drawing.Point(742, 140);
            this.txtbxStaff.Name = "txtbxStaff";
            this.txtbxStaff.PlaceholderText = "ID";
            this.txtbxStaff.Size = new System.Drawing.Size(97, 27);
            this.txtbxStaff.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(742, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 86;
            this.label2.Text = "Staff";
            // 
            // txtbxDate
            // 
            this.txtbxDate.Location = new System.Drawing.Point(742, 307);
            this.txtbxDate.Name = "txtbxDate";
            this.txtbxDate.PlaceholderText = "YYYY-MM-DD";
            this.txtbxDate.Size = new System.Drawing.Size(97, 27);
            this.txtbxDate.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Date";
            // 
            // txtbxPatient
            // 
            this.txtbxPatient.Location = new System.Drawing.Point(742, 226);
            this.txtbxPatient.Name = "txtbxPatient";
            this.txtbxPatient.PlaceholderText = "ID";
            this.txtbxPatient.Size = new System.Drawing.Size(97, 27);
            this.txtbxPatient.TabIndex = 91;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Patient";
            // 
            // dgvCreateAppointment
            // 
            this.dgvCreateAppointment.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCreateAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreateAppointment.Location = new System.Drawing.Point(12, 113);
            this.dgvCreateAppointment.Name = "dgvCreateAppointment";
            this.dgvCreateAppointment.RowHeadersWidth = 51;
            this.dgvCreateAppointment.RowTemplate.Height = 29;
            this.dgvCreateAppointment.Size = new System.Drawing.Size(690, 423);
            this.dgvCreateAppointment.TabIndex = 92;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(742, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 93;
            this.label5.Text = "Time";
            // 
            // bttnCreate
            // 
            this.bttnCreate.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnCreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnCreate.Location = new System.Drawing.Point(742, 421);
            this.bttnCreate.Name = "bttnCreate";
            this.bttnCreate.Size = new System.Drawing.Size(94, 30);
            this.bttnCreate.TabIndex = 95;
            this.bttnCreate.Text = "Create";
            this.bttnCreate.UseVisualStyleBackColor = false;
            this.bttnCreate.Click += new System.EventHandler(this.bttnCreate_Click);
            // 
            // cbxTime
            // 
            this.cbxTime.FormattingEnabled = true;
            this.cbxTime.Items.AddRange(new object[] {
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00"});
            this.cbxTime.Location = new System.Drawing.Point(742, 377);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(103, 28);
            this.cbxTime.TabIndex = 96;
            // 
            // ArrangeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.cbxTime);
            this.Controls.Add(this.bttnCreate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCreateAppointment);
            this.Controls.Add(this.txtbxPatient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxStaff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbxReturn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttnLogOut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ArrangeAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAppointment";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcbxReturn;
        private PictureBox pictureBox2;
        private Button bttnLogOut;
        private PictureBox pictureBox1;
        private TextBox txtbxStaff;
        private Label label2;
        private TextBox txtbxDate;
        private Label label3;
        private TextBox txtbxPatient;
        private Label label4;
        private DataGridView dgvCreateAppointment;
        private Label label5;
        private Button bttnCreate;
        private ComboBox cbxTime;
    }
}