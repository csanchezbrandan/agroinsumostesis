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
    public partial class FrmEditarProducto : Form
    {
        private bool iseditar = false;
        Producto _valor;

       Producto _owner;
        private bool isnuevo = false;

        public FrmEditarProducto()
        {
            InitializeComponent();
        }

        public FrmEditarProducto(Producto valor)
        {
            InitializeComponent();
            _valor = valor;
            this.txtidproducto.Text = Convert.ToString(_valor.ObtenerSeleccion().Cells["ID"].Value);
            this.txtMarca.Text = Convert.ToString(_valor.ObtenerSeleccion().Cells["DETALLE"].Value);
            this.txtnombreProduco.Text = Convert.ToString(_valor.ObtenerSeleccion().Cells["PRODUCTO"].Value);
            this.txtPrecUnit.Text = Convert.ToString(_valor.ObtenerSeleccion().Cells["PRECIO"].Value);
        }

        private void bttnabririmage_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                this.pximagen.Image = Image.FromFile(dialog.FileName);
            }
        }
        private void botones()
        {
            if (this.iseditar == true)
            {

                //this.cajatextoHabilitar(true);                
                this.btneditarp.Enabled = true;
                this.btncancelar.Enabled = true;

            }
            else
            {

                //  this.cajatextoHabilitar(false);
                this.btneditarp.Enabled = true;
                this.btncancelar.Enabled = true;

            }
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void mesajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {

            try
            {
                string rsp = "";

                if (this.txtnombreProduco.Text == string.Empty || this.txtStock.Text == string.Empty)
                {
                    MensajeError("No puede dejar nombre de campo vacío");
                    erroricono.SetError(txtnombreProduco, "Debe ingresar nombre Producto");
                }
                else
                {


                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    pximagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                    byte[] imagen = ms.GetBuffer();


                    if (this.isnuevo)
                    {

                        rsp = Lproducto.InsertarP(Convert.ToInt32(this.txtidProveed.Text), Convert.ToInt32(this.txtidcategoria.Text), this.txtnombreProduco.Text, Convert.ToDecimal(this.txtPrecCompra.Text), Convert.ToDecimal(this.txtPrecUnit.Text), Convert.ToDecimal(this.txtStock.Text), Convert.ToDecimal(this.txtPuntReposicion.Text), this.txtMarca.Text, this.txtestadoP.Text, imagen, Convert.ToDateTime(this.dtpikerVencimiento.Text), (this.cbxUniMedid.Text), this.txtdescripProd.Text);

                    } 

                    if (rsp.Equals("Y"))
                    {
                        this.mesajeok("Se Editó con exito");

                        _owner.mostrar();

                        this.Close();

                    }
                    else
                    {
                        this.MensajeError(rsp);
                    }


                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void bttnabririmage_Click_1(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                this.pximagen.Image = Image.FromFile(dialog.FileName);
            }
        }
        private void mostrarconsultaCategoria()
        {
            ConsultarCaategoria consulta = new ConsultarCaategoria();
            consulta.ShowDialog(this);
        }

        private void mostrarconsultaProveedor()
        {
            ConsultarProveedor consulta = new ConsultarProveedor();
            consulta.ShowDialog(this);
        }
        private void btnbusProd_Click(object sender, EventArgs e)
        {
            {
                this.mostrarconsultaCategoria();

            }
        }

        private void btnbusProv_Click(object sender, EventArgs e)
        {
            mostrarconsultaProveedor();
        }
    }
}
