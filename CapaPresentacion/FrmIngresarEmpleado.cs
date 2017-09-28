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
    public partial class FrmIngresarEmpleado : Form
    {

         Empleado _owner;
        private bool isnuevo=false;
        public FrmIngresarEmpleado()
        {
            InitializeComponent();
        }
        public FrmIngresarEmpleado(Empleado owner)
        {
            InitializeComponent();
            _owner=owner;
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

        //public void habilitarrbt()
        //{


        //    //this.lblfe.Visible = true;
        //    //this.lblfi.Visible = true;
        //    //|| this.rbtfe.Checked == true

        //    if (this.rbtfi.Checked ) 
        //        {

        //            this.lblfi.Visible = true;
        //            this.lblfe.Visible = false;


        //        }
        //        else
        //        {                    
        //            this.lblfe.Visible = true;
        //            this.lblfi.Visible = false;
        //        }


               
        
        //}
        public void cajatextoHabilitar(bool valor)
        {


            this.txtdnietelf.ReadOnly = !valor;
            this.txtdniedir.ReadOnly = !valor;
            this.txtnombre.ReadOnly = !valor;
            this.txtdnie.ReadOnly = !valor;
            this.txtidtelefe.ReadOnly = !valor;
            this.txtiddiree.ReadOnly = !valor;
            this.txtapellido.ReadOnly = !valor;
            this.txtmail.ReadOnly = !valor;
            this.txtPartic.ReadOnly = !valor;
            this.txtCelul.ReadOnly = !valor;
            this.txtbarrio.ReadOnly = !valor;
            this.txtcalle.ReadOnly = !valor;
            this.txtcp.ReadOnly = !valor;
            this.txtestadoc.ReadOnly = !valor;
            this.txtNcalle.ReadOnly = !valor;
            this.txtfax.ReadOnly = !valor;
            this.txtlocalidad.ReadOnly = !valor;
            this.txtProv.ReadOnly = !valor;
            this.rbtfe.Checked = false;
            this.rbtfi.Checked= false;
            this.rbtfe.Visible = valor;
            this.rbtfi.Visible = valor;

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

                if (this.txtdnie.Text == string.Empty && this.txtnombre.Text == string.Empty)
                {
                    mesajerror("No puede dejar nombre de campo vacío");
                    erroricono.SetError(txtdnie, "Debe ingresar DNI de CLIENTE");
                }

                if (this.isnuevo)

                {
                    this.txtidtelefe.Text = this.txtdnie.Text;
                    this.txtiddiree.Text = this.txtdnie.Text;
                    this.txtdnietelf.Text = this.txtdnie.Text;
                    this.txtdniedir.Text = this.txtdnie.Text;
                    
                    //this.txtfi.Text = (this.dtpikeringreso.Text);
                    //this.txtfe.Text = (this.dtpikeringreso.Text);

                    if (this.rbtfi.Checked)
                    {

                        this.lblfi.Visible = true;
                        this.lblfe.Visible = false;
                        this.txtfi.Text = this.dtpikeringreso.Text;
                        //Convert.ToDateTime(this.txtfi.Text);
                        this.txtfe.Text = "''";
                    }
                    else
                    {
                        this.lblfe.Visible = true;
                        this.lblfi.Visible = false;
                        this.txtfe.Text = this.dtpikeringreso.Text;
                        //Convert.ToDateTime(this.txtfe.Text);
                        this.txtfi.Text = "''";
                    }

                                                               
                  

                    
                    

                    
                    rsp = Lproveedor_telef.InsertarTP(Convert.ToInt32(this.txtidtelefe.Text), Convert.ToInt32(this.txtPartic.Text), Convert.ToInt32(this.txtCelul.Text),Convert.ToInt32(this.txtfax.Text));
                   
                    rsp = Lproveedor_direcc.InsertarPD(Convert.ToInt32(this.txtiddiree.Text), this.txtcalle.Text, Convert.ToInt32(this.txtNcalle.Text),this.txtProv.Text, this.txtlocalidad.Text, this.txtbarrio.Text, Convert.ToInt32(this.txtcp.Text));

                    rsp = Lempleado.InsertarE(Convert.ToInt32(this.txtdnie.Text), Convert.ToInt32(this.txtdnietelf.Text), Convert.ToInt32(this.txtdniedir.Text), this.PLMay(this.txtnombre.Text), this.PLMay(this.txtapellido.Text), this.txtmail.Text, this.txtestadoc.Text,(this.txtfi.Text),(this.txtfe.Text));
                                        
               }
                            //Convert.ToDateTime(this.dtpikeringreso.Text), Convert.ToDateTime(this.dtpikegreso.Text) 
     
                          if (rsp.Equals("Y"))
                               {
                                   this.mesajeok("Se registró con exito");

                                   _owner.MostrarE();

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

        private void FrmIngresarEmpleado_Load(object sender, EventArgs e)
        {
            this.txtdnie.Focus();
            cajatextoHabilitar(false);
            botones();
            //habilitarrbt();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            this.isnuevo = true;
            botones();
  
        }

        private void rbtfi_CheckedChanged(object sender, EventArgs e)
        {
            //habilitarrbt();
        }

       
    }
}
