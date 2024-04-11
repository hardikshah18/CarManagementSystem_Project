namespace CarManagementSystem
{
    partial class CustomerPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerPage));
            this.BookBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.TypeTxt = new System.Windows.Forms.TextBox();
            this.CarImageBox = new System.Windows.Forms.PictureBox();
            this.HourlyRentTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CModelTxt = new System.Windows.Forms.TextBox();
            this.MailBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CNameTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SearchComBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CarGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarImageBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookBtn
            // 
            this.BookBtn.Location = new System.Drawing.Point(729, 202);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(97, 42);
            this.BookBtn.TabIndex = 4;
            this.BookBtn.Text = "Book Car";
            this.BookBtn.UseVisualStyleBackColor = true;
            this.BookBtn.Click += new System.EventHandler(this.BookBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(329, 25);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(111, 34);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search By type";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // TypeTxt
            // 
            this.TypeTxt.Enabled = false;
            this.TypeTxt.Location = new System.Drawing.Point(478, 174);
            this.TypeTxt.Name = "TypeTxt";
            this.TypeTxt.Size = new System.Drawing.Size(231, 22);
            this.TypeTxt.TabIndex = 38;
            // 
            // CarImageBox
            // 
            this.CarImageBox.Image = ((System.Drawing.Image)(resources.GetObject("CarImageBox.Image")));
            this.CarImageBox.Location = new System.Drawing.Point(54, 25);
            this.CarImageBox.Name = "CarImageBox";
            this.CarImageBox.Size = new System.Drawing.Size(255, 219);
            this.CarImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarImageBox.TabIndex = 32;
            this.CarImageBox.TabStop = false;
            // 
            // HourlyRentTxt
            // 
            this.HourlyRentTxt.Enabled = false;
            this.HourlyRentTxt.Location = new System.Drawing.Point(478, 220);
            this.HourlyRentTxt.Name = "HourlyRentTxt";
            this.HourlyRentTxt.Size = new System.Drawing.Size(231, 22);
            this.HourlyRentTxt.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Hourly Rent :";
            // 
            // CModelTxt
            // 
            this.CModelTxt.Enabled = false;
            this.CModelTxt.Location = new System.Drawing.Point(476, 85);
            this.CModelTxt.Name = "CModelTxt";
            this.CModelTxt.Size = new System.Drawing.Size(231, 22);
            this.CModelTxt.TabIndex = 22;
            // 
            // MailBtn
            // 
            this.MailBtn.Location = new System.Drawing.Point(729, 60);
            this.MailBtn.Name = "MailBtn";
            this.MailBtn.Size = new System.Drawing.Size(97, 23);
            this.MailBtn.TabIndex = 1;
            this.MailBtn.Text = "Mail Box";
            this.MailBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome Customer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Type :";
            // 
            // CNameTxt
            // 
            this.CNameTxt.Enabled = false;
            this.CNameTxt.Location = new System.Drawing.Point(475, 129);
            this.CNameTxt.Name = "CNameTxt";
            this.CNameTxt.Size = new System.Drawing.Size(231, 22);
            this.CNameTxt.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Company Name :";
            // 
            // SearchComBox
            // 
            this.SearchComBox.FormattingEnabled = true;
            this.SearchComBox.Items.AddRange(new object[] {
            "All",
            "SUV",
            "Sedan",
            "HatchBack"});
            this.SearchComBox.Location = new System.Drawing.Point(476, 31);
            this.SearchComBox.Name = "SearchComBox";
            this.SearchComBox.Size = new System.Drawing.Size(231, 24);
            this.SearchComBox.TabIndex = 18;
            this.SearchComBox.Text = "Select Catageory";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(329, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Car Model :";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(753, 18);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutBtn.TabIndex = 3;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CarGridView);
            this.groupBox2.Controls.Add(this.BookBtn);
            this.groupBox2.Controls.Add(this.SearchBtn);
            this.groupBox2.Controls.Add(this.TypeTxt);
            this.groupBox2.Controls.Add(this.CarImageBox);
            this.groupBox2.Controls.Add(this.HourlyRentTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CModelTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CNameTxt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.SearchComBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 439);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // CarGridView
            // 
            this.CarGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarGridView.Location = new System.Drawing.Point(15, 271);
            this.CarGridView.Name = "CarGridView";
            this.CarGridView.RowHeadersWidth = 51;
            this.CarGridView.RowTemplate.Height = 24;
            this.CarGridView.Size = new System.Drawing.Size(810, 162);
            this.CarGridView.TabIndex = 39;
            this.CarGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CarGridView_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LogOutBtn);
            this.groupBox3.Controls.Add(this.MailBtn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(845, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 607);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "Confirm Booking";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CustomerPage
            // 
            this.ClientSize = new System.Drawing.Size(870, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button2);
            this.Name = "CustomerPage";
            this.Text = "Customer Home";
            this.Load += new System.EventHandler(this.CustomerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CarImageBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BookBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox TypeTxt;
        private System.Windows.Forms.PictureBox CarImageBox;
        private System.Windows.Forms.TextBox HourlyRentTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CModelTxt;
        private System.Windows.Forms.Button MailBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CNameTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox SearchComBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView CarGridView;
    }
}