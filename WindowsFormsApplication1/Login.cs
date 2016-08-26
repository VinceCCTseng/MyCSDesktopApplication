using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApplication1.Classes;

namespace WindowsFormsApplication1
{
    public delegate void CloseSaveEvent(object sender, EventArgs e);
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // create sql access class and check login data
            try
            {
                sqlAccess sqllogin = new sqlAccess();
                string result = sqllogin.LoginCheck(textBox1.Text, textBox2.Text);
                // two models for login 
                if (result.CompareTo("2") == 0)
                {
                    AdministratorInterface administrator = new AdministratorInterface();
                    administrator.Owner = this;
                    administrator.Show();
                    textBox1.Clear();
                    textBox2.Clear();
                    Hide();

                }
                else if (result.Substring(0, 1).CompareTo("1") == 0)
                {
                    CustomerInterface customer = new CustomerInterface(result.Substring(2, (result.Length - 2)));
                    customer.Owner = this;
                    customer.Show();
                    textBox1.Clear();
                    textBox2.Clear();
                    Hide();
                }
                else
                    System.Windows.Forms.MessageBox.Show("Invaild account! Please try again.");
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Sql access error!");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ToDo: Test only, remove it!
        private void btnTestDataForm_Click(object sender, EventArgs e)
        {
            NewCard newCard = new NewCard();
            newCard.Show();
        }

    }
}

