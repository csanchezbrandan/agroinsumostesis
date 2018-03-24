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
    public partial class FrmEditarCliente : Form
    {
        Cliente _owner;
        int Id_Cliente;

        public FrmEditarCliente()
        {
            InitializeComponent();
        }

        public FrmEditarCliente(Cliente owner)
        {
            _owner = owner;
            InitializeComponent();

            this.Id_Cliente = Convert.ToInt32(_owner.ObtenerSeleccion().Cells["ID"].Value);
            this.txtcalle.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["CALLE"].Value);
            this.txtCelul.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["CELULAR"].Value);
            this.txtnombre.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["NOMBRE"].Value);
            this.txtapellido.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["APELLIDO"].Value);
            this.txtmailc.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["EMAIL"].Value);
            this.txtestadoc.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["ESTADO"].Value);
            //this.txtProv.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["PROVINCIA"].Value);
            //this.txtlocalidad.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["LOCALIDAD"].Value);
            //this.txtNcalle.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["NRO CALLE"].Value);
            
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            String mensaje = Lcliente.EditarC(this.Id_Cliente, this.txtcalle.TextLength, this.txtCelul.TextLength, this.txtnombre.Text,
                this.txtapellido.Text, this.txtmailc.Text, this.txtestadoc.Text);

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("El Cliente {0} ha sido EDITADO", this.txtnombre.Text));
                this._owner.Refrescar();
                this.Close();
            }
            else
            {
                MensajeError(mensaje);
            }
        }
    }
}
