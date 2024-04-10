namespace CarManagementSystem
{
    partial class DriverDetail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.CarDetailBtn = new System.Windows.Forms.Button();
            this.ReqBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.RequestList = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ExTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FeesTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EIDTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DNameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogOutBtn);
            this.groupBox1.Controls.Add(this.CarDetailBtn);
            this.groupBox1.Controls.Add(this.ReqBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 100);
            this.groupBox1.TabIndex = 2;
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
            // CarDetailBtn
            // 
            this.CarDetailBtn.Location = new System.Drawing.Point(731, 59);
            this.CarDetailBtn.Name = "CarDetailBtn";
            this.CarDetailBtn.Size = new System.Drawing.Size(97, 23);
            this.CarDetailBtn.TabIndex = 2;
            this.CarDetailBtn.Text = "Car Detail";
            this.CarDetailBtn.UseVisualStyleBackColor = true;
            this.CarDetailBtn.Click += new System.EventHandler(this.CarDetailBtn_Click);
            // 
            // ReqBtn
            // 
            this.ReqBtn.Location = new System.Drawing.Point(608, 59);
            this.ReqBtn.Name = "ReqBtn";
            this.ReqBtn.Size = new System.Drawing.Size(97, 23);
            this.ReqBtn.TabIndex = 1;
            this.ReqBtn.Text = "Request";
            this.ReqBtn.UseVisualStyleBackColor = true;
            this.ReqBtn.Click += new System.EventHandler(this.ReqBtn_Click);
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
            this.groupBox2.Controls.Add(this.PassTxt);
            this.groupBox2.Controls.Add(this.ExTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.FeesTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.EIDTxt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.DNameTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DeleteBtn);
            this.groupBox2.Controls.Add(this.RequestList);
            this.groupBox2.Controls.Add(this.UpdateBtn);
            this.groupBox2.Controls.Add(this.AddBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(845, 439);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(733, 304);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 35;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // RequestList
            // 
            this.RequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestList.Location = new System.Drawing.Point(28, 31);
            this.RequestList.Name = "RequestList";
            this.RequestList.RowHeadersWidth = 51;
            this.RequestList.RowTemplate.Height = 24;
            this.RequestList.Size = new System.Drawing.Size(469, 386);
            this.RequestList.TabIndex = 33;
            this.RequestList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RequestList_CellContentClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(642, 304);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 27;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(543, 304);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 15;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ExTxt
            // 
            this.ExTxt.Location = new System.Drawing.Point(647, 229);
            this.ExTxt.Name = "ExTxt";
            this.ExTxt.Size = new System.Drawing.Size(154, 22);
            this.ExTxt.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Experiance :";
            // 
            // FeesTxt
            // 
            this.FeesTxt.Location = new System.Drawing.Point(649, 181);
            this.FeesTxt.Name = "FeesTxt";
            this.FeesTxt.Size = new System.Drawing.Size(154, 22);
            this.FeesTxt.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Fees :";
            // 
            // EIDTxt
            // 
            this.EIDTxt.Location = new System.Drawing.Point(652, 71);
            this.EIDTxt.Name = "EIDTxt";
            this.EIDTxt.Size = new System.Drawing.Size(154, 22);
            this.EIDTxt.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Email ID :";
            // 
            // DNameTxt
            // 
            this.DNameTxt.Location = new System.Drawing.Point(654, 25);
            this.DNameTxt.Name = "DNameTxt";
            this.DNameTxt.Size = new System.Drawing.Size(154, 22);
            this.DNameTxt.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Driver Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Password :";
            // 
            // PassTxt
            // 
            this.PassTxt.Location = new System.Drawing.Point(648, 128);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(154, 22);
            this.PassTxt.TabIndex = 46;
            // 
            // DriverDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 569);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DriverDetail";
            this.Text = "DriverDetail";
            this.Load += new System.EventHandler(this.DriverDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button CarDetailBtn;
        private System.Windows.Forms.Button ReqBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.DataGridView RequestList;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox ExTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FeesTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EIDTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DNameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassTxt;
    }
}