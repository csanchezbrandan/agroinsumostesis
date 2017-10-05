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
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class Producto : UserControl
    {
        //Categoria _ini;
        public Producto()
        {
            InitializeComponent();
            mostrar();
        }

       

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmIngresarProducto ingrersar = new FrmIngresarProducto(this);
            ingrersar.ShowDialog();
        }

        private void mesajerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void mostrar()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                this.dataGridViewProduct.DataSource = Lproducto.MostrarP();
                this.dataGridViewProduct.Columns[0].Visible = false;

            }
            catch (Exception ex)
            {
                mesajerror(ex.Message);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dataGridViewProduct.Rows.Count > 0)
                {
                    FrmEditarProducto editarcategoria = new FrmEditarProducto(this);
                    editarcategoria.ShowDialog();
                }
                else
                {
                    mesajerror("Debe seleccionar una fila para editar");
                }
            }
            catch (Exception ex)
            {
                mesajerror(ex.Message);
            }
        }
        public DataGridViewRow ObtenerSeleccion()
        {
            DataGridViewRow filaSeleccionada = this.dataGridViewProduct.Rows[this.dataGridViewProduct.CurrentRow.Index];
            return filaSeleccionada;
        }
    }
}
