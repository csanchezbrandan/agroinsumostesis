using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using System.Data;

namespace CapaLogica
{
   public class Lproveedor_telef
    {
        public static string InsertarTP( int id_t, int n_part, int n_mov, int fax)
        {
            Dproveedor_telef telefono = new Dproveedor_telef();
            telefono.Idtelef = id_t;
            telefono.Nparti= n_part;
            telefono.Nmovil = n_mov;
            telefono.Fax = fax;

            return telefono.InsertarTP(telefono);
 
        }
    }
}

