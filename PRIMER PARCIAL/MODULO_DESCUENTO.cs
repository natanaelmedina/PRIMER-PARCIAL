//Natanael Medina De Jesus 16-EISN-6-061

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PRIMER_PARCIAL
{
    public partial class FDESCUENTO : Form
    {
        //Impuesto a la Transferencia de Bienes Industrializados (ITBIS)
        const double ITBIS = 0.16;

        double price, qty;
        CultureInfo culture = CultureInfo.CreateSpecificCulture("es-DO");

        //Diccionario de descuentos
        Dictionary<int, double> discounts = new Dictionary<int, double>()
       {
           {-1, 0.0},
           {0, 0.20},
           {1, 0.15},
           {2, 0.10},
           {3, 0.05},

       };

        public FDESCUENTO()
        {
            InitializeComponent();
            culture.NumberFormat.CurrencyNegativePattern = 1;
        }

        //calculamos los resultados y mostramos en los textBox
        private void calculate(object sender, EventArgs e)
        {

            double subTotal = price * qty;
            double discount = subTotal * discounts[CBdiscount.SelectedIndex];
            double itbis = (subTotal - discount) * ITBIS;
            double total = (subTotal - discount) + itbis;

            TBsubTotal.Text = subTotal.ToString("C", culture);
            TBtotal.Text = total.ToString("C", culture);
            TBitbis.Text = itbis.ToString("C", culture);
            TBdiscount.Text = discount.ToString("C", culture);

        }

        //controlamos que solo ingresen números
        private void onPressPriceQty(object sender, KeyPressEventArgs e)
        {
            string value = (sender as TextBox).Text;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }
            if ((e.KeyChar == '.') && (value.IndexOf('.') > -1))
            {
                e.Handled = true;
                return;
            }
        }

        //almacenados el precio y/o la cantidad
        private void onChange(object sender, EventArgs e)
        {
            try
            {
                string tbName = (sender as TextBox).Name;
                string value = (sender as TextBox).Text.Replace('.', ',');
                if (tbName == TBprice.Name)
                    price = Convert.ToDouble(value);
                else if (tbName == TBqty.Name)
                    qty = Convert.ToDouble(value);
            }
            catch { }
        }
        //limpiamos variables
        private void newItem(object sender, EventArgs e)
        {

            CBitems.SelectedIndex = -1;
            CBdiscount.SelectedIndex = -1;
            TBsubTotal.Clear();
            TBtotal.Clear();
            TBitbis.Clear();
            TBdiscount.Clear();
            TBprice.Clear();
            TBqty.Clear();
            price = 0;
            qty = 0;
            CBitems.Text = "SELECCIONA UN ARTICULO";
            CBdiscount.Text = "SELECCIONA LA CATEGORÍA";


        }

        //inhabilito las entradas si no se selecciona un articulo
        private void CBitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBprice.ReadOnly = !((sender as ComboBox).SelectedIndex > -1);
            TBqty.ReadOnly = TBprice.ReadOnly;
        }

        //inicializamos un nuevo articulo cuando el formulario carga
        private void FDESCUENTO_Load(object sender, EventArgs e)
        {
            newItem(null, null);
        }

        // salir de la aplicación
        private void exitApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
