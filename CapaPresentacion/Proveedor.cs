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
    public partial class Proveedor : UserControl
    {
        public Proveedor()
        {
            InitializeComponent();
            mostrarP();
            this.Dock = DockStyle.Fill;
        }

        private void mesajerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void 
            mostrarP()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                this.dataGridViewProveedor.DataSource = Lproveedor_t_d.mostrarP();
                //this.dataGridViewProveedor.Columns[0].Visible = false;
                //this.ocultarcolumna();

                // lblTregistro.Text = Convert.ToString(dataGridViewCategoria.Rows.Count);
            }
            catch (Exception ex)
            {
                mesajerror(ex.Message);
            }
        }
        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmIngresarProveedor agregarProveedor = new FrmIngresarProveedor(this);
            agregarProveedor.ShowDialog();
            
        }
    }
}
