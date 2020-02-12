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
        double total;

        RadioButton rbn1, rbn2, rbn;
        public frmPedidos()
        {
            InitializeComponent();
            Total();
        }
        public void SetValorSuco ()
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
        public void SetValorRefri ()
        {
          
            if (rbnRefri.Text.Equals("Coca Cola 1,5L"))
            {
                Refri = 6.50;
            }
            else
            {
                Refri = 5.00;
            }
        } 
        public void SetValorSanduiche ()
        {
            try
            {
                if (rbnSanduiche.Text.Equals("X - Tudo"))
                {
                    Sanduiche = 16.50;
                }
                else if (rbnSanduiche.Text.Equals("X - Salada"))
                {
                    Sanduiche = 12.50;
                }
                else if (rbnSanduiche.Text.Equals("X - Egg Burguer"))
                {
                    Sanduiche = 16.50;
                }
                else if (rbnSanduiche.Text.Equals("X - Egg Frango"))
                {
                    Sanduiche = 18.50;
                }
                else if (rbnSanduiche.Text.Equals("Misto"))
                {
                    Sanduiche = 9.50;
                }
                else
                {
                    Sanduiche = 11.50;
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Selecione algum sanduíche", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }                      
        private void rbnSucoDeLaranja_CheckedChanged_1(object sender, EventArgs e)
        {
            rbn1 = (RadioButton)sender;
            if (rbn1.Checked)
            {
                rbnSuco = rbn1;
                SetValorSuco();
                Total();
            }
        } 
        private void rbnCocaCola_CheckedChanged(object sender, EventArgs e)
        {
            rbn2 = (RadioButton)sender;
            if (rbn2.Checked)
            {
                rbnRefri = rbn2;
                SetValorRefri();
                Total();
            }
        }

        private void rbnXTudo_CheckedChanged(object sender, EventArgs e)
        {
            rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnRefri = rbn;
                SetValorSanduiche();
                Total();
            }
        }
        public void Total()
        {
            total = Refri + Suco + Sanduiche;
            labelTotal.Text = Convert.ToString(total);
        }
    }
}
    

