using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDato;

namespace CapaLogica
{
    public class Lcategoria
    {


        public static DataTable mostrar()
        {
            return new Dcategoria().mostrar();
        }

        public static string Insertar ( string NOMBRE, string DESCRIPCION)
        {

            Dcategoria categoria = new Dcategoria();
            categoria.Nombrecategoria = NOMBRE;
            categoria.Descripcioncategoria = DESCRIPCION;
            
            return categoria.Insertar(categoria);
        
        }

        public static string Editar(int IDCATEGORIA, string NOMBRE, string DESCRIPCION)
        {

            Dcategoria obj = new Dcategoria();
            obj.Idcategoria = IDCATEGORIA;
            obj.Nombrecategoria = NOMBRE;
            obj.Descripcioncategoria = DESCRIPCION;
            
            return obj.Editar(obj);

        }

        public static string Eliminar(int id)
        {

            Dcategoria obj = new Dcategoria();
            obj.Idcategoria = id;
            
            return obj.Eliminar(obj);

        }
        public static  DataTable Buscar(string buscar)
        {

            Dcategoria obj = new Dcategoria();

            obj.Nombrebuscar = buscar;
            
            return obj.Buscar(obj);
        }
       

    }
}
