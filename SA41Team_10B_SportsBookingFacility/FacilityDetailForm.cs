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
    public partial class FacilityDetailForm : Form
    {
        SA41Team_10B_SportsBookingFacility.FacilityBookingEntities ctx = new SA41Team_10B_SportsBookingFacility.FacilityBookingEntities();
     
        SA41Team_10B_SportsBookingFacility.Facility fac;
        public SA41Team_10B_SportsBookingFacility.Facility FACOBJ
        {

            set
            {
                this.fac = value;
            }
        }



        public string TXTFacilityID
        {

            get
            {

                return this.txtFacilityID.Text;
            }
            set
            {
                this.txtFacilityID.Text = value;
            }
        }

        public string TXTName
        {
            get
            {

                return this.txtName.Text;
            }
            set
            {
                this.txtName.Text = value;
            }
        }

        public string TXTRemarks
        {
            get
            {

                return this.txtRemarks.Text;
            }
            set
            {
                this.txtRemarks.Text = value;
            }
        }
        public FacilityDetailForm()
        {
            InitializeComponent();
        }

        private void FacilityDetailForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SA41Team_10B_SportsBookingFacility.Facility f1 = new SA41Team_10B_SportsBookingFacility.Facility();

            // ctx .Facilities.Add
            //////f1.Name = textBox1.Text;
            ////////var query = from x in ctx.Facilities where x .Name == textBox1 .Text select x .FacilityId.Max () ;

            //////var query = from x in ctx.Facilities select  x.FacilityId.Max();
            //////MessageBox.Show(query.ToString());
            ////////f1.FacilityId = query.ToString()+ 1;

            //////var query = from x in ctx.Customers select new { x.CustomerID, x.DOB, x.Email };
            //var cus = query.ToList();
            //dataGridView1.DataSource = cus;

            //f1.FacilityId = txtFacilityID.Text;
            f1.FacilityId = "6001";
            f1.Name = txtFacilityID.Text;

            ctx.Facilities.Add(f1);
            ctx.SaveChanges();
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            //var updatecus = updatequery.First();
            var updatequery = from x in ctx.Facilities where x.FacilityId == this.txtFacilityID.Text select x;

            //MessageBox.Show(updatequery.ToString());
            var updatefac = updatequery.First();


            updatefac.FacilityId = txtFacilityID.Text;
            updatefac.Name = txtName.Text;
            updatefac.Remarks = txtRemarks.Text;
            ctx.SaveChanges();
            MessageBox.Show("save successfully");
            this.Close();
        }
    }
}
