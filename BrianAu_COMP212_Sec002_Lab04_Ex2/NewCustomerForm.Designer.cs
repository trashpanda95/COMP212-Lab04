namespace BrianAu_COMP212_Sec002_Lab04_Ex2
{
    partial class NewCustomerForm
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
            this.radCL = new System.Windows.Forms.RadioButton();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.radCC = new System.Windows.Forms.RadioButton();
            this.radWithdraw = new System.Windows.Forms.RadioButton();
            this.radPay = new System.Windows.Forms.RadioButton();
            this.radDep = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radCL
            // 
            this.radCL.AutoSize = true;
            this.radCL.Location = new System.Drawing.Point(91, 154);
            this.radCL.Margin = new System.Windows.Forms.Padding(2);
            this.radCL.Name = "radCL";
            this.radCL.Size = new System.Drawing.Size(123, 17);
            this.radCL.TabIndex = 20;
            this.radCL.TabStop = true;
            this.radCL.Text = "Apply for a credit line";
            this.radCL.UseVisualStyleBackColor = true;
            this.radCL.CheckedChanged += new System.EventHandler(this.radCL_CheckedChanged);
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Location = new System.Drawing.Point(91, 175);
            this.radOther.Margin = new System.Windows.Forms.Padding(2);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(51, 17);
            this.radOther.TabIndex = 19;
            this.radOther.TabStop = true;
            this.radOther.Text = "Other";
            this.radOther.UseVisualStyleBackColor = true;
            this.radOther.CheckedChanged += new System.EventHandler(this.radOther_CheckedChanged);
            // 
            // radCC
            // 
            this.radCC.AutoSize = true;
            this.radCC.Location = new System.Drawing.Point(91, 133);
            this.radCC.Margin = new System.Windows.Forms.Padding(2);
            this.radCC.Name = "radCC";
            this.radCC.Size = new System.Drawing.Size(119, 17);
            this.radCC.TabIndex = 18;
            this.radCC.TabStop = true;
            this.radCC.Text = "Apply for credit card";
            this.radCC.UseVisualStyleBackColor = true;
            this.radCC.CheckedChanged += new System.EventHandler(this.radCC_CheckedChanged);
            // 
            // radWithdraw
            // 
            this.radWithdraw.AutoSize = true;
            this.radWithdraw.Location = new System.Drawing.Point(91, 91);
            this.radWithdraw.Margin = new System.Windows.Forms.Padding(2);
            this.radWithdraw.Name = "radWithdraw";
            this.radWithdraw.Size = new System.Drawing.Size(104, 17);
            this.radWithdraw.TabIndex = 17;
            this.radWithdraw.TabStop = true;
            this.radWithdraw.Text = "Withdraw money";
            this.radWithdraw.UseVisualStyleBackColor = true;
            this.radWithdraw.CheckedChanged += new System.EventHandler(this.radWithdraw_CheckedChanged);
            // 
            // radPay
            // 
            this.radPay.AutoSize = true;
            this.radPay.Location = new System.Drawing.Point(91, 112);
            this.radPay.Margin = new System.Windows.Forms.Padding(2);
            this.radPay.Name = "radPay";
            this.radPay.Size = new System.Drawing.Size(95, 17);
            this.radPay.TabIndex = 16;
            this.radPay.TabStop = true;
            this.radPay.Text = "Make payment";
            this.radPay.UseVisualStyleBackColor = true;
            this.radPay.CheckedChanged += new System.EventHandler(this.radPay_CheckedChanged);
            // 
            // radDep
            // 
            this.radDep.AutoSize = true;
            this.radDep.Location = new System.Drawing.Point(91, 70);
            this.radDep.Margin = new System.Windows.Forms.Padding(2);
            this.radDep.Name = "radDep";
            this.radDep.Size = new System.Drawing.Size(95, 17);
            this.radDep.TabIndex = 15;
            this.radDep.TabStop = true;
            this.radDep.Text = "Deposit money";
            this.radDep.UseVisualStyleBackColor = true;
            this.radDep.CheckedChanged += new System.EventHandler(this.radDep_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(67, 206);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(172, 26);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Service:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 42);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 262);
            this.Controls.Add(this.radCL);
            this.Controls.Add(this.radOther);
            this.Controls.Add(this.radCC);
            this.Controls.Add(this.radWithdraw);
            this.Controls.Add(this.radPay);
            this.Controls.Add(this.radDep);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "NewCustomerForm";
            this.Text = "NewCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radCL;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.RadioButton radCC;
        private System.Windows.Forms.RadioButton radWithdraw;
        private System.Windows.Forms.RadioButton radPay;
        private System.Windows.Forms.RadioButton radDep;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
    }
}