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
    public partial class Empleado : UserControl
    {
        public Empleado()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            MostrarE();
        }

        private void mesajerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void MostrarE()
        {
            try
            {

                Dock = DockStyle.Fill;
                dataGridViewEmpleado.DataSource = Lempleado.MostrarE();
            }
            catch (Exception ex)
            {
                mesajerror(ex.Message);
 
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmIngresarEmpleado ingresar = new FrmIngresarEmpleado(this);
            ingresar.ShowDialog();
            
        }
    }
}
