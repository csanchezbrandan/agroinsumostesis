using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
   public  class Dcategoria

    {
       private  int _idcategoria;
       private string _nombrecategoria;
       private string _descripcioncategoria;
       private string _txtbuscar;

      
       public int Idcategoria
       {
           get { return _idcategoria; }
           set { _idcategoria = value; }
       }

       public string Nombrecategoria
       {
           get { return _nombrecategoria; }
           set { _nombrecategoria = value; }
       }

       public string Descripcioncategoria
       {
           get { return _descripcioncategoria; }
           set { _descripcioncategoria = value; }
       }

       public string Nombrebuscar
       {
           get { return _txtbuscar; }
           set { _txtbuscar = value; }
       }

       /* constructor vacio*/
       public Dcategoria()
        { 
   
        }
       /* constructor parametro*/
       public Dcategoria (int IDCATEGORIA, string NOMBRE, string DESCRIPCION, string BUSACARCATEG)
       {
           this.Idcategoria = IDCATEGORIA;
           this.Nombrecategoria = NOMBRE;
           this.Descripcioncategoria = DESCRIPCION;
           this.Nombrebuscar = BUSACARCATEG;
                        
       }


       //*buscar*//

       public DataTable mostrar()
       {

           DataTable dt = new DataTable("Produccion.Categoria");
           SqlConnection sqlcon = new SqlConnection();

           try
           {
               sqlcon.ConnectionString = Conexion.cn;
               sqlcon.Open();

               SqlCommand sqlcmd = new SqlCommand();
               sqlcmd.Connection = sqlcon;
               sqlcmd.CommandText = "Produccion.MostrarCategoria";
               sqlcmd.CommandType = CommandType.StoredProcedure;

               sqlcmd.ExecuteNonQuery();

               SqlDataAdapter sqldat = new SqlDataAdapter(sqlcmd);          
               sqldat.Fill(dt);

           }

           catch (Exception ex)
           {
               dt = null;
               throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.MostrarCategoria. " + ex.Message, ex);

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

       //*insertar*//
       public string Insertar(Dcategoria parcategoria)
       {
           string rsp = "";

          SqlConnection sqlcon = new SqlConnection();

          try
          {

              sqlcon.ConnectionString = Conexion.cn;
              sqlcon.Open();

              SqlCommand cmd = new SqlCommand();
              cmd.Connection = sqlcon;
              cmd.CommandText = "Produccion.InsertarCategoria";
              cmd.CommandType = CommandType.StoredProcedure;    
              
              SqlParameter parnombre = new SqlParameter();
              parnombre.ParameterName = "@Nombre";
              parnombre.SqlDbType = SqlDbType.VarChar;
              parnombre.Size = parcategoria.Nombrecategoria.Length;
              parnombre.Value = parcategoria.Nombrecategoria;
              cmd.Parameters.Add(parnombre);

              SqlParameter pardescripcion = new SqlParameter();
              pardescripcion.ParameterName = "@Descripcion";
              pardescripcion.SqlDbType = SqlDbType.VarChar;
              pardescripcion.Size = parcategoria.Descripcioncategoria.Length;
              pardescripcion.Value = parcategoria.Descripcioncategoria;
              cmd.Parameters.Add(pardescripcion);

            
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
                  rsp ="Error al intentar ejecutar el procedimiento almacenado Produccion.InsertarCategoria. " + ex.Message;
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
     
       //*editar*//
       public string Editar(Dcategoria categoria)
       {
          string rsp = "";
          SqlConnection sqlcon = new SqlConnection();
          try
          {
              sqlcon.ConnectionString = Conexion.cn;
              sqlcon.Open();

              SqlCommand cmd = new SqlCommand();
              cmd.Connection = sqlcon;
              cmd.CommandText = "Produccion.EditarCategoria";
              cmd.CommandType = CommandType.StoredProcedure;

              /*psar parametro*/

              SqlParameter parId = new SqlParameter();
              parId.ParameterName = "@Id_categoria";
              parId.SqlDbType = SqlDbType.Int;
              parId.Value = categoria.Idcategoria;
              cmd.Parameters.Add(parId);

              SqlParameter parnombre = new SqlParameter();
              parnombre.ParameterName = "@Nombre";
              parnombre.SqlDbType = SqlDbType.VarChar;
              parnombre.Size = categoria.Nombrecategoria.Length;
              parnombre.Value = categoria.Nombrecategoria;
              cmd.Parameters.Add(parnombre);

              SqlParameter pardescrip = new SqlParameter();
              pardescrip.ParameterName = "@Descripcion";
              pardescrip.SqlDbType = SqlDbType.VarChar;
              pardescrip.Size = categoria.Descripcioncategoria.Length;
              pardescrip.Value = categoria.Descripcioncategoria;
              cmd.Parameters.Add(pardescrip);

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
          
       public DataTable Buscar(Dcategoria parCategorias)
       {
           DataTable TablaDatos = new DataTable("Produccion.Categorias");
           SqlConnection SqlConexion = new SqlConnection();

           try
           {
               SqlConexion.ConnectionString = Conexion.cn;
               SqlConexion.Open();

               SqlCommand SqlComando = new SqlCommand();
               SqlComando.Connection = SqlConexion;
               SqlComando.CommandText = "Produccion.BuscarCategoria";
               SqlComando.CommandType = CommandType.StoredProcedure;

               SqlParameter ParNombre_Buscado = new SqlParameter();
               ParNombre_Buscado.ParameterName = "@buscar";
               ParNombre_Buscado.SqlDbType = SqlDbType.VarChar;
               ParNombre_Buscado.Size = parCategorias.Nombrebuscar.Length;
               ParNombre_Buscado.Value = parCategorias.Nombrebuscar;
               SqlComando.Parameters.Add(ParNombre_Buscado);

               SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
               SqlAdaptadorDatos.Fill(TablaDatos);
           }

           catch (Exception ex)
           {
               TablaDatos = null;
               throw new Exception("Error al intentar ejecutar el procedimiento almacenado Produccion.BuscarCategoria. " + ex.Message, ex);
           }

           finally
           {
               if (SqlConexion.State == ConnectionState.Open)
               {
                   SqlConexion.Close();
               }
           }

           return TablaDatos;
       }

       //*eliminar*//
  
       public string Eliminar(Dcategoria categoria)
       {
          string rps = "";
          SqlConnection sqlcon = new SqlConnection();
          try
          {
              sqlcon.ConnectionString = Conexion.cn;
              sqlcon.Open();

              SqlCommand cmd = new SqlCommand();
              cmd.Connection = sqlcon;
              cmd.CommandText = "Produccion.EliminarCategoria";
              cmd.CommandType = CommandType.StoredProcedure;

              /*psar parametro*/

              SqlParameter parId = new SqlParameter();
              parId.ParameterName = "@Id_categoria";
              parId.SqlDbType = SqlDbType.Int;
              parId.Value = categoria.Idcategoria;
              cmd.Parameters.Add(parId);

       
              rps = cmd.ExecuteNonQuery() == 1 ? "ok" : "No se eliminó el registro";

          }





          catch (Exception ex)
          {
              rps = ex.Message;


          }

          finally
          {

              if (sqlcon.State == ConnectionState.Open)
                  sqlcon.Close();
          }

          return rps;
       
       }
      
       
       

    }


}



