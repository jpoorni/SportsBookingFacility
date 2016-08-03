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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string TextBoxName
        {
            set { this.txtName.Text = value; }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //textBox1.Text = f.SelectedCust;
        }
    }
}
