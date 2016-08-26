using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1
{
    // event handler
    
    public partial class CustomerCard : Form
    {
        //hanlder define
        public event CloseSaveEvent CloseSave;

        // Create a class and enter the data from USER
        ourCustomer customer;

        //new verison
        public CustomerCard(ourCustomer ourcustomer)
        {
            InitializeComponent();
            customer = ourcustomer;
            labelCustomerID.Text = ourcustomer.CustomerId.ToString();
            // To get customer data
            textBoxFirstName.Text = ourcustomer.FirstName;
            textBoxLastName.Text = ourcustomer.LastName;
            textBoxEmail.Text = ourcustomer.Email;
            textBoxMemberCard.Text = ourcustomer.MemberCard;
            textBoxPhone.Text = ourcustomer.Phone;
            textBoxmoblie.Text = ourcustomer.Mobile;
            textBoxFax.Text = ourcustomer.Fax;
            textBoxwebsite.Text = ourcustomer.Website;
            //DOB
            dateTimePickerDOB.Value = DateTime.Parse(ourcustomer.DOB);
            //Boolean
            checkBoxLoyaltyMember.CheckState = (ourcustomer.LoyaltyMember.CompareTo("true") == 0) ? CheckState.Checked : CheckState.Unchecked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ourCustomer customernewinof = new ourCustomer(customer.CustomerId); //TODO: customer id
            customernewinof.FirstName = textBoxFirstName.Text;
            customernewinof.LastName = textBoxLastName.Text;
            customernewinof.Email = textBoxEmail.Text;
            customernewinof.DOB = dateTimePickerDOB.Value.ToString("yyyy-MM-dd"); // make it fit to MS SQL
            customernewinof.MemberCard = textBoxMemberCard.Text;
            customernewinof.LoyaltyMember = (checkBoxLoyaltyMember.Checked) ? "true" : "false";
            customernewinof.Phone = textBoxPhone.Text;
            customernewinof.Mobile = textBoxmoblie.Text;
            customernewinof.Fax = textBoxFax.Text;
            customernewinof.Website = textBoxwebsite.Text;
            //Todo: update to Database
            if (customer.SaveCustomer(customernewinof))
            {
                System.Windows.Forms.MessageBox.Show("Record was updated sucessful!");
                CloseSave(sender, e);
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Record was updated failed!");
            }
        }

        private void labelCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
