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
    public partial class Form_Orders : Form
    {

        private GestorOrders controller;

        public Form_Orders(GestorOrders gc)
        {            
            InitializeComponent();
            controller = gc;
        }

        private void btnAddO_Click(object sender, EventArgs e)
        {
            controller.addOrderClick();
        }

        private void btnChangesO_Click(object sender, EventArgs e)
        {
            controller.showLogsClick();
        }

        private void btnModifO_Click(object sender, EventArgs e)
        {
            controller.modifyOrderClick();
        }

        private void btnDeleteO_Click(object sender, EventArgs e)
        {
            controller.deleteOrderClick();
        }

        private void btnFiltO_Click(object sender, EventArgs e)
        {
            controller.searchClicked();
        }

        public String getDateFilter() {
            return (cbxDate.Checked) ? dtpDateO.Value.ToString("dd/MM/yyyy"): null;
        }
        public int getPaymentFilter() {
            return (cbPaymentO.SelectedValue != null) ? int.Parse(cbPaymentO.SelectedValue.ToString()): -1;
        }
        public String getPriceFilter()
        {
            if (!cbSignPriceO.SelectedItem.ToString().Equals("*") && txtPriceO.Text.Length > 0)
                return (String.Format(" {0} {1} ", cbSignPriceO.SelectedItem.ToString(), txtPriceO.Text.Trim()));
            else return null;
        }
        public int getCustomerFilter()
        {
            return (cbCustomerO.SelectedValue != null) ? int.Parse(cbCustomerO.SelectedValue.ToString()) : -1;
        }

        public int getDeletedFilter() { return (ckDelO.Checked) ? -1 : 0; }


        public DataGridView getDataGridOrders() { return dgvOrdersO; }

        public ComboBox getCustomersCBO() { return cbCustomerO; }
        public ComboBox getPaymentMehtodCBO() { return cbPaymentO; }
        public ComboBox getSignCBO() { return cbSignPriceO; }
        public CheckBox getDateTick() { return cbxDate; }
        public CheckBox getDeletedTick() { return ckDelO; }
        public TextBox getPriceTxt() { return txtPriceO; }
        public DateTimePicker getDateTime() { return dtpDateO; }

        public void Styledgv()
        {
            dgvOrdersO.ReadOnly = true;
            dgvOrdersO.AllowUserToAddRows = false;
            dgvOrdersO.ColumnHeadersVisible = true;
            dgvOrdersO.RowHeadersVisible = false;
            
            dgvOrdersO.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgvOrdersO.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvOrdersO.ColumnHeadersDefaultCellStyle.BackColor = Color.Beige;
            dgvOrdersO.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Yellow;
            dgvOrdersO.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Blue;
            
            dgvOrdersO.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvOrdersO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrdersO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvOrdersO.RowsDefaultCellStyle.BackColor = Color.White;
            dgvOrdersO.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;

            dgvOrdersO.DefaultCellStyle.Font = new Font("Tahoma", 9);
            dgvOrdersO.DefaultCellStyle.ForeColor = Color.Black;
            dgvOrdersO.DefaultCellStyle.BackColor = Color.Beige;
            dgvOrdersO.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            dgvOrdersO.DefaultCellStyle.SelectionBackColor = Color.Blue;
        }

        private void btnClearO_Click(object sender, EventArgs e)
        {
            controller.startDataGridView();
        }

        private void txtPriceO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
                e.Handled = true;
            if (e.KeyChar == '.' && txtPriceO.Text.IndexOf('.') != -1) e.Handled = true;
        }

        private void btnDoneO_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        
    }
}
