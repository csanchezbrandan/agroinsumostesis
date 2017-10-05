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
    public partial class FrmEditarCategoria : Form
    { 
        private bool iseditar = false;
        Categoria _valor;

        public FrmEditarCategoria()
        { 
            
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtCateg, "Ingrese nombre de Categoria");
            this.ttmensaje.SetToolTip(this.txtdescrip, "Ingrese descripcion de Categoria");

        }

        public  FrmEditarCategoria (Categoria valor)
        {
            
            InitializeComponent();
            _valor = valor;

            this.txtcodigo.Text = Convert.ToString(_valor.ObtenerSeleccion().Cells["ID"].Value);
            this.txtCateg.Text = Convert.ToString(_valor.ObtenerSeleccion().Cells["NOMBRE"].Value);
            this.txtdescrip.Text=Convert.ToString(_valor.ObtenerSeleccion().Cells["DESCRIPCION"].Value);
            
        }


       
        //mensaje de confirmacion

       public void mesajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //mensaje de error
        private void mesajerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //limpiar
        private void limpiar()
        {
            this.txtCateg.Text = string.Empty;
            this.txtdescrip.Text = string.Empty;
            this.txtcodigo.Text = string.Empty;
        }

        public void cajatextoHabilitar(bool valor)
        {
            
            this.txtCateg.ReadOnly = !valor;
            this.txtdescrip.ReadOnly = !valor;
        }

        private void botones()
        {
            if( this.iseditar == true)
           
            {

                this.cajatextoHabilitar(true);                
                this.btnguardar.Enabled = true;
                this.btneditar.Enabled = false;
                this.btncancelar.Enabled = true;

            }
            else
            {
                
                this.cajatextoHabilitar(false);
                this.btnguardar.Enabled = false;
                this.btneditar.Enabled = true;
                this.btncancelar.Enabled = false;
                
            }
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
           
            string rsp = "";
           
         try
         {

            if (this.txtCateg.Text == string.Empty)
            {
                mesajerror("No puede dejar nombre de campo vacío");
                erroricono.SetError(txtCateg, "Debe ingresar nombre de Categoria");
            }
            else
            {
                if (this.iseditar)
                {

                    rsp = Lcategoria.Editar(Convert.ToInt32(this.txtcodigo.Text), this.txtCateg.Text.ToUpper(), txtdescrip.Text);
                }


              if(rsp.Equals("Y"))
                
                                                 
                    {
                        this.mesajeok("Se editó correctamente");
                        _valor.mostrar();
                        this.Close();
                    }
                
                else
                {
                    this.mesajerror(rsp);
                }
             }
         }
                catch (Exception ex)
                {

                   MessageBox.Show(ex.Message );
                    
                }
        }

        private void FrmEditarCategoria_Load(object sender, EventArgs e)
        {
            this.cajatextoHabilitar(false);
            this.txtcodigo.ReadOnly = true;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();       

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            this.iseditar = true;
            this.botones();
            this.txtCateg.Focus();

        }   

    }  
     
     
}
