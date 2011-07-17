using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace LoanManager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            TestAmortization();
        }


        public void TestAmortization()
        {
            double result = AmortizationSchedule.getInstance().calculateMonthlyPayment(360, 4.5f, 200000.0f);

            Console.WriteLine("Monthly payment = {0}", result);


            AmortizationSchedule.getInstance().getSchedule(360, 4.5, 200000.0);


            Console.WriteLine("Principle for 1058.42, at 4.5% over 30 years = {0}", AmortizationSchedule.getInstance().calculatePrinciple(360, 4.875, 1058.42));

            Console.WriteLine("APR for 1058.42, for 200,0000 over 30 years = {0}", AmortizationSchedule.getInstance().calculateAPR(360, 200000, 1058.42));

            Loan loan = new Loan("House Loan", new DateTime(2011, 6, 29), 4.5, 2000000.0, 360.0);

            LoanPayment payment = new LoanPayment(1500.0, 1100.0, 400.0, 0.0);

            loan.addPayment(payment);

            Profile profile = new Profile("Brian");
            profile.addLoan(loan);


            // Create a new XmlSerializer instance with the type of the test class
            XmlSerializer SerializerObj = new XmlSerializer(typeof(Profile));

            // Create a new file stream to write the serialized object to a file
            TextWriter WriteFileStream = new StreamWriter("./test.xml");
            SerializerObj.Serialize(WriteFileStream, profile);


            //TextReader ReadStream = new StreamReader("./test.xml");
            //Loan loan2 = (Loan)SerializerObj.Deserialize(ReadStream);


            //Console.WriteLine("Loan apr = {0}", loan.APR);

            //AmortizationPayment p = (AmortizationPayment)loan.PaymentHistory[0];

            //Console.WriteLine("Payment Interest = {0}", p.InterestPaid);


            // Cleanup
            WriteFileStream.Close();
            //ReadStream.Close();



        }

        private void amortizationCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculatorWindow calc = new CalculatorWindow();
            calc.ShowDialog();

        }
    }
}
