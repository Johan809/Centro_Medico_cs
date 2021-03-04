using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Final
{
    public partial class FormMoneda : Form
    {
        double monto;
        string origen, destino;
        public FormMoneda()
        {
            InitializeComponent();
        }

        private void FormMoneda_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                monto = double.Parse(txtMoneda.Text);
                origen = MonOrigList.Text;
                destino = MonDestList.Text;

                MonedaCambio Change = new MonedaCambio();

                labelresult.Text = "El cambio es de " + Change.Cambio(monto, origen, destino).ToString();
            }
            catch
            {
                MessageBox.Show("Por favor eliga una moneda de origen, una de destino y un monto a cambiar.");
            }
        }
    }

    public class MonedaCambio //Clase para realizar las operaciones de Cambio
    {
        double monchange;

        public double Cambio(double monto, string origen, string destino)
        {
            if(origen == "Peso Dom.") //Cuando el origen son Pesos Dominicanos
            {
                if(destino == "Peso Dom.")
                {
                    monchange = monto;
                }
                if(destino == "Dolar")
                {
                    monchange = monto * 0.019;
                }
                if(destino == "Euro")
                {
                    monchange = monto * 0.017;
                }
            }

            if(origen == "Dolar") //Cuando el origen es Dollar
            {
                if(destino == "Dolar")
                {
                    monchange = monto;
                }
                if(destino == "Peso Dom.")
                {
                    monchange = monto * 52.71;
                }
                if(destino == "Euro")
                {
                    monchange = monto * 0.90;
                }
            }

            if(origen == "Euro") //Cuando el origen son Euros
            {
                if(destino == "Euro")
                {
                    monchange = monto;
                }
                if(destino == "Peso Dom.")
                {
                    monchange = monto * 58.38;
                }
                if(destino == "Dolar")
                {
                    monchange = monto * 1.11;
                }
            }
            return monchange;
        }
    }
}
