using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _001_Datos
{
    public class D_Categorias
    {
        public DataTable ListaCat(string Texto) //el procedimiento listar categoria va a llamr elprocedimiento de acuerdo al parametro, se filtrará, recolecta la info resultado, se la carga a la tabla esa info y retorna el contanido de la tabla
            //datatable devuelve una n cantidad de registros de lo consultado
        {
            SqlDataReader Resultado; //resultado recibe la info desde la consulta de sql server
            DataTable Tabla = new DataTable(); //activando el datatable, y la info final va a pasar desde resultado a tabla 
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = ConexionDB.GetInstancia().CreacionConexion();
                SqlCommand cmd = new SqlCommand("P_Lista", SqlCon); //mapea a que procedimeitno tiene que interactuar
                cmd.CommandType = CommandType.StoredProcedure; //la forma en que se va a establecer el proce almacenado
                cmd.Parameters.Add("@Texto", SqlDbType.VarChar).Value = Texto; //Parametro y dato filtrado
                SqlCon.Open();
                Resultado = cmd.ExecuteReader(); //la info regresará como con un conjunto de datos
                Tabla.Load(Resultado); //lainfo se va ala tabla
                return Tabla;

            }
            catch (Exception e)
            {
                throw e;
            }
            finally //si la conexion se queda abierta, cerrarla
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
            }
        }
    }
}
