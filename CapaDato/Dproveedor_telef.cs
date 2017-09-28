using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace CapaDato
{
   public class Dproveedor_telef
    {

        private int _idtelef;
        private int _nparti;
        private int _nmovil;
        private int _fax;




        public int Idtelef
        {
            get { return _idtelef; }
            set { _idtelef = value; }
        }
        public int Nparti
        {
            get { return _nparti; }
            set { _nparti = value; }
        }

        public int Nmovil
        {
            get { return _nmovil; }
            set { _nmovil = value; }
        }

        public int Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        public Dproveedor_telef()
        { 
        
        }

        public Dproveedor_telef(int IDTELEF, int NPARTI, int NMOVIL, int FAX)
        {
            this.Idtelef = IDTELEF;
            this.Nparti = NPARTI;
            this.Nmovil = NMOVIL;
            this.Fax = FAX;
        }

        

        public string InsertarTP(Dproveedor_telef Proveedort)
        {
            string rsp = "";
            SqlConnection sqlcon = new SqlConnection();

            try
            {
                sqlcon.ConnectionString = Conexion.cn;
                sqlcon.Open();

                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "RRHH.InsertarTelefono";
                sqlcmd.CommandType = CommandType.StoredProcedure;


               
              

                SqlParameter pardnitp = new SqlParameter();
                pardnitp.ParameterName = "@IDtelef";
                pardnitp.SqlDbType = SqlDbType.Int;
                pardnitp.Value = Proveedort.Idtelef;
                sqlcmd.Parameters.Add(pardnitp);

                SqlParameter parnpart = new SqlParameter();
                parnpart.ParameterName = "@Telefono_parti";
                parnpart.SqlDbType = SqlDbType.Int;
                parnpart.Value = Proveedort.Nparti;
                sqlcmd.Parameters.Add(parnpart);

                SqlParameter parnmov = new SqlParameter();
                parnmov.ParameterName = "@Telefono_movil ";
                parnmov.SqlDbType = SqlDbType.Int;
                parnmov.Value = Proveedort.Nmovil;
                sqlcmd.Parameters.Add(parnmov);

                SqlParameter parfax = new SqlParameter();
                parfax.ParameterName = "@Fax ";
                parfax.SqlDbType = SqlDbType.Int;
                parfax.Value = Proveedort.Fax;
                sqlcmd.Parameters.Add(parfax);



                sqlcmd.ExecuteNonQuery();

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
                    rsp = "Error al intentar ejecutar el procedimiento almacenado Produccion.InsertarTelefono. " + ex.Message;
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
