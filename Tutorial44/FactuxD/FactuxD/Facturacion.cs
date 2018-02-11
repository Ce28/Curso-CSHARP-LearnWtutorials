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
    }
}
