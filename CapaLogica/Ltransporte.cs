using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using System.Data;
namespace CapaLogica
{
   public class Ltransporte
    {
        public static DataTable MostrarT()
        {
            return new Dtransporte().MostrarT();
        
        }

        public static string InsertarT(int DNIT, int DNITELF, int DNIDIRE, string NOMBRETRANSP, string NOMBR, string APELL, string MAIL, string ESTADO)
        {
            Dtransporte transp = new Dtransporte();

            transp.Dnit = DNIT;
            transp.Dnitelef = DNITELF;
            transp.Dnidire = DNIDIRE;
            transp.Nombtransport = NOMBRETRANSP;
            transp.Nombre = NOMBR;
            transp.Apellido = APELL;
            transp.Mail = MAIL;
            transp.Estado = ESTADO;

            return transp.InsertatT(transp);
        
        }
    }
}
