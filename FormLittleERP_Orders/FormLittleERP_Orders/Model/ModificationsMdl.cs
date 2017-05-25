using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FormLittleERP_Orders.Persistence;
using System.Windows.Forms;
using System.Drawing;

namespace FormLittleERP_Orders.Model
{
    class ModificationsMdl
    {
        public void saveModification(Decimal idUser, Decimal idOrder, char type)
        {
            new ConnectOracle().setData(
                String.Format("insert into Orders_Changes values (modi_ords_seq.nextval, {0}, {1}, '{2}', Sysdate)", idUser.ToString(), idOrder.ToString(), type));
        }

        public DataSet loadModifications()
        {
            return new ConnectOracle().getData("select m.REF_USER, u.NAME, m.REF_ORDER, m.C_TYPE, m.C_DATE from Orders_Changes m, users u "
                                                + " where u.IDUSER = m.REF_USER", "TB");
        }

        public void Styledgv(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.ColumnHeadersVisible = true;
            //dgv.RowHeadersVisible = false;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Beige;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Yellow;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Blue;

            dgv.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;

            dgv.DefaultCellStyle.Font = new Font("Tahoma", 9);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.Beige;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Yellow;
            dgv.DefaultCellStyle.SelectionBackColor = Color.Blue;
        }

    }
}
