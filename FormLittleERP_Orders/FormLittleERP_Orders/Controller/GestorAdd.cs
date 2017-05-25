using FormLittleERP_Orders.Model;
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
    public class GestorAdd
    {
        private Form_AddO window;
        private AddMdl model;
        private bool type;
        public bool Changes{get;set;}
        private DataGridViewRow current;
        private List<Decimal> idsDeleted;
        private int idUser;


        public GestorAdd(int idUser) : this(idUser, null, true) {}
        public GestorAdd(int idUser, DataGridViewRow row, bool type)
        {
            this.type = type;
            this.idUser = idUser;
            current = row;
            window = new Form_AddO(type, this);
            model = new AddMdl();
            idsDeleted = new List<Decimal>();
            if(this.type) newAddInit();
            else editAddInit();
            window.ShowDialog();
        }



        public DataGridView getDGVProducts()
        {
            return window.getDataGridProducts();
        }



        private void newAddInit()
        {
            refillAddsCBOs();
            startDataGrid();
        }

        private void editAddInit()
        {
            startDataGrid();
            refillEditCBOs();
            
        }

        private void startDataGrid()
        {
            DataGridView dgv = window.getDataGridProducts();
            DataTable dt = new DataTable();
            DataColumn aux;
            String[] columnNames = { "IdProduct", "Nombre", "Amount", "Pvp", "ID_order_Prod"};
            String[] columnTypes = { "System.Decimal", "System.String", "System.Decimal", "System.Decimal", "System.Decimal" };

            for (int i = 0; i < columnNames.Length; i++)
            {
                aux = new DataColumn(columnNames[i], Type.GetType(columnTypes[i]));
                dt.Columns.Add(aux);
            }
            dgv.DataSource = dt;
        }



        public void refillAddsCBOs()
        {

            model.refillCBO( window.getCustomerCBO(), "select idcustomer, name from customers where deleted = 0", "-- select Customer --");
            model.refillCBO(window.getPayCBO(), "select idpaymentmethod, paymentmethod from paymentmethods where deleted = 0",
                                 "-- select PaymentMethod --");
            model.Styledgv(window.getDataGridProducts());
        }

        public void refillEditCBOs()
        {
            //Filling the PaymentMethod cbo and preselecting the original choice
            model.refillCBO(window.getPayCBO(),
                                 "select idpaymentmethod, paymentmethod from paymentmethods where deleted = 0", "*" );
            selectChoiced(window.getPayCBO(), 3);

            //Filling the customer cbo and preselecting the original choice
            model.refillCBO(window.getCustomerCBO(),
                            "select idcustomer, name from customers where deleted = 0", "*");
            selectChoiced(window.getCustomerCBO(), 1);

            //filling the money fields
            window.getTotal().Text = current.Cells[5].Value.ToString();
            window.getPrepaid().Text = current.Cells[4].Value.ToString();

            //refreshing the DateTimePicker
            window.getDatePicker().Value = (DateTime) current.Cells[6].Value;

            //filling the DataGridView of the products 
            model.refillDGV(window.getDataGridProducts(), ((Decimal) current.Cells[0].Value));
            model.Styledgv(window.getDataGridProducts());

        }

        
        private void selectChoiced(ComboBox aux, int rowCell)
        {
            DataTable dt = (DataTable)aux.DataSource;
            DataRow dr;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                if (dr[1].Equals(current.Cells[rowCell].Value)) aux.SelectedItem = aux.Items[i];

            }
        }

        public void addProductClick()
        { 
            new GestorInserProd(this, false);
        }
        public void modifyProductClick()
        {
            DataGridView dgv = window.getDataGridProducts();
            if (dgv.SelectedRows.Count>0)
                new GestorInserProd(this, true);
            else Console.WriteLine("AHORA NO");
           // dgv.Refresh();
        }

        public void deleteProductClick()
        {
            DataGridView dgv = window.getDataGridProducts();
            if (dgv.SelectedRows.Count > 0)
            {
                if (System.Windows.Forms.DialogResult.Yes == MessageBox.Show("Do you Want to delete this Product?", "You are Deleting Product", MessageBoxButtons.YesNo))
                {
                    idsDeleted.Add((Decimal)dgv.SelectedRows[0].Cells[4].Value);
                    dgv.Rows.Remove(dgv.SelectedRows[0]);
                }
            }
            operateTotal();
        }

        public void operateTotal()
        {
            Decimal sum = 0;
            DataTable dt = (DataTable) window.getDataGridProducts().DataSource;
            foreach (DataRow aux in dt.Rows)
            {
                try { sum +=  (Decimal)aux[2] * (Decimal)aux[3]; }
                catch (System.Data.DeletedRowInaccessibleException e){}
            }
            window.getTotal().Text = sum.ToString().Replace(',','.');
        }

        public void addOrderClick()
        {
            if (DialogResult.Yes == MessageBox.Show("Do you Want to Save this Order?", "You are Saving Order", MessageBoxButtons.YesNo))
            {
                if (isReady()) saveOrder();
                else MessageBox.Show("You did not choose some required options", "Lost Data");

            }
        }

        private void saveOrder()
        {
            Decimal idCurrent;
            // Inserting/updating Order
            if (type && Changes)
            {
                // Insert new Orders
                 idCurrent = model.insertOrder((Decimal)window.getCustomerCBO().SelectedValue, idUser,
                                         (window.getPrepaid().Text.Length > 0)? window.getPrepaid().Text.Replace(',','.'): "0",
                                         window.getTotal().Text.Replace(',', '.'), (Decimal) window.getPayCBO().SelectedValue,
                                         window.getDatePicker().Value.ToString("dd/MM/yyyy"));
                // Inserting Order_products
                saveOrder_Products(idCurrent);
                // Inserting LOG
                new ModificationsMdl().saveModification(idUser, idCurrent, 'I');
                window.Dispose();
             }
            else if (!type && Changes)
            {
                idCurrent = model.modifyOrder((Decimal)current.Cells[0].Value, (Decimal)window.getCustomerCBO().SelectedValue, 
                                            idUser, (window.getPrepaid().Text.Length > 0) ? window.getPrepaid().Text.Replace(',', '.'): "0",
                                            window.getTotal().Text.Replace(',', '.'), (Decimal)window.getPayCBO().SelectedValue,
                                            window.getDatePicker().Value.ToString("dd/MM/yyyy"));
                // Inserting Order_products
                saveOrder_Products(idCurrent);
                // Inserting LOG
                new ModificationsMdl().saveModification(idUser, idCurrent, 'U');
                window.Dispose();
            }
        }

        private void saveOrder_Products(Decimal idCurrent)
        {
            //deleting products order_products
            if (idsDeleted.Count > 0 && type)
            {
                foreach (Decimal aux in idsDeleted)
                {
                    model.deleteProductBD(idCurrent, aux);
                }
            }
            //inserting and updating products Order_products
            DataTable dt = (DataTable)window.getDataGridProducts().DataSource;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow aux in dt.Rows)
                {
                    model.inserProductBD(idCurrent, (Decimal)aux[0], (Decimal)aux[2], (Decimal)aux[3], (Decimal)aux[4]);
                }
            }
        }
        private bool isReady()
        {
            if ((Decimal) window.getCustomerCBO().SelectedValue == -1) return false;
            if (window.getTotal().Text.Length <= 0) return false;
            if ((Decimal)window.getPayCBO().SelectedValue == -1) return false;
            return (window.getDataGridProducts().Rows.Count > 0);
        }

        public void newCustomer()
        {
            //    new controlAddC();  // HAY QUE DESCOMENTARLO Y ELIMINAR ESTE COMENTARIO! ----------------------
            model.refillCBO(window.getCustomerCBO(), "select idcustomer, name from customers where deleted = 0", "-- select Customer --");
        }
    }
}
