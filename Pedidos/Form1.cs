using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedidos
{
    public partial class frmPedidos : Form
    {
        RadioButton rbnSuco = null;
        RadioButton rbnRefri = null;
        RadioButton rbnSanduiche = null;

        double Suco = 0;
        double Refri = 0;
        double Sanduiche = 0;
        double Total;

        RadioButton rbn1, rbn2, rb3;
        public frmPedidos()
        {
            InitializeComponent();
        }
        public void SetValorSuco ()
        {
            try
            {                
                if (rbnSuco.Text.Equals("Suco de Laranja"))
                {
                    Suco = 5.70;
                }
                else
                {
                    Suco = 12.50;
                }
                
            }
            catch (Exception e)
            {

                MessageBox.Show("Selecione algum Suco", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetValorRefri ()
        {
            if (rbnSelecionado.Text.Equals("Coca Cola 1,5L"))
            {
                SetValorRefri = 6.50;
            }
            else
            {

            }
        }               
        private void rbnSucoDeLaranja_CheckedChanged_1(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn1;
                SetValorSuco();
            }
        }

        private void rbnCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn2;
                SetValorRefri();
            }
        }
        Total = ValorSuco + ValorRefri + ValorSanduiche
            labelTotal = 
    }
}
    

