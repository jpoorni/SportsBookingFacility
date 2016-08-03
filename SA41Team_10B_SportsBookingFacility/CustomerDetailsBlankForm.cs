using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SA41Team_10B_SportsBookingFacility
{
    public partial class CustomerDetailsBlankForm : Form
    {
        SA41Team_10B_SportsBookingFacility.FacilityBookingEntities ctx = new SA41Team_10B_SportsBookingFacility.FacilityBookingEntities();

        public CustomerDetailsBlankForm()
        {
            InitializeComponent();
        }

        private void CustomerDetailsBlankForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SA41Team_10B_SportsBookingFacility.Customer cus = new SA41Team_10B_SportsBookingFacility.Customer();
            SA41Team_10B_SportsBookingFacility.CustomerController cusctrl = new SA41Team_10B_SportsBookingFacility.CustomerController();
            cus.Name = txtCustName.Text;
            cus.DOB = dtDOB.Value.Date;
            if (optMale.Checked)
            {
                cus.Gender = "M";
            }
            else
            {
                cus.Gender = "F";
            }
            cus.NRIC = txtNRIC.Text;
            cus.Address = txtAddress.Text;
            cus.PostalCode = txtPostalCode.Text;
            cus.Phoneno = txtPostalCode.Text;
            cus.Email = txtEmail.Text;
            cus.Remarks = txtRemarks.Text;
            cus.Custstatus = true;
            // no empty values for required fields
           
            bool acceptData = true;
            int count = 0;
            lblvalidate.Text = "";

            if (txtCustName.Text == "")
            {
                lblvalidate.Text = "Fill in the Name.";
                acceptData = false;
                count = count + 1;
                txtCustName.Focus();
            }
            if (txtPhoneNo.Text == "")
            {
                lblvalidate.Text = "Fill in the Mobile No.";
                count = count + 1;
                acceptData = false;
                txtPhoneNo.Focus();
            }
            if (this.txtEmail.Text == "")
            {
                lblvalidate.Text = "Fill in the Email.";
                count = count + 1;
                acceptData = false;
                txtEmail.Focus();
            }
            else
            {
                //email validation
                string email = txtEmail.Text;

                string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                 @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                 @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

                Regex re = new Regex(strRegex);
                if (re.IsMatch(email) == false)
                {
                    lblvalidate.Text = "Invalid email address";
                    acceptData = false;
                    txtEmail.Focus();
                }

            }
            //length validation
            txtCustName.MaxLength = 30;
            if (txtCustName.Text.Length > 30)
            {
                MessageBox.Show("Customer name cannot be more than 30 characters!!!");
                count = count + 1;
                acceptData = false;
                txtCustName.Focus();
            }


            txtNRIC.MaxLength = 9;
            if (txtNRIC.Text.Length > 9)
            {
                MessageBox.Show("NRIC should be 9 characters!!!");
                count = count + 1;
                acceptData = false;
                txtNRIC.Focus();
            }
            else if (txtNRIC.Text.Length < 9)
            {
                MessageBox.Show("NRIC should be 9 characters!!!");
                count = count + 1;
                acceptData = false;
                txtNRIC.Focus();
            }

            txtAddress.MaxLength = 255;
            if (txtAddress.Text.Length > 255)
            {
                MessageBox.Show("Address cannot be more than 255 characters!!!");
                count = count + 1;
                acceptData = false;
                txtAddress.Focus();
            }

            txtPostalCode.MaxLength = 6;
            if (txtPostalCode.Text.Length > 6)
            {
                MessageBox.Show("Postal Code should be 6 characters");
                count = count + 1;
                acceptData = false;
                txtPostalCode.Focus();
            }
            else if (txtPostalCode.Text.Length < 6 )
            {
                MessageBox.Show("Postal Code should be 6 characters");
                count = count + 1;
                acceptData = false;
                txtPostalCode.Focus();
            }

            txtPhoneNo.MaxLength = 8;
            if (txtPhoneNo.Text.Length > 8)
            {
                MessageBox.Show("Phone no digits should be 8.");
                count = count + 1;
                acceptData = false;
                txtPhoneNo.Focus();
            }
            else if (txtPhoneNo.Text.Length < 8)
            {
                MessageBox.Show("Phone no digits should be 8.");
                count = count + 1;
                acceptData = false;
                txtPhoneNo.Focus();
            }


            txtEmail.MaxLength = 50;
            if (txtEmail.Text.Length > 50)
            {
                MessageBox.Show("Email address cannot be more than 50 characters!!!.");
                count = count + 1;
                acceptData = false;
                txtEmail.Focus();
            }

            txtRemarks.MaxLength = 255;
            if (txtRemarks.Text.Length > 255)
            {
                MessageBox.Show("Remarks cannot be more than 255 characters!!!x.");
                count = count + 1;
                acceptData = false;
                txtRemarks.Focus();
            }

            if (count > 1)
            {
                lblvalidate.Text = "Required fields cannot be empty.";
            }
            if ((acceptData == true) && (cusctrl.NewCustomerValidation(cus)))
            {
                MessageBox.Show("All data are validated.");
                ctx.Customers.Add(cus);
                ctx.SaveChanges();
                MessageBox.Show("Save Successfully");
                this.Close();
                SA41Team10b_Form.CustomerListForm clf = new SA41Team10b_Form.CustomerListForm();
                clf.Show();
                clf.Focus();
            }
            else
                MessageBox.Show("Data validation Error.");
        }
        private void txtCustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //customer name can accept only letters
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
               
            }
        }
        private void txtPostalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //postal code can accept only numbers 
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //phone no can accept only numbers 
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
    }
}
