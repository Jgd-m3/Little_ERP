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
    public class OrdersMdl
    {

        public void deleteOrder(Decimal idOrder, Decimal idUser)
        {
            new ConnectOracle().setData(String.Format("update orders set DELETED = -1 where IDORDER = {0}", idOrder.ToString()));
            new ModificationsMdl().saveModification(idUser, idOrder, 'D');
        }

        public DataSet getOrders(String date, int payment, String price, int customer, int del)
        {
            StringBuilder sql = new StringBuilder("Select o.idorder, cu.name, us.name, pm.paymentmethod, o.prepaid, o.total, o.datetime "
                                                   + " from orders o, users us, paymentmethods pm, customers cu "
                                                   + " where o.refcustomer = cu.idcustomer and o.refuser = us.iduser "
                                                   + " and o.refpaymentmethod = pm.idpaymentmethod and o.deleted = " + del.ToString());

            if (date != null) sql.AppendFormat(" and o.datetime = '{0}' ", date);
            if (payment != -1) sql.AppendFormat(" and o.refpaymentmethod = {0} ", payment.ToString());
            if (price != null) sql.AppendFormat(" and o.total {0} ", price);
            if (customer != -1) sql.AppendFormat(" and o.refcustomer = {0} ", customer.ToString());

            sql.Append(" order by o.idorder, o.datetime");

            return new ConnectOracle().getData(sql.ToString(),"ORDERS");
        }


        public void refillCBO(ComboBox cb, String sql, String init)
        {
            DataTable dt = new ConnectOracle().getData(sql, "CB").Tables[0];
            if(init != null && !init.Equals(""))
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
