using FormLittleERP_Orders.Model;
using FormLittleERP_Orders.Representation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLittleERP_Orders.Controller
{
    class GestorLogOrders
    {
        private Form_ChangesO window;
        private ModificationsMdl model;

        public GestorLogOrders()
        {
            window = new Form_ChangesO();
            model = new ModificationsMdl();
            model.Styledgv(window.getDataGrid());
            window.getDataGrid().DataSource = model.loadModifications().Tables[0];
            window.ShowDialog();
        }

    }
}
