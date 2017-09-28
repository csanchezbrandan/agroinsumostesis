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
       
        
   

  //    FrmInicio _ower;
        public string x;
        public string j;
       

        public Categoria()
        {
            InitializeComponent();
           
            mostrar();

         

           
        }

       

       
        //
        public void mostrar()
         {
            try
            {
                this.Dock = DockStyle.Fill;
                this.dataGridViewCategoria.DataSource = Lcategoria.mostrar();
                this.dataGridViewCategoria.Columns[0].Visible = false;
                //this.ocultarcolumna();
              
               
                

                    
               // lblTregistro.Text = Convert.ToString(dataGridViewCategoria.Rows.Count);
            }
            catch (Exception ex)
            { 
            mesajerror(ex .Message);
            }
        }

       
        
        //private void ocultarcolumna()
        //{
        //   // this.dataGridViewCategoria.Columns[0].Visible = false;
        //   // this.dataGridViewCategoria.Columns[1].Visible = false;

        //}
        
       
       
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

             //new FrmIngresarProducto(this).CargarCategorias();

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
        //public void dataGridViewCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //FrmInicio v = new FrmInicio();
        //    //v.abrirproducto(); 
        //    //_ower.abrirproducto();
        //    this.ObtenerSeleccion();

        //    new FrmInicio().borrar();
           
        //    //new FrmIngresarCategoria().Close();


                       

        //    FrmIngresarProducto product = new FrmIngresarProducto(this);

     
        //    //new FrmIngresarProducto().ShowDialog();
           
            
           
        //    //v.borrar();
        //    //v.borrarpanel();

           
           
        //    //v.borrarpanel();


           

        //    //new FrmInicio().borrarpanel();
          


        //    //try
        //    //{

        //    //    if (this.dataGridViewCategoria.Rows.Count > 0)
        //    //    {
        //    //        x = Convert.ToString(ObtenerSeleccion().Cells["ID"].Value);
        //    //        j = Convert.ToString(ObtenerSeleccion().Cells["NOMBRE"].Value);

        //    //        new FrmIngresarProducto().CargarCategorias();

        //    //        new FrmIngresarCategoria().Close();

        //    //        FrmIngresarProducto product = new FrmIngresarProducto(this);
        //    //        product.ShowDialog();
        //    //    }
        //    //    else
        //    //    {
        //    //        mesajerror("Debe seleccionar una fila para cargar categoria");
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    mesajerror(ex.Message);
        //    //}

          
         
          
            
            

        //}

        private void dataGridViewCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
       
    }
        
      
 }

       

