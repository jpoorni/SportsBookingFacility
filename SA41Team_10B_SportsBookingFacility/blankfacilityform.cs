using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA41Team_10B_SportsBookingFacility
{
    public partial class blankfacilityform : Form
    {
        FacilityBookingEntities ctx = new FacilityBookingEntities();
        public blankfacilityform()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SA41Team_10B_SportsBookingFacility.Facility f1 = new SA41Team_10B_SportsBookingFacility.Facility();
            f1.FacilityId = txtFacilityID.Text;
            f1.Name = txtName.Text;
            f1.Remarks = txtRemarks.Text;

            //var query = from x in ctx.Facilities where x.Name == txtFacilityID.Text select x.FacilityId.Max();



            bool acceptData = true;
            int count = 0;
            label4.Text = "";
            txtFacilityID.MaxLength = 5;
            if (txtFacilityID.Text.Length > 5)
            {
                count = count + 1;
                acceptData = false;
                MessageBox.Show("Over the length");

            }
            var query = from x in ctx.Facilities select new { x.FacilityId };
            var unique = query.ToArray();
            for (int i = 0; i < unique.Length; i++)
            {
                if (txtFacilityID.Text == unique[i].FacilityId.ToString())
                {
                    MessageBox.Show("the facilityID should be unique");
                    acceptData = false;
                    break;
                }

                //MessageBox.Show(unique[i].FacilityId.ToString());
            }
            if (txtFacilityID.Text == "")
            {
                label4.Text = "Fill in the faacilityID...";
                acceptData = false;
                count = count + 1;
                txtFacilityID.Focus();
            }
            if (txtName.Text.Length > 20)
            {
                count = count + 1;
                acceptData = false;
                MessageBox.Show("Over the length");

            }
            if (txtName.Text == "")
            {
                label4.Text = "Fill in the name. ...";
                count = count + 1;
                acceptData = false;
                txtFacilityID.Focus();
            }
            if (txtRemarks.Text.Length > 255)
            {
                count = count + 1;
                acceptData = false;
                MessageBox.Show("Over the length");

            }



            if (count > 1)
            {
                label4.Text = "Required fields cannot be empty.";
            }

            if (acceptData == true)
            {
                f1.FacilityId = txtFacilityID.Text;
                f1.Remarks = txtRemarks.Text;
                ctx.Facilities.Add(f1);
                ctx.SaveChanges();
                MessageBox.Show("All data are validated...");
                this.Close();
            }
            else
                MessageBox.Show("Data validation Error!!!...");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
