﻿namespace CarManagementSystem
{
    partial class AdminHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomePage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.DriverDetailBtn = new System.Windows.Forms.Button();
            this.CarDetailBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PaymentTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CustomerNameTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AppointDriver = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExTxt = new System.Windows.Forms.TextBox();
            this.DIDCmbBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FeesTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DNameTxt = new System.Windows.Forms.TextBox();
            this.IsDriverReqRadioButton = new System.Windows.Forms.RadioButton();
            this.RequestList = new System.Windows.Forms.DataGridView();
            this.CarImageBox = new System.Windows.Forms.PictureBox();
            this.CarModalTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.NumDaysTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DeclineBtn = new System.Windows.Forms.Button();
            this.PickUpDateTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ReqDateTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ApproveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FinalAmountLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.AppointDriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogOutBtn);
            this.groupBox1.Controls.Add(this.DriverDetailBtn);
            this.groupBox1.Controls.Add(this.CarDetailBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 100);
            this.groupBox1.TabIndex = 0;
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
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // DriverDetailBtn
            // 
            this.DriverDetailBtn.Location = new System.Drawing.Point(731, 59);
            this.DriverDetailBtn.Name = "DriverDetailBtn";
            this.DriverDetailBtn.Size = new System.Drawing.Size(97, 23);
            this.DriverDetailBtn.TabIndex = 2;
            this.DriverDetailBtn.Text = "Driver Detail";
            this.DriverDetailBtn.UseVisualStyleBackColor = true;
            this.DriverDetailBtn.Click += new System.EventHandler(this.DriverDetailBtn_Click);
            // 
            // CarDetailBtn
            // 
            this.CarDetailBtn.Location = new System.Drawing.Point(608, 59);
            this.CarDetailBtn.Name = "CarDetailBtn";
            this.CarDetailBtn.Size = new System.Drawing.Size(97, 23);
            this.CarDetailBtn.TabIndex = 1;
            this.CarDetailBtn.Text = "Car Detail";
            this.CarDetailBtn.UseVisualStyleBackColor = true;
            this.CarDetailBtn.Click += new System.EventHandler(this.CarDetailBtn_Click);
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
            this.groupBox2.Controls.Add(this.FinalAmountLbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PaymentTxt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.CustomerNameTxt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.AppointDriver);
            this.groupBox2.Controls.Add(this.IsDriverReqRadioButton);
            this.groupBox2.Controls.Add(this.RequestList);
            this.groupBox2.Controls.Add(this.CarImageBox);
            this.groupBox2.Controls.Add(this.CarModalTxt);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.NumDaysTxt);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.DeclineBtn);
            this.groupBox2.Controls.Add(this.PickUpDateTxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ReqDateTxt);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ApproveBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 439);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // PaymentTxt
            // 
            this.PaymentTxt.Enabled = false;
            this.PaymentTxt.Location = new System.Drawing.Point(156, 166);
            this.PaymentTxt.Name = "PaymentTxt";
            this.PaymentTxt.Size = new System.Drawing.Size(121, 22);
            this.PaymentTxt.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "Payment :";
            // 
            // CustomerNameTxt
            // 
            this.CustomerNameTxt.Enabled = false;
            this.CustomerNameTxt.Location = new System.Drawing.Point(156, 26);
            this.CustomerNameTxt.Name = "CustomerNameTxt";
            this.CustomerNameTxt.Size = new System.Drawing.Size(121, 22);
            this.CustomerNameTxt.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 36;
            this.label9.Text = "Customer Name :";
            // 
            // AppointDriver
            // 
            this.AppointDriver.Controls.Add(this.label2);
            this.AppointDriver.Controls.Add(this.ExTxt);
            this.AppointDriver.Controls.Add(this.DIDCmbBox);
            this.AppointDriver.Controls.Add(this.label6);
            this.AppointDriver.Controls.Add(this.FeesTxt);
            this.AppointDriver.Controls.Add(this.label5);
            this.AppointDriver.Controls.Add(this.label3);
            this.AppointDriver.Controls.Add(this.DNameTxt);
            this.AppointDriver.Location = new System.Drawing.Point(559, 29);
            this.AppointDriver.Name = "AppointDriver";
            this.AppointDriver.Size = new System.Drawing.Size(270, 233);
            this.AppointDriver.TabIndex = 35;
            this.AppointDriver.TabStop = false;
            this.AppointDriver.Text = "Appoint Driver";
            this.AppointDriver.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Driver ID :";
            // 
            // ExTxt
            // 
            this.ExTxt.Enabled = false;
            this.ExTxt.Location = new System.Drawing.Point(119, 152);
            this.ExTxt.Name = "ExTxt";
            this.ExTxt.Size = new System.Drawing.Size(121, 22);
            this.ExTxt.TabIndex = 14;
            // 
            // DIDCmbBox
            // 
            this.DIDCmbBox.DisplayMember = "DriverID";
            this.DIDCmbBox.FormattingEnabled = true;
            this.DIDCmbBox.Location = new System.Drawing.Point(122, 28);
            this.DIDCmbBox.Name = "DIDCmbBox";
            this.DIDCmbBox.Size = new System.Drawing.Size(121, 24);
            this.DIDCmbBox.TabIndex = 6;
            this.DIDCmbBox.ValueMember = "DriverID";
            this.DIDCmbBox.SelectedIndexChanged += new System.EventHandler(this.DIDCmbBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Experiance :";
            // 
            // FeesTxt
            // 
            this.FeesTxt.Enabled = false;
            this.FeesTxt.Location = new System.Drawing.Point(119, 111);
            this.FeesTxt.Name = "FeesTxt";
            this.FeesTxt.Size = new System.Drawing.Size(121, 22);
            this.FeesTxt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fees :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Driver Name :";
            // 
            // DNameTxt
            // 
            this.DNameTxt.Enabled = false;
            this.DNameTxt.Location = new System.Drawing.Point(122, 65);
            this.DNameTxt.Name = "DNameTxt";
            this.DNameTxt.Size = new System.Drawing.Size(121, 22);
            this.DNameTxt.TabIndex = 8;
            // 
            // IsDriverReqRadioButton
            // 
            this.IsDriverReqRadioButton.AutoSize = true;
            this.IsDriverReqRadioButton.Enabled = false;
            this.IsDriverReqRadioButton.Location = new System.Drawing.Point(43, 212);
            this.IsDriverReqRadioButton.Name = "IsDriverReqRadioButton";
            this.IsDriverReqRadioButton.Size = new System.Drawing.Size(136, 20);
            this.IsDriverReqRadioButton.TabIndex = 34;
            this.IsDriverReqRadioButton.TabStop = true;
            this.IsDriverReqRadioButton.Text = "Is Driver Required";
            this.IsDriverReqRadioButton.UseVisualStyleBackColor = true;
            // 
            // RequestList
            // 
            this.RequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestList.Location = new System.Drawing.Point(28, 294);
            this.RequestList.Name = "RequestList";
            this.RequestList.RowHeadersWidth = 51;
            this.RequestList.RowTemplate.Height = 24;
            this.RequestList.Size = new System.Drawing.Size(801, 123);
            this.RequestList.TabIndex = 33;
            this.RequestList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RequestList_CellContentClick);
            // 
            // CarImageBox
            // 
            this.CarImageBox.Image = ((System.Drawing.Image)(resources.GetObject("CarImageBox.Image")));
            this.CarImageBox.Location = new System.Drawing.Point(313, 29);
            this.CarImageBox.Name = "CarImageBox";
            this.CarImageBox.Size = new System.Drawing.Size(229, 204);
            this.CarImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CarImageBox.TabIndex = 32;
            this.CarImageBox.TabStop = false;
            // 
            // CarModalTxt
            // 
            this.CarModalTxt.Enabled = false;
            this.CarModalTxt.Location = new System.Drawing.Point(156, 138);
            this.CarModalTxt.Name = "CarModalTxt";
            this.CarModalTxt.Size = new System.Drawing.Size(121, 22);
            this.CarModalTxt.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Car Model :";
            // 
            // NumDaysTxt
            // 
            this.NumDaysTxt.Enabled = false;
            this.NumDaysTxt.Location = new System.Drawing.Point(156, 110);
            this.NumDaysTxt.Name = "NumDaysTxt";
            this.NumDaysTxt.Size = new System.Drawing.Size(121, 22);
            this.NumDaysTxt.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Number of Days :";
            // 
            // DeclineBtn
            // 
            this.DeclineBtn.Location = new System.Drawing.Point(456, 239);
            this.DeclineBtn.Name = "DeclineBtn";
            this.DeclineBtn.Size = new System.Drawing.Size(86, 34);
            this.DeclineBtn.TabIndex = 27;
            this.DeclineBtn.Text = "Decline";
            this.DeclineBtn.UseVisualStyleBackColor = true;
            this.DeclineBtn.Click += new System.EventHandler(this.DeclineBtn_Click);
            // 
            // PickUpDateTxt
            // 
            this.PickUpDateTxt.Enabled = false;
            this.PickUpDateTxt.Location = new System.Drawing.Point(156, 82);
            this.PickUpDateTxt.Name = "PickUpDateTxt";
            this.PickUpDateTxt.Size = new System.Drawing.Size(121, 22);
            this.PickUpDateTxt.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Pick Up Date :";
            // 
            // ReqDateTxt
            // 
            this.ReqDateTxt.Enabled = false;
            this.ReqDateTxt.Location = new System.Drawing.Point(156, 54);
            this.ReqDateTxt.Name = "ReqDateTxt";
            this.ReqDateTxt.Size = new System.Drawing.Size(121, 22);
            this.ReqDateTxt.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Request Date :";
            // 
            // ApproveBtn
            // 
            this.ApproveBtn.Location = new System.Drawing.Point(313, 239);
            this.ApproveBtn.Name = "ApproveBtn";
            this.ApproveBtn.Size = new System.Drawing.Size(92, 34);
            this.ApproveBtn.TabIndex = 15;
            this.ApproveBtn.Text = "Approve";
            this.ApproveBtn.UseVisualStyleBackColor = true;
            this.ApproveBtn.Click += new System.EventHandler(this.ApproveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Final Amount :";
            // 
            // FinalAmountLbl
            // 
            this.FinalAmountLbl.AutoSize = true;
            this.FinalAmountLbl.Location = new System.Drawing.Point(153, 248);
            this.FinalAmountLbl.Name = "FinalAmountLbl";
            this.FinalAmountLbl.Size = new System.Drawing.Size(14, 16);
            this.FinalAmountLbl.TabIndex = 41;
            this.FinalAmountLbl.Text = "0";
            // 
            // AdminHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminHomePage";
            this.Text = " ";
            this.Load += new System.EventHandler(this.AdminHomePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.AppointDriver.ResumeLayout(false);
            this.AppointDriver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button DriverDetailBtn;
        private System.Windows.Forms.Button CarDetailBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ApproveBtn;
        private System.Windows.Forms.TextBox ExTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FeesTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DIDCmbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView RequestList;
        private System.Windows.Forms.PictureBox CarImageBox;
        private System.Windows.Forms.TextBox CarModalTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NumDaysTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button DeclineBtn;
        private System.Windows.Forms.TextBox PickUpDateTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ReqDateTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton IsDriverReqRadioButton;
        private System.Windows.Forms.GroupBox AppointDriver;
        private System.Windows.Forms.TextBox PaymentTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CustomerNameTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label FinalAmountLbl;
        private System.Windows.Forms.Label label4;
    }
}