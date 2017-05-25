using FormLittleERP_Orders.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLittleERP_Orders.Model
{
    public class InserProdMdl
    {

        public void refillCBO(ComboBox cb, String sql, String init)
        {
            DataTable dt = new ConnectOracle().getData(sql, "CB").Tables[0];
            if (init != null && !init.Equals(""))
            {
                DataRow newrow = dt.NewRow();
                newrow[0] = -1;
                newrow[1] = init;
                dt.Rows.InsertAt(newrow, 0);
            }
            cb.DataSource = dt;
            cb.DisplayMember = dt.Columns[1].ToString();
            cb.ValueMember = dt.Columns[0].ToString();

        }
    }
}
