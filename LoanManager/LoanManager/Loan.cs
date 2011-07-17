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
        private double _APR;
        private double _principle;
        private double _numMonths;
       
        private ArrayList _paymentHistory;

        private double _principlePaid;
        private double _interestPaid;

        public Loan()
        {

        }


        public Loan(String name, DateTime startDate, double APR, double principle, double numMonths)
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

        public double APR
        {
            get { return _APR;  }
            set { _APR = value; }
        }

        public double Principle
        {
            get { return _principle;  }
            set { _principle = value; }
        }

        public double NumMonths
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
