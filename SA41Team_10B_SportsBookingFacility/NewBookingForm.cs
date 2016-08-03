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

namespace SA41Team_10B_SportsBookingFacility
{
    public partial class NewBookingForm : Form
    {
        BookingTranController Bookingcontroller;

        //FacilityBookingEntities ctx = new FacilityBookingEntities();
        //SqlConnection cn;
        //SqlCommand cm;
        //SqlParameter pFID, pIDate;


        public NewBookingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string conS = "data source=(local);integrated security=SSPI;initial catalog=FacilityBooking";
            //cn = new SqlConnection(conS);
            //cm = new SqlCommand();
            //cm.Connection = cn;

            ////to select all columns from facilities table 

            ////var query = from x in ctx.Facilities select x.FacilityId;
            ////var query = from x in ctx.Facilities select x.Name;
            //var query = from x in ctx.Facilities select x;
            //var fac = query.ToList();

            //cmbFacilities.DataSource = fac ;
            //cmbFacilities.DisplayMember = "Name".ToString();
            //cmbFacilities.ValueMember = "FacilityId";

            //to clear the status label
            staLabel.Text = "";

            //to add the facilities data to the combo box
            FacilityBroker fb = new FacilityBroker();
            List<FacilityBooking> facilityList = new List<FacilityBooking>();

            facilityList = fb.GetAllFacilites();
            cmbFacilities.DataSource = facilityList;
            cmbFacilities.DisplayMember = "Name".ToString();
            cmbFacilities.ValueMember = "FacilityId";

            //foreach (FacilityBooking fac in facilityList)
            //{
            //    //MessageBox.Show(cus.Name);
            //    this.cmbFacilities.Items.Add(fac.Name);
            //    this.cmbFacilities.ValueMember = fac.FacilityID;
            //    //MessageBox.Show(cmbFacilities.ValueMember);
            //}

            this.cmbFacilities.SelectedIndex = 0;

            //to add the customer data to the combo box
            CustomerBroker cb = new CustomerBroker();
            List<CustomerBook> customerList = new List<CustomerBook>();
            customerList = cb.GetAllCustomers();
            cmbCustName.DataSource = customerList;
            cmbCustName.DisplayMember = "Name".ToString();
            cmbCustName.ValueMember = "CustomerID";
            cmbCustName.SelectedIndex = -1;

            //foreach (CustomerBook cus in customerList)
            //{
            //    //MessageBox.Show(cus.Name);
            //    cmbCustName.Items.Add(cus.Name);
            //    cmbCustName.ValueMember = cus.CustomerID.ToString();
            //    //MessageBox.Show(cus.CustomerID.ToString());
            //}



            //cm.CommandText = "select name,customerid from customers where custstatus = 1";
            //cn.Open();

            //DataTable dt = new DataTable();
            //dt.Load(cm.ExecuteReader());
            //cmbCustName.DataSource = dt;

            //cmbCustName.DisplayMember = "Name";
            //cmbCustName.ValueMember = "CustomerID";
            //cmbCustName.SelectedIndex = -1;
            //cmbCustName.SelectedIndex = 1;
           
        }
        bool chk = false;
        

        private void btnAvailability_Click(object sender, EventArgs e)
        {

            Bookingcontroller = new BookingTranController();
            string fId = this.cmbFacilities.SelectedValue.ToString();
            DateTime iDate = Convert.ToDateTime(this.dtpIssueDate.Value.ToShortDateString());

            List<SlotBooking> slotList = new List<SlotBooking>();
            slotList = Bookingcontroller.FindAvailableSlots(fId, iDate);

            dataGridView1.DataSource = slotList;
            //dataGridView1.DataMember = "TimeSlot".ToString();
            dataGridView1.Refresh();
            
            //pFID = new SqlParameter("@pFID", SqlDbType.NVarChar,5);
            //pIDate = new SqlParameter("@pIDate",SqlDbType.DateTime);

            //cm.Parameters.Add(pFID);
            //cm.Parameters.Add(pIDate);

            ////pFID.Value = this.cmbFacilities.SelectedValue.ToString();
            //pFID.Value = this.cmbFacilities.SelectedValue.ToString();

            //pIDate.Value = Convert.ToDateTime(this.dtpIssueDate.Value.ToShortDateString());

            ////cm.CommandText = "select * from Slots where SlotId not in (select SlotId from BookingTran where FacilityId = @pFID and IssueDate = '2015-10-17 00:00:00.000')";
            //cm.CommandText = "select * from Slots where SlotId not in (select SlotId from BookingTran where FacilityId = @pFID and IssueDate = @pIDate)";
            

            //DataTable dt  = new DataTable();
            //dt.Load(cm.ExecuteReader());
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();



            if (chk == false)
            {
                dataGridView1.Columns["slotid"].Visible = false;
                //to change the column heading
                dataGridView1.Columns["timeslot"].HeaderText = "Available slots";
                dataGridView1.Columns["timeslot"].Width = 200;
                chk = true;

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "";
                checkBoxColumn.Width = 30;
                checkBoxColumn.Name = "checkBoxColumn";
                dataGridView1.Columns.Insert(0, checkBoxColumn);
            }

            //cm.Parameters.Remove(pFID);
            //cm.Parameters.Remove(pIDate);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbCustName.SelectedValue.ToString());
        }

        private void cmbFacilities_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnBooking_Click(object sender, EventArgs e)
        {
            int count = 0;
            string tempSlotID = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkBoxColumn"].Value);
                if (isSelected)
                {
                    tempSlotID = row.Cells["slotid"].Value.ToString();
                    count++;
                }
            }

            //validation
            //allowing only selection of time slot 
            bool validate = true;
            if (count == 0)
            {
                //MessageBox.Show("Select atleast one Time Slot to book");
                this.staLabel.Text = "Select atleast one Time Slot to book!!!";
                validate = false;
            }
            else if (count > 1)
            {
                //MessageBox.Show("Select only one Time Slot to book");
                this.staLabel.Text = "Select only one Time Slot to book!!!";
                validate = false;
            }

            //MessageBox.Show(cmbCustName.SelectedIndex.ToString());
            //customer is selected
            if (cmbCustName.SelectedIndex == -1)
            {
                //MessageBox.Show("Select Customer to book");
                this.staLabel.Text = "Select Customer to book";
                validate = false;
            }
            //check for facility & customer they are selected before booking & only one day of booking

            while (validate == true)
            {
                try
                {
                    Bookingcontroller = new BookingTranController();
                    //get the customer,slot,facility idsbt
                    BookingTranLayer bt = new BookingTranLayer();
                    bt.CustomerID = Convert.ToInt32(cmbCustName.SelectedValue.ToString());
                    bt.FacilityId = cmbFacilities.SelectedValue.ToString();
                    bt.SlotID = tempSlotID;
                    bt.Issuedate = Convert.ToDateTime(this.dtpIssueDate.Value.ToShortDateString());
                    //bt.Issuedate = Convert.ToDateTime("2015/10/18");
                    bt.Status = true; //defalut to true while booking

                    Bookingcontroller.BookedToCustomer(bt);
                    //MessageBox.Show("Booking Successful...");
                    staLabel.Text = "Booking Successful...";
                    validate = false;
                }

                catch (Exception ex)
                {
                    //show the error in the status  
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    SA41Team10b_Form.BookingListForm frm = new SA41Team10b_Form.BookingListForm();
                    frm.Show();
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            SA41Team10b_Form.BookingListForm blf = new SA41Team10b_Form.BookingListForm();
            blf.Show();
            blf.Focus();


        }
    }
}
