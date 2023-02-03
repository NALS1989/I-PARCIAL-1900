using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcularbutton1_Click(object sender, EventArgs e)
        {
            //variables 
            decimal numero1 = 0;
            decimal numero2 = 0;


            numero1 =Convert.ToDecimal (Numero1textBox1.Text);
            numero2 = Convert.ToDecimal(Numero2textBox2.Text);

            decimal suma = numero1 + numero2;

            MessageBox.Show("La suma es: "+ suma);

        }
    }
}
