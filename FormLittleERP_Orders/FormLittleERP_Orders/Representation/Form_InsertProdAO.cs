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
    public partial class Form_InsertProdAO : Form
    {
        private GestorInserProd controller;

        public Form_InsertProdAO(GestorInserProd controller)
        {
            this.controller = controller;
            InitializeComponent();
        }


        public ComboBox getProductsCBO() { return cboProdM; }
        public TextBox getAmounts() { return txtAmount; }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)e.Handled = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            controller.clickAccept();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
