using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SA41Team_10B_SportsBookingFacility
{
    public class FacilityBroker
    {
        SqlConnection cn;
        SqlCommand cmSelectAll;
        SqlDataReader rd;


        public FacilityBroker()
        {
            string conS = "data source=(local);integrated security=SSPI;initial catalog=FacilityBooking";
            cn = new SqlConnection(conS);
            cmSelectAll = new SqlCommand();
            cmSelectAll.Connection = cn;
        }

        public List<FacilityBooking> GetAllFacilites()
        {
            cmSelectAll.CommandText = "select * from facilities";
            cn.Open();
            rd = cmSelectAll.ExecuteReader();

            List<FacilityBooking> facilityList = new List<FacilityBooking>();

            while (rd.Read())
            {
                FacilityBooking facility = new FacilityBooking();
                facility.FacilityID = rd["FacilityId"].ToString();
                facility.Name = rd["Name"].ToString();
                facility.Description = rd["Description"].ToString();
                facility.Remarks = rd["Remarks"].ToString();

                facilityList.Add(facility);
            }
            return facilityList;
        }



    }
}
