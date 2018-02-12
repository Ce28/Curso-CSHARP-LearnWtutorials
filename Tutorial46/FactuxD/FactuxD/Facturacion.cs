using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MiLibreria;

namespace FactuxD
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE id_usuario = " + VentanaLogin.Codigo;

            DataSet ds;
            ds = Utilidades.Ejecutar(cmd);

            lblLeAtiende.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigoCli.Text.Trim()) == false)
            {
                try
                {
                    string cmd = string.Format("select Nom_cli from cliente where id_clientes = '{0}'", txtCodigoCli.Text.Trim());

                    DataSet ds = Utilidades.Ejecutar(cmd);
                    txtCliente.Text = ds.Tables[0].Rows[0]["Nom_cli"].ToString().Trim();
                    txtCodigoPro.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido nun error: " + error.Message);
                }
            }
        }

        public static int cont_fila = 0;
        public static double total;
        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (Utilidades.ValidarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {
                    dataGridView1.Rows.Add(txtCodigoPro.Text, txtDescrip.Text, txtPrecio.Text, txtCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                    dataGridView1.Rows[cont_fila].Cells[4].Value = importe;
                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == txtCodigoPro.Text)
                        {
                            existe = true;
                            num_fila = Fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        dataGridView1.Rows[num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[num_fila].Cells[3].Value);
                        dataGridView1.Rows[num_fila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCodigoPro.Text, txtDescrip.Text, txtPrecio.Text, txtCantidad.Text);
                        double importe = Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[cont_fila].Cells[3].Value);
                        dataGridView1.Rows[cont_fila].Cells[4].Value = importe;
                        cont_fila++;
                    }
                }
                total = 0;
                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[4].Value);
                }
                lblTotal.Text = "$" + total.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cont_fila > 0)
            {
                total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                lblTotal.Text = "$" + total.ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                cont_fila--;
            }
        }
    }
}
