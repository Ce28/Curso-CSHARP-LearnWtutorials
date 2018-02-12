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
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        public override bool Guardar()
        {
            try
            {
                string cmd = string.Format("EXEC ActualizaClientes '{0}','{1}','{2}'", txtID_cli.Text.Trim(), txtNom.Text.Trim(), txtApe.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha guardado correctamente!..");
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
                return false;
            }
        }

        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarCliente '{0}'", txtID_cli.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se ha eliminado correctamente!..");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }
    }
}
