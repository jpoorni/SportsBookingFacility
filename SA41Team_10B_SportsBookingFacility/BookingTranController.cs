using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA41Team_10B_SportsBookingFacility
{
    public class BookingTranController
    {
        //do the validation method of the usecase
        //string errMessage = "";
        //do try - catch

        //public void BookedToCustomer(CustomerBook cb,FacilityBooking fb,SlotBooking sb,BookingTranLayer bt)
        public void BookedToCustomer(BookingTranLayer bt)
        {
            bt.Status = true;

            using (System.Transactions.TransactionScope ts = new System.Transactions.TransactionScope())
            {
                BookingTranBroker bookingbroker = new BookingTranBroker();
                bookingbroker.Insert(bt);
                ts.Complete();
            }
        }

        public List<SlotBooking> FindAvailableSlots(string slotid,DateTime issuedate)
        {
            SlotBroker sb = new SlotBroker();
            return sb.GetSlots(slotid,issuedate);
        }

        public List<BookingTranLayer> GetAllBookings()
        {
            BookingTranBroker btb = new BookingTranBroker();
            List<BookingTranLayer> tempList = new List<BookingTranLayer>();
            tempList = btb.GetBookings();
            //to get the name of the customer
            //List<CustomerBook> cusNameList = new List<CustomerBook>();
            //foreach(BookingTranLayer b in tempList)
            //{
            //    cusNameList.Add(GetCustomer(b.CustomerID));
            //}
            
            return tempList;
        }


        public CustomerBook GetCustomer(int id)
        {
            CustomerBroker cb = new CustomerBroker();
            CustomerBook cus = cb.GetCustomer(id);
            return cus;
        }


        public List<BookingGridData> GetGridData()
        {
            BookingTranBroker btb = new BookingTranBroker();
            List<BookingGridData> tempList = new List<BookingGridData>();
            tempList = btb.GetGridBookings();
         
            return tempList;
        }


        public List<BookingGridData> GetSearchGridData(string facId, int cusId, DateTime idate)
        {
            BookingTranBroker btb = new BookingTranBroker();
            List<BookingGridData> tempList = new List<BookingGridData>();
            tempList = btb.GetSearchGridBookings(facId, cusId, idate);

            return tempList;
        }

        public List<BookingTranLayer> GetSearchBookings(string facId, int cusId,DateTime idate)
        {
            BookingTranBroker btb = new BookingTranBroker();
            List<BookingTranLayer> tempList = new List<BookingTranLayer>();
            tempList = btb.GetSearchBookings(facId,cusId,idate);
            //to get the name of the customer
            //List<CustomerBook> cusNameList = new List<CustomerBook>();
            //foreach(BookingTranLayer b in tempList)
            //{
            //    cusNameList.Add(GetCustomer(b.CustomerID));
            //}

            return tempList;
        }
    }
}
