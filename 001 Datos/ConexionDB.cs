using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace _001_Datos
{
    public class ConexionDB
    {
        /*
        private static ConexionDB Con = null;
        static void Main(string[] args)
        {
            
            string sConnectionString;
            sConnectionString = "User ID=sa;Password =SQLN22;Initial Catalog=pubs;Data Source=myServer,1200";
            SqlConnection objConn = new SqlConnection(sConnectionString);
            objConn.Open();
            SqlDataAdapter daAuthors = new SqlDataAdapter("Select * From Authors", objConn);

            DataSet dsPubs = new DataSet("Pubs");
            daAuthors.FillSchema(dsPubs, SchemaType.Source, "Authors");
            daAuthors.Fill(dsPubs, "Authors");
            daAuthors.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            daAuthors.Fill(dsPubs, "Authors");

            DataTable tblAuthors;
            tblAuthors = dsPubs.Tables["Authors"];
            foreach (DataRow drCurrent in tblAuthors.Rows)
            {
                Console.WriteLine("{0} {1}",
                drCurrent["au_fname"].ToString(),
                drCurrent["au_lname"].ToString());
            }
            Console.ReadLine();
        
        }*/

        private string DB;
        private string Servidor;
        private string Usuario;
        private string Contraseña;
        private static ConexionDB Con = null;

        private ConexionDB()
        {
            this.Servidor = "SJR1NSAH-NICO";
            this.DB = "001BasedeDatos";
            this.Usuario = "sa";
            this.Contraseña = "SQLN22";
        }

        public SqlConnection CreacionConexion()
        {
            SqlConnection conexion = new SqlConnection();
            //string sConnectionString;
            try
            {
                conexion.ConnectionString = "Server=" + this.Servidor + ", Database=" + this.DB + ", User Id=" + this.Usuario + "Password=" + this.Contraseña+ "Data Source="+1200;
            }
            catch (Exception e)
            {
                conexion = null;
                throw e;
            }
            return conexion;
        }
        
        public static ConexionDB GetInstancia()
        {
            if(Con == null)
            {
                Con = new ConexionDB();
            }
            return Con;
        }
    }

    
    }
