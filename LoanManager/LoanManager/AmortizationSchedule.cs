using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace LoanManager
{
    public class AmortizationSchedule
    {
        static AmortizationSchedule scheduler = null;

        private AmortizationSchedule()
        {
            
        }

        public static AmortizationSchedule getInstance()
        {
            if (scheduler == null)
            {
                scheduler = new AmortizationSchedule();
            }

            return scheduler;
        }

        private static double getMonthlyInterestRate(double yearlyAPR)
        {
            return yearlyAPR / 100.0 / 12.0;
        }

        private static double roundToNearestPenny(double value)
        {
            //Round the result to the nearest penny
            double scaled = value * 100.0;
            scaled += 0.5;
            int rounded = (int)scaled;
            return ( (double)rounded / 100.0);
        }

        public ArrayList getSchedule(int months, double yearlyAPR, double principle)
        {
            ArrayList list = new ArrayList();

            double monthlyPayment = calculateMonthlyPayment(months, yearlyAPR, principle);
            double remainingPrinciple = principle;
            double monthlyRate = getMonthlyInterestRate(yearlyAPR);

            for (int i = 0; i < months; i++)
            {
                //Round to the nearest penny
                double interestPaid = monthlyRate * remainingPrinciple;
                interestPaid = (double)roundToNearestPenny((double)interestPaid);

                //Remainder of the payment is principle
                double principlePaid = monthlyPayment - interestPaid;

                //Any extra paid on top of the monthly payment
                double extraPaid = 0;

                //Create a payment with these values
                LoanPayment payment = new LoanPayment(monthlyPayment+extraPaid, interestPaid, principlePaid, extraPaid);

                //Add the payment to the list
                list.Add(payment);

                //Adjust the remaining principle on the loan
                remainingPrinciple -= principlePaid;
            }

            remainingPrinciple = roundToNearestPenny(remainingPrinciple);

            //Tack on the remainder on the last payment
            LoanPayment lastPayment = (LoanPayment)list[months - 1];
            lastPayment.TotalPayment += remainingPrinciple;
            lastPayment.PrinciplePaid += remainingPrinciple;

            double principleSum = 0;
            int num = 0;
            /*
            foreach (LoanPayment payment in list)
            {
                num++;
                Console.WriteLine("{0}: {1}", num, payment);
                principleSum += payment.PrinciplePaid;
            }*/

            for (int i = 0; i < 100; i++)
            {
                LoanPayment payment = (LoanPayment)list[i];
                Console.WriteLine("{0}: {1}", num, payment);
            }

            Console.WriteLine("Principle to be paid = {0}", principle);

            Console.WriteLine("Remaining Principle = {0}", remainingPrinciple);

            Console.WriteLine("Total principle paid = {0}", principleSum);

            return list;
        }

        public double calculateMonthlyPayment(int months, double yearlyAPR, double principle)
        {
            double P = principle;
            double N = months;
            double I = getMonthlyInterestRate(yearlyAPR);

            double raised = Math.Pow((1.0 + I), N);

            double numerator = (I * raised);
            double denominator = (raised - 1);
      
            double result = P * (numerator / denominator);


            double rounded = roundToNearestPenny(result);

            return rounded;
        }

        public double calculatePrinciple(int months, double yearlyAPR, double monthlyPayment)
        {
            double M = monthlyPayment;
            double N = months;
            double I = getMonthlyInterestRate(yearlyAPR);

            double raised = Math.Pow((1.0 + I), N);

            double numerator = (I * raised);
            double denominator = (raised - 1);

            double result = M * (denominator / numerator);

            return result;
        }

        public double calculateAPR(int months, double principle, double monthlyPayment)
        {
            double startVal = 0.0;
            double endVal = 100.0;

            return recursiveSearch(startVal, endVal, monthlyPayment, months, principle, 0);
        }

        private double recursiveSearch(double startVal, double endVal, double desiredVal, int months, double principle, double depth)
        {
            //Error tolerance
            double eps = 0.005;

            if ( ((endVal - startVal) < eps) || depth > 30)
            {
                return (endVal + startVal) / 2.0;
            }

            //Possible principle value that could equal this monthly payment
            double attemptedVal = (endVal + startVal) / 2.0;

            //The monthly payment given this principle value
            double result = calculateMonthlyPayment(months, attemptedVal, principle);

            //If the result is less than we want, increase the search
            if (result < desiredVal)
            {
                return recursiveSearch(attemptedVal, endVal, desiredVal, months, principle, depth + 1);
            }
            //The result is greater than we want, decrease the range of the search
            else 
            {
                return recursiveSearch(startVal, attemptedVal, desiredVal, months, principle, depth + 1);
            }
        }
    }
}
