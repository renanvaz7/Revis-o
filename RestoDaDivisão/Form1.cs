using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoDaDivisão
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtDividendo.Text);
            b = Convert.ToInt32(txtDivisor.Text);
            c = a % b;

            txtResto.Text = Convert.ToString(c);
        }
    }
}
