namespace HospitalManagementSystem
{
    partial class ViewPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPatient));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnLogOut = new System.Windows.Forms.Button();
            this.dgvPatientView = new System.Windows.Forms.DataGridView();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbxReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1310, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // bttnLogOut
            // 
            this.bttnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bttnLogOut.Location = new System.Drawing.Point(1214, 55);
            this.bttnLogOut.Name = "bttnLogOut";
            this.bttnLogOut.Size = new System.Drawing.Size(90, 30);
            this.bttnLogOut.TabIndex = 19;
            this.bttnLogOut.Text = "Log out";
            this.bttnLogOut.UseVisualStyleBackColor = true;
            this.bttnLogOut.Click += new System.EventHandler(this.bttnLogOut_Click_1);
            // 
            // dgvPatientView
            // 
            this.dgvPatientView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPatientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientView.Location = new System.Drawing.Point(12, 143);
            this.dgvPatientView.Name = "dgvPatientView";
            this.dgvPatientView.RowHeadersWidth = 51;
            this.dgvPatientView.RowTemplate.Height = 29;
            this.dgvPatientView.Size = new System.Drawing.Size(1324, 566);
            this.dgvPatientView.TabIndex = 24;
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(22, 106);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.PlaceholderText = "Search by ID";
            this.txtbxSearch.Size = new System.Drawing.Size(1203, 27);
            this.txtbxSearch.TabIndex = 47;
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bttnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnSearch.Location = new System.Drawing.Point(1231, 105);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(94, 30);
            this.bttnSearch.TabIndex = 48;
            this.bttnSearch.Text = "Search";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1363, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pcbxReturn
            // 
            this.pcbxReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.pcbxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pcbxReturn.Image")));
            this.pcbxReturn.Location = new System.Drawing.Point(16, 27);
            this.pcbxReturn.Name = "pcbxReturn";
            this.pcbxReturn.Size = new System.Drawing.Size(40, 40);
            this.pcbxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxReturn.TabIndex = 49;
            this.pcbxReturn.TabStop = false;
            this.pcbxReturn.Click += new System.EventHandler(this.pcbxReturn_Click);
            // 
            // ViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.pcbxReturn);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.dgvPatientView);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bttnLogOut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ViewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPatient";
            this.Load += new System.EventHandler(this.Display);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox2;
        private Button bttnLogOut;
        private DataGridView dgvPatientView;
        private TextBox txtbxSearch;
        private Button bttnSearch;
        private PictureBox pictureBox1;
        private PictureBox pcbxReturn;
    }
}