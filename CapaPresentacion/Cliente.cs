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
    public partial class Cliente : UserControl
    {
        public Cliente()
        {
            InitializeComponent();
            mostraC();
            this.Dock = DockStyle.Fill;
        }

        private void mesajerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void  mostraC()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                this.dataGridViewCliente.DataSource = Lcliente.MostrarC();
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
            FrmIngresarCliente ingreClin = new FrmIngresarCliente(this);
            ingreClin.ShowDialog();
            

        }
    }
}
