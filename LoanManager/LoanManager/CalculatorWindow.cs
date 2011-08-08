using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LoanManager
{
    public partial class CalculatorWindow : Form
    {
        private double _principle = 0;
        private double _numPayments = 0;
        private double _APR = 0;
        private double _monthlyPayment = 0;


        public struct CurrencyValue
        {
            public string valueString;
            public double value;
        }

        public CalculatorWindow()
        {
            InitializeComponent();

            this.generateSchedule.Enabled = false;
        }


        private void UpdateMonthlyPayment()
        {
            this.generateSchedule.Enabled = false;

            if (_principle != 0 && _APR != 0 && _numPayments != 0)
            {
                _monthlyPayment = AmortizationSchedule.getInstance().calculateMonthlyPayment((int)_numPayments, _APR, _principle);
                this.generateSchedule.Enabled = true;

            }

            UpdateMonthlyPayment(_monthlyPayment.ToString());
        }

        private string AddCommas(string input)
        {
            string newString = "";
            int counter = 0;
            int location = input.Length-1;
          
            while(location >= 0)
            {
                if (counter%3 == 0 && counter != 0)
                {
                    newString = "," + newString;
                }

                char val = input[location];
                counter++;
                location--;

                newString = val + newString;
            }
           
            return newString;
        }

        private CurrencyValue ReturnFormatedCurrency(int leftDecimalPlaces, int rightDecimalPlaces, string inputStr)
        {
            //Find the decimal point
            int index = inputStr.IndexOf(".");

            string wholeNumber = inputStr;
            string fraction = "";

            //If there is a decimal point
            if (index > 0)
            {
                //The whole number is to the left
                wholeNumber = inputStr.Substring(0, index);

                //If there is any more string to the right, that's the fraction
                if (index+1 < inputStr.Length)
                {
                    fraction = inputStr.Substring(index+1);

                  
                }
            }
           
            //Finds all non-digit characters and replaces with ""
            string strippedWhole = Regex.Replace(wholeNumber, @"[^0-9]", "");
            string strippedFraction = Regex.Replace(fraction, @"[^0-9]", "");

            //Trim the whole number to the provided decimal places
            if (strippedWhole.Length > leftDecimalPlaces)
            {
                strippedWhole = strippedWhole.Substring(0, leftDecimalPlaces);
            }

            //Trim the fraction to 2 decimal places
            if (strippedFraction.Length > rightDecimalPlaces)
            {
                strippedFraction = strippedFraction.Substring(0, rightDecimalPlaces);
            }

            //Combine the values back
            string combinedNumeric = null;
            string combinedCommas = null;
            if ((strippedFraction.Equals("") == false || index > 0) && rightDecimalPlaces > 0)
            {
                combinedNumeric = strippedWhole + "." + strippedFraction;
                combinedCommas = AddCommas(strippedWhole) + "." + strippedFraction;
            }
            else
            {
                combinedNumeric = strippedWhole;
                combinedCommas = AddCommas(strippedWhole);
            }

            //Parse the value while we have it
            double value;
            if (!double.TryParse(combinedNumeric, out value))
            {
                Console.WriteLine("ERROR: Couldn't parse string {0} to value!", combinedNumeric);
            }

            CurrencyValue currValue;
            currValue.value = value;
            currValue.valueString = combinedCommas;

            Console.WriteLine("String = {0} Value = {1}", currValue.valueString, currValue.value);

            return currValue;
        }


        private void inputPrinciple_Changed(object sender, EventArgs e)
        {
            UpdatePrinciple(this.inputPrinciple.Text);

            UpdateMonthlyPayment();
        }

        private void inputAPR_Changed(object sender, EventArgs e)
        {
            UpdateAPR(this.inputAPR.Text);

            UpdateMonthlyPayment();
        }

        private void inputNumPayments_Changed(object sender, EventArgs e)
        {
            UpdateNumPayments(this.inputNumPayments.Text);
          
            UpdateMonthlyPayment();
        }

        private void UpdatePrinciple(string text)
        {
            CurrencyValue curr = ReturnFormatedCurrency(8, 2, text);

            this._principle = curr.value;

            //Set the text box to display this new value and set the cursor to the end
            this.inputPrinciple.Text = curr.valueString;
            this.inputPrinciple.Select(curr.valueString.Length, 0);
        }

        private void UpdateAPR(string text)
        {
            CurrencyValue curr = ReturnFormatedCurrency(2, 2, text);

            this._APR = curr.value;

            //Set the text box to display this new value and set the cursor to the end
            this.inputAPR.Text = curr.valueString;
            this.inputAPR.Select(curr.valueString.Length, 0);
        }

        private void UpdateNumPayments(string text)
        {
            CurrencyValue curr = ReturnFormatedCurrency(4, 0, text);

            this._numPayments = curr.value;

            //Set the text box to display this new value and set the cursor to the end
            this.inputNumPayments.Text = curr.valueString;
            this.inputNumPayments.Select(curr.valueString.Length, 0);
        }

        private void UpdateMonthlyPayment(string text)
        {
            CurrencyValue curr = ReturnFormatedCurrency(7, 2, text);

            this._monthlyPayment = curr.value;

            //Set the text box to display this new value and set the cursor to the end
            this.inputMonthlyPayment.Text = curr.valueString;
            this.inputMonthlyPayment.Select(curr.valueString.Length, 0);
        }

        private void generateScheduleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
