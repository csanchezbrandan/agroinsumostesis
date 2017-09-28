using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
   public
       class Dempleado
    {
        private int _idempleado;
        private int _dnie;
        private int _dnitefel;
        private int _dnidire;
        private string _nombre;
        private string _apellido;
        private string _mail;
        private string _estado;
        private string _fechingreso;
        private string _fechaegreso;
       
        public int Idempleado
        {
            get { return _idempleado; }
            set { _idempleado = value; }
        }
     

        public int Dnie
        {
            get { return _dnie; }
            set { _dnie = value; }
        }
        

        public int Dnitefel
        {
            get { return _dnitefel; }
            set { _dnitefel = value; }
        }
        

        public int Dnidire
        {
            get { return _dnidire; }
            set { _dnidire = value; }
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

        public string Fechingreso
        {
            get { return _fechingreso; }
            set { _fechingreso = value; }
        }


        public string Fechaegreso
        {
            get { return _fechaegreso; }
            set { _fechaegreso = value; }
        }
       

       

        public Dempleado()
        { 
        }
        public Dempleado(int IDEM, int DNIE, int DNITEL, int DNIDIR, string NOMB, string APELL, string MAIL, string ESTADO, string FECHING, string FEHCEGRE)
        {
            this.Idempleado = IDEM;
            this.Dnie = DNIE;
            this.Dnitefel = DNITEL;
            this.Dnidire = DNIDIR;
            this.Nombre = NOMB;
            this.Apellido = APELL;
            this.Mail = MAIL;
            this.Estado = ESTADO;
            this.Fechingreso = FECHING;
            this.Fechaegreso = FEHCEGRE;
        }

        public DataTable MostratE()
        {   
            DataTable dt = new DataTable ();
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand cmde = new SqlCommand();
                cmde.Connection = sqlcon;
                cmde.CommandText = "RRHH.MostrarEmpleado";
                cmde.CommandType = CommandType.StoredProcedure;

                cmde.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmde);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                dt = null;
                throw new Exception("Erro al ejecutar el procedimiento almacenado Venta.InsertarEmpleado" + ex.Message, ex);
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

        public string InsertarEmpleado(Dempleado empleado)
        {
            string rsp = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand cmde = new SqlCommand();
                cmde.Connection = sqlcon;
                cmde.CommandText = "RRHH.InsertarEmpleado";
                cmde.CommandType = CommandType.StoredProcedure;

                SqlParameter pardnie = new SqlParameter();
                pardnie.ParameterName = "@dnie";
                pardnie.SqlDbType = SqlDbType.Int;
                pardnie.Value = empleado.Dnie;
                cmde.Parameters.Add(pardnie);

                SqlParameter pardnitelf = new SqlParameter();
                pardnitelf.ParameterName = "@dnitelefe";
                pardnitelf.SqlDbType = SqlDbType.Int;
                pardnitelf.Value = empleado.Dnitefel;
                cmde.Parameters.Add(pardnitelf);

                SqlParameter pardir = new SqlParameter();
                pardir.ParameterName = "@dnidiree";
                pardir.SqlDbType = SqlDbType.Int;
                pardir.Value = empleado.Dnidire;
                cmde.Parameters.Add(pardir);

                SqlParameter parnomb = new SqlParameter();
                parnomb.ParameterName = "@nombree";
                parnomb.SqlDbType = SqlDbType.VarChar;
                parnomb.Size = empleado.Nombre.Length;
                parnomb.Value = empleado.Nombre;
                cmde.Parameters.Add(parnomb);

                SqlParameter parapell = new SqlParameter();
                parapell.ParameterName = "@apellidoce";
                parapell.SqlDbType = SqlDbType.VarChar;
                parapell.Size = empleado.Apellido.Length;
                parapell.Value = empleado.Apellido;
                cmde.Parameters.Add(parapell);

                SqlParameter parmail = new SqlParameter();
                parmail.ParameterName = "@mail";
                parmail.SqlDbType = SqlDbType.VarChar;
                parmail.Size = empleado.Mail.Length;
                parmail.Value = empleado.Mail;
                cmde.Parameters.Add(parmail);

                SqlParameter parestado = new SqlParameter();
                parestado.ParameterName = "@estado";
                parestado.SqlDbType = SqlDbType.VarChar;
                parestado.Size = empleado.Estado.Length;
                parestado.Value = empleado.Estado;
                cmde.Parameters.Add(parestado);

                SqlParameter parfi = new SqlParameter();
                parfi.ParameterName = "@fechingreso";
                parfi.SqlDbType = SqlDbType.VarChar;
                parfi.Value = empleado.Fechingreso;
                cmde.Parameters.Add(parfi);

                SqlParameter parfe = new SqlParameter();
                parfe.ParameterName = "@fechaegreso";
                parfe.SqlDbType = SqlDbType.VarChar;
                parfe.Value = empleado.Fechaegreso;
                cmde.Parameters.Add(parfe);


                cmde.ExecuteNonQuery();

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
                    rsp = "Error al intentar ejecutar el procedimiento almacenado Produccion.InsertarEmpleado. " + ex.Message;
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
