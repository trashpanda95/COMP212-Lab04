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
    public partial class Form1 : Form
    {
        static Queue<string> TellerQueue = new Queue<string>();
        static Queue<string> ManagerQueue = new Queue<string>();
        static Queue<string> OfficerQueue = new Queue<string>();
        string incomingManagerCust;
        string incomingTellerCust;
        string incomingOfficerCust;
        string Manager = "Manager";
        string Teller = "Teller";
        string Officer = "Officer";

        public Form1()
        {
            InitializeComponent();
        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewCust_Click(object sender, EventArgs e)
        {
            NewCustomerForm CustomerForm = new NewCustomerForm();
            CustomerForm.Show();
        }

        private void btnNextMgr_Click(object sender, EventArgs e)
        {
            try
            {
                incomingManagerCust = ManagerQueue.Dequeue();
                txtCustName.Text = incomingManagerCust;
                txtServing.Text = Manager;
                label33.Text = incomingManagerCust;
            }

            catch (System.InvalidOperationException msg)
            {

                MessageBox.Show("ERROR: Not part of Manager's services.");
            }
        }

        private void btnNextTeller_Click(object sender, EventArgs e)
        {
            try
            {
                if (TellerQueue.Any())
                {
                    incomingTellerCust = TellerQueue.Dequeue();
                    txtCustName.Text = incomingTellerCust;
                    txtServing.Text = Teller;
                    label10.Text = incomingTellerCust;
                }
                else
                {
                    incomingManagerCust = ManagerQueue.Dequeue();
                    txtCustName.Text = incomingManagerCust;
                    txtServing.Text = Manager;
                    label33.Text = incomingManagerCust;

                }
            }
            catch (System.InvalidOperationException msg)
            {

                MessageBox.Show("ERROR: Not part of Teller's services.");
            }
        }

        private void btnNextOfc_Click(object sender, EventArgs e)
        {
            try
            {

                if (OfficerQueue.Any())
                {
                    incomingOfficerCust = OfficerQueue.Dequeue();
                    txtCustName.Text = incomingOfficerCust;
                    txtServing.Text = Officer;
                    label.Text = incomingOfficerCust;
                }
                else
                {
                    incomingManagerCust = ManagerQueue.Dequeue();
                    txtCustName.Text = incomingManagerCust;
                    txtServing.Text = Manager;
                    label33.Text = incomingManagerCust;
                }
            }
            catch (System.InvalidOperationException msg)
            {

                MessageBox.Show("ERROR: Not part of Officer's services.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        public void AssignTeller(string CustomerName)
        {
            TellerQueue.Enqueue(CustomerName);
        }
        public void AssignManager(string CustomerName)
        {
            ManagerQueue.Enqueue(CustomerName);

        }
        public void AssignOfficer(string CustomerName)
        {
            OfficerQueue.Enqueue(CustomerName);

        }
    }
}
