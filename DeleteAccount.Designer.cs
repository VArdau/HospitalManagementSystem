namespace HospitalManagementSystem
{
    partial class DeleteAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAccount));
            this.pcbxReturn = new System.Windows.Forms.PictureBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.dgvAccountDelete = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttnDeleteAccount = new System.Windows.Forms.Button();
            this.txtbxID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbxReturn
            // 
            this.pcbxReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.pcbxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pcbxReturn.Image")));
            this.pcbxReturn.Location = new System.Drawing.Point(14, 23);
            this.pcbxReturn.Name = "pcbxReturn";
            this.pcbxReturn.Size = new System.Drawing.Size(40, 40);
            this.pcbxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxReturn.TabIndex = 103;
            this.pcbxReturn.TabStop = false;
            this.pcbxReturn.Click += new System.EventHandler(this.pcbxReturn_Click);
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnSearch.Location = new System.Drawing.Point(1233, 119);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(94, 30);
            this.bttnSearch.TabIndex = 102;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(28, 122);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.PlaceholderText = "Search by ID";
            this.txtbxSearch.Size = new System.Drawing.Size(1199, 27);
            this.txtbxSearch.TabIndex = 101;
            // 
            // dgvAccountDelete
            // 
            this.dgvAccountDelete.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvAccountDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountDelete.Location = new System.Drawing.Point(14, 174);
            this.dgvAccountDelete.Name = "dgvAccountDelete";
            this.dgvAccountDelete.RowHeadersWidth = 51;
            this.dgvAccountDelete.RowTemplate.Height = 29;
            this.dgvAccountDelete.Size = new System.Drawing.Size(1324, 348);
            this.dgvAccountDelete.TabIndex = 100;
            this.dgvAccountDelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1312, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 99;
            this.pictureBox2.TabStop = false;
            // 
            // bttnLogOut
            // 
            this.bttnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnLogOut.Location = new System.Drawing.Point(1216, 55);
            this.bttnLogOut.Name = "bttnLogOut";
            this.bttnLogOut.Size = new System.Drawing.Size(90, 30);
            this.bttnLogOut.TabIndex = 98;
            this.bttnLogOut.Text = "Log out";
            this.bttnLogOut.UseVisualStyleBackColor = true;
            this.bttnLogOut.Click += new System.EventHandler(this.bttnLogOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1363, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // bttnDeleteAccount
            // 
            this.bttnDeleteAccount.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnDeleteAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnDeleteAccount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnDeleteAccount.Location = new System.Drawing.Point(184, 536);
            this.bttnDeleteAccount.Name = "bttnDeleteAccount";
            this.bttnDeleteAccount.Size = new System.Drawing.Size(94, 30);
            this.bttnDeleteAccount.TabIndex = 104;
            this.bttnDeleteAccount.Text = "Delete";
            this.bttnDeleteAccount.UseVisualStyleBackColor = false;
            this.bttnDeleteAccount.Click += new System.EventHandler(this.bttnDeleteAccount_Click);
            // 
            // txtbxID
            // 
            this.txtbxID.Location = new System.Drawing.Point(71, 538);
            this.txtbxID.Name = "txtbxID";
            this.txtbxID.Size = new System.Drawing.Size(107, 27);
            this.txtbxID.TabIndex = 105;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(41, 541);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 20);
            this.ID.TabIndex = 106;
            this.ID.Text = "ID";
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txtbxID);
            this.Controls.Add(this.bttnDeleteAccount);
            this.Controls.Add(this.pcbxReturn);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.dgvAccountDelete);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttnLogOut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DeleteAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteAccount";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcbxReturn;
        private Button bttnSearch;
        private TextBox txtbxSearch;
        private DataGridView dgvAccountDelete;
        private PictureBox pictureBox2;
        private Button bttnLogOut;
        private PictureBox pictureBox1;
        private Button bttnDeleteAccount;
        private TextBox txtbxID;
        private Label ID;
    }
}