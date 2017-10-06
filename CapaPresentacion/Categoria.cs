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
    public partial class Categoria : UserControl
    {

        public string x;
        public string j;
       

        public Categoria()
        {
            InitializeComponent();
            mostrar(); 
        }

        public void mostrar()
         {
            try
            {
                this.Dock = DockStyle.Fill;
                this.dataGridViewCategoria.DataSource = Lcategoria.mostrar();
                this.dataGridViewCategoria.Columns[0].Visible = false;

            }
            catch (Exception ex)
            { 
            mesajerror(ex .Message);
            }
        }

         public void bucar()
         {
             try
             {
                 this.dataGridViewCategoria.DataSource = Lcategoria.Buscar(this.txtbuscar.Text);
             }
             catch (Exception ex)
             {
                 mesajerror(ex.Message);
             
             }
         }
         //private void tableLayoutPanelTop_Paint(object sender, PaintEventArgs e)
         //{

         //}

       

         private void mesajerror(string mensaje)
         {
             MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }

         public DataGridViewRow ObtenerSeleccion()
         {
             DataGridViewRow filaSeleccionada = this.dataGridViewCategoria.Rows[this.dataGridViewCategoria.CurrentRow.Index];
             return filaSeleccionada;
         }

        private void btneditar_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.dataGridViewCategoria.Rows.Count > 0)
                {
                    FrmEditarCategoria editarcategoria = new FrmEditarCategoria(this);
                    editarcategoria.ShowDialog();
                }
                else
                {
                    mesajerror("Debe seleccionar una fila para editar");
                }
            }
            catch (Exception ex)
            { 
            mesajerror(ex .Message);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
             if (this.txtbuscar.Text == String.Empty)
            {
                //this.numeroPagina = 1;
                this.mostrar();
                //this.tableLayoutPanelPaginacion.Show();
            }
            else
            {
                this.bucar();
                //this.tableLayoutPanelPaginacion.Hide();
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            FrmIngresarCategoria nuevacategoria = new FrmIngresarCategoria(this);
            nuevacategoria.ShowDialog();
        }

        public void cerrar()
        {
            
           this.ParentForm.Close();
        }
    }
}

       

