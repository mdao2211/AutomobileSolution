namespace AutomobileWinApp
{
    partial class frmCarDetails
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
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufactorer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            cboManufactorer = new ComboBox();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(51, 67);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(51, 124);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufactorer
            // 
            lbManufactorer.AutoSize = true;
            lbManufactorer.Location = new Point(51, 178);
            lbManufactorer.Name = "lbManufactorer";
            lbManufactorer.Size = new Size(98, 20);
            lbManufactorer.TabIndex = 2;
            lbManufactorer.Text = "Manufactorer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(51, 232);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(51, 285);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(92, 20);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(213, 60);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(406, 27);
            txtCarID.TabIndex = 5;
            txtCarID.TextChanged += txtCarID_TextChanged;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(213, 117);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(406, 27);
            txtCarName.TabIndex = 6;
            // 
            // cboManufactorer
            // 
            cboManufactorer.FormattingEnabled = true;
            cboManufactorer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Mercedes", "Honda", "Kia", "Huyndai", "Suzuki", "Toyota", "Lamborghini", "Ferrari", "McLarren" });
            cboManufactorer.Location = new Point(213, 170);
            cboManufactorer.Name = "cboManufactorer";
            cboManufactorer.Size = new Size(406, 28);
            cboManufactorer.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(213, 225);
            txtPrice.Mask = "0000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(406, 27);
            txtPrice.TabIndex = 8;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(213, 285);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(406, 27);
            txtReleaseYear.TabIndex = 9;
            txtReleaseYear.Text = "0";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(215, 364);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(153, 42);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(464, 364);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 42);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
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
            Name = "frmCarDetails";
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private void txtCarID_TextChanged(object sender, EventArgs e)
        {
            String CarID = txtCarID.Text;
            String CarName = txtCarName.Text;
            String Manufactorer = lbManufactorer.Text;
            String Price = txtPrice.Text;
            String ReleaseYear = txtReleaseYear.Text;
            
        }


        #endregion

        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufactorer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private ComboBox cboManufactorer;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
        private Button btnSave;
        private Button btnCancel;
    }
}