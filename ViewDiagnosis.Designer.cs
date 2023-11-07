namespace HospitalManagementSystem
{
    partial class ViewDiagnosis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewDiagnosis));
            this.pcbxReturn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnLogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDiagnosisView = new System.Windows.Forms.DataGridView();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosisView)).BeginInit();
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
            this.pcbxReturn.TabIndex = 87;
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
            this.pictureBox2.TabIndex = 86;
            this.pictureBox2.TabStop = false;
            // 
            // bttnLogOut
            // 
            this.bttnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnLogOut.Location = new System.Drawing.Point(1215, 56);
            this.bttnLogOut.Name = "bttnLogOut";
            this.bttnLogOut.Size = new System.Drawing.Size(90, 30);
            this.bttnLogOut.TabIndex = 85;
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
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDiagnosisView
            // 
            this.dgvDiagnosisView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDiagnosisView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosisView.Location = new System.Drawing.Point(53, 153);
            this.dgvDiagnosisView.Name = "dgvDiagnosisView";
            this.dgvDiagnosisView.RowHeadersWidth = 51;
            this.dgvDiagnosisView.RowTemplate.Height = 29;
            this.dgvDiagnosisView.Size = new System.Drawing.Size(1240, 515);
            this.dgvDiagnosisView.TabIndex = 88;
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnSearch.Location = new System.Drawing.Point(1181, 108);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(94, 30);
            this.bttnSearch.TabIndex = 90;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(53, 110);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.PlaceholderText = "Search by ID";
            this.txtbxSearch.Size = new System.Drawing.Size(1122, 27);
            this.txtbxSearch.TabIndex = 89;
            // 
            // ViewDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.dgvDiagnosisView);
            this.Controls.Add(this.pcbxReturn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttnLogOut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ViewDiagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDiagnosis";
            this.Load += new System.EventHandler(this.Display);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosisView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pcbxReturn;
        private PictureBox pictureBox2;
        private Button bttnLogOut;
        private PictureBox pictureBox1;
        private DataGridView dgvDiagnosisView;
        private Button bttnSearch;
        private TextBox txtbxSearch;
    }
}