using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace LoanManager
{
    [Serializable(), XmlInclude(typeof(Loan))]
    public class Profile
    {
        private String _name;
        private ArrayList _loanList;

        public Profile()
        {

        }

        public Profile(String name)
        {
            _name = name;
            _loanList = new ArrayList();
        }

        public void addLoan(Loan loan)
        {
            _loanList.Add(loan);
        }

        public String Name
        {
            get { return _name;  }
            set { _name = value; }
        }

        [XmlArrayItem("Loan")]
        public ArrayList LoanList
        {
            get { return _loanList;  }
            set { _loanList = value; }
        }
    }
}
