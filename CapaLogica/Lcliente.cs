using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using System.Data;
using System.Data.SqlClient;

namespace CapaLogica
{
   public class Lcliente
    {
       public static DataTable MostrarC()
       {
           return new Dcliente().MostrarC();
       }
       public static string InsertarC(int DNI,int DOMICILIO, int TELEFONO, string NOMBRE, string APELLIDO, string MAIL,string ESTADO)
       {
           Dcliente cliente = new Dcliente();
           cliente.Idcliente = DNI;
           cliente.Dnidire = DOMICILIO;
           cliente.Dnitelef = TELEFONO;
           cliente.Nombrec = NOMBRE;
           cliente.Apellidoc = APELLIDO;
           cliente.Estado = ESTADO;
           return cliente.InsertarC(cliente);
       }
    
    public static string EditarC(int DNI,int  DOMICILIO, int TELEFONO, string NOMBRE, string APELLIDO, string MAIL,string ESTADO)
    {
        Dcliente cliente = new Dcliente();
           cliente.Idcliente = DNI;
           cliente.Dnidire = DOMICILIO;
           cliente.Dnitelef = TELEFONO;
           cliente.Nombrec = NOMBRE;
           cliente.Apellidoc = APELLIDO;
           cliente.Mail = MAIL;
           cliente.Estado = ESTADO;
           return cliente.EditarCliente(cliente);
    }
    public static DataTable BuscarC(int dni)
    {
        Dcliente cliente = new Dcliente();
       // cliente.BuscarCliente = dni;
        return cliente.BuscarCliente(cliente);
    }
    //public static string EliminarC(int DNI)
    //{
    //    Dcliente cliente = new Dcliente();
    //    cliente.Idcliente = DNI;
    //    return cliente.EliminarCliente(cliente);
    //}
   }
}
