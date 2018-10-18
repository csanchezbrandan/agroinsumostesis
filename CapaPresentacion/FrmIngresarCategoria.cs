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
    public partial class FrmIngresarCategoria : Form
    {
        Categoria _owner;
        private bool isnuevo = false;

        public FrmIngresarCategoria()
        {
            InitializeComponent();
        }

        public FrmIngresarCategoria(Categoria owner)
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

            this.textBox2.ReadOnly = !valor;
            this.txtdescripCateg.ReadOnly = !valor;
            this.txtNombCateg.ReadOnly = !valor;
            
        }

        //limpiar
        private void limpiar()
        {
            this.txtNombCateg.Text = string.Empty;
            this.txtdescripCateg.Text = string.Empty;
            this.textBox2.Text = string.Empty;
        }

        private void botones()
        {
            if (this.isnuevo == true)
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

                if (this.txtNombCateg.Text == string.Empty)
                {
                    mesajerror("No puede dejar nombre de campo vacío");
                    erroricono.SetError(txtNombCateg, "Debe ingresar nombre de Categoria");
                }
                     if (this.isnuevo)
                    {

                        rsp = Lcategoria.Insertar(this.txtNombCateg.Text, this.txtdescripCateg.Text);
                       

                    }
                        
                            if (rsp.Equals("Y"))
                            
                            {
                             this.mesajeok("Se registró con exito");

                             _owner.mostrar();                              
                                 
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

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.isnuevo = true;
            botones();
        }

        private void FrmIngresarCategoria_Load(object sender, EventArgs e)
        {
            this.cajatextoHabilitar(false);
            botones();
        }
    }
}
