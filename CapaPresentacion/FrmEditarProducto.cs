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

        public FrmEditarProducto()
        {
            InitializeComponent();
        }

        public FrmEditarProducto(Producto valor)
        {
            InitializeComponent();
             _valor = valor;
            this.txtidproducto.Text = Convert.ToString(_valor.ObtenerSeleccion().Cells["id_Producto"].Value);
            this.txtMarca.Text = Convert.ToString(_valor.ObtenerSeleccion().Cells["Marca"].Value);
            this.txtnombreProduco.Text = Convert.ToString(_valor.ObtenerSeleccion().Cells["nombre_Producto"].Value);
            this.txtdescripProd.Text = Convert.ToString(_valor.ObtenerSeleccion().Cells["descripcion"].Value);   
        }

        private void btneditarp_Click(object sender, EventArgs e)
        {
            this.iseditar = true;
          //  this.botones();
            this.txtnombreProduco.Focus();
        }
    }
     public void cajatextoHabilitar(bool valor)
        {
            
            this.txtnombreProduco.ReadOnly = !valor;
            this.txtdescripProd.ReadOnly = !valor;
           
        }
     private void botones()
        {
            if( this.iseditar == true)
           
            {

               this.cajatextoHabilitar(true);                
                this.txtdescripProd.Enabled = true;
                this.txtnombreProduco.Enabled = false;
               // this.btncancelar.Enabled = true;

            }
            else
            {
                
                this.txtdescripProd.Enabled = true;
                this.txtnombreProduco.Enabled = false;
                
            }
        }
}
