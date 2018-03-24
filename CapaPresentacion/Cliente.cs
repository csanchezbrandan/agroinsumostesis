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
        public DataGridViewRow ObtenerSeleccion()
        {
            DataGridViewRow filaSeleccionada = this.dataGridViewCliente.Rows[this.dataGridViewCliente.CurrentRow.Index];
            return filaSeleccionada;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmIngresarCliente ingreClin = new FrmIngresarCliente();
            ingreClin.ShowDialog();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewCliente.Rows.Count > 0)
                {
                    FrmEditarCliente editarCliente = new FrmEditarCliente(this);
                    editarCliente.ShowDialog();
                }
                else
                {
                    MensajeError("Debes seleccionar una fila para editar");
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void Mensaje(String mensaje)
        {
            this.labelMensajes.Text = mensaje;
        }
        //public void Refrescar()
        //{
            
        //    this.Mostrar();
        //}

    }
}
