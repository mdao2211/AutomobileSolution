using AutomobileSolution.BussinessObject;
using AutomobileSolution.Repository;
namespace AutomobileMPFSolution
{
    public partial class frmCarDetails : Form
    {
        public Label lbCarID;
        public Label lbCarName;
        public Label lbManufactorer;
        public Label lbPrice;
        public Label lbReleasedYear;
        public TextBox txtCarID;
        public TextBox txtCarName;
        public ComboBox comboBox1;
        public MaskedTextBox txtPrice;
        public MaskedTextBox txtReleaseYear;
        public Button btnSave;
        public Button btnCancel;

        public frmCarDetails() { }
        //--------------------------------------
        public ICarRepository CarRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Car CarInfo { get; set; }
        //--------------------------------------
        private void frmCarDetails_Load(object sender, EventArgs e, cboManufactorer cboManufactorer)
        {
            cboManufactorer.SelectedIndex = 0;
            txtCarID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtCarID.Text = CarInfo.CarID.ToString();
                txtCarName.Text = CarInfo.CarName;
                txtPrice.Text = CarInfo.Price.ToString();
                txtReleaseYear.Text = CarInfo.RealeaseYear.ToString();
                cboManufactorer.Text = CarInfo.Manufactorer.Trim();

            }
        }
        //--------------------------------------
        private void btnSave_Click(object sender, EventArgs e, cboManufactorer cboManufactorer)
        {
            try
            {
                var car = new Car
                {
                    CarID = int.Parse(txtCarID.Text),
                    CarName = txtCarName.Text,
                    Manufactorer = cboManufactorer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    RealeaseYear = int.Parse(txtReleaseYear.Text)
                };
                if (InsertOrUpdate == false)
                {
                    CarRepository.InsertCar(car);
                }
                else
                {
                    CarRepository.UpdateCar(car);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new car" : "Update a car");
            }
        }
        //--------------------------------------
        private void btnCancel_Click(object sender, EventArgs e) => Close();
    

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Label lbCarID;
        private Label lbCarName;
        private Label lbManufactorer;
        private Label lbPrice;
        private Label lbReleasedYear;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private ComboBox cboManufactoer;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleasedYear;
        private Button btnSave;
        private Button btnCancel;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCarID = new Label();
            lbCarName = new Label();
            lbManufactorer = new Label();
            lbPrice = new Label();
            lbReleasedYear = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            cboManufactoer = new ComboBox();
            txtPrice = new MaskedTextBox();
            txtReleasedYear = new MaskedTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(54, 80);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(50, 20);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            lbCarID.Click += label1_Click;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(54, 137);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(75, 20);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            lbCarName.Click += label2_Click;
            // 
            // lbManufactorer
            // 
            lbManufactorer.AutoSize = true;
            lbManufactorer.Location = new Point(54, 196);
            lbManufactorer.Name = "lbManufactorer";
            lbManufactorer.Size = new Size(98, 20);
            lbManufactorer.TabIndex = 2;
            lbManufactorer.Text = "Manufactorer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(54, 251);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(41, 20);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleasedYear
            // 
            lbReleasedYear.AutoSize = true;
            lbReleasedYear.Location = new Point(54, 311);
            lbReleasedYear.Name = "lbReleasedYear";
            lbReleasedYear.Size = new Size(101, 20);
            lbReleasedYear.TabIndex = 4;
            lbReleasedYear.Text = "Released Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(210, 80);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(354, 27);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(210, 134);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(354, 27);
            txtCarName.TabIndex = 6;
            // 
            // cboManufactoer
            // 
            cboManufactoer.FormattingEnabled = true;
            cboManufactoer.Items.AddRange(new object[] { "Audi", "Bmw", "Lamborghini", "Ferrari", "Ford", "Honda", "Huyndai", "Kia", "Vinfast" });
            cboManufactoer.Location = new Point(210, 196);
            cboManufactoer.Name = "cboManufactoer";
            cboManufactoer.Size = new Size(354, 28);
            cboManufactoer.TabIndex = 7;
            cboManufactoer.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(210, 251);
            txtPrice.Mask = "0000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.ResetOnSpace = false;
            txtPrice.Size = new Size(354, 27);
            txtPrice.TabIndex = 8;
            txtPrice.Text = "0";
            // 
            // txtReleasedYear
            // 
            txtReleasedYear.Location = new Point(210, 308);
            txtReleasedYear.Mask = "0000";
            txtReleasedYear.Name = "txtReleasedYear";
            txtReleasedYear.Size = new Size(354, 27);
            txtReleasedYear.TabIndex = 9;
            txtReleasedYear.Text = "0";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(210, 365);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(133, 36);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(439, 361);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboManufactorer
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(643, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtReleasedYear);
            Controls.Add(txtPrice);
            Controls.Add(cboManufactoer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleasedYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufactorer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "cboManufactorer";
            Text = "Form1";
            Load += cboManufactorer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion



        public static int SelectedIndex { get; internal set; }
        public string Text { get; internal set; }
    }
}
