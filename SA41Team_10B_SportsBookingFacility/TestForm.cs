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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            FacilityBookingEntities ctx = new FacilityBookingEntities();

            //to select only few colums from customer table 
            //var query = from x in ctx.Customers select new { x.CustomerID,x.DOB,x.Email};
            //var cus = query.ToList();
            //dataGridView1.DataSource = cus;

            //selecting colums from various tables
            var query = from b in ctx.BookingTrans
                    join c in ctx.Customers on b.CustomerId equals c.CustomerID
                    select new {c.Name,b.SlotId,b.FacilityId,b.IssueDate};
            var cus = query.ToList();
            dataGridView1.DataSource = cus;

            //to display all columns of the table in the grid
            //var query = from x in ctx.Customers select x;
            //var cus = query.ToList();
            //dataGridView1.DataSource = cus;

            //to display the colmns of our interest
            //dataGridView1.Columns["CustomerId"].Visible = false;
            ////to change the column heading
            //dataGridView1.Columns["PhoneNo"].HeaderText = "Contact No";

            ////to make the entire row selected
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //to display one row of the table in the form controls
            //Customer cus = query.First();
            //label1.Text = cus.CustomerId.ToString();
            //label2.Text = cus.Name.ToString();

          
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //label2.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            Form2 f = new Form2();
            f.TextBoxName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.Show();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
