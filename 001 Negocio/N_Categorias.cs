using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using _001_Datos;

namespace _001_Negocio
{
    public class N_Categorias
    {
        public static DataTable ListaCat(string Texto)
        {
            D_Categorias Datos = new D_Categorias();
            return Datos.ListaCat(Texto);
            //recibe la indicacion (texto) y llama al metodo que esta en la cpaa de datos (es el que se comunica con la db)
        }
    }
}
