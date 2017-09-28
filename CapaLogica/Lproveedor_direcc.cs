using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using System.Data;

namespace CapaLogica
{
    public class Lproveedor_direcc
    {
        public static string InsertarPD(int IDDIR, string CALLE, int NCALLE, string PROVINC, string LOCAL, string BARRIO, int CP)
        {
            Dproveedor_direcc direccion = new Dproveedor_direcc();
            
            direccion.Iddire = IDDIR;
            direccion.Calle = CALLE;
            direccion.Ncalle = NCALLE;
            direccion.Provincia = PROVINC;
            direccion.Localida = LOCAL;
            direccion.Barrio = BARRIO;
            direccion.Cp = CP;
            

            return direccion.InsertarPD(direccion);
        
        
        }

    }
}
