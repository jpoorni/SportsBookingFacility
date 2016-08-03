using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA41Team_10B_SportsBookingFacility
{
    public class BookingTranLayer
    {
        private string faciltyId;
        public string FacilityId
        {
            get { return faciltyId; }
            set { faciltyId = value; }
        }

        private string slotid;
        public string SlotID
        {
            get { return slotid; }
            set { slotid = value; }
        }

        private int customerID;
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        private DateTime issuedate;
        public DateTime Issuedate
        {
            get { return issuedate; }
            set { issuedate = value; }
        }

        private bool status;
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}
