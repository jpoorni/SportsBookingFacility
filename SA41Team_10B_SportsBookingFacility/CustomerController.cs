using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SA41Team_10B_SportsBookingFacility
{
    public class CustomerController
    {
        //assume our customer can only be over 18 years old.
        public bool NewCustomerValidation(Customer customer)
        {

           bool IsOk = false;
           if (DateTime.Today.Year-customer.DOB.Value.Year<18)
           {
               MessageBox.Show("Age below 18 can not book");
           }
           else
           {
               IsOk = true;
           }
           return IsOk;

        }
   
    }
}
