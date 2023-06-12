using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace Sol_ProcesoCRUD.Presentacion.Logica
{
    public class Conexion
    {
        private string DataBase;
        private static Conexion con = null;

        private Conexion() 
        {
            //Ruta de la base de datos
            this.DataBase = "./bd_CRUD.db";
        }

        public SQLiteConnection CrearConexion() 
        {
            SQLiteConnection cadena = new SQLiteConnection();

            try 
            {
                cadena.ConnectionString = "Data Source=" + this.DataBase;
            }
            catch(Exception ex)
            {
                cadena = null;
                throw ex;
            }

            return cadena;
        }

        public static Conexion getInstancia() 
        {
            if (con == null) 
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
