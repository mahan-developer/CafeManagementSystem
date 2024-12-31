using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntitiesLayer
{	
    public class Customer
    {
        private int _customerID;
        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }


        private string _firstName;
        [Column("NVARCHAR",50)]
        public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

        private string _lastName;
        [Column("NVARCHAR", 50)]
        public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}

        private string _phoneNumber;
        [Column("NVARCHAR", 20)]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private string _emailAddress;
        [Column("NVARCHAR", 80)]
        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }

        private string _customerAddress;
        [Column("NVARCHAR", 150)]
        public string CustomerAddress
        {
            get { return _customerAddress; }
            set { _customerAddress = value; }
        }
    }
}
