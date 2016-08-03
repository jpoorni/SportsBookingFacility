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
    public partial class CustomerListForm : Form
    {
        public SA41Team_10B_SportsBookingFacility.FacilityBookingEntities ctx = new SA41Team_10B_SportsBookingFacility.FacilityBookingEntities();
        public CustomerListForm()
        {
            InitializeComponent();
        }

        SA41Team_10B_SportsBookingFacility.Customer cus;
        public string SelectedCust
        {
            get
            {
                return dgvCusList.CurrentRow.Cells[0].Value.ToString();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            var query = from x in ctx.Customers where x.Custstatus==true select new { x.Name, x.Phoneno, x.Email };
            var cus = query.ToList();
            dgvCusList.DataSource = cus;
            
        }
        
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var searchquery = from x in ctx.Customers where x.Name == txtCustNamese.Text  select new { x.Name, x.Phoneno, x.Email };
            var cus = searchquery.ToList();
            if (cus.Count == 0)
            {
                MessageBox.Show("Customer Name does not exist!!!");
            }
                dgvCusList.DataSource = cus;
          
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            SA41Team_10B_SportsBookingFacility.CustomerDetailsBlankForm cdf = new SA41Team_10B_SportsBookingFacility.CustomerDetailsBlankForm();
            cdf.Show();
            this.Hide();
            this.LayoutMdi(MdiLayout.Cascade);
            cdf.Dock = DockStyle.Left;
        }

        private void dgvCusList_DoubleClick(object sender, EventArgs e)
        {
            CustomerDetailForm cdf = new CustomerDetailForm();
            cdf.TXTCustName = SelectedCust;
            var query = from x in ctx.Customers where x.Name == cdf.TXTCustName select x;

            cus = new SA41Team_10B_SportsBookingFacility.Customer();
            cus = query.First();
            cdf.TXTNRIC = cus.NRIC;
            cdf.Gender = cus.Gender;
            cdf.TXTAddress = cus.Address;
            cdf.TXTPostalCode = cus.PostalCode;
            cdf.TXTPhoneNo = cus.Phoneno;
            cdf.TXTEmail = cus.Email;
            cdf.TXTRemarks = cus.Remarks.Trim();
            cdf.DTDOB = cus.DOB.Value;
            cdf.CUSOBJ = cus;
            cdf.ShowDialog();
            this.Hide();
            this.LayoutMdi(MdiLayout.Cascade);
            cdf.Dock = DockStyle.Left;
        }

        private void txtCustNamese_KeyPress(object sender, KeyPressEventArgs e)
        {
            //customer name can accept only letters
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;

            }
        }

        private void CustomerListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //showForm = true;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            SA41Team_10B_SportsBookingFacility.MemberReportForm members = new SA41Team_10B_SportsBookingFacility.MemberReportForm();
            members.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
           SA41Team_10B_SportsBookingFacility.Customer deltcus=new SA41Team_10B_SportsBookingFacility.Customer();
           var deletequery = from x in ctx.Customers where x.Name == SelectedCust select x;
           deltcus= deletequery.First();
            deltcus.Custstatus=false;
            ctx.SaveChanges();
            MessageBox.Show("Customer information deleted sucessefully!!!");
        }
    }
}
