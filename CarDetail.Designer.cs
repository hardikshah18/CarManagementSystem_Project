namespace CarManagementSystem
{
    partial class CarDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.DriverDetailBtn = new System.Windows.Forms.Button();
            this.ReqBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.BrowseImgBtn = new System.Windows.Forms.Button();
            this.CarImageBox = new System.Windows.Forms.PictureBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.HourlyRentTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CModelTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CNameTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TypeComBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.NumPlateTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CarListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarImageBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogOutBtn);
            this.groupBox1.Controls.Add(this.DriverDetailBtn);
            this.groupBox1.Controls.Add(this.ReqBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(753, 18);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutBtn.TabIndex = 3;
            this.LogOutBtn.Text = "button3";
            this.LogOutBtn.UseVisualStyleBackColor = true;
            // 
            // DriverDetailBtn
            // 
            this.DriverDetailBtn.Location = new System.Drawing.Point(731, 59);
            this.DriverDetailBtn.Name = "DriverDetailBtn";
            this.DriverDetailBtn.Size = new System.Drawing.Size(97, 23);
            this.DriverDetailBtn.TabIndex = 2;
            this.DriverDetailBtn.Text = "Driver Detail";
            this.DriverDetailBtn.UseVisualStyleBackColor = true;
            // 
            // ReqBtn
            // 
            this.ReqBtn.Location = new System.Drawing.Point(608, 59);
            this.ReqBtn.Name = "ReqBtn";
            this.ReqBtn.Size = new System.Drawing.Size(97, 23);
            this.ReqBtn.TabIndex = 1;
            this.ReqBtn.Text = "Request";
            this.ReqBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Admin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CarListBox);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.NumPlateTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DeleteBtn);
            this.groupBox2.Controls.Add(this.BrowseImgBtn);
            this.groupBox2.Controls.Add(this.CarImageBox);
            this.groupBox2.Controls.Add(this.UpdateBtn);
            this.groupBox2.Controls.Add(this.HourlyRentTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CModelTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CNameTxt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TypeComBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.AddBtn);
            this.groupBox2.Location = new System.Drawing.Point(13, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 439);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(346, 303);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(111, 32);
            this.DeleteBtn.TabIndex = 35;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // BrowseImgBtn
            // 
            this.BrowseImgBtn.Location = new System.Drawing.Point(346, 118);
            this.BrowseImgBtn.Name = "BrowseImgBtn";
            this.BrowseImgBtn.Size = new System.Drawing.Size(111, 32);
            this.BrowseImgBtn.TabIndex = 34;
            this.BrowseImgBtn.Text = "Browse Image";
            this.BrowseImgBtn.UseVisualStyleBackColor = true;
            this.BrowseImgBtn.Click += new System.EventHandler(this.BrowseImgBtn_Click);
            // 
            // CarImageBox
            // 
            this.CarImageBox.Image = ((System.Drawing.Image)(resources.GetObject("CarImageBox.Image")));
            this.CarImageBox.Location = new System.Drawing.Point(31, 19);
            this.CarImageBox.Name = "CarImageBox";
            this.CarImageBox.Size = new System.Drawing.Size(255, 202);
            this.CarImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarImageBox.TabIndex = 32;
            this.CarImageBox.TabStop = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(346, 248);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(111, 32);
            this.UpdateBtn.TabIndex = 27;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // HourlyRentTxt
            // 
            this.HourlyRentTxt.Location = new System.Drawing.Point(177, 343);
            this.HourlyRentTxt.Name = "HourlyRentTxt";
            this.HourlyRentTxt.Size = new System.Drawing.Size(121, 22);
            this.HourlyRentTxt.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Hourly Rent :";
            // 
            // CModelTxt
            // 
            this.CModelTxt.Location = new System.Drawing.Point(175, 241);
            this.CModelTxt.Name = "CModelTxt";
            this.CModelTxt.Size = new System.Drawing.Size(121, 22);
            this.CModelTxt.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Type :";
            // 
            // CNameTxt
            // 
            this.CNameTxt.Location = new System.Drawing.Point(177, 274);
            this.CNameTxt.Name = "CNameTxt";
            this.CNameTxt.Size = new System.Drawing.Size(121, 22);
            this.CNameTxt.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Company Name :";
            // 
            // TypeComBox
            // 
            this.TypeComBox.FormattingEnabled = true;
            this.TypeComBox.Location = new System.Drawing.Point(177, 309);
            this.TypeComBox.Name = "TypeComBox";
            this.TypeComBox.Size = new System.Drawing.Size(121, 24);
            this.TypeComBox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Car Model :";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(346, 186);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(111, 32);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NumPlateTxt
            // 
            this.NumPlateTxt.Location = new System.Drawing.Point(177, 384);
            this.NumPlateTxt.Name = "NumPlateTxt";
            this.NumPlateTxt.Size = new System.Drawing.Size(121, 22);
            this.NumPlateTxt.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Number Plate :";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(31, 413);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 20);
            this.radioButton1.TabIndex = 38;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Is Available";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // CarListBox
            // 
            this.CarListBox.FormattingEnabled = true;
            this.CarListBox.ItemHeight = 16;
            this.CarListBox.Location = new System.Drawing.Point(499, 19);
            this.CarListBox.Name = "CarListBox";
            this.CarListBox.Size = new System.Drawing.Size(328, 372);
            this.CarListBox.TabIndex = 39;
            this.CarListBox.SelectedIndexChanged += new System.EventHandler(this.CarListBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(845, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(753, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button3";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(731, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Driver Detail";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(608, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Request";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Welcome Admin";
            // 
            // CarDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "CarDetail";
            this.Text = "CarDetail";
            this.Load += new System.EventHandler(this.CarDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CarImageBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button DriverDetailBtn;
        private System.Windows.Forms.Button ReqBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox CarImageBox;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.TextBox HourlyRentTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CModelTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CNameTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TypeComBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button BrowseImgBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox NumPlateTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox CarListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
    }
}