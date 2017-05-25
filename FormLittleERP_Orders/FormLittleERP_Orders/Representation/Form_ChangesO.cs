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
    public partial class Form_ChangesO : Form
    {
        public Form_ChangesO()
        {
            InitializeComponent();
        }

        private void btnOkCO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DataGridView getDataGrid() { return dgvChangesO; }
    }
}
