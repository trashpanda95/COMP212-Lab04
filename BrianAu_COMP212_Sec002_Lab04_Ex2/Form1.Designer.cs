﻿namespace BrianAu_COMP212_Sec002_Lab04_Ex2
{
    partial class Form1
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
            this.label = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtServing = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNewCust = new System.Windows.Forms.Button();
            this.OffLbl = new System.Windows.Forms.Label();
            this.btnNextOfc = new System.Windows.Forms.Button();
            this.btnNextTeller = new System.Windows.Forms.Button();
            this.btnNextMgr = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(401, 179);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 44;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(395, 46);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 13);
            this.label33.TabIndex = 43;
            // 
            // txtServing
            // 
            this.txtServing.Location = new System.Drawing.Point(69, 61);
            this.txtServing.Margin = new System.Windows.Forms.Padding(2);
            this.txtServing.Name = "txtServing";
            this.txtServing.Size = new System.Drawing.Size(167, 20);
            this.txtServing.TabIndex = 42;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(69, 35);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(167, 20);
            this.txtCustName.TabIndex = 41;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 61);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Goes to:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Customer:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 37;
            // 
            // btnNewCust
            // 
            this.btnNewCust.Location = new System.Drawing.Point(12, 119);
            this.btnNewCust.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewCust.Name = "btnNewCust";
            this.btnNewCust.Size = new System.Drawing.Size(131, 25);
            this.btnNewCust.TabIndex = 36;
            this.btnNewCust.Text = "New Customer";
            this.btnNewCust.UseVisualStyleBackColor = true;
            this.btnNewCust.Click += new System.EventHandler(this.btnNewCust_Click);
            // 
            // OffLbl
            // 
            this.OffLbl.AutoSize = true;
            this.OffLbl.Location = new System.Drawing.Point(398, 188);
            this.OffLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OffLbl.Name = "OffLbl";
            this.OffLbl.Size = new System.Drawing.Size(0, 13);
            this.OffLbl.TabIndex = 35;
            // 
            // btnNextOfc
            // 
            this.btnNextOfc.Location = new System.Drawing.Point(246, 179);
            this.btnNextOfc.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextOfc.Name = "btnNextOfc";
            this.btnNextOfc.Size = new System.Drawing.Size(84, 21);
            this.btnNextOfc.TabIndex = 34;
            this.btnNextOfc.Text = "Next Officer";
            this.btnNextOfc.UseVisualStyleBackColor = true;
            this.btnNextOfc.Click += new System.EventHandler(this.btnNextOfc_Click);
            // 
            // btnNextTeller
            // 
            this.btnNextTeller.Location = new System.Drawing.Point(243, 111);
            this.btnNextTeller.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextTeller.Name = "btnNextTeller";
            this.btnNextTeller.Size = new System.Drawing.Size(87, 21);
            this.btnNextTeller.TabIndex = 33;
            this.btnNextTeller.Text = "Next Teller";
            this.btnNextTeller.UseVisualStyleBackColor = true;
            this.btnNextTeller.Click += new System.EventHandler(this.btnNextTeller_Click);
            // 
            // btnNextMgr
            // 
            this.btnNextMgr.Location = new System.Drawing.Point(239, 38);
            this.btnNextMgr.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextMgr.Name = "btnNextMgr";
            this.btnNextMgr.Size = new System.Drawing.Size(91, 21);
            this.btnNextMgr.TabIndex = 32;
            this.btnNextMgr.Text = "Next Manager";
            this.btnNextMgr.UseVisualStyleBackColor = true;
            this.btnNextMgr.Click += new System.EventHandler(this.btnNextMgr_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "With";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Credit officer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 87);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "With";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Incoming Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Teller";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "With";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Serving";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 215);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtServing);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNewCust);
            this.Controls.Add(this.OffLbl);
            this.Controls.Add(this.btnNextOfc);
            this.Controls.Add(this.btnNextTeller);
            this.Controls.Add(this.btnNextMgr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtServing;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNewCust;
        private System.Windows.Forms.Label OffLbl;
        private System.Windows.Forms.Button btnNextOfc;
        private System.Windows.Forms.Button btnNextTeller;
        private System.Windows.Forms.Button btnNextMgr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

