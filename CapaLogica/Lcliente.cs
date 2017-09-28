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

        public static string InsertarC(int DNIC, int DNIDIR, int DNITELE, string NOMBRE,string APELL, string MAIL, string ESTADO)
        {
            Dcliente cliente = new Dcliente();

            cliente.Dni = DNIC;
            cliente.Dnidire = DNIDIR;
            cliente.Dnitelef = DNITELE;
            cliente.Nombrec = NOMBRE;
            cliente.Apellidoc = APELL;
            cliente.Mail = MAIL;
            cliente.Estado = ESTADO;

            return cliente.InsertarC(cliente);
            
        }
    }
}
