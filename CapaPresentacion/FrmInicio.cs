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
using CapaPresentacion;

namespace CapaPresentacion
{
    
    public partial class FrmInicio : Form
    {

        public delegate  void Consultar_Categ();
        public event EventHandler consultar;
     //   FrmIngresarProducto prod;

        Pedido controlPedidio;
        Producto controlProducto;
        Categoria controlCateg;
        Cliente controlClient;
        Empleado controlEmpl;
        Proveedor controlProv;
        Transporte controlTrans;
        venta controlventa;
        //Comprobante controlCompro;
   //     Producto _cat;
        public FrmInicio()
        {
            InitializeComponent();
           controlPedidio = new Pedido();                                                  
           controlProducto= new Producto();
           controlCateg= new Categoria();
           controlClient= new Cliente();
           controlEmpl= new Empleado();
           controlProv= new Proveedor();
           controlTrans= new Transporte();
          // controlCompro = new Comprobante();

            //this.borrarpanel();
            //Categoria ver = new Categoria();

            //ver.mostrar();
            
            
            //new Categoria().mostrar();
                      
        }

        public FrmInicio(Producto cat)
        {
            InitializeComponent();
            
            this.btnproducto.Controls.Add(controlProducto);
            //this.borrar();


        }

        public FrmInicio(Categoria cat)
        {
            InitializeComponent();

           


        }





       

       public void Consultar_Load()
        {
            var evento = consultar;
           if (evento != null)
           {
            
            this.panelContenedor.Controls.Clear();
            
            this.panelContenedor.Controls.Add(new Categoria());
            new Categoria().mostrar();
           }
           
        }

       

	
       
//    private void Form_Load(...)
//    {
//        ConsultaFac _consultaFac = new ConsultaFac();
//        panel1.Controls.Add(_consultaFac);
//        _consultaFac.EventoComunica += _consultaFac_EventoComunica;
//    }

//    void _consultaFac_EventoComunica(EventArgs e)
//    {
//                panel1.Controls.Clear();
//        panel1.Controls.Add(new MuestraFac());            
//    }
//}
        //public FrmInicio(FrmIngresarProducto _prod)
        //{
        //    prod = _prod;
        //    InitializeComponent();
        //    MostrarBotones();
           
        //    ////_owner = owner;
        //    ////new Categoria();


        //}

        //private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        //{
            
        //}

        private void btnlista_Click(object sender, EventArgs e)
        {
            
            ////Pedido controlPedidio = new Pedido();
            //this.panelContenedor.Controls.Clear();
            //this.panelContenedor.Controls.Add(controlPedidio);
            abrirlista();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Producto controlProducto = new Producto();
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(controlProducto);
            //abrirproducto();
           
  


        }

        public void btncategoria_Click(object sender, EventArgs e)
         {
        
           
            ////Categoria controlCateg = new Categoria();
            //this.panelContenedor.Controls.Clear();
            //this.panelContenedor.Controls.Add(controlCateg);
             abrircategoria();
           
         }
        

        private void btncliente_Click(object sender, EventArgs e)
        {
            //Cliente controlClient = new Cliente();
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(controlClient);
        }

        private void btnemplead_Click(object sender, EventArgs e)
        {
            //Empleado controlEmpl = new Empleado();
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add (controlEmpl );
        }

        private void btnproveed_Click(object sender, EventArgs e)
        {
            //Proveedor controlProv = new Proveedor();
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(controlProv);

        }

        private void btntransport_Click(object sender, EventArgs e)
        {
            //Transporte controlTrans = new Transporte();
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(controlTrans);
        }

        public void MostrarBotones()
        {

            this.btncategoria.Visible=true;
            this.btncliente.Visible = false;
            this.btnproducto.Visible = false;
            
                        
                    
        }
       
            //Categoria controlCat = new Categoria();
            //this.panelContenedor.Controls.Clear();
            //this.panelContenedor.Controls.Add(controlCat);

        public void  borrar()
          
         {
            //Categoria controlCateg = new Categoria();
             this.panelContenedor.Controls.Clear();
            //this.panelContenedor.Controls.Remove(controlCateg);
            //return;
        
        }
        public void abrirlista()
        {

            //Pedido controlPedidio = new Pedido();
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(controlPedidio);
 
        }
        public void abrircategoria()
        {

            //Categoria controlCateg = new Categoria();
            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(new Categoria());
        }
        public void abrirproducto()
        {

            //Producto controlProducto = new Producto();

            FrmInicio inicio = new FrmInicio();

          
           panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(new Producto());
            inicio.ShowDialog();
            //new Producto().mostrar();
           
        }

        private void btncobro_Click(object sender, EventArgs e)
        {
            //this.panelContenedor.Controls.Clear();
            //this.panelContenedor.Controls.Add(new Comprobante());

            this.panelContenedor.Controls.Clear();
            this.panelContenedor.Controls.Add(new venta());

        }        
    }
}






