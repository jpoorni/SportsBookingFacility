using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA41Team10b_Form
{
    public partial class BookingSearchForm : Form
    {
        SA41Team_10B_SportsBookingFacility.BookingTranController BookingController;
        public BookingSearchForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                //finally
                //{
                    SA41Team10b_Form.BookingListForm frm = new SA41Team10b_Form.BookingListForm();
                    frm.Show();
                    this.Close();
                //}
        }

        private void BookingSearchForm_Load(object sender, EventArgs e)
        {
            BookingController = new SA41Team_10B_SportsBookingFacility.BookingTranController();
            //to add the facilities data to the combo box
            SA41Team_10B_SportsBookingFacility.FacilityBroker fb = new SA41Team_10B_SportsBookingFacility.FacilityBroker();
            List<SA41Team_10B_SportsBookingFacility.FacilityBooking> facilityList = new List<SA41Team_10B_SportsBookingFacility.FacilityBooking>();

            facilityList = fb.GetAllFacilites();
            cmbFacilites.DataSource = facilityList;
            cmbFacilites.DisplayMember = "Name".ToString();
            cmbFacilites.ValueMember = "FacilityId";
            cmbFacilites.SelectedIndex = -1;


            //to add the customer data to the combo box
            SA41Team_10B_SportsBookingFacility.CustomerBroker cb = new SA41Team_10B_SportsBookingFacility.CustomerBroker();
            List<SA41Team_10B_SportsBookingFacility.CustomerBook> customerList = new List<SA41Team_10B_SportsBookingFacility.CustomerBook>();
            customerList = cb.GetAllCustomers();
            cmbCustName.DataSource = customerList;
            cmbCustName.DisplayMember = "Name".ToString();
            cmbCustName.ValueMember = "CustomerID";
            cmbCustName.SelectedIndex = -1;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbFacilites.SelectedValue.ToString());
            //MessageBox.Show(cmbCustName.SelectedValue.ToString());
            //MessageBox.Show(dtpIssueDate.Value.ToShortDateString());

            int cusId = Convert.ToInt32(cmbCustName.SelectedValue.ToString());
            string facID = cmbFacilites.SelectedValue.ToString();
            DateTime tempDate = Convert.ToDateTime(dtpIssueDate.Value.ToShortDateString());
            List<SA41Team_10B_SportsBookingFacility.BookingTranLayer> bt = new List<SA41Team_10B_SportsBookingFacility.BookingTranLayer>();
            bt = BookingController.GetSearchBookings(facID,cusId,tempDate);
             if (bt.Count > 1)
             {
                foreach(SA41Team_10B_SportsBookingFacility.BookingTranLayer b in bt)
                {
                    MessageBox.Show(b.CustomerID+b.FacilityId);
                    SA41Team10b_Form.BookingListForm frm = new SA41Team10b_Form.BookingListForm();
                    frm.Show();
            
                }
              }
              else if (bt.Count == 0)
              {
                 MessageBox.Show("No Records");
              }

        }
    }
}
