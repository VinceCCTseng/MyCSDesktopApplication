using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Classes; // myClasses

namespace WindowsFormsApplication1
{

    public partial class NewCard : Form
    {
        public event CloseSaveEvent CloseSave;
        private Boolean isInformationVaild = false;
        // Create a class and enter the data from USER
        ourCustomer customer = new ourCustomer(); //New Member without any parameter
        public NewCard()
        {
            InitializeComponent();
        }

        private void AddNew_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Todo: create a customer class and set up the vaild data.
            if (isInformationVaild == true && textBoxMemberCard.Text != null)
            {
                customer.FirstName = textBoxFirstName.Text;
                customer.LastName = textBoxLastName.Text;
                customer.Email = textBoxEmail.Text;
                customer.Website = textBoxwebsite.Text;
                customer.DOB = dateTimePickerDOB.Value.ToString("yyyy-MM-dd"); // make it fit to MS SQL
                customer.MemberCard = textBoxMemberCard.Text;
                customer.LoyaltyMember = (checkBoxLoyaltyMember.Checked)?"true":"false";
                customer.Phone = textBoxPhone.Text;
                customer.Mobile = textBox1moblie.Text;
                customer.Fax = textBoxFax.Text;

                //2. Update  
                if (customer.SaveCustomer())
                {
                    System.Windows.Forms.MessageBox.Show("Record was updated sucessful!");
                    CloseSave(sender,e);
                    // 3. Check for account, if user does not have one, ask for create one
                    // 3.1 check data base by membercard
                    try
                    {
                        sqlAccess useraccountcheck = new sqlAccess();
                        if (!useraccountcheck.IsUserExist(customer.MemberCard))
                        {
                            var confirmfeedback = MessageBox.Show("The member do not have a account. Do you want to create it?", "User create!", MessageBoxButtons.YesNo);
                            if (confirmfeedback == DialogResult.Yes)
                            {
                                CreateNewUserAccount newuseracc = new CreateNewUserAccount(customer.MemberCard);
                                newuseracc.Owner = this;
                                newuseracc.ShowDialog();
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Cannot connect with sql server!");
                    }

                    this.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Record was updated failed!");
                }              
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("There is/are some data invaild. Please check the data again!");
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (checkVaildEmail(textBoxEmail.Text))
            {
                emailErrorProvider.Clear();
                isInformationVaild = true;
            }
            else
            {
                emailErrorProvider.SetError(textBoxEmail, "need a vaild email address.");
                isInformationVaild = false;
            }
            



        }
        private Boolean checkVaildEmail(string email)
        {
            if (email.Contains('@') && email.Contains('.'))
                return true;
            else
                return false;
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != null && textBoxFirstName.Text.Length <= 25)
            {
                nameErrorProvider.Clear();
                isInformationVaild = true;
            }
            else
            {
                nameErrorProvider.SetError(textBoxEmail, "need a vaild name.");
                isInformationVaild = false;
            }
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLastName.Text != null && textBoxLastName.Text.Length <= 25)
            {
                nameErrorProvider.Clear();
                isInformationVaild = true;
            }
            else
            {
                nameErrorProvider.SetError(textBoxEmail, "need a vaild name.");
                isInformationVaild = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}

