using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA41Team_10B_SportsBookingFacility
{
    public class SlotBooking
    {
        private string slotid;
        public string SlotID
        {
            get { return slotid; }
            set { slotid = value; }
        }

        private string timeslot;
        public string Timeslot
        {
            get { return timeslot; }
            set { timeslot = value; }
        }

    }
}
