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
    public partial class Ejercicio_2 : Form
    {
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        private void calcularbutton1_Click(object sender, EventArgs e)
        {
            if ( Numero1textBox1.Text=="")
            {
                errorProvider1.SetError(Numero1textBox1, "Ingrese un valor") ;
                return;
            }
            errorProvider1.Clear();

            if (Numero2textBox2.Text=="")
            {
                errorProvider1.SetError(Numero2textBox2, "Ingrese un valor");
                return;
            }
            errorProvider1.Clear();

            if (OperacionesComboBox.Text == "")
            {
                errorProvider1.SetError(OperacionesComboBox, "Seleccione una operacion");
                return;
            }
            errorProvider1.Clear();

            decimal num1 = Convert.ToDecimal(Numero1textBox1.Text);
            decimal num2 = Convert.ToDecimal(Numero2textBox2.Text);

            Resultadolabel3.Text = calcular2(num1, num2).ToString();
        }


        private  decimal calcular2 (decimal n1, decimal n2)
        {
            string operacion = OperacionesComboBox.Text;

            decimal resultado = 0;

            if (operacion == "suma")
            {
                resultado = n1 + n2;
            }

            else if (operacion == "Resta")
            {
                resultado = n1 - n2;
            }

            else if (operacion == "Multiplicacion")
            {
                resultado = n1 * n2;
            }

            else if (operacion == "Division")
            {
                if (n2 == 0)
                    resultado = 0;
                else
                resultado = n1 / n2;
            }

            return resultado;

        }



    }
}
