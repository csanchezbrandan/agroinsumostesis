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
    public partial class FrmIngresarProveedor : Form
    {
        Proveedor _owner;
        private bool isnuevo = false;
        public FrmIngresarProveedor()
        {
            InitializeComponent();
        }

        public FrmIngresarProveedor(Proveedor owner)
        {
            _owner = owner;
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

           
            this.txtidtelef.ReadOnly = !valor;
            this.txtiddire.ReadOnly = !valor;
            this.txtRZ.ReadOnly = !valor;
            this.txtdni.ReadOnly = !valor;
            this.txtdnipd.ReadOnly = !valor;
            this.txtdnipt.ReadOnly = !valor;
            this.txtdni.ReadOnly = !valor;
            this.txtnomcontat.ReadOnly = !valor;
            this.txtPartic.ReadOnly = !valor;
            this.txtCelul.ReadOnly = !valor;
            this.txtbarrio.ReadOnly = !valor;
            this.txtcalle.ReadOnly = !valor;
            this.txtcp.ReadOnly = !valor;
            this.txtestado.ReadOnly = !valor;
            this.txtiddire.ReadOnly = !valor;
            this.txtidtelef.ReadOnly = !valor;
            this.txtNcalle.ReadOnly = !valor;
            this.txtfax.ReadOnly = !valor;
           
                       
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

                if (this.txtnomcontat.Text == string.Empty && this.txtRZ.Text == string.Empty)
                {
                    mesajerror("No puede dejar nombre de campo vacío");
                    erroricono.SetError(txtdni, "Debe ingresar nombre de Proveedor");
                }
               
                if (this.isnuevo)

                {

                  
                    this.txtdnipt.Text = this.txtdni.Text;
                    this.txtdnipd.Text = this.txtdni.Text;
                    this.txtiddire.Text = this.txtdni.Text;
                    this.txtidtelef.Text = this.txtdni.Text;
                    
                    rsp = Lproveedor_telef.InsertarTP(Convert.ToInt32(this.txtidtelef.Text), Convert.ToInt32(this.txtPartic.Text), Convert.ToInt32(this.txtCelul.Text), Convert.ToInt32(this.txtfax.Text));
                   
                    rsp = Lproveedor_direcc.InsertarPD(Convert.ToInt32(this.txtiddire.Text), this.txtcalle.Text, Convert.ToInt32(this.txtNcalle.Text),this.txtProv.Text, this.txtlocalidad.Text, this.txtbarrio.Text, Convert.ToInt32(this.txtcp.Text));

                    rsp = Lproveedor_t_d.insertar(Convert.ToInt32(this.txtdnipt.Text), Convert.ToInt32(this.txtdnipd.Text),this.txtRZ.Text, this.txtnomcontat.Text, this.txtmail.Text, this.txtestado.Text, Convert.ToInt32(this.txtdni.Text));
                                        
               }
               
     
                          if (rsp.Equals("Y"))
                               {
                                   this.mesajeok("Se registró con exito");

                                   _owner.mostrarP();

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
        private void FrmIngresarProveedor_Load(object sender, EventArgs e)
        {
            cajatextoHabilitar(false);
            botones();
        }


    }
}
