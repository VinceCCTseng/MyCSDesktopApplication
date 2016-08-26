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
    public partial class CreateNewUserAccount : Form
    {
        private string _username;
        private string _userpassword;
        private Boolean _authority;
        private string _membercard;

        public CreateNewUserAccount(string membercard)
        {
            InitializeComponent();
            _membercard = membercard;
            labelmembercard.Text = _membercard;
            _authority = false;
            _username = null;
            _userpassword = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlAccess sqladduseraccount = new sqlAccess();
                // data check

                if (textBoxuser.Text.Length > 4 && textBoxuser.Text.Length <= 20)
                    _username = textBoxuser.Text;
                else
                    MessageBox.Show("User name include at least 5 char!");

                if (textBoxpassword.Text.Length > 4 && textBoxpassword.Text.Length <= 20)
                    _userpassword = textBoxpassword.Text;
                else
                    MessageBox.Show("User password include at least 5 char!");

                if (_username !=null && _userpassword!=null)
                {    
                    if (sqladduseraccount.CreateUserAccount(_username, _userpassword, _authority, _membercard))
                    {
                        MessageBox.Show("User account has been created!");
                        this.Close();
                    }                      
                    else
                        MessageBox.Show("User account was created fail!");
                }
            }
            catch
            {
                MessageBox.Show("??");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            var confirmfeedback = MessageBox.Show("Do you want to cancel account create step?", "User infomration has been dropped!", MessageBoxButtons.YesNo);
            if(confirmfeedback == DialogResult.Yes)
            {
                Owner.Show();
                this.Close();
            }
        }

        private void CreateNewUserAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
