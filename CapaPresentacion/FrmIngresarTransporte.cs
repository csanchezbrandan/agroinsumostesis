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
    public partial class FrmIngresarTransporte : Form
    {
        Transporte _owner;
        private bool isnuevo= false;
         
        public FrmIngresarTransporte()
        {
            InitializeComponent();
        }
        public FrmIngresarTransporte(Transporte owner)
        {
            _owner=owner;
            InitializeComponent();
        }


        public void mesajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //mensaje de error
        private void mesajerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void cajatextoHabilitar(bool valor)
        {


           
            this.txtnombreTransp.ReadOnly = !valor;
            this.txtnombre.ReadOnly = !valor;
            this.txtdniT.ReadOnly = !valor;
            this.txtdniTd.ReadOnly = !valor;
            this.txtdniTt.ReadOnly = !valor;
            this.txtapellido.ReadOnly = !valor;
            this.txtmailc.ReadOnly = !valor;
            this.txtPartic.ReadOnly = !valor;
            this.txtCelul.ReadOnly = !valor;
            this.txtbarrio.ReadOnly = !valor;
            this.txtcalle.ReadOnly = !valor;
            this.txtcp.ReadOnly = !valor;
            this.txtestadoc.ReadOnly = !valor;
            this.txtiddireT.ReadOnly = !valor;
            this.txtidtelefT.ReadOnly = !valor;
            this.txtNcalle.ReadOnly = !valor;
            this.txtfax.ReadOnly = !valor;
            this.txtlocalidad.ReadOnly = !valor;
            this.txtProv.ReadOnly = !valor;


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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            
             string rsp = "";


            try
            {

                if (this.txtdniT.Text == string.Empty && this.txtmailc.Text == string.Empty)
                {
                    mesajerror("No puede dejar nombre de campo vacío");
                    erroricono.SetError(txtdniT, "Debe ingresar DNI de CLIENTE");
                }
               
                if (this.isnuevo)

                {
                    this.txtidtelefT.Text = this.txtdniT.Text;
                    this.txtiddireT.Text = this.txtdniT.Text;
                    this.txtdniTt.Text = this.txtdniT.Text;
                    this.txtdniTd.Text = this.txtdniT.Text;
                    
                   
                    
                    rsp = Lproveedor_telef.InsertarTP(Convert.ToInt32(this.txtidtelefT.Text), Convert.ToInt32(this.txtPartic.Text), Convert.ToInt32(this.txtCelul.Text),Convert.ToInt32(this.txtfax.Text));
                   
                    rsp = Lproveedor_direcc.InsertarPD(Convert.ToInt32(this.txtiddireT.Text), this.txtcalle.Text, Convert.ToInt32(this.txtNcalle.Text),this.txtProv.Text, this.txtlocalidad.Text, this.txtbarrio.Text, Convert.ToInt32(this.txtcp.Text));

                    rsp = Ltransporte.InsertarT(Convert.ToInt32(this.txtdniT.Text), Convert.ToInt32(this.txtdniTt.Text), Convert.ToInt32(this.txtdniTd.Text),this.txtnombreTransp.Text, this.PLMay(this.txtnombre.Text), this.PLMay(this.txtapellido.Text), this.txtmailc.Text, this.txtestadoc.Text);
                                        
                }
               
     
                          if (rsp.Equals("Y"))
                               {
                                   this.mesajeok("Se registró con exito");

                                   _owner.MostrarT();

                                   this.Close();
                                                  
                               }
                            else
                {
                    this.mesajerror(rsp);
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

        private void FrmIngresarTransporte_Load(object sender, EventArgs e)
        {
            this.txtdniT.Focus();
            cajatextoHabilitar(false);
            botones();
        }

    
       
   }
}
