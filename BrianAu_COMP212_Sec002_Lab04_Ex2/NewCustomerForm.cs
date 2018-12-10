using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrianAu_COMP212_Sec002_Lab04_Ex2
{
    public partial class NewCustomerForm : Form
    {
        string CustomerName;

        int selectedService = 0;
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void radDep_CheckedChanged(object sender, EventArgs e)
        {
            selectedService = 1; // Teller Selection
        }

        private void radWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            selectedService = 1; // Teller Selection
        }

        private void radPay_CheckedChanged(object sender, EventArgs e)
        {
            selectedService = 1; // Teller Selection
        }

        private void radCC_CheckedChanged(object sender, EventArgs e)
        {
            selectedService = 2;  // Officer Selection
        }

        private void radCL_CheckedChanged(object sender, EventArgs e)
        {
            selectedService = 2;  // Officer Selection
        }

        private void radOther_CheckedChanged(object sender, EventArgs e)
        {
            selectedService = 3; // Manager Selection
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            CustomerName = Convert.ToString(txtName);
            Form1 form1 = new Form1();

            switch (selectedService)
            {
                case 1:
                    form1.AssignTeller(CustomerName);
                    break;
                case 2:
                    form1.AssignOfficer(CustomerName);
                    break;
                case 3:
                    form1.AssignManager(CustomerName);
                    break;
            }
            this.Close();
        }
    }
}
