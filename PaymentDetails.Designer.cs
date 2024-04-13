namespace CarManagementSystem
{
    partial class PaymentDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CardNoTxt = new System.Windows.Forms.TextBox();
            this.UserNameTxt = new System.Windows.Forms.TextBox();
            this.CVVTxt = new System.Windows.Forms.TextBox();
            this.AmountTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.expdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Card No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exp Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "CVV:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 260);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pay now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CardNoTxt
            // 
            this.CardNoTxt.Location = new System.Drawing.Point(315, 164);
            this.CardNoTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CardNoTxt.Name = "CardNoTxt";
            this.CardNoTxt.Size = new System.Drawing.Size(189, 22);
            this.CardNoTxt.TabIndex = 6;
            // 
            // UserNameTxt
            // 
            this.UserNameTxt.Enabled = false;
            this.UserNameTxt.Location = new System.Drawing.Point(315, 81);
            this.UserNameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserNameTxt.Name = "UserNameTxt";
            this.UserNameTxt.Size = new System.Drawing.Size(189, 22);
            this.UserNameTxt.TabIndex = 7;
            // 
            // CVVTxt
            // 
            this.CVVTxt.Location = new System.Drawing.Point(501, 221);
            this.CVVTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CVVTxt.Name = "CVVTxt";
            this.CVVTxt.Size = new System.Drawing.Size(68, 22);
            this.CVVTxt.TabIndex = 9;
            // 
            // AmountTxt
            // 
            this.AmountTxt.Enabled = false;
            this.AmountTxt.Location = new System.Drawing.Point(314, 124);
            this.AmountTxt.Margin = new System.Windows.Forms.Padding(2);
            this.AmountTxt.Name = "AmountTxt";
            this.AmountTxt.Size = new System.Drawing.Size(189, 22);
            this.AmountTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Amount :";
            // 
            // expdate
            // 
            this.expdate.Location = new System.Drawing.Point(156, 221);
            this.expdate.MinDate = new System.DateTime(2024, 4, 12, 23, 37, 28, 0);
            this.expdate.Name = "expdate";
            this.expdate.Size = new System.Drawing.Size(200, 22);
            this.expdate.TabIndex = 12;
            this.expdate.Value = new System.DateTime(2024, 4, 12, 23, 37, 28, 0);
            // 
            // PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 385);
            this.Controls.Add(this.expdate);
            this.Controls.Add(this.AmountTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CVVTxt);
            this.Controls.Add(this.UserNameTxt);
            this.Controls.Add(this.CardNoTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PaymentDetails";
            this.Text = "PaymentDetails";
            this.Load += new System.EventHandler(this.PaymentDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CardNoTxt;
        private System.Windows.Forms.TextBox UserNameTxt;
        private System.Windows.Forms.TextBox CVVTxt;
        private System.Windows.Forms.TextBox AmountTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker expdate;
    }
}