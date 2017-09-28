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
   public class Lempleado
    {
        public static DataTable MostrarE()
        {

            return new Dempleado().MostratE();
        }

        public static string InsertarE(int DNIE, int DNITELF, int DNIDIRE, string NOMB, string APELL, string MAIL, string ESTAD, string FI, string FE)
        {
            Dempleado empleado = new Dempleado();

            empleado.Dnie = DNIE;
            empleado.Dnitefel = DNITELF;
            empleado.Dnidire = DNIDIRE;
            empleado.Nombre = NOMB;
            empleado.Apellido = APELL;
            empleado.Mail = MAIL;
            empleado.Estado = ESTAD;
            empleado.Fechingreso = FI;
            empleado.Fechaegreso = FE;

            return empleado.InsertarEmpleado(empleado);
        }
    }
}
