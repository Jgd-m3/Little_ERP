using FormLittleERP_Orders.Model;
using FormLittleERP_Orders.Persistence;
using FormLittleERP_Orders.Representation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLittleERP_Orders.Controller
{
    public class GestorInserProd
    {
        private Form_InsertProdAO window;
        private InserProdMdl model;
        private GestorAdd father;
        private bool modificator;

        public GestorInserProd(GestorAdd f, bool modif) 
        {
            father = f;
            modificator = modif;
            model = new InserProdMdl();
            window = new Form_InsertProdAO(this);
            refillProductsCBO();
            if (modificator) refillDatas();
            window.ShowDialog();
        }


        private void refillProductsCBO()
        {
            model.refillCBO(window.getProductsCBO(), "select pkproduct, composition from products where deleted = 0", null);
        }

        private void refillDatas()
        {
            Decimal value = ((Decimal)father.getDGVProducts().SelectedRows[0].Cells[0].Value);
            Console.WriteLine(father.getDGVProducts().SelectedRows[0].Cells[0].Value.GetType());
            DataTable dt = (DataTable) window.getProductsCBO().DataSource;
            DataRow dr;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                if ((decimal)dr[0] == value)
                {
                    window.getProductsCBO().SelectedItem = window.getProductsCBO().Items[i];
                    break;
                }
                Console.WriteLine(i);
            }
            value = (Decimal)father.getDGVProducts().SelectedRows[0].Cells[2].Value;
            window.getAmounts().Text = value.ToString();
           
        }


        public void clickAccept()
        {
            if(window.getAmounts().Text.Length<1 || window.getProductsCBO().SelectedIndex == -1) { return; }

            double pvpSale = 1.21 * double.Parse(new ConnectOracle().DLookUp("price", "products",
                                            "pkproduct = " + window.getProductsCBO().SelectedValue.ToString()).ToString());

            DataTable dt = (DataTable) father.getDGVProducts().DataSource;
            DataRow dr = (modificator) ? dt.Rows[father.getDGVProducts().SelectedRows[0].Index]: dt.NewRow();
            object[] row = new object[5];
            row[0] = window.getProductsCBO().SelectedValue.ToString();
            row[1] = window.getProductsCBO().GetItemText(window.getProductsCBO().SelectedItem).ToString();
            row[2] = Decimal.Parse(window.getAmounts().Text);
            row[3] = pvpSale;
            row[4] = (modificator)? (Decimal)dr[4]: -1;
            if(!modificator) dt.Rows.Add(row);
            else dt.Rows[father.getDGVProducts().SelectedRows[0].Index].ItemArray = row;

            father.getDGVProducts().Refresh();
            if (father.getDGVProducts().Rows.Count > 0) father.operateTotal();
            window.Dispose();
        }

        
    }
}
