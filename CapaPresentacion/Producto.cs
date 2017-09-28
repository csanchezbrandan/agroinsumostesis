using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class Producto : UserControl
    {
        //Categoria _ini;
        public Producto()
        {
            InitializeComponent();
            mostrar();
        }

       

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmIngresarProducto ingrersar = new FrmIngresarProducto(this);
            ingrersar.ShowDialog();
            
            
        }

        private void mesajerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public void mostrar()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                this.dataGridViewProduct.DataSource = Lproducto.MostrarP();
                this.dataGridViewProduct.Columns[0].Visible = false;
                //this.ocultarcolumna();





                // lblTregistro.Text = Convert.ToString(dataGridViewCategoria.Rows.Count);
            }
            catch (Exception ex)
            {
                mesajerror(ex.Message);
            }
        }

        

       
     
    }
}
