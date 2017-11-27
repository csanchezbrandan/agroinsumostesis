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
   public class Lproducto
    {
        public static DataTable MostrarP()
        {
            
           return new Dproducto().MostraP();
            
        }

        public static string InsertarP(int IDP, int IDC, string NP, decimal PRCOMP,decimal PREUNIT, decimal STOCK, decimal PREPOS, string MARCA, string ESTAD, byte[] IMAGEN, DateTime FVENCIM, string UMEDID , string DESCRIP)
        {
            Dproducto producto = new Dproducto();

            producto.Idproveedor = IDP;
            producto.Idcategoria = IDC;
            producto.NombreP = NP;
            producto.Preciocompra = PRCOMP;
            producto.Stock = STOCK;
            producto.Puntreposi = PREPOS;
            producto.Marca = MARCA;
            producto.Unidmedida = UMEDID;
            producto.Estado = ESTAD;
            producto.Imagen = IMAGEN;
            producto.Fvencimiento = FVENCIM;
            producto.Preciounitario = PREUNIT;
            producto.Descripcion = DESCRIP;

            return producto.InsertarProducto(producto);
        }

        public static string Editar(int IDPROUD,int IDPROV,int IDCATEG, string NOMBRP, string PRECCOMP, STOCK,PREPOS,string MARCA,UNIMEDID,ESTADO,IMAGEN,FVENCIM,PREUNITAR,PREUNITAR,DESCRIP)
        {

            Dcategoria obj = new Dcategoria();
            obj.Idcategoria = IDCATEGORIA;
            obj.Nombrecategoria = NOMBRE;
            obj.Descripcioncategoria = DESCRIPCION;

            return obj.Editar(obj);

        }
    }
}
