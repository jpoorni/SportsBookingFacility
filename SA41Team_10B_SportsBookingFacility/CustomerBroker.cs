using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SA41Team_10B_SportsBookingFacility
{
    public class CustomerBroker
    {
        SqlConnection cn;
        SqlCommand cmSelectAll;
        SqlCommand cmSelectOne;
        SqlDataReader rd;


        public CustomerBroker()
        {
            string conS = "data source=(local);integrated security=SSPI;initial catalog=FacilityBooking";
            cn = new SqlConnection(conS);
            cmSelectAll = new SqlCommand();
            cmSelectAll.Connection = cn;
            cmSelectOne = new SqlCommand();
            cmSelectOne.Connection = cn;
        }
        public List<CustomerBook> GetAllCustomers()
        {
            cmSelectAll.CommandText = "select * from customers where custstatus = 1";
            cn.Open();
            rd = cmSelectAll.ExecuteReader();

            List<CustomerBook> customerList = new List<CustomerBook>();

            while (rd.Read())
            {
                CustomerBook customer = new CustomerBook();
                customer.CustomerID = Convert.ToInt32(rd["CustomerID"].ToString());
                customer.Name = rd["Name"].ToString();
                customer.Gender = Convert.ToChar(rd["Gender"].ToString());
                customer.DOB = Convert.ToDateTime(rd["DOB"].ToString());
                customer.Address = rd["Address"].ToString();
                customer.Email = rd["Email"].ToString();
                customer.NRIC = rd["NRIC"].ToString();
                customer.CustStatus = Convert.ToBoolean(rd["Custstatus"].ToString());
                customer.PostalCode = rd["PostalCode"].ToString();
                customer.Phoneno = rd["Phoneno"].ToString();
                customer.Remarks = rd["Remarks"].ToString();

                customerList.Add(customer);
            }

            return customerList;
        }


        
        public CustomerBook GetCustomer(int id)
        {

            SqlParameter pId = new SqlParameter("@Id", SqlDbType.Int);
            cmSelectOne.Parameters.Add(pId);
            pId.Value = id;

            CustomerBook cus = new CustomerBook();
            cmSelectOne.CommandText = "Select * from customers where customerid = @Id";
            cn.Open();
            rd = cmSelectOne.ExecuteReader();
            if (rd.Read())
            {
                cus.CustomerID = Convert.ToInt32(rd["CustomerID"].ToString());
                cus.Name = rd["Name"].ToString();
                cus.Gender = Convert.ToChar(rd["Gender"].ToString());
                cus.DOB = Convert.ToDateTime(rd["DOB"].ToString());
                cus.Address = rd["Address"].ToString();
                cus.Email = rd["Email"].ToString();
                cus.NRIC = rd["NRIC"].ToString();
                cus.CustStatus = Convert.ToBoolean(rd["Custstatus"].ToString());
                cus.PostalCode = rd["PostalCode"].ToString();
                cus.Phoneno = rd["Phoneno"].ToString();
                cus.Remarks = rd["Remarks"].ToString();
                cn.Close();
            }

            return cus;
        }
    }
}
