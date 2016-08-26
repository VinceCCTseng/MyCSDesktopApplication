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
    public partial class CustomerInterface : Form
    {
        private string _membercardnumber = "default";
        private ourCustomerList _customerlist = new ourCustomerList();

        public CustomerInterface()
        {
            InitializeComponent();
        }

        public CustomerInterface(string membercardnumber)
        {
            _membercardnumber = membercardnumber;
            InitializeComponent();
            updatathedatagrid(null, null);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttoncustomerlist_Click(object sender, EventArgs e)
        {
            updatathedatagrid(sender,null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void CustomerdataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CustomerCard customercard = new CustomerCard(_customerlist.Getacustomer(CustomerdataGridView.CurrentCell.RowIndex)); 
                customercard.CloseSave += new CloseSaveEvent(updatathedatagrid);
                customercard.Show();
            }
            catch
            {
                MessageBox.Show("Did not pick up a itme yet.");
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerCard customercard = new CustomerCard(_customerlist.Getacustomer(CustomerdataGridView.CurrentCell.RowIndex)); 
                customercard.CloseSave += new CloseSaveEvent(updatathedatagrid);
                customercard.Show();
            }
            catch
            {
                MessageBox.Show("Did not pick up a itme yet.");
            }
        }

        private void updatathedatagrid(object sender, EventArgs e)
        {

            try
            {
                sqlAccess sqlcustomerlist = new sqlAccess();
                _customerlist = sqlcustomerlist.SearchRecord(sqlAccess.MEMBERCARD, _membercardnumber);
                this.CustomerdataGridView.AutoGenerateColumns = false;
                this.CustomerdataGridView.DataSource = _customerlist.Getcustomerlist();
            }
            catch
            {
                MessageBox.Show("[Error] SQL access issue!");
            }
        }
    }
}
