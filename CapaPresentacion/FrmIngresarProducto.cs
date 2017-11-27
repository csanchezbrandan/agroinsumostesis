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
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class FrmIngresarProducto : Form, Iform,Iform3
    {
    
         Producto _owner;
         private bool isnuevo = false;
        
       //private FrmInicio inicio;

        public FrmIngresarProducto()
        {
            InitializeComponent();
           
        }
        
        public FrmIngresarProducto(Producto owner)
        {
            InitializeComponent();
            _owner = owner;
        }

        public void enviarTexto(string enviar1, string enviar2)
        {
            txtidcategoria.Text = enviar1;
            txtnombreCategoria.Text = enviar2;
        }

        public void enviarTexto1(string enviar1, string enviar2)
        {
            txtidProveed.Text = enviar1;
            txtNombProveedor.Text = enviar2;
        }

        public void cajatextoHabilitar(bool valor)
        {


            this.txtNombProveedor.ReadOnly = !valor;
            this.txtidcategoria.ReadOnly = !valor;
            this.txtdescripProd.ReadOnly = !valor;
            this.txtestadoP.ReadOnly = !valor;
            this.txtidProveed.ReadOnly = !valor;
            //this.pximagen.ReadOnly = !valor;
            this.txtMarca.ReadOnly = !valor;
            this.txtnombreProduco.ReadOnly = !valor;
            this.txtPrecCompra.ReadOnly = !valor;
            this.txtPrecUnit.ReadOnly = !valor;
            this.txtPuntReposicion.ReadOnly = !valor;
            this.txtStock.ReadOnly = !valor;
           

        }

        public void mesajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string PLMay(string texto)
        {
            return texto.Substring(0, 1).ToUpper() + texto.Substring(1);
        }

        
        //limpiar
        //private void limpiar()
        //{
        //    this.txtNombCateg.Text = string.Empty;
        //    this.txtdescripCateg.Text = string.Empty;
        //    this.textBox2.Text = string.Empty;
        //}

        private void botones()
        {
            if (this.isnuevo == true)
            {

                this.cajatextoHabilitar(true);
                this.btnguardar.Enabled = true;
                this.btnuevo.Enabled = false;
                this.btncancelar.Enabled = true;

            }
            else
            {

                this.cajatextoHabilitar(false);
                this.btnguardar.Enabled = false;
                this.btnuevo.Enabled = true;
                this.btncancelar.Enabled = false;

            }
        }

      //  public FrmIngresarProducto(ConsultarCaategoria owner)
      //  {
      //      //ConsultarCaategoria owner
      //      _owner = owner;
      //      InitializeComponent();

      //      //new Producto().mostrar();

      //rsp = txtidcategoria.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["ID"].Value);
      //  rsp = txtnombrecateg.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["NOMBRE"].Value);

          
      //      //_owner.cerrar();

      //  }
        //public FrmIngresarProducto(Producto prod)
        //{

        //    _prod = prod;
        //    InitializeComponent();

           

        //}
        

        //public  FrmIngresarProducto (FrmInicio inicio)
        //{

        //}
       //public Frmicio (categoria inicio)
       //{
       //    InitializeComponent();
       //    _inicio = inicio;
       //    _inicio.MostrarBotones();

       //}

      


        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
       private void mostrarconsultaCategoria ()
       {
           ConsultarCaategoria consulta = new ConsultarCaategoria();
           consulta.ShowDialog(this);
       }

       private void mostrarconsultaProveedor()
       {
          ConsultarProveedor consulta = new ConsultarProveedor();
          consulta.ShowDialog(this);
       }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
            
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
                        

                        rsp = Lproducto.InsertarP(Convert.ToInt32(this.txtidProveed.Text), Convert.ToInt32(this.txtidcategoria.Text), this.PLMay(this.txtnombreProduco.Text), Convert.ToDecimal(this.txtPrecCompra.Text), Convert.ToDecimal(this.txtPrecUnit.Text), Convert.ToDecimal(this.txtStock.Text), Convert.ToDecimal(this.txtPuntReposicion.Text), this.PLMay(this.txtMarca.Text), this.PLMay(this.txtestadoP.Text), imagen, Convert.ToDateTime(this.dtpikerVencimiento.Text),(this.cbxUniMedid.Text), this.txtdescripProd.Text);

                    }
                    //Convert.ToDateTime(this.dtpikeringreso.Text), Convert.ToDateTime(this.dtpikegreso.Text) 

                    if (rsp.Equals("Y"))
                    {
                        this.mesajeok("Se registró con exito");

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

        

        private void btnuevo_Click(object sender, EventArgs e)
        {
            this.isnuevo = true;
            botones();
        }

        private void FrmIngresarProducto_Load(object sender, EventArgs e)
        {
            cajatextoHabilitar(false);
            botones();
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
      

       
          
            
            
        }
    
}
