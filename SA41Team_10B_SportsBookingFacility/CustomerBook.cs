using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA41Team_10B_SportsBookingFacility
{
    public class CustomerBook
    {
        private int customerID;

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private char gender;
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        private DateTime dob;
        public DateTime DOB
        {
            get { return dob; }
            set { dob = value; }
        }


        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        
        private string nric;
        public string NRIC
        {
            get { return nric; }
            set { nric = value; }
        }

        private bool custStatus;

        public bool CustStatus
        {
            get { return custStatus; }
            set { custStatus = value; }
        }

        private string postalcode;
        public string PostalCode
        {
            get { return postalcode; }
            set { postalcode = value; }
        }

        private string phoneno;
        public string Phoneno
        {
            get { return phoneno; }
            set { phoneno = value; }
        }

        private string remarks;
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
   }
}
