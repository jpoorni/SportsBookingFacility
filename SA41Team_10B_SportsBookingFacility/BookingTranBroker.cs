using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SA41Team_10B_SportsBookingFacility
{
    public class BookingTranBroker
    {
        SqlConnection cn;
        SqlCommand cmInsert;
        SqlCommand cmSelectAll;
        SqlCommand cmSelectSearch;
        SqlCommand cmSelectGridSearch;
        SqlDataReader rd;

        public BookingTranBroker()
        {
            string conS = "data source=(local);integrated security=SSPI;initial catalog=FacilityBooking";
            cn = new SqlConnection(conS);
            cmInsert = new SqlCommand();
            cmSelectAll = new SqlCommand();
            cmSelectSearch = new SqlCommand();
            cmSelectGridSearch = new SqlCommand();

            cmInsert.CommandText = "Insert into BookingTran (FacilityId,SlotId,CustomerId,IssueDate,Status)" + " values(@FacilityId,@SlotId,@CustomerId,@IssueDate,@Status)";
            cmInsert.Connection = cn;
        }

        public void Insert(BookingTranLayer bt)
        {

            SqlParameter pFacilityId = new SqlParameter("@FacilityId", SqlDbType.NVarChar, 5);
            SqlParameter pSlotId = new SqlParameter("@SlotId", SqlDbType.NVarChar, 5);
            SqlParameter pCustomerId = new SqlParameter("@CustomerId", SqlDbType.Int);
            SqlParameter pIssueDate = new SqlParameter("@IssueDate", SqlDbType.DateTime);
            SqlParameter pStatus = new SqlParameter("@Status", SqlDbType.Bit);

            cmInsert.Parameters.AddRange(new SqlParameter[] { pFacilityId, pSlotId, pCustomerId, pIssueDate, pStatus });
            //cmInsert.Parameters.AddRange(new SqlParameter[] { pFacilityId, pSlotId, pCustomerId, pIssueDate });

            pFacilityId.Value = bt.FacilityId;
            pSlotId.Value = bt.SlotID;
            pCustomerId.Value = bt.CustomerID;
            pIssueDate.Value = bt.Issuedate;
            pStatus.Value = bt.Status;

            cn.Open();
            cmInsert.ExecuteNonQuery();
            cn.Close();
        }


        public List<BookingTranLayer> GetBookings()
        {
            List<BookingTranLayer> allBookings = new List<BookingTranLayer>();
            cmSelectAll.Connection = cn;
            cmSelectAll.CommandText = "Select facilityid,slotid,customerid,issuedate from BookingTran where Status = 1";//show only booked transactions and not cancelled transactions
            cn.Open();
            rd = cmSelectAll.ExecuteReader();

            while (rd.Read())
            {
                BookingTranLayer bookingTrans = new BookingTranLayer();
                //find the customer name through id
                bookingTrans.CustomerID = Convert.ToInt32(rd["CustomerID"].ToString());
                //CustomerBook c = new CustomerBook();
                //c.GetCustomer(bookingTrans.CustomerID);
                bookingTrans.FacilityId = rd["FacilityId"].ToString();
                bookingTrans.Issuedate = Convert.ToDateTime(rd["IssueDate"].ToString());
                bookingTrans.SlotID = rd["SlotId"].ToString();

                allBookings.Add(bookingTrans);
            }

            return allBookings;
        }

        public List<BookingGridData> GetGridBookings()
        {
            List<BookingGridData> allBookings = new List<BookingGridData>();
            cmSelectAll.Connection = cn;

            cmSelectAll.CommandText = "select b.CustomerId, c.Name, b.SlotId, s.TimeSlot,b.FacilityID, f.Name as FacilityName,b.IssueDate from Customers c,Slots s,Facilities f,BookingTran b where b.CustomerId = c.CustomerID and b.SlotId = s.SlotId and  b.FacilityId = f.FacilityId order by b.CustomerId";
            cn.Open();
            rd = cmSelectAll.ExecuteReader();
            //rd.FieldCount()
            while (rd.Read())
            {
                BookingGridData bookingTransGrid = new BookingGridData();
                
                bookingTransGrid.BookCustomerID = Convert.ToInt32(rd["CustomerID"].ToString());
                bookingTransGrid.BookName = rd["Name"].ToString();
                
                bookingTransGrid.BookFacilityID = rd["FacilityId"].ToString();
                bookingTransGrid.BookFacilityname = rd["FacilityName"].ToString();

                bookingTransGrid.BookSlotID = rd["SlotId"].ToString();
                bookingTransGrid.BookTimeSlot = rd["TimeSlot"].ToString();

                bookingTransGrid.BookIssuedate = Convert.ToDateTime(rd["IssueDate"].ToString());

                allBookings.Add(bookingTransGrid);
            }

            return allBookings;
        }


        public List<BookingTranLayer> GetSearchBookings(string facId, int cusID,DateTime idate)
        {
            List<BookingTranLayer> SearchBookingsList = new List<BookingTranLayer>();
            cmSelectSearch.Connection = cn;


            SqlParameter pFacId1 = new SqlParameter("@FacId1", SqlDbType.NVarChar, 5);
            //SqlParameter pSlotId = new SqlParameter("@SlotId", SqlDbType.NVarChar, 5);
            SqlParameter pCusId1 = new SqlParameter("@CustId1", SqlDbType.Int);
            SqlParameter pIssDate1 = new SqlParameter("@IssDate1", SqlDbType.DateTime);
            //SqlParameter pStatus = new SqlParameter("@Status", SqlDbType.Bit);

            cmSelectSearch.Parameters.AddRange(new SqlParameter[] {pFacId1, pCusId1, pIssDate1});

            pFacId1.Value = facId;
            pCusId1.Value = cusID;
            pIssDate1.Value = idate; 

            cmSelectSearch.CommandText = "Select facilityid,slotid,customerid,issuedate from BookingTran where Status = 1 and customerid = @CustId1 and facilityid = @Facid1 and issuedate = @IssDate1";//show only booked transactions and not cancelled transactions
            cn.Open();
            rd = cmSelectSearch.ExecuteReader();

            while (rd.Read())
            {
                BookingTranLayer bookingTrans = new BookingTranLayer();
                bookingTrans.CustomerID = Convert.ToInt32(rd["CustomerID"].ToString());
                bookingTrans.FacilityId = rd["FacilityId"].ToString();
                bookingTrans.Issuedate = Convert.ToDateTime(rd["IssueDate"].ToString());
                bookingTrans.SlotID = rd["SlotId"].ToString();

                SearchBookingsList.Add(bookingTrans);
            }

            return SearchBookingsList;
        }

        public List<BookingGridData> GetSearchGridBookings(string facId, int cusID, DateTime idate)
        {
            List<BookingGridData> SearchBookingsList = new List<BookingGridData>();
            cmSelectGridSearch.Connection = cn;


            SqlParameter pFacId = new SqlParameter("@FacId", SqlDbType.NVarChar, 5);
            //SqlParameter pSlotId = new SqlParameter("@SlotId", SqlDbType.NVarChar, 5);
            SqlParameter pCusId = new SqlParameter("@CustId", SqlDbType.Int);
            SqlParameter pIssDate = new SqlParameter("@IssDate", SqlDbType.DateTime);
            //SqlParameter pStatus = new SqlParameter("@Status", SqlDbType.Bit);

            cmSelectGridSearch.Parameters.AddRange(new SqlParameter[] { pFacId, pCusId, pIssDate });

            pFacId.Value = facId;
            pCusId.Value = cusID;
            pIssDate.Value = idate;

            cmSelectGridSearch.CommandText = "select b.CustomerId, c.Name, b.SlotId, s.TimeSlot,b.FacilityID, f.Name as FacilityName,b.IssueDate from Customers c,Slots s,Facilities f,BookingTran b where b.CustomerId = c.CustomerID and b.SlotId = s.SlotId and  b.FacilityId = f.FacilityId and b.CustomerId = @CustId and b.facilityid = @Facid and b.IssueDate = @issdate";
            //cmSelectSearch.CommandText = "Select facilityid,slotid,customerid,issuedate from BookingTran where Status = 1 and customerid = @CustId and facilityid = @Facid and issuedate = @issdate";//show only booked transactions and not cancelled transactions
            cn.Open();
            rd = cmSelectGridSearch.ExecuteReader();

            while (rd.Read())
            {
                BookingGridData bookingTransGrid = new BookingGridData();

                bookingTransGrid.BookCustomerID = Convert.ToInt32(rd["CustomerID"].ToString());
                bookingTransGrid.BookName = rd["Name"].ToString();

                bookingTransGrid.BookFacilityID = rd["FacilityId"].ToString();
                bookingTransGrid.BookFacilityname = rd["FacilityName"].ToString();

                bookingTransGrid.BookSlotID = rd["SlotId"].ToString();
                bookingTransGrid.BookTimeSlot = rd["TimeSlot"].ToString();

                bookingTransGrid.BookIssuedate = Convert.ToDateTime(rd["IssueDate"].ToString());

                SearchBookingsList.Add(bookingTransGrid);
            }

            return SearchBookingsList;
        }




    }



}
