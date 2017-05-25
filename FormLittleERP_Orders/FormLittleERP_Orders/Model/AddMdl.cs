using FormLittleERP_Orders.Persistence;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLittleERP_Orders.Model
{
    public class AddMdl
    {

        public void refillDGV(DataGridView dgv, Decimal idOrder)
        {
            dgv.DataSource = new ConnectOracle().getData(
                            String.Format("Select op.REFPRODUCT, p.COMPOSITION, op.AMOUNT, op.PRICESALE, op.IDORDERPRODUCT from ORDERSPRODUCTS op, PRODUCTS p "
                                            + " where op.REFPRODUCT = p.PKPRODUCT and op.REFORDER = {0}", idOrder.ToString()), "Tb").Tables[0];
            dgv.Refresh();
        }

        public void refillCBO(ComboBox cb, String sql, String init)
        {
            DataTable dt = new ConnectOracle().getData(sql, "dgv").Tables[0];
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

        public void inserProductBD(Decimal idOrder, Decimal idProduct, Decimal amount, Decimal pvp, Decimal idOrd_Prod)
        {

            if (idOrd_Prod == -1)
            {
                new ConnectOracle().setData(String.Format("insert into ordersproducts values(produ_ords_seq.nextval, {0}, {1}, {2}, {3})",
                                                idOrder.ToString(), idProduct.ToString(), pvp.ToString().Replace(',', '.'), amount.ToString().Replace(',', '.')));
            }
            else
            {
                new ConnectOracle().setData(String.Format("update ordersproducts set reforder = {0}, refproduct = {1}, amount = {2}, pricesale = {3} "
                                                            + " where idorderproduct = {4}", idOrder.ToString(), idProduct.ToString(), 
                                                            amount.ToString().Replace(',', '.'), pvp.ToString().Replace(',', '.'), idOrd_Prod.ToString()));
            }

        }

        public void deleteProductBD(Decimal idOrder, Decimal idProduct)
        {
            new ConnectOracle().setData(String.Format("delete from ORDERSPRODUCTS where REFORDER = {O} and REFPRODUCT = {1}", idOrder.ToString(), idProduct.ToString()));
        }


        public Decimal insertOrder(Decimal idCustomer,Decimal idUser, String prepaid, 
                                        String pvp, Decimal idPayment, String date)
        {
            ConnectOracle conn = new ConnectOracle();
            
            conn.setData(String.Format("insert into orders values(orders_seq.nextval, {0}, {1}, '{2}', {3}, {4},{5}, 0)",
                                        idCustomer, idUser, date, idPayment, pvp, prepaid));

            return (Decimal) conn.DLookUp("max(IDORDER)", "ORDERS", "");
        }

        public Decimal modifyOrder(Decimal idOrder, Decimal idCustomer, Decimal idUser,
                                        String prepaid, String pvp, Decimal idPayment, String date)
        {
            ConnectOracle conn = new ConnectOracle();
            String que = String.Format("update orders set REFCUSTOMER = {0}, REFUSER = {1}, DATETIME = '{2}', REFPAYMENTMETHOD = {3}, TOTAL = {4}, PREPAID = {5} where IDORDER = {6}",
                                        idCustomer, idUser, date, idPayment, pvp, prepaid, idOrder);
            conn.setData(que);
            return idOrder;
        }


        public void Styledgv( DataGridView dgv)
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
