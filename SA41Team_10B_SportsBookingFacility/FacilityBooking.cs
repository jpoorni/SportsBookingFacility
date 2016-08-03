using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA41Team_10B_SportsBookingFacility
{
    public class FacilityBooking
    {
        private string facilityID;
        public string FacilityID
        {
            get { return facilityID; }
            set { facilityID = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string remarks;
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }
    }
}
