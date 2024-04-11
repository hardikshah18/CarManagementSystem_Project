namespace CarManagementSystem
{
    partial class BookingConfirmation
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.MailBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LogOutBtn);
            this.groupBox3.Controls.Add(this.MailBtn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(845, 100);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " ";
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.Location = new System.Drawing.Point(753, 18);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogOutBtn.TabIndex = 3;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.UseVisualStyleBackColor = true;
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
            // BookingConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 569);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BookingConfirmation";
            this.Text = "BookingConfirmation";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button MailBtn;
        private System.Windows.Forms.Label label3;
    }
}