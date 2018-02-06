using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaLogin
{
    public partial class Ventana2 : Form
    {
        public Ventana2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string seleccion = string.Empty;

            if (checkBox1.Checked == true)
            {
                count++;
            }
            if (checkBox2.Checked == true)
            {
                count++;
            }

            if (radioButton1.Checked == true)
            {
                seleccion = "Tarjeta de credito";
            }
            else if (radioButton2.Checked == true)
            {
                seleccion = "Paypal";
            }

            MessageBox.Show("Ha seleccionado " + count + " cursos y el metodo de pago es: " + seleccion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 venLog = new Form1();
            venLog.Show();
        }
    }
}
