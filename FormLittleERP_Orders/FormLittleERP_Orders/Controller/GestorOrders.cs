using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormLittleERP_Orders.Model;
using FormLittleERP_Orders.Representation;
using System.Windows.Forms;
using System.Data;

namespace FormLittleERP_Orders.Controller
{
    public class GestorOrders
    {

        private Form_Orders window;
        private OrdersMdl model;
        private int iduser;
        private bool deleted;
        public GestorOrders(int id)
        {
            iduser = id;
            model = new OrdersMdl();
            window = new Form_Orders(this);
            window.Styledgv();
            startDataGridView();
            window.ShowDialog();
            deleted = false;
        }


        public void searchClicked()
        {
            DataSet ds = model.getOrders(window.getDateFilter(), window.getPaymentFilter(),
                                window.getPriceFilter(), window.getCustomerFilter(), window.getDeletedFilter());
            deleted = (window.getDeletedFilter() == 0) ? false : true;
            DataGridView dgv = window.getDataGridOrders();
            dgv.DataSource = ds.Tables[0];
            dgv.Refresh();
                
            
        }


        public int getUserID() { return iduser; }

        public void startDataGridView()
        {
            window.getDataGridOrders().DataSource = model.getOrders(null, -1, null, -1, 0).Tables[0];
            fillCBOPayment();
            fillCBOCustomer();
            window.getSignCBO().SelectedIndex = 0;
            window.getDateTick().Checked = false;
            window.getDeletedTick().Checked = false;
            window.getPriceTxt().Text = null;
            window.getDateTime().ResetText();
        }


        public void addOrderClick()
        {
            new GestorAdd(iduser);
            startDataGridView();
        }

        public void modifyOrderClick()
        {
            if (deleted) MessageBox.Show("You can not modify an deleted order");
            else if (window.getDataGridOrders().SelectedRows.Count > 0)
            {
                new GestorAdd(iduser, window.getDataGridOrders().SelectedRows[0], false);
                startDataGridView();
            }
        }
        public void deleteOrderClick()
        {
            if (deleted) MessageBox.Show("You can not delete an deleted order");
            else if (window.getDataGridOrders().SelectedRows.Count > 0)
            {
                if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show("Do you Want to delete this Order?", "You are Deleting Order", MessageBoxButtons.YesNo))
                {
                    model.deleteOrder((Decimal)window.getDataGridOrders().SelectedRows[0].Cells[0].Value, (Decimal)iduser);
                    startDataGridView();
                }
            }
        }
        public void showLogsClick()
        {
            new GestorLogOrders();
            
        }

        private void fillCBOPayment()
        {
            model.refillCBO(window.getPaymentMehtodCBO(),
                            "select idpaymentmethod, paymentmethod from paymentmethods where deleted = 0",
                            "-- select PaymentMethod --");
        }
        private void fillCBOCustomer()
        {
            model.refillCBO(window.getCustomersCBO(),
                            "select idcustomer, name from customers where deleted = 0",
                            "-- select Customer --");
        }


        
    }
}
