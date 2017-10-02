using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
   public class Dproducto
    {
        private int _idproducto;
        private int _idproveedor;
        private int _idcategoria;
        private string _nombreP;
        private decimal _preciocompra;
        private decimal _stock;
        private decimal _puntreposi;
        private string _marca;
        private string _unidmedida;
        private string _estado;
        private byte [] _imagen;
        private DateTime _fvencimiento;
        private decimal _preciounitario;
        private string _descripcion;
        public int Idproducto
        {
            get { return _idproducto; }
            set { _idproducto = value; }
        }
      

        public int Idproveedor
        {
            get { return _idproveedor; }
            set { _idproveedor = value; }
        }
       

        public int Idcategoria
        {
            get { return _idcategoria; }
            set { _idcategoria = value; }
        }
    

        public string NombreP
        {
            get { return _nombreP; }
            set { _nombreP = value; }
        }
      

        public decimal Preciocompra
        {
            get { return _preciocompra; }
            set { _preciocompra = value; }
        }
        

        public decimal Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
       

        public decimal Puntreposi
        {
            get { return _puntreposi; }
            set { _puntreposi = value; }
        }
        

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
       

        public string Unidmedida
        {
            get { return _unidmedida; }
            set { _unidmedida = value; }
        }
       

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
      

        public byte[] Imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }
   

        public DateTime Fvencimiento
        {
            get { return _fvencimiento; }
            set { _fvencimiento = value; }
        }
    

        public decimal Preciounitario
        {
            get { return _preciounitario; }
            set { _preciounitario = value; }
        }
       

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public Dproducto()
        { 
        }
        public Dproducto(int IDPROUD, int IDPROV, int IDCATEG, string NOMBP, decimal PRECCOMP, decimal STOCK, decimal PREPOS, string MARCA, string UNIMEDID, string ESTADO, byte[] IMAGEN, DateTime FVENCIM, decimal PREUNITAR, string DESCRIP)

        {
            this.Idproducto = IDPROUD;
            this.Idproveedor = IDPROV;
            this.Idcategoria = IDCATEG;
            this.NombreP = NOMBP;
            this.Preciocompra = PRECCOMP;
            this.Stock = STOCK;
            this.Puntreposi = PREPOS;
            this.Marca = MARCA;
            this.Unidmedida = UNIMEDID;
            this.Estado = ESTADO;
            this.Imagen = IMAGEN;
            this.Fvencimiento = FVENCIM;
            this.Preciounitario = PREUNITAR;
            this.Descripcion = DESCRIP;
 
        }

        public DataTable MostraP()
        {
            DataTable dt = new DataTable();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand cmdp = new SqlCommand();
                cmdp.Connection = sqlcon;
                cmdp.CommandText = "Produccion.MostrarProducto";
                cmdp.CommandType = CommandType.StoredProcedure;

                cmdp.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmdp);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                dt = null;

                throw new Exception("Erro al ejecutar el Procedimiento almacenado Produccion.MostrarProducto" + ex.Message, ex);

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }
            return dt;
        }

        public string InsertarProducto(Dproducto producto)
        {

            string rsp = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "Produccion.InsertarProducto";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paridprov = new SqlParameter();
                paridprov.ParameterName = "@idproveedor";
                paridprov.SqlDbType = SqlDbType.Int;
                paridprov.Value = producto.Idproveedor;
                cmd.Parameters.Add(paridprov);


                SqlParameter paridc = new SqlParameter();
                paridc.ParameterName = "@idcategoria";
                paridc.SqlDbType = SqlDbType.Int;
                paridc.Value = producto.Idcategoria;
                cmd.Parameters.Add(paridc);

              
                SqlParameter parnomp = new SqlParameter();
                parnomp.ParameterName = "@nombreprod";
                parnomp.SqlDbType = SqlDbType.VarChar;
                parnomp.Size = producto.NombreP.Length;
                parnomp.Value = producto.NombreP;
                cmd.Parameters.Add(parnomp);

                SqlParameter parpreccomp = new SqlParameter();
                parpreccomp.ParameterName = "@preciocompra";
                parpreccomp.SqlDbType = SqlDbType.SmallMoney;
                parpreccomp.Value = producto.Preciocompra;
                cmd.Parameters.Add(parpreccomp);


                SqlParameter parstock = new SqlParameter();
                parstock.ParameterName = "@stock";
                parstock.SqlDbType = SqlDbType.Decimal;
                parstock.Value = producto.Stock;
                cmd.Parameters.Add(parstock);

                SqlParameter parreposicion = new SqlParameter();
                parreposicion.ParameterName = "@preposicion";
                parreposicion.SqlDbType = SqlDbType.Decimal;
                parreposicion.Value = producto.Puntreposi;
                cmd.Parameters.Add(parreposicion);

                SqlParameter parmarca = new SqlParameter();
                parmarca.ParameterName = "@marca";
                parmarca.SqlDbType = SqlDbType.VarChar;
                parmarca.Size = producto.Marca.Length;
                parmarca.Value = producto.Marca;
                cmd.Parameters.Add(parmarca);

                SqlParameter parunimedid = new SqlParameter();
                parunimedid.ParameterName = "@umedida";
                parunimedid.SqlDbType = SqlDbType.VarChar;
                parunimedid.Size = producto.Unidmedida.Length;
                parunimedid.Value = producto.Unidmedida;
                cmd.Parameters.Add(parunimedid);

                SqlParameter parestad = new SqlParameter();
                parestad.ParameterName = "@estado";
                parestad.SqlDbType = SqlDbType.VarChar;
                parestad.Size = producto.Estado.Length;
                parestad.Value = producto.Estado;
                cmd.Parameters.Add(parestad);

                SqlParameter parimag = new SqlParameter();
                parimag.ParameterName = "@imagen";
                parimag.SqlDbType = SqlDbType.Image;
                parimag.Size = producto.Imagen.Length;
                parimag.Value = producto.Imagen; 
                cmd.Parameters.Add(parimag);

                SqlParameter parfvenc = new SqlParameter();
                parfvenc.ParameterName = "@fvencimiento";
                parfvenc.SqlDbType = SqlDbType.Date;
                parfvenc.Value = producto.Fvencimiento;
                cmd.Parameters.Add(parfvenc);

                SqlParameter parprecunit = new SqlParameter();
                parprecunit.ParameterName = "@preciounitario";
                parprecunit.SqlDbType = SqlDbType.SmallMoney;
                parprecunit.Value = producto.Preciounitario;
                cmd.Parameters.Add(parprecunit);

                SqlParameter pardesc = new SqlParameter();
                pardesc.ParameterName = "@descrip";
                pardesc.SqlDbType = SqlDbType.VarChar;
                pardesc.Size = producto.Descripcion.Length;
                pardesc.Value = producto.Descripcion;
                cmd.Parameters.Add(pardesc);

                cmd.ExecuteNonQuery();

                rsp = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    rsp = "Has introducido demasiados caracteres en uno de los campos.";
                }
                else if (ex.Number == 2627)
                {
                    rsp = "Ya existe un Producto con ese Nombre.";
                }
                else if (ex.Number == 515)
                {
                    rsp = "No puedes dejar el campo Nombre vacío.";
                }
                else
                {
                    rsp = "Error al intentar ejecutar el procedimiento almacenado Produccion.EditarProducto. " + ex.Message;
                }

            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
 
            }
            return rsp;
        }
        public string Editar(Dproducto producto)
        {
            string rsp = "";
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcon;
                cmd.CommandText = "Produccion.EditarProducto";
                cmd.CommandType = CommandType.StoredProcedure;

                /*psar parametro*/
                SqlParameter paridprov = new SqlParameter();
                paridprov.ParameterName = "@idproveedor";
                paridprov.SqlDbType = SqlDbType.Int;
                paridprov.Value = producto.Idproveedor;
                cmd.Parameters.Add(paridprov);


                SqlParameter paridc = new SqlParameter();
                paridc.ParameterName = "@idcategoria";
                paridc.SqlDbType = SqlDbType.Int;
                paridc.Value = producto.Idcategoria;
                cmd.Parameters.Add(paridc);


                SqlParameter parnomp = new SqlParameter();
                parnomp.ParameterName = "@nombreprod";
                parnomp.SqlDbType = SqlDbType.VarChar;
                parnomp.Size = producto.NombreP.Length;
                parnomp.Value = producto.NombreP;
                cmd.Parameters.Add(parnomp);

                SqlParameter parpreccomp = new SqlParameter();
                parpreccomp.ParameterName = "@preciocompra";
                parpreccomp.SqlDbType = SqlDbType.SmallMoney;
                parpreccomp.Value = producto.Preciocompra;
                cmd.Parameters.Add(parpreccomp);


                SqlParameter parstock = new SqlParameter();
                parstock.ParameterName = "@stock";
                parstock.SqlDbType = SqlDbType.Decimal;
                parstock.Value = producto.Stock;
                cmd.Parameters.Add(parstock);

                SqlParameter parreposicion = new SqlParameter();
                parreposicion.ParameterName = "@preposicion";
                parreposicion.SqlDbType = SqlDbType.Decimal;
                parreposicion.Value = producto.Puntreposi;
                cmd.Parameters.Add(parreposicion);

                SqlParameter parmarca = new SqlParameter();
                parmarca.ParameterName = "@marca";
                parmarca.SqlDbType = SqlDbType.VarChar;
                parmarca.Size = producto.Marca.Length;
                parmarca.Value = producto.Marca;
                cmd.Parameters.Add(parmarca);

                SqlParameter parunimedid = new SqlParameter();
                parunimedid.ParameterName = "@umedida";
                parunimedid.SqlDbType = SqlDbType.VarChar;
                parunimedid.Size = producto.Unidmedida.Length;
                parunimedid.Value = producto.Unidmedida;
                cmd.Parameters.Add(parunimedid);

                SqlParameter parestad = new SqlParameter();
                parestad.ParameterName = "@estado";
                parestad.SqlDbType = SqlDbType.VarChar;
                parestad.Size = producto.Estado.Length;
                parestad.Value = producto.Estado;
                cmd.Parameters.Add(parestad);

                SqlParameter parimag = new SqlParameter();
                parimag.ParameterName = "@imagen";
                parimag.SqlDbType = SqlDbType.Image;
                parimag.Size = producto.Imagen.Length;
                parimag.Value = producto.Imagen;
                cmd.Parameters.Add(parimag);

                SqlParameter parfvenc = new SqlParameter();
                parfvenc.ParameterName = "@fvencimiento";
                parfvenc.SqlDbType = SqlDbType.Date;
                parfvenc.Value = producto.Fvencimiento;
                cmd.Parameters.Add(parfvenc);

                SqlParameter parprecunit = new SqlParameter();
                parprecunit.ParameterName = "@preciounitario";
                parprecunit.SqlDbType = SqlDbType.SmallMoney;
                parprecunit.Value = producto.Preciounitario;
                cmd.Parameters.Add(parprecunit);

                SqlParameter pardesc = new SqlParameter();
                pardesc.ParameterName = "@descrip";
                pardesc.SqlDbType = SqlDbType.VarChar;
                pardesc.Size = producto.Descripcion.Length;
                pardesc.Value = producto.Descripcion;
                cmd.Parameters.Add(pardesc);
                

                // rsp = cmd.ExecuteNonQuery() == 1 ? "ok" : "No se modificó el registro";
                cmd.ExecuteNonQuery();
                rsp = "Y";

            }


            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    rsp = "Has introducido demasiados caracteres en uno de los campos.";
                }
                else if (ex.Number == 2627)
                {
                    rsp = "Ya existe una categoría con ese Nombre.";
                }
                else if (ex.Number == 515)
                {
                    rsp = "No puedes dejar el campo Nombre vacío.";
                }
                else
                {
                    rsp = "Error al intentar ejecutar el procedimiento almacenado Produccion.EditarCategoria. " + ex.Message;
                }
            }

            finally
            {
                if (sqlcon.State == ConnectionState.Open)
                {
                    sqlcon.Close();
                }
            }

            return rsp;

        }
    }
}
