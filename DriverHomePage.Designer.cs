namespace CarManagementSystem
{
    partial class DriverHomePage
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LogOutBtn);
            this.groupBox1.Controls.Add(this.CarDetailBtn);
            this.groupBox1.Controls.Add(this.ReqBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 100);
            this.groupBox1.TabIndex = 3;
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
            // CarDetailBtn
            // 
            this.CarDetailBtn.Location = new System.Drawing.Point(731, 59);
            this.CarDetailBtn.Name = "CarDetailBtn";
            this.CarDetailBtn.Size = new System.Drawing.Size(97, 23);
            this.CarDetailBtn.TabIndex = 2;
            this.CarDetailBtn.Text = "Car Detail";
            this.CarDetailBtn.UseVisualStyleBackColor = true;
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
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Driver";
            // 
            // DriverHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 569);
            this.Controls.Add(this.groupBox1);
            this.Name = "DriverHomePage";
            this.Text = "DriverHomePage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button CarDetailBtn;
        private System.Windows.Forms.Button ReqBtn;
        private System.Windows.Forms.Label label1;
    }
}