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

        public static float getMonthlyInterestRate(float yearlyAPR)
        {
            return yearlyAPR / 100.0f / 12.0f;
        }

        public ArrayList getSchedule(int months, float yearlyAPR, float principle)
        {
            ArrayList list = new ArrayList();

            float monthlyPayment = calculateMonthlyPayment(months, yearlyAPR, principle);
            float remainingPrinciple = principle;
            float monthlyRate = getMonthlyInterestRate(yearlyAPR);

            for (int i = 0; i < months; i++)
            {
                float interestPaid = monthlyRate * remainingPrinciple;
                float principlePaid = monthlyPayment - interestPaid;
                float extraPaid = 0;
                LoanPayment payment = new LoanPayment(monthlyPayment, interestPaid, principlePaid, extraPaid);

                list.Add(payment);

                Console.WriteLine("{0}: {1}", i, payment);

                remainingPrinciple -= principlePaid;
            }

            float principleSum = 0;
            foreach (LoanPayment payment in list)
            {
                principleSum += payment.PrinciplePaid;
            }

            Console.WriteLine("Total principle paid = {0}", principleSum);

            return list;
        }

        public float calculateMonthlyPayment(int months, float yearlyAPR, float principle)
        {
            double P = (double)principle;
            double N = (double)months;
            double I = (double)getMonthlyInterestRate(yearlyAPR);

            double raised = Math.Pow((1.0 + I), N);

            double numerator = (I * raised);
            double denominator = (raised - 1);
      
            double result = P * (numerator / denominator);

            return (float)result;
        }

        public float calculatePrinciple(int months, float yearlyAPR, float monthlyPayment)
        {
            double M = (double)monthlyPayment;
            double N = (double)months;
            double I = (double)getMonthlyInterestRate(yearlyAPR);

            double raised = Math.Pow((1.0 + I), N);

            double numerator = (I * raised);
            double denominator = (raised - 1);

            double result = M * (denominator / numerator);

            return (float)result;
        }

        public float calculateAPR(int months, float principle, float monthlyPayment)
        {
            float startVal = 0.0f;
            float endVal   = 100.0f;

            return recursiveSearch(startVal, endVal, monthlyPayment, months, principle, 0);
        }

        private float recursiveSearch(float startVal, float endVal, float desiredVal, int months, float principle, int depth)
        {
            //Error tolerance
            float eps = 0.005f;

            if ( ((endVal - startVal) < eps) || depth > 30)
            {
                return (endVal + startVal) / 2.0f;
            }

            //Possible principle value that could equal this monthly payment
            float attemptedVal = (endVal + startVal) / 2.0f;

            //The monthly payment given this principle value
            float result = calculateMonthlyPayment(months, attemptedVal, principle);

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
