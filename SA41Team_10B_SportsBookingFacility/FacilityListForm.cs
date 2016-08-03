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
    public partial class FacilityListForm : Form
    {
        SA41Team_10B_SportsBookingFacility.FacilityBookingEntities ctx = new SA41Team_10B_SportsBookingFacility.FacilityBookingEntities();
        public string SelectedFac
        {
            get
            {
                return dgvFacilityList.CurrentRow.Cells[0].Value.ToString();
            }
        }
        public FacilityListForm()
        {
            InitializeComponent();
            var query = from x in ctx.Facilities select new { x.FacilityId, x.Name, x.Remarks };
            var fac = query.ToList();
            dgvFacilityList.DataSource = fac;
        }

        private void dgvFacilityList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FacilityDetailForm fdl = new FacilityDetailForm();
            fdl.TXTFacilityID = SelectedFac;
            var query = from x in ctx.Facilities where x.FacilityId == fdl.TXTFacilityID select x;
            SA41Team_10B_SportsBookingFacility.Facility fac = new SA41Team_10B_SportsBookingFacility.Facility();
            fac = query.First();

            fdl.TXTFacilityID = fac.FacilityId;
            fdl.TXTName = fac.Name;
            fdl.TXTRemarks = fac.Remarks;
            fdl.ShowDialog();

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            var query = from x in ctx.Facilities where x.Name == comboBox1.Text select new { x.FacilityId, x.Name, x.Remarks };
            var fac = query.ToList();
            dgvFacilityList.DataSource = fac;
     
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            var query = from x in ctx.Facilities select new { x.FacilityId, x.Name, x.Remarks };
            var fac = query.ToList();
            dgvFacilityList.DataSource = fac;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

            SA41Team_10B_SportsBookingFacility.blankfacilityform m = new SA41Team_10B_SportsBookingFacility.blankfacilityform();
            m.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FacilityListForm_Load(object sender, EventArgs e)
        {
            var query = from x in ctx.Facilities select new {x.Name,x.FacilityId};
            var fac = query.ToList();

            for (int i = 0; i < fac.Count; i++)
            {
                comboBox1.Items.Add(fac[i].Name.ToString());
                comboBox1.ValueMember = fac[i].FacilityId.ToString();
            }
        }
    }
}
