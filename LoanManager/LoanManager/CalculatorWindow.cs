using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoanManager
{
    public partial class CalculatorWindow : Form
    {
        private double _principle = 0;
        private double _numPayments = 0;
        private double _APR = 0;
        private double _monthlyPayment = 0;

        public CalculatorWindow()
        {
            InitializeComponent();

            this.calculateAPRButton.Enabled = false;
            this.calculateMonthlyPaymentButton.Enabled = false;
            this.calculateNumPaymentsButton.Enabled = false;
            this.calculatePrincipleButton.Enabled = false;    
        }


        private void updateButtonStatuses()
        {
            this.calculateAPRButton.Enabled = false;
            this.calculateMonthlyPaymentButton.Enabled = false;
            this.calculateNumPaymentsButton.Enabled = false;
            this.calculatePrincipleButton.Enabled = false;

            Console.WriteLine("Updating button statuses!");

            if (_principle != 0 && _numPayments != 0 && _APR != 0)
            {
                this.calculateMonthlyPaymentButton.Enabled = true;
            }
        }

        private void inputPrinciple_Enter(object sender, EventArgs e)
        {
            double result;
            if (double.TryParse(this.inputAPR.Text, out result))
            {
                _principle = result;
            }

            updateButtonStatuses();
        }

        private void inputAPR_ModifiedChanged(object sender, EventArgs e)
        {
            double result;
            if (double.TryParse(this.inputAPR.Text, out result))
            {
                _APR = result;
            }

            updateButtonStatuses();
        }

        private void inputNumPayments_ModifiedChanged(object sender, EventArgs e)
        {
            double result;
            if (double.TryParse(this.inputAPR.Text, out result))
            {
                _numPayments = result;
            }

            updateButtonStatuses();
        }

        private void inputMonthlyPayment_ModifiedChanged(object sender, EventArgs e)
        {
            double result;
            if (double.TryParse(this.inputAPR.Text, out result))
            {
                _monthlyPayment = result;
            }

            updateButtonStatuses();
        }

        private void calculatePrincipleButton_Click(object sender, EventArgs e)
        {

        }

        private void calculateAPRButton_Click(object sender, EventArgs e)
        {

        }

        private void calculateNumPaymentsButton_Click(object sender, EventArgs e)
        {

        }

        private void calculateMonthlyPaymentButton_Click(object sender, EventArgs e)
        {

        }

       
    }
}
