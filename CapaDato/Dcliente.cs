using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
    public class Dcliente
    {
        private int _idcliente;
        private int _dni;
        private int dnidire;
        private int dnitelef;
        private string nombrec;
        private string apellidoc;
        private string mail;
        private string estado;

        public int Idcliente
        {
            get { return _idcliente; } set { _idcliente = value; }
        }
        public int Dni
        {
            get { return _dni; } set { _dni = value; }
        }
        public int Dnidire
        {
            get { return dnidire; } set { dnidire = value; }
        }
        public int Dnitelef
        {
            get { return dnitelef; }  set { dnitelef = value; }
        }

        public string Nombrec
        {
            get { return nombrec; }
            set { nombrec = value; }
        }

        public string Apellidoc
        {
            get { return apellidoc; }
            set { apellidoc = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Dcliente()
        {
            //constructor vacio
        }
        //contrustuctor con parametros
        public Dcliente(int IDCLIENT, int DNIC, int DIRECC, int TELEF, string NOMBRE, string APELLIDO, string MAIL, string ESTADO)
        {
            this.Idcliente = IDCLIENT;
            this.Dni = DNIC;
            this.Dnidire = DIRECC;
            this.Dnitelef = TELEF;
            this.Nombrec = NOMBRE;
            this.Apellidoc = APELLIDO;
            this.Mail = MAIL;
            this.Estado = ESTADO;
        }

        public DataTable MostrarC()
        {
            DataTable dt = new DataTable("Produccio.MostrarCliente");
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand cmndc = new SqlCommand();
                cmndc.Connection = sqlcon;
                cmndc.CommandText = "Venta.MostrarCliente";
                cmndc.CommandType = CommandType.StoredProcedure;

                cmndc.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(cmndc);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                dt = null;
                throw new Exception("Error al ejecutar el Procedimiento Almacenado Venat.MostrarCliente. " + ex.Message, ex);

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

        public string InsertarC(Dcliente cliente)
        {
            string rsp = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand cmdc = new SqlCommand();
                cmdc.Connection = sqlcon;
                cmdc.CommandText = "Venta.InsertarCliente";
                cmdc.CommandType = CommandType.StoredProcedure;

                SqlParameter pardnic = new SqlParameter();
                pardnic.ParameterName = "@dnic";
                pardnic.SqlDbType = SqlDbType.Int;
                pardnic.Value = cliente.Dni;
                cmdc.Parameters.Add(pardnic);

                SqlParameter pardnidire = new SqlParameter();
                pardnidire.ParameterName = "@dnidirec";
                pardnidire.SqlDbType = SqlDbType.Int;
                pardnidire.Value = cliente.Dnidire;
                cmdc.Parameters.Add(pardnidire);

                SqlParameter pardnitel = new SqlParameter();
                pardnitel.ParameterName = "@dnitelefc";
                pardnitel.SqlDbType = SqlDbType.Int;
                pardnitel.Value = cliente.Dnitelef;
                cmdc.Parameters.Add(pardnitel);

                SqlParameter parnomb = new SqlParameter();
                parnomb.ParameterName = "@nombrec";
                parnomb.SqlDbType = SqlDbType.VarChar;
                parnomb.Size = cliente.Nombrec.Length;
                parnomb.Value = cliente.Nombrec;
                cmdc.Parameters.Add(parnomb);

                SqlParameter parapell = new SqlParameter();
                parapell.ParameterName = "@apellidoc";
                parapell.SqlDbType = SqlDbType.VarChar;
                parapell.Size = cliente.Apellidoc.Length;
                parapell.Value = cliente.Apellidoc;
                cmdc.Parameters.Add(parapell);

                SqlParameter parmail = new SqlParameter();
                parmail.ParameterName = "@mail";
                parmail.SqlDbType = SqlDbType.VarChar;
                parmail.Size = cliente.Mail.Length;
                parmail.Value = cliente.Mail;
                cmdc.Parameters.Add(parmail);

                SqlParameter parestado = new SqlParameter();
                parestado.ParameterName = "@estado";
                parestado.SqlDbType = SqlDbType.VarChar;
                parestado.Size = cliente.Estado.Length;
                parestado.Value = cliente.Estado;
                cmdc.Parameters.Add(parestado);

                cmdc.ExecuteNonQuery();
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
                    rsp = "Ya existe un Cliente con ese DNI.";
                }
                else if (ex.Number == 515)
                {
                    rsp = "No puedes dejar el campo Nombre vacío.";
                }
                else
                {
                    rsp = "Error al intentar ejecutar el procedimiento almacenado Produccion.InsertarCliente. " + ex.Message;
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
        public string EditarCliente(Dcliente cliente)
        {
            string rsp = "";

            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand cmdc = new SqlCommand();
                cmdc.Connection = sqlcon;
                cmdc.CommandText = "Venta.EditarCliente";
                cmdc.CommandType = CommandType.StoredProcedure;

                SqlParameter pardnic = new SqlParameter();
                pardnic.ParameterName = "@dnic";
                pardnic.SqlDbType = SqlDbType.Int;
                pardnic.Value = cliente.Dni;
                cmdc.Parameters.Add(pardnic);

                SqlParameter pardnidire = new SqlParameter();
                pardnidire.ParameterName = "@dnidirec";
                pardnidire.SqlDbType = SqlDbType.Int;
                pardnidire.Value = cliente.Dnidire;
                cmdc.Parameters.Add(pardnidire);

                SqlParameter pardnitel = new SqlParameter();
                pardnitel.ParameterName = "@dnitelefc";
                pardnitel.SqlDbType = SqlDbType.Int;
                pardnitel.Value = cliente.Dnitelef;
                cmdc.Parameters.Add(pardnitel);

                SqlParameter parnomb = new SqlParameter();
                parnomb.ParameterName = "@nombrec";
                parnomb.SqlDbType = SqlDbType.VarChar;
                parnomb.Size = cliente.Nombrec.Length;
                parnomb.Value = cliente.Nombrec;
                cmdc.Parameters.Add(parnomb);

                SqlParameter parapell = new SqlParameter();
                parapell.ParameterName = "@apellidoc";
                parapell.SqlDbType = SqlDbType.VarChar;
                parapell.Size = cliente.Apellidoc.Length;
                parapell.Value = cliente.Apellidoc;
                cmdc.Parameters.Add(parapell);

                SqlParameter parmail = new SqlParameter();
                parmail.ParameterName = "@mail";
                parmail.SqlDbType = SqlDbType.VarChar;
                parmail.Size = cliente.Mail.Length;
                parmail.Value = cliente.Mail;
                cmdc.Parameters.Add(parmail);

                SqlParameter parestado = new SqlParameter();
                parestado.ParameterName = "@estado";
                parestado.SqlDbType = SqlDbType.VarChar;
                parestado.Size = cliente.Estado.Length;
                parestado.Value = cliente.Estado;
                cmdc.Parameters.Add(parestado);

                cmdc.ExecuteNonQuery();
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
                    rsp = "Ya existe una Cliente con ese Documento.";
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
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
            return rsp;
        }
        public DataTable BuscarCliente(Dcliente Cliente)
        {
            DataTable dtresultado = new DataTable("Venta.Cliente");
            SqlConnection sqlcon = new SqlConnection();
            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.Connection = sqlcon;
                sqlcom.CommandText = "Venta.BuscarCliente";
                sqlcom.CommandType = CommandType.StoredProcedure;

                SqlParameter parDNI = new SqlParameter();
                parDNI.ParameterName = "@dni";
                parDNI.SqlDbType = SqlDbType.Int;
                parDNI.Value = Cliente._idcliente;
                sqlcom.Parameters.Add(parDNI);

                SqlDataAdapter sqlda = new SqlDataAdapter(sqlcom);
                sqlda.Fill(dtresultado);
            }
            catch (Exception ex)
            {
                dtresultado = null;
            }
            return dtresultado;
        }
    }
}