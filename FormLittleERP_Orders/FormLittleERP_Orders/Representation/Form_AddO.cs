using FormLittleERP_Orders.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLittleERP_Orders.Representation
{
    public partial class Form_AddO : Form
    {

        public bool Type { get; }
        private GestorAdd controller;

        public Form_AddO(bool type, GestorAdd control)
        {
            controller = control;
            this.Type = type;
            InitializeComponent();
            if(Type)
            {
                lblTitleAO.Text = "Adding new Order";
                btnAddAO.Text = "ADD ORDER";
            }
            else
            {
                lblTitleAO.Text = "Modifying Order";
                btnAddAO.Text = "MODIFY ORDER";
            }
        }


        public ComboBox getCustomerCBO() { return cboCustomA; }
        public ComboBox getPayCBO() { return cboPayA; }
        public TextBox getTotal() { return txtTotalAO; }
        public TextBox getPrepaid() { return txtPrepAO; }
        public DateTimePicker getDatePicker() { return dtpDateAO; }
        public DataGridView getDataGridProducts() { return dgvProducts; }


        private void btnCanAO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrepAO_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool handled = false;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
                handled = (e.Handled = true);
            if (e.KeyChar == '.' && txtPrepAO.Text.IndexOf('.') != -1)
                handled = (e.Handled = true);
            if (!handled) controller.Changes = true;
        }


        private void btnAddProdAO_Click(object sender, EventArgs e)
        {
            controller.addProductClick();
        }

        private void btnModifProdAO_Click(object sender, EventArgs e)
        {
            controller.modifyProductClick();
        }

        private void btnDelProdAO_Click(object sender, EventArgs e)
        {
            controller.deleteProductClick();
        }

        private void btnAddAO_Click(object sender, EventArgs e)
        {
            controller.addOrderClick();
        }

        private void btnCustomerAO_Click(object sender, EventArgs e)
        {
            controller.newCustomer();
        }

        private void cboCustomA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            controller.Changes = true;
        }

        private void cboPayA_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.Changes = true;
        }

        private void dtpDateAO_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateAO.Checked) controller.Changes = true;      
        }
    }
}
