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
using System.Windows;

namespace WindowsFormsApplication1
{
    public partial class AdministratorInterface : Form
    {
        // Create new customer
        private ourCustomerList _customerlist;
        //
        Boolean _desc;        
        

        public AdministratorInterface()
        {
            InitializeComponent();
            CustomerlizeInit();
        }

        private void administrator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelDataBase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewCard addnewcustomer = new NewCard();
            addnewcustomer.Owner = this;
            addnewcustomer.CloseSave += new CloseSaveEvent(updatathedatagrid);
            addnewcustomer.ShowDialog();
        }

        // get Customer ID and open customer card
        private void customerDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CustomerCard customercard = new CustomerCard(_customerlist.Getacustomer(customerDataGrid.CurrentCell.RowIndex));
                customercard.CloseSave += new CloseSaveEvent(updatathedatagrid);
                customercard.ShowDialog();
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Please try it again and make sure that choose a vaild item!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlAccess sqldeletecustomer = new sqlAccess();
                int itemno = (int)customerDataGrid[0, customerDataGrid.CurrentCell.RowIndex].Value;
                string membercard = _customerlist.Getacustomer(customerDataGrid.CurrentCell.RowIndex).MemberCard.ToString();
                //delete membership
                var confirmfeedback = MessageBox.Show("[Warning!] Do you want to delete customer: (No." + itemno + ")  information?", "Information deleted!" , MessageBoxButtons.YesNo);
                if (confirmfeedback == DialogResult.Yes)
                {

                    sqldeletecustomer.DeleteRecord(itemno);
                    updatathedatagrid(this, null);
                }
                //delete account
                //1. check exists?
                if(sqldeletecustomer.IsUserExist(membercard))
                {
                    //2. delete account
                    confirmfeedback = MessageBox.Show("[Warning!] Do you want to delete customer account (MemberID." + membercard + ")?", "account deleted!", MessageBoxButtons.YesNo);
                    if (confirmfeedback == DialogResult.Yes)
                    {
                        sqldeletecustomer.DeleteAccount(membercard);
                    }
                }
                
            }
            catch 
            {
                MessageBox.Show("There is no data from database yet!");
            }
           
            
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(customerDataGrid[3, customerDataGrid.CurrentCell.RowIndex].Value.ToString());                
            }            
            catch
            {
                MessageBox.Show("There is no data from database yet!");
            }
        }

        private void searchtextBox_TextChanged(object sender, EventArgs e)
        {
            sqlAccess sqlfindcustomer = new sqlAccess();
            try
            {
                _customerlist = sqlfindcustomer.SearchRecord(searchcomboBox.Text, searchtextBox.Text);
                customerDataGrid.DataSource = _customerlist.Getcustomerlist(); 
            }
            catch
            {
                MessageBox.Show("SQL data access fail!");
            }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            searchtextBox.Clear();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {                

                CustomerCard customercard = new CustomerCard(_customerlist.Getacustomer(customerDataGrid.CurrentCell.RowIndex));
                customercard.CloseSave += new CloseSaveEvent(updatathedatagrid);
                customercard.ShowDialog();

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show("Please try it again and make sure that choose a vaild item!");
            }
        }

        private void Customercard_CloseSave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click_1(object sender, EventArgs e)
        {
            updatathedatagrid(this, null);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        protected void updatathedatagrid(object sender, EventArgs e)
        {
            
            try
            {
                sqlAccess sqlcustomerlist = new sqlAccess();
                _customerlist = sqlcustomerlist.RetrievalCustomerList();
                this.customerDataGrid.AutoGenerateColumns = false;
                customerDataGrid.DataSource = _customerlist.Getcustomerlist(); 
            }
            catch
            {
                MessageBox.Show("[Error] SQL access issue!");
            }
        }
        // Customerlize init settings
        private void CustomerlizeInit()
        {
            updatathedatagrid(this, null);
            searchcomboBox.SelectedIndex = 0;

            _desc = true;            
        }

        private void customerDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // N/A
        }

        private void customerDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //Method 1 - by qurey to sort
            try
            {
                sqlAccess sqlcustomerlist = new sqlAccess();
                _desc = (!_desc);
                _customerlist = sqlcustomerlist.RetrievalCustomerList((customerDataGrid.Columns[e.ColumnIndex].DataPropertyName != null)? customerDataGrid.Columns[e.ColumnIndex].DataPropertyName : sqlAccess.CUSTOMERID, _desc);// argu sortitem, argu 
                customerDataGrid.DataSource = _customerlist.Getcustomerlist();
            }
            catch
            {
                MessageBox.Show("[Error] SQL access issue!");
            }
            //Method 2 - by 
            //_desc = (!_desc);
            //try
            //{
            //    customerDataGrid.Sort(customerDataGrid.Columns[1], (_desc == true) ? ListSortDirection.Descending : ListSortDirection.Ascending);
            //}
            //catch
            //{
            //    MessageBox.Show("Oops, something worng!");
            //}

        }
    }

}
