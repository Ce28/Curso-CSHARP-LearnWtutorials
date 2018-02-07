using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using MiLibreria;

namespace FactuxD
{
    public partial class VentanaLogin : Form
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public static string Codigo = "";

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("SELECT * FROM Usuarios WHERE account = '{0}' AND password = '{1}'", txtUsuario.Text.Trim(), txtContraseña.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);

                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();
                
                if (cuenta == txtUsuario.Text.Trim() && contra == txtContraseña.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true)
                    {
                        VentanaAdmin VenAd = new VentanaAdmin();
                        this.Hide();
                        VenAd.Show();
                    }
                    else
                    {
                        VentanaUser VenUs = new VentanaUser();
                        this.Hide();
                        VenUs.Show();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario o contraseña incorrecta!...");
            }
        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
