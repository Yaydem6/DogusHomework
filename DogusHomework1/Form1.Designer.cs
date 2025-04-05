using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using System;

namespace DogusHomework1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_payment_method = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_pay = new System.Windows.Forms.Button();
            this.lbl_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(152, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Method:";
            // 
            // cb_payment_method
            // 
            this.cb_payment_method.FormattingEnabled = true;
            this.cb_payment_method.Items.AddRange(new object[] {
            "Select",
            "CreditCard",
            "Cash",
            "Eft"});
            this.cb_payment_method.Location = new System.Drawing.Point(401, 121);
            this.cb_payment_method.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_payment_method.Name = "cb_payment_method";
            this.cb_payment_method.Size = new System.Drawing.Size(231, 24);
            this.cb_payment_method.TabIndex = 1;
            this.cb_payment_method.SelectedIndexChanged += new System.EventHandler(this.cb_payment_method_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label2.Location = new System.Drawing.Point(252, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount:";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(401, 201);
            this.txt_amount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(231, 22);
            this.txt_amount.TabIndex = 3;
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(439, 252);
            this.btn_pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(149, 66);
            this.btn_pay.TabIndex = 4;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(368, 371);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(64, 16);
            this.lbl_message.TabIndex = 5;
            this.lbl_message.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(955, 546);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_payment_method);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Make Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private Label label1;
        private ComboBox cb_payment_method;
        private Label label2;
        private TextBox txt_amount;
        private Button btn_pay;
        private Label lbl_message;
    }
}
