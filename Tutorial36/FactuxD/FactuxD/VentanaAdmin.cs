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
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE id_usuario = " + VentanaLogin.Codigo;
            DataSet DS = Utilidades.Ejecutar(cmd);

            lblNomAdm.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUsAdm.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblCodAdm.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

            string url = DS.Tables[0].Rows[0]["Foto"].ToString();

            pbFoto.Image = Image.FromFile(url);
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


    }
}
