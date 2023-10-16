namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            txtReleaseYear = new MaskedTextBox();
            txtPrice = new MaskedTextBox();
            cboManufactorer = new ComboBox();
            txtCarName = new TextBox();
            txtCarID = new TextBox();
            lbReleaseYear = new Label();
            lbPrice = new Label();
            lbManufactorer = new Label();
            lbCarName = new Label();
            lbCarID = new Label();
            btnLoad = new Button();
            btnDelete = new Button();
            btnNew = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(548, 92);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(240, 27);
            txtReleaseYear.TabIndex = 19;
            txtReleaseYear.Text = "0";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(548, 32);
            txtPrice.Mask = "0000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(240, 27);
            txtPrice.TabIndex = 18;
            txtPrice.Text = "0";
            // 
            // cboManufactorer
            // 
            cboManufactorer.FormattingEnabled = true;
            cboManufactorer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Mercedes", "Honda", "Kia", "Huyndai", "Suzuki", "Toyota", "Lamborghini", "Ferrari", "McLarren" });
            cboManufactorer.Location = new Point(175, 95);
            cboManufactorer.Name = "cboManufactorer";
            cboManufactorer.Size = new Size(251, 28);
            cboManufactorer.TabIndex = 17;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(175, 57);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(251, 27);
            txtCarName.TabIndex = 16;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(175, 24);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(251, 27);
            txtCarID.TabIndex = 15;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(450, 98);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(92, 20);
            lbReleaseYear.TabIndex = 14;
            lbReleaseYear.Text = "Release Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(501, 35);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 13;
            lbPrice.Text = "Price";
            // 
            // lbManufactorer
            // 
            lbManufactorer.AutoSize = true;
            lbManufactorer.Location = new Point(13, 98);
            lbManufactorer.Name = "lbManufactorer";
            lbManufactorer.Size = new Size(98, 20);
            lbManufactorer.TabIndex = 12;
            lbManufactorer.Text = "Manufactorer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(13, 64);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 11;
            lbCarName.Text = "Car Name";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(13, 31);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 10;
            lbCarID.Text = "Car ID";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(153, 150);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(127, 36);
            btnLoad.TabIndex = 20;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(489, 150);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(127, 36);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(327, 150);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(127, 36);
            btnNew.TabIndex = 23;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(13, 192);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(775, 219);
            dgvCarList.TabIndex = 24;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(341, 417);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(113, 29);
            btnClose.TabIndex = 25;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnNew);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(cboManufactorer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufactorer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtReleaseYear;
        private MaskedTextBox txtPrice;
        private ComboBox cboManufactorer;
        private TextBox txtCarName;
        private TextBox txtCarID;
        private Label lbReleaseYear;
        private Label lbPrice;
        private Label lbManufactorer;
        private Label lbCarName;
        private Label lbCarID;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnNew;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}