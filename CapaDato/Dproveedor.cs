using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
   public class Dproveedor
    {
       private int _idprov;
       private int _dnitelefP;
       private int _dnidirP;
       private string _razonsocial;
       private string _nombrecontacto;
       private string _mail;
       private string _estado;
       private int _dni;


      
       
        
        public int Idprov
        {
            get { return _idprov; }
            set { _idprov = value; }
        }
      

       public int DnitelefP
       {
           get { return _dnitelefP; }
           set { _dnitelefP = value; }
       }

       public int DnidirP
       {
           get { return _dnidirP; }
           set { _dnidirP = value; }
       }
        public string Razonsocial
        {
            get { return _razonsocial; }
            set { _razonsocial = value; }
        }


        public string Nombrecontacto
        {
            get { return _nombrecontacto; }
            set { _nombrecontacto = value; }
        }


        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public int dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
      

       
       


        
        public Dproveedor()
        { 
        
        }

        public Dproveedor( int IDP,  int DNITELEFP, int DNIDIRP, string RAZONSOCIAL, string NOMBRECONT,string MAIL, string ESTADO ,int DNI)
        {
            this.Idprov=IDP;
            this.DnitelefP = DNITELEFP;
            this.DnidirP = DNIDIRP;
            this.Razonsocial=RAZONSOCIAL;
            this.Nombrecontacto=NOMBRECONT;
            this.Mail = MAIL;
            this.Estado = ESTADO;
            this.dni=DNI;
        
        }
        
        
            
        


        public  DataTable mostrarP()
        {

            DataTable dt = new DataTable("Produccion.MostrarProveedor");
            SqlConnection sqlcon = new SqlConnection();

            try
            {

                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand sqlcmand = new SqlCommand();
                sqlcmand.Connection = sqlcon;
                sqlcmand.CommandText = "Produccion.MostrarProveedor";
                sqlcmand.CommandType = CommandType.StoredProcedure;

                sqlcmand.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlcmand);
                adapter.Fill(dt);


            }

            catch (Exception ex)
            {

                dt = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.MostrarProveedor. " + ex.Message, ex);

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

        public string Insertar(Dproveedor Proveedor)
        {
            string rsp = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand sqlcmand = new SqlCommand();
                sqlcmand.Connection = sqlcon;
                sqlcmand.CommandText = "Produccion.InsertarProveedor";
                sqlcmand.CommandType = CommandType.StoredProcedure;

                

                SqlParameter pardnitelef = new SqlParameter();
                pardnitelef.ParameterName = "@DNItelefonoP ";
                pardnitelef.SqlDbType = SqlDbType.Int;
                pardnitelef.Value = Proveedor.DnitelefP;
                sqlcmand.Parameters.Add(pardnitelef);

                SqlParameter pardnidire = new SqlParameter();
                pardnidire.ParameterName = "@DNIdireccionP";
                pardnidire.SqlDbType = SqlDbType.Int;
                pardnidire.Value = Proveedor.DnidirP;
                sqlcmand.Parameters.Add(pardnidire);

                SqlParameter parRZ = new SqlParameter();
                parRZ.ParameterName = "@RazonSocial";
                parRZ.SqlDbType = SqlDbType.VarChar;
                parRZ.Size = Proveedor.Razonsocial.Length;
                parRZ.Value=Proveedor.Razonsocial;
                sqlcmand.Parameters.Add(parRZ);

                SqlParameter parNC = new SqlParameter();
                parNC.ParameterName = "@NombreContacto";
                parNC.SqlDbType=SqlDbType.VarChar;
                parNC.Size = Proveedor.Nombrecontacto.Length;
                parNC.Value=Proveedor.Nombrecontacto;
                sqlcmand.Parameters.Add(parNC);

                SqlParameter parmail = new SqlParameter();
                parmail.ParameterName = "@Mail";
                parmail.SqlDbType = SqlDbType.VarChar;
                parmail.Size = Proveedor.Mail.Length;
                parmail.Value = Proveedor.Mail;
                sqlcmand.Parameters.Add(parmail);

                SqlParameter parestado = new SqlParameter();
                parestado.ParameterName = "@Estado";
                parestado.SqlDbType = SqlDbType.VarChar;
                parestado.Size = Proveedor.Estado.Length;
                parestado.Value = Proveedor.Estado;
                sqlcmand.Parameters.Add(parestado);

                SqlParameter pardni = new SqlParameter();
                pardni.ParameterName = "@DNI";
                pardni.SqlDbType = SqlDbType.Int;
                pardni.Value = Proveedor.dni;
                sqlcmand.Parameters.Add(pardni);
                                            

                sqlcmand.ExecuteNonQuery();
               
                rsp = "Y";

            }

            catch(SqlException ex)
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
                  rsp ="Error al intentar ejecutar el procedimiento almacenado Produccion.InsertarProveedor. " + ex.Message;
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

