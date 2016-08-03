using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SA41Team_10B_SportsBookingFacility
{
    public class SlotBroker
    {
        SqlConnection cn;
        SqlCommand cmSelectSlots;
        SqlDataReader rd;
        SqlParameter pFID, pIDate;
        public SlotBroker()
        {
            string conS = "data source=(local);integrated security=SSPI;initial catalog=FacilityBooking";
            cn = new SqlConnection(conS);
            cmSelectSlots = new SqlCommand();
            cmSelectSlots.Connection = cn;
        }


        public List<SlotBooking> GetSlots(string slotid,DateTime issuedate)
        {
            List<SlotBooking> Availslots = new List<SlotBooking>();

            pFID = new SqlParameter("@pFID", SqlDbType.NVarChar, 5);
            pIDate = new SqlParameter("@pIDate", SqlDbType.DateTime);

            cmSelectSlots.Parameters.Add(pFID);
            cmSelectSlots.Parameters.Add(pIDate);

            //pFID.Value = this.cmbFacilities.SelectedValue.ToString();
            pFID.Value = slotid;
            pIDate.Value = issuedate;

            //cm.CommandText = "select * from Slots where SlotId not in (select SlotId from BookingTran where FacilityId = @pFID and IssueDate = '2015-10-17 00:00:00.000')";
            cmSelectSlots.CommandText = "select * from Slots where SlotId not in (select SlotId from BookingTran where FacilityId = @pFID and IssueDate = @pIDate)";
            cn.Open();
            rd = cmSelectSlots.ExecuteReader();

            while (rd.Read())
            {
                SlotBooking sb = new SlotBooking();
                sb.SlotID = rd["SlotId"].ToString();
                sb.Timeslot = rd["TimeSlot"].ToString();

                Availslots.Add(sb);
            }
            return Availslots;
        }
    }
}
