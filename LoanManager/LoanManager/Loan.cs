using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Globalization;

using System.Xml.Serialization;

namespace LoanManager
{
   
    [Serializable(), XmlInclude(typeof(LoanPayment))]
    public class Loan
    {
        private String _name;
        private DateTime _startDate;
        private float _APR;
        private float _principle;
        private float _numMonths;
       
        private ArrayList _paymentHistory;

        private float _principlePaid;
        private float _interestPaid;

        public Loan()
        {

        }


        public Loan(String name, DateTime startDate, float APR, float principle, float numMonths)
        {
            _name = name;
            _startDate = startDate;
            _APR = APR;
            _principle = principle;
            _numMonths = numMonths;
            _paymentHistory = new ArrayList();

            _interestPaid = 0;
            _principlePaid = 0;
        }

        public String Name
        {
            get { return _name;  }
            set { _name = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate;  }
            set { _startDate = value; }
        }

        public float APR
        {
            get { return _APR;  }
            set { _APR = value; }
        }

        public float Principle
        {
            get { return _principle;  }
            set { _principle = value; }
        }

        public float NumMonths
        {
            get { return _numMonths;  }
            set { _numMonths = value; }
        }

        [XmlArrayItem("Payment")]
        public ArrayList PaymentHistory
        {
            get { return _paymentHistory;  }
            set { _paymentHistory = value; }
        }

        public void addPayment(LoanPayment payment)
        {
            if (payment != null)
            {
                _paymentHistory.Add(payment);
            }

            updateTotals();
        }

        public void updateTotals()
        {
            _interestPaid = 0;
            _principlePaid = 0;

            foreach (LoanPayment payment in _paymentHistory)
            {
                _interestPaid += payment.InterestPaid;
                _principlePaid += payment.PrinciplePaid;
            }
        }
    }
}
