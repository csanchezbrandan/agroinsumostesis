using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;

namespace CapaPresentacion
{
    public partial class ConsultarCaategoria : Form
    {
        //FrmIngresarProducto Ingresar;
        public ConsultarCaategoria()
        {
            InitializeComponent();
            mostrar();
        }

        public void mostrar()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                this.dataGridViewCategoria.DataSource = Lcategoria.mostrarC();
                this.dataGridViewCategoria.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                mesajerror(ex.Message);
            }
        }

        private void mesajerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DataGridViewRow ObtenerSeleccion()
        {
            DataGridViewRow filaSeleccionada = this.dataGridViewCategoria.Rows[this.dataGridViewCategoria.CurrentRow.Index];
            return filaSeleccionada;
        }

        public void cerrar()
        {

            this.Close();
        }

        public void buscar()
        {
            try
            {
                this.dataGridViewCategoria.DataSource = Lcategoria.Buscar(this.txtconsultarCategoria.Text);

            }
            catch (Exception ex)
            {
                mesajerror(ex.Message);
            }    
        }

        private void dataGridViewCategoria_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Iform miinterfaz = this.Owner as Iform;
            if (miinterfaz != null)
                miinterfaz.enviarTexto(Convert.ToString(dataGridViewCategoria.CurrentRow.Cells["ID"].Value), (Convert.ToString(dataGridViewCategoria.CurrentRow.Cells["NOMBRE"].Value)));
            this.Close();
        }

        private void btnagregarcateg_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dataGridViewCategoria.Rows.Count > 0)
                {
                    Iform miinterfaz = this.Owner as Iform;
                    if (miinterfaz != null)
                        miinterfaz.enviarTexto(Convert.ToString(dataGridViewCategoria.CurrentRow.Cells["ID"].Value), (Convert.ToString(dataGridViewCategoria.CurrentRow.Cells["NOMBRE"].Value)));
                    this.Close();
                }
                else
                {
                    mesajerror("Debe seleccionar una fila para agregar Proveedor");
                }
            }
            catch (Exception ex)
            {
                mesajerror(ex.Message);
            }
        }
        private void txtconsultarCategoria_TextChanged(object sender, EventArgs e)
        {
            if (this.txtconsultarCategoria.Text == string.Empty)
            {
                this.mostrar();

            }
            else
            {
                this.buscar();
            }
        }
    }
}
