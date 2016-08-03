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

namespace SA41Team10b_Form
{
    public partial class CustomerDetailForm : Form
    {

        SA41Team_10B_SportsBookingFacility.FacilityBookingEntities ctx = new SA41Team_10B_SportsBookingFacility.FacilityBookingEntities();
        SA41Team_10B_SportsBookingFacility.Customer cusobj;
        SA41Team_10B_SportsBookingFacility.CustomerController cusctrl = new SA41Team_10B_SportsBookingFacility.CustomerController();
        public SA41Team_10B_SportsBookingFacility.Customer CUSOBJ
        {
            set
            {
                this.cusobj = value;
            }
        }
        private void CustomerDetailForm_Load(object sender, EventArgs e)
        {
            //when we view the information, making user can not change the information
            //unable the textbox
            txtCustName.Enabled = false;
            dtDOB.Enabled = false;
            optMale.Enabled = false;
            optFemale.Enabled = false;
            txtNRIC.Enabled = false;
            txtAddress.Enabled = false;
            txtPostalCode.Enabled = false;
            txtPhoneNo.Enabled = false;
            txtEmail.Enabled = false;
            txtRemarks.Enabled = false;
        }
        public string TXTCustName
        {
            get
            {

                return this.txtCustName.Text;
            }
            set
            {
                this.txtCustName.Text = value;
            }

        }

        public string TXTNRIC
        {
            get
            {
                return this.txtNRIC.Text;
            }
            set
            {
                this.txtNRIC.Text = value;
            }
        }

        public string TXTAddress
        {
            get
            {
                return this.txtAddress.Text;
            }
            set
            {
                this.txtAddress.Text = value;
            }
        }


        public string TXTPostalCode
        {
            get
            {
                return this.txtPostalCode.Text;
            }
            set
            {
                this.txtPostalCode.Text = value;
            }
        }

        public string TXTPhoneNo
        {
            get
            {
                return this.txtPhoneNo.Text;
            }
            set
            {
                this.txtPhoneNo.Text = value;
            }
        }

        public string TXTEmail
        {
            get
            {
                return this.txtEmail.Text;
            }
            set
            {
                this.txtEmail.Text = value;
            }
        }

        public string TXTRemarks
        {
            get
            {
                return this.txtRemarks.Text.Trim();
            }
            set
            {
                this.txtRemarks.Text = value;
            }
        }

        public DateTime DTDOB
        {
            get
            {
                return this.dtDOB.Value.Date;
            }
            set
            {
                this.dtDOB.Value = value;
            }
        }
        public string Gender
        {
            set
            {
                if (value == "M")
                {
                    this.optMale.Checked = true;
                    this.optFemale.Checked = false;
                }
                else
                {
                    this.optMale.Checked = false;
                    this.optFemale.Checked = true;
                }
            }
            get
            {
                return this.Gender;
            }
        }

        public CustomerDetailForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            var updatequery = from x in ctx.Customers where x.CustomerID == cusobj.CustomerID select x;
            var updatecus = updatequery.First();
            updatecus.Name = txtCustName.Text;
            updatecus.DOB = dtDOB.Value;
            if (optFemale.Checked)
            {
                updatecus.Gender = "F";
            }
            else
            {
                updatecus.Gender = "M";
            }
            updatecus.NRIC = txtNRIC.Text;
            updatecus.Address = txtAddress.Text;
            updatecus.PostalCode = txtPostalCode.Text;
            updatecus.Phoneno = txtPhoneNo.Text;
            updatecus.Email = txtEmail.Text;
            updatecus.Remarks = txtRemarks.Text.Trim();
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
            else if (txtNRIC.Text.Length <9 )
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
            else if (txtPostalCode.Text.Length < 6)
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

            if ((acceptData == true) && (cusctrl.NewCustomerValidation(cusobj)))
            {
                MessageBox.Show("All data are validated.");
                ctx.SaveChanges();
                MessageBox.Show("Update Successfully");
               
                CustomerListForm clf = new CustomerListForm();
                clf.Show();
                clf.Focus();
                clf.TopMost = false;
                this.Close();
            }
            else
                MessageBox.Show("Data validation Error.");
        }
       
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //when click edit button , enable the button
           
            txtCustName.Enabled = true;
            dtDOB.Enabled = true;
            optMale.Enabled = true;
            optFemale.Enabled = true;
            txtNRIC.Enabled = true;
            txtAddress.Enabled = true;
            txtPostalCode.Enabled = true;
            txtPhoneNo.Enabled = true;
            txtEmail.Enabled = true;
            txtRemarks.Enabled = true;

        }

        private void txtCustName_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //customer name can accept only letters
            if (!char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtPostalCode_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //postal code can accept only numbers 
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void txtPhoneNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            //phone no can accept only numbers 
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerListForm clf = new CustomerListForm();
            clf.Show();
            clf.Focus();

        }

    

    }
}
