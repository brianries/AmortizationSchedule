using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoanManager
{
    [Serializable()]
    public class LoanPayment
    {
        private DateTime _time;
        private double _payment;
        private double _interestPaid;
        private double _principlePaid;
        private double _extraPaid;

        public LoanPayment()
        {
            //Default Constructor
        }

        public LoanPayment(double payment, double interestPaid, double principlePaid, double extraPaid)
        {
            _time = DateTime.Now;
            _payment = payment;
            _interestPaid = interestPaid;
            _principlePaid = principlePaid;
            _extraPaid = extraPaid;
        }

        public DateTime PaymentDate
        {
            get { return _time; }
            set { _time = value; }
        }

        public double TotalPayment
        {
            get { return _payment; }
            set { _payment = value; }
        }

        public double InterestPaid
        {
            get { return _interestPaid; }
            set { _interestPaid = value; }
        }

        public double PrinciplePaid
        {
            get { return _principlePaid; }
            set { _principlePaid = value; }
        }

        public double ExtraPaid
        {
            get { return _extraPaid; }
            set { _extraPaid = value; }
        }

        public override string ToString()
        {
            return String.Format("Payment: {0} | Interest: {1} | Principle: {2}", _payment, _interestPaid, _principlePaid);
        }

    }
}
