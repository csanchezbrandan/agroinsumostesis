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
    public partial class ConsultarProveedor : Form
    {
        public ConsultarProveedor()
        {
            InitializeComponent();
            mostrar();
        }


        public void mostrar()
        {
            try
            {
                this.Dock = DockStyle.Fill;
                this.dataGridViewProveedor. DataSource =Lproveedor_t_d.mostrarP();
                this.dataGridViewProveedor.Columns[0].Visible = false;
                //this.ocultarcolumna();





                // lblTregistro.Text = Convert.ToString(dataGridViewCategoria.Rows.Count);
            }
            catch (Exception ex)
            {
                mesajerror(ex.Message);
            }
        }

        private void dataGridViewProveedor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Iform3 miinterfazz = this.Owner as Iform3;
            if (miinterfazz != null)
                miinterfazz.enviarTexto1(Convert.ToString(dataGridViewProveedor.CurrentRow.Cells["ID"].Value), (Convert.ToString(dataGridViewProveedor.CurrentRow.Cells["RAZON SOCIAL"].Value)));
            this.Close();


        }

       


        //private void ocultarcolumna()
        //{
        //   // this.dataGridViewCategoria.Columns[0].Visible = false;
        //   // this.dataGridViewCategoria.Columns[1].Visible = false;

        //}



        //public void bucar()
        //{
        //    try
        //    {
        //        this.dataGridViewCategoria.DataSource = Lcategoria.Buscar(this.txtbuscar.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        mesajerror(ex.Message);

        //    }
        //}
        ////private void tableLayoutPanelTop_Paint(object sender, PaintEventArgs e)
        //{

        //}



        private void mesajerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DataGridViewRow ObtenerSeleccion()
        {
            DataGridViewRow filaSeleccionada = this.dataGridViewProveedor.Rows[this.dataGridViewProveedor.CurrentRow.Index];

            //new FrmIngresarProducto(this).CargarCategorias();

            return filaSeleccionada;



        }

        //private void btneditar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        if (this.dataGridViewCategoria.Rows.Count > 0)
        //        {
        //            FrmEditarCategoria editarcategoria = new FrmEditarCategoria(this);
        //            editarcategoria.ShowDialog();
        //        }
        //        else
        //        {
        //            mesajerror("Debe seleccionar una fila para editar");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        mesajerror(ex.Message);
        //    }
        //}

        //private void txtbuscar_TextChanged(object sender, EventArgs e)
        //{
        //    if (this.txtbuscar.Text == String.Empty)
        //    {
        //        //this.numeroPagina = 1;
        //        this.mostrar();
        //        //this.tableLayoutPanelPaginacion.Show();
        //    }
        //    else
        //    {
        //        this.bucar();
        //        //this.tableLayoutPanelPaginacion.Hide();
        //    }
        //}

        //private void btnagregar_Click(object sender, EventArgs e)
        //{
        //    FrmIngresarCategoria nuevacategoria = new FrmIngresarCategoria(this);
        //    nuevacategoria.ShowDialog();
        //}


        public void cerrar()
        {

            this.Close();
        }

        private void dataGridViewProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Iform3 miinterfazz = this.Owner as Iform3;
            //if (miinterfazz != null)
            //    miinterfazz.enviarTexto1(Convert.ToString(dataGridViewProveedor.CurrentRow.Cells["ID"].Value), (Convert.ToString(dataGridViewProveedor.CurrentRow.Cells["RAZON SOCIAL"].Value)));
            //this.Close();



        }

        private void btnagregarcateg_Click(object sender, EventArgs e)
        {
              try
                {

                    if (this.dataGridViewProveedor.Rows.Count > 0)
                    {

                        Iform3 miinterfazz = this.Owner as Iform3;
                        if (miinterfazz != null)
                            miinterfazz.enviarTexto1(Convert.ToString(dataGridViewProveedor.CurrentRow.Cells["ID"].Value), (Convert.ToString(dataGridViewProveedor.CurrentRow.Cells["RAZON SOCIAL"].Value)));
                        this.Close();
                    }
                    else
                    {
                        mesajerror("Debe seleccionar una fila para editar");
                    }
                }
                catch (Exception ex)
                {
                    mesajerror(ex.Message);
                }
            

        }

              

       
    
    }
}
