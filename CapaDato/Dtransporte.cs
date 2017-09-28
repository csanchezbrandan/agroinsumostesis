using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDato
{
   public class Dtransporte
    {
        private int _idtransp;
        private int dnit;
        private int _dnitelef;
        private int _dnidire;
        private string _nombtransport;
        private string _nombre;
        private string _apellido;
        private string _mail;
        private string _estado;

        public int Idtransp
        {
            get { return _idtransp; }
            set { _idtransp = value; }
        }
      

        public int Dnit
        {
            get { return dnit; }
            set { dnit = value; }
        }
       

        public int Dnitelef
        {
            get { return _dnitelef; }
            set { _dnitelef = value; }
        }
    

        public int Dnidire
        {
            get { return _dnidire; }
            set { _dnidire = value; }
        }
  

        public string Nombtransport
        {
            get { return _nombtransport; }
            set { _nombtransport = value; }
        }
       

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
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

        public Dtransporte()
        { 
        }
        public Dtransporte(int IDT, int DNIT, int DNITELEF, int DNIDIRE, string NOMBRTRANSP, string NOMBRE, string APELLIDO, string MAIL, string ESTADO)
        {
            this.Idtransp = IDT;
            this.Dnit = DNIT;
            this.Dnitelef = DNITELEF;
            this.Dnidire = DNIDIRE;
            this.Nombtransport = NOMBRTRANSP;
            this.Nombre = NOMBRE;
            this.Apellido = APELLIDO;
            this.Mail = MAIL;
            this.Estado = ESTADO;
        
        }

        public DataTable MostrarT()
        {
            DataTable dt = new DataTable("Venta.MostrarTransporte");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand cmdt = new SqlCommand();
                cmdt.Connection = sqlcon;
                cmdt.CommandText = "Venta.MostrarTransporte";
                cmdt.CommandType = CommandType.StoredProcedure;

                cmdt.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmdt);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                throw new Exception("Error al ejecutar el procedienti almacenado Venta.MostrarTransporte" + ex.Message, ex);
            
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

        public string InsertatT(Dtransporte transporte)
        {
            string rsp = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand cmdt = new SqlCommand();
                cmdt.Connection = sqlcon;
                cmdt.CommandText = "Venta.InsertarTransporte";
                cmdt.CommandType = CommandType.StoredProcedure;

                SqlParameter pardnit = new SqlParameter();
                pardnit.ParameterName = "@dnit";
                pardnit.SqlDbType = SqlDbType.Int;
                pardnit.Value = transporte.Dnit;
                cmdt.Parameters.Add(pardnit);

                SqlParameter pardnitelef = new SqlParameter();
                pardnitelef.ParameterName = "@dniteleft";
                pardnitelef.SqlDbType = SqlDbType.Int;
                pardnitelef.Value = transporte.Dnitelef;
                cmdt.Parameters.Add(pardnitelef);

                SqlParameter pardnidire = new SqlParameter();
                pardnidire.ParameterName = "@dnidiret";
                pardnidire.SqlDbType = SqlDbType.Int;
                pardnidire.Value = transporte.Dnidire;
                cmdt.Parameters.Add(pardnidire);

                SqlParameter parnombtransp = new SqlParameter();
                parnombtransp.ParameterName = "@nombtransporte";
                parnombtransp.SqlDbType = SqlDbType.VarChar;
                parnombtransp.Size = transporte.Nombtransport.Length;
                parnombtransp.Value = transporte.Nombtransport;
                cmdt.Parameters.Add(parnombtransp);

                SqlParameter parnomb = new SqlParameter();
                parnomb.ParameterName = "@nombre";
                parnomb.SqlDbType = SqlDbType.VarChar;
                parnomb.Size = transporte.Nombre.Length;
                parnomb.Value = transporte.Nombre;
                cmdt.Parameters.Add(parnomb);

                SqlParameter parapell = new SqlParameter();
                parapell.ParameterName = "@apellido";
                parapell.SqlDbType = SqlDbType.VarChar;
                parapell.Size = transporte.Apellido.Length;
                parapell.Value = transporte.Apellido;
                cmdt.Parameters.Add(parapell);

                SqlParameter parmail = new SqlParameter();
                parmail.ParameterName = "@mail";
                parmail.SqlDbType = SqlDbType.VarChar;
                parmail.Size = transporte.Mail.Length;
                parmail.Value = transporte.Mail;
                cmdt.Parameters.Add(parmail);

                SqlParameter parestado = new SqlParameter();
                parestado.ParameterName = "@estado";
                parestado.SqlDbType = SqlDbType.VarChar;
                parestado.Size = transporte.Estado.Length;
                parestado.Value = transporte.Estado;
                cmdt.Parameters.Add(parestado);

                cmdt.ExecuteNonQuery();

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
                    rsp = "Error al intentar ejecutar el procedimiento almacenado Produccion.InsertarProveedor. " + ex.Message;
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
