using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA41Team_10B_SportsBookingFacility
{
    public class BookingGridData
    {
        private int bookcustomerID;

        public int BookCustomerID
        {
            get { return bookcustomerID; }
            set { bookcustomerID = value; }
        }

        private string bookname;
        public string BookName
        {
            get { return bookname; }
            set { bookname = value; }
        }

        private string bookfacilityID;
        public string BookFacilityID
        {
            get { return bookfacilityID; }
            set { bookfacilityID = value; }
        }

        private string bookFacilityname;
        public string BookFacilityname
        {
            get { return bookFacilityname; }
            set { bookFacilityname = value; }
        }

        private string bookSlotid;
        public string BookSlotID
        {
            get { return bookSlotid; }
            set { bookSlotid = value; }
        }

        private string bookTimeSlot;
        public string BookTimeSlot
        {
            get { return bookTimeSlot; }
            set { bookTimeSlot = value; }
        }

        private DateTime bookIssueDate;
        public DateTime BookIssuedate
        {
            get { return bookIssueDate; }
            set { bookIssueDate = value; }
        }

    }
}
