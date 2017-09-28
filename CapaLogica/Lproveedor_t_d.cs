using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using System.Data;
namespace CapaLogica
{
    public class Lproveedor_t_d
    {
        public static DataTable mostrarP()
        {
            return new Dproveedor().mostrarP();


        }
        //

        public static string insertar (int dnitelefp, int dnidirp, string razonsocial ,string Ncontacto, string mail, string estado, int DNI)
       
        {
            Dproveedor proveedor = new Dproveedor();

     
            proveedor.DnitelefP = dnitelefp;
            proveedor.DnidirP = dnidirp;
            proveedor.Razonsocial = razonsocial;
            proveedor.Nombrecontacto = Ncontacto;
            proveedor.Mail = mail;
            proveedor.Estado = estado;
            proveedor.dni = DNI;
           

           

            return proveedor.Insertar(proveedor);
        }

    }
}
