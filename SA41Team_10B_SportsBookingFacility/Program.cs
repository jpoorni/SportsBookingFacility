using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA41Team_10B_SportsBookingFacility
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SA41Team10b_Form.frmMain());
            //Application.Run(new NewBookingForm());
            //Application.Run(new SA41Team10b_Form.FacilityDetailForm());
            //Application.Run(new SA41Team10b_Form.BookingListForm());
            //Application.Run(new SA41Team10b_Form.BookingSearchForm());
            //Application.Run(new SA41Team10b_Form.CustomerDetailForm());
        }
    }
}
