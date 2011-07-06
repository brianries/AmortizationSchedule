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
        private float _payment;
        private float _interestPaid;
        private float _principlePaid;
        private float _extraPaid;

        public LoanPayment()
        {
            //Default Constructor
        }

        public LoanPayment(float payment, float interestPaid, float principlePaid, float extraPaid)
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

        public float TotalPayment
        {
            get { return _payment; }
            set { _payment = value; }
        }

        public float InterestPaid
        {
            get { return _interestPaid; }
            set { _interestPaid = value; }
        }

        public float PrinciplePaid
        {
            get { return _principlePaid; }
            set { _principlePaid = value; }
        }

        public float ExtraPaid
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
