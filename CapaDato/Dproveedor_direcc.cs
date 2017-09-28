using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
    public class Dproveedor_direcc
    {

        private int _iddire;
        private string _calle;
        private int _ncalle;
        private string _provincia;
        private string _localida;
        private string _barrio;
        private int cp;

        public int Iddire
        {
            get { return _iddire; }
            set { _iddire = value; }
        }
        

        public string Calle
        {
            get { return _calle; }
            set { _calle = value; }
        }
       

        public int Ncalle
        {
            get { return _ncalle; }
            set { _ncalle = value; }
        }
       

        public string Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }
       

        public string Localida
        {
            get { return _localida; }
            set { _localida = value; }
        }
        

        public string Barrio
        {
            get { return _barrio; }
            set { _barrio = value; }
        }
    
        public int Cp
        {
            get { return cp; }
            set { cp = value; }
        }

        public Dproveedor_direcc()
        { 
        }
        public Dproveedor_direcc(int IDDIRE, string calle, int nCALLE, string PROVI, string LOCAL, string BARRIO, int cp)
        {
            this.Iddire = IDDIRE;
            this.Calle = calle;
            this.Ncalle = nCALLE;
            this.Provincia = PROVI;
            this.Localida = LOCAL;
            this.Barrio = BARRIO;
            this.Cp = cp;
            
 
        }

        public string InsertarPD(Dproveedor_direcc Proveedord)
        {
            string rsp = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand sqlcmdd = new SqlCommand();
                sqlcmdd.Connection = sqlcon;
                sqlcmdd.CommandText = "RRHH.InsertarDireccion";
                sqlcmdd.CommandType = CommandType.StoredProcedure;



               
                SqlParameter parnidd = new SqlParameter();
                parnidd.ParameterName = "@IDdireccion ";
                parnidd.SqlDbType = SqlDbType.Int;
                parnidd.Value = Proveedord.Iddire;
                sqlcmdd.Parameters.Add(parnidd);


                SqlParameter parcalle = new SqlParameter();
                parcalle.ParameterName = "@Calle ";
                parcalle.SqlDbType = SqlDbType.VarChar;
                parcalle.Size = Proveedord.Calle.Length;
                parcalle.Value = Proveedord.Calle;
                sqlcmdd.Parameters.Add(parcalle);

                SqlParameter parncalle = new SqlParameter();
                parncalle.ParameterName = "@Numero_calle ";
                parncalle.SqlDbType = SqlDbType.Int;
                parncalle.Value = Proveedord.Ncalle;
                sqlcmdd.Parameters.Add(parncalle);

                SqlParameter parp = new SqlParameter();
                parp.ParameterName = "@Provincia ";
                parp.SqlDbType = SqlDbType.VarChar;
                parp.Size = Proveedord.Provincia.Length;
                parp.Value = Proveedord.Provincia;
                sqlcmdd.Parameters.Add(parp);

                SqlParameter parl = new SqlParameter();
                parl.ParameterName = "@Localidad ";
                parl.SqlDbType = SqlDbType.VarChar;
                parl.Size = Proveedord.Localida.Length;
                parl.Value = Proveedord.Localida;
                sqlcmdd.Parameters.Add(parl);

                SqlParameter parb = new SqlParameter();
                parb.ParameterName = "@Barrio ";
                parb.SqlDbType = SqlDbType.VarChar;
                parb.Size = Proveedord.Barrio.Length;
                parb.Value = Proveedord.Barrio;
                sqlcmdd.Parameters.Add(parb);


                SqlParameter parcp = new SqlParameter();
                parcp.ParameterName = "@Codigo_postal ";
                parcp.SqlDbType = SqlDbType.Int;
                parcp.Value = Proveedord.Cp;
                sqlcmdd.Parameters.Add(parcp);

                sqlcmdd.ExecuteNonQuery();

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
                    rsp = "Error al intentar ejecutar el procedimiento almacenado InsertarDomicilio. " + ex.Message;
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
