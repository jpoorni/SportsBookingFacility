using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SA41Team_10B_SportsBookingFacility;


namespace SA41Team10b_Form
{
    public partial class frmMain : Form
    {

        //public Boolean showForm = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (showForm == false)
            {
                CustomerListForm child1 = new CustomerListForm();
                child1.MdiParent = this;
                child1.Show();
                //showForm = true;
            }
        }

        private void searchByCustomerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (showForm == false)
            {
                CustomerListForm child1 = new CustomerListForm();
                child1.MdiParent = this;
                child1.Show();
                //showForm = true;
            }
        }

        private void memberInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (showForm == false)
            {
                CustomerListForm child1 = new CustomerListForm();
                child1.MdiParent = this;
                child1.Show();
                //this.LayoutMdi(MdiLayout.Cascade);
                //child1.Dock = DockStyle.Left;
                //showForm = true;
            }
        }

        private void sportsFacilitiesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (showForm == false)
            {
                FacilityListForm child1 = new FacilityListForm();
                child1.MdiParent = this;
                child1.Show();
                //showForm = true;
            }

        }

        private void bookingOfFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (showForm == false)
            {
                BookingListForm child1 = new BookingListForm();
                child1.MdiParent = this;
                child1.Show();
                //showForm = true;
            }
        }

        private void cancelABookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (showForm == false)
            {
                BookingListForm child1 = new BookingListForm();
                child1.MdiParent = this;
                child1.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void reportListOfMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemberReportForm members = new MemberReportForm();
            members.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CustomerListForm child1 = new CustomerListForm();
            child1.MdiParent = this;
            child1.Show();
        }

        private void manageMentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TrendByFacilityForm1 form1 = new TrendByFacilityForm1();
            form1.Show();
        }

        private void transactionOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrendByWeekDayForm fm = new TrendByWeekDayForm();
            fm.Show();
        }

        private void chartReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
             CrossTabFacilityWeekDayForm f = new CrossTabFacilityWeekDayForm();
            f.Show();
        }
    }
}

