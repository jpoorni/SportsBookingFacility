using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SA41Team10b_Form
{
    public partial class BookingListForm : Form
    {
        SA41Team_10B_SportsBookingFacility.BookingTranController Bookingcontroller;
        SA41Team_10B_SportsBookingFacility.FacilityBooking ctx = new SA41Team_10B_SportsBookingFacility.FacilityBooking();
        public BookingListForm()
        {
            InitializeComponent();
        }

        private void BookingListForm_Load(object sender, EventArgs e)
        {
            //Bookingcontroller = new SA41Team_10B_SportsBookingFacility.BookingTranController();

            btnCancelBooking.Enabled = false;

            Bookingcontroller = new SA41Team_10B_SportsBookingFacility.BookingTranController();
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

            //dgvBookingList.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            //List<SA41Team_10B_SportsBookingFacility.BookingTranLayer> BookingList = new List<SA41Team_10B_SportsBookingFacility.BookingTranLayer>();
            //BookingList = Bookingcontroller.GetAllBookings();

            //dgvBookingList.DataSource = BookingList;


            List<SA41Team_10B_SportsBookingFacility.BookingGridData> BookingGridList = new List<SA41Team_10B_SportsBookingFacility.BookingGridData>();
            BookingGridList = Bookingcontroller.GetGridData();

            dgvBookingList.DataSource = BookingGridList;
            dgvBookingList.Columns["BookName"].HeaderText = "Customer";
            dgvBookingList.Columns["BookFacilityname"].HeaderText = "Facility Booked";
            dgvBookingList.Columns["BookTimeSlot"].HeaderText = "Time Slot";
            dgvBookingList.Columns["BookIssueDate"].HeaderText = "Booked Date";
            dgvBookingList.Columns["BookCustomerId"].Visible = false;
            dgvBookingList.Columns["BookSlotId"].Visible = false;
            dgvBookingList.Columns["BookFacilityId"].Visible = false;
            dgvBookingList.AutoResizeColumns();



            //List<SA41Team_10B_SportsBookingFacility.CustomerBook> cusNameList = new List<SA41Team_10B_SportsBookingFacility.CustomerBook>();
            //foreach (SA41Team_10B_SportsBookingFacility.BookingTranLayer b in BookingList)
            //{
            //    cusNameList.Add(Bookingcontroller.GetCustomer(b.CustomerID));
            //}

            //dgvBookingList.Columns["status"].Visible = false;
            //MessageBox.Show(cusNameList.Count.ToString());

            //for (int i = 0; i < cusNameList.Count; i++)
            //{
            //    //MessageBox.Show(cusNameList[i].Name.ToString());
            //    //dgvBookingList.Rows.Add(cusNameList[i].Name.ToString());
            //    MessageBox.Show(dgvBookingList.Rows[i].Cells[2].Value.ToString());
            //    MessageBox.Show(cusNameList[i].Name.ToString());
            //    dgvBookingList.Rows[i].Cells[2].Value = cusNameList[i].Name.ToString();
            //}

            dgvBookingList.Refresh();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if ((cmbCustName.SelectedIndex == -1) || (cmbFacilites.SelectedIndex == -1))
            {
                MessageBox.Show("Select Customer Name & Facilites...");
            }
            else
            {
                try
                {
                    int cusId = Convert.ToInt32(cmbCustName.SelectedValue.ToString());
                    string facID = cmbFacilites.SelectedValue.ToString();
                    DateTime tempDate = Convert.ToDateTime(dtpIssueDate.Value.ToShortDateString());
                    //List<SA41Team_10B_SportsBookingFacility.BookingTranLayer> bt = new List<SA41Team_10B_SportsBookingFacility.BookingTranLayer>();
                    List<SA41Team_10B_SportsBookingFacility.BookingGridData> bt = new List<SA41Team_10B_SportsBookingFacility.BookingGridData>();

                    bt = Bookingcontroller.GetSearchGridData(facID, cusId, tempDate);


                    dgvBookingList.DataSource = bt;
                    dgvBookingList.Refresh();
                    dgvBookingList.AutoResizeColumns();

                    if (bt.Count == 0)
                    {
                        MessageBox.Show("No Booking Transaction Found for the Searched Criteria...");
                    }
                }
                catch (Exception ex)
                {
                    //show the error in the status  
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    //SA41Team10b_Form.BookingListForm frm = new SA41Team10b_Form.BookingListForm();
                    //frm.Show();
                    //this.Close();
                }
            }
        }

        private void BtnNewBooking_Click(object sender, EventArgs e)
        {
             
            SA41Team_10B_SportsBookingFacility.NewBookingForm nbf = new SA41Team_10B_SportsBookingFacility.NewBookingForm();
            nbf.Show();
            this.Hide();
        }

        private void btnListAll_Click(object sender, EventArgs e)
        {
            //List<SA41Team_10B_SportsBookingFacility.BookingTranLayer> BookingList = new List<SA41Team_10B_SportsBookingFacility.BookingTranLayer>();
            //BookingList = Bookingcontroller.GetAllBookings();

            List<SA41Team_10B_SportsBookingFacility.BookingGridData> BookingGridList = new List<SA41Team_10B_SportsBookingFacility.BookingGridData>();
            BookingGridList = Bookingcontroller.GetGridData();

            dgvBookingList.DataSource = BookingGridList;

            dgvBookingList.DataSource = BookingGridList;
            dgvBookingList.Columns["BookName"].HeaderText = "Customer Name";

            dgvBookingList.AutoResizeColumns();

            dgvBookingList.Columns["BookFacilityname"].HeaderText = "Facility";

            dgvBookingList.Columns["BookTimeSlot"].HeaderText = "Time Slot";
            dgvBookingList.Columns["BookIssueDate"].HeaderText = "Booked Date";
            dgvBookingList.Columns["BookCustomerId"].Visible = false;
            dgvBookingList.Columns["BookSlotId"].Visible = false;
            dgvBookingList.Columns["BookFacilityId"].Visible = false;


        }
    }
}
