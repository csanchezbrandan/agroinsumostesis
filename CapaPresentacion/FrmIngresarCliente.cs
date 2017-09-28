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
    public partial class FrmIngresarCliente : Form
    {
        private Cliente _ower;

        private bool isnuevo = false;
        public FrmIngresarCliente()
        {
            InitializeComponent();
           
        }

        public FrmIngresarCliente(Cliente ower)
        {
            _ower = ower;
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


            this.txtidtelefc.ReadOnly = !valor;
            this.txtiddirec.ReadOnly = !valor;
            this.txtnombre.ReadOnly = !valor;
            this.txtdnic.ReadOnly = !valor;
            this.txtdnicd.ReadOnly = !valor;
            this.txtdnict.ReadOnly = !valor;
            this.txtapellido.ReadOnly = !valor;
            this.txtmailc.ReadOnly = !valor;
            this.txtPartic.ReadOnly = !valor;
            this.txtCelul.ReadOnly = !valor;
            this.txtbarrio.ReadOnly = !valor;
            this.txtcalle.ReadOnly = !valor;
            this.txtcp.ReadOnly = !valor;
            this.txtestadoc.ReadOnly = !valor;
            this.txtiddirec.ReadOnly = !valor;
            this.txtidtelefc.ReadOnly = !valor;
            this.txtNcalle.ReadOnly = !valor;
            this.txtfax.ReadOnly = !valor;
            this.txtlocalidad.ReadOnly = !valor;
            this.txtProv.ReadOnly=!valor;
            

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

                if (this.txtdnic.Text == string.Empty && this.txtmailc.Text == string.Empty)
                {
                    mesajerror("No puede dejar nombre de campo vacío");
                    erroricono.SetError(txtdnic, "Debe ingresar DNI de CLIENTE");
                }
               
                if (this.isnuevo)

                {
                    this.txtidtelefc.Text = this.txtdnic.Text;
                    this.txtiddirec.Text = this.txtdnic.Text;
                    this.txtdnicd.Text = this.txtdnic.Text;
                    this.txtdnict.Text = this.txtdnic.Text;
                    
                    rsp = Lproveedor_telef.InsertarTP(Convert.ToInt32(this.txtidtelefc.Text), Convert.ToInt32(this.txtPartic.Text), Convert.ToInt32(this.txtCelul.Text),Convert.ToInt32(this.txtfax.Text));
                   
                    rsp = Lproveedor_direcc.InsertarPD(Convert.ToInt32(this.txtiddirec.Text), this.txtcalle.Text, Convert.ToInt32(this.txtNcalle.Text),this.txtProv.Text, this.txtlocalidad.Text, this.txtbarrio.Text, Convert.ToInt32(this.txtcp.Text));

                    rsp = Lcliente.InsertarC(Convert.ToInt32(this.txtdnic.Text), Convert.ToInt32(this.txtdnicd.Text), Convert.ToInt32(this.txtdnict.Text), this.PLMay(this.txtnombre.Text), this.PLMay(this.txtapellido.Text), this.txtmailc.Text, this.txtestadoc.Text);
                                        
               }
               
     
                          if (rsp.Equals("Y"))
                               {
                                   this.mesajeok("Se registró con exito");

                                   _ower.mostraC();

                                   //this.Close();

                    
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

        private void FrmIngresarCliente_Load(object sender, EventArgs e)
        {
            this.txtdnic.Focus();
            cajatextoHabilitar(false);
            botones();
            
        }

        
    }
}
