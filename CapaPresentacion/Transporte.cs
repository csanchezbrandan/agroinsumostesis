using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class Transporte : UserControl
    {
        public Transporte()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            MostrarT();
        }

        private void mesajerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void MostrarT()
        {
            try
            {

                Dock = DockStyle.Fill;
                dataGridViewTransporte.DataSource = Ltransporte.MostrarT(); 
            }
            catch (Exception ex)
            {
                mesajerror(ex.Message);

            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmIngresarTransporte ingresar = new FrmIngresarTransporte(this);
            ingresar.ShowDialog();
        }
    }
}
