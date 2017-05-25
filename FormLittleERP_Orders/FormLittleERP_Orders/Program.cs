using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormLittleERP_Orders.Representation;
using FormLittleERP_Orders.Controller;
using FormLittleERP_Orders.Model;

namespace FormLittleERP_Orders
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new GestorOrders(12); //to change

        }
    }
}
