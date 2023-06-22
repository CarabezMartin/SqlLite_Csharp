using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Sol_ProcesoCRUD.Presentacion.Logica
{
    public class L_Articulos
    {
        public DataTable ListadoArticulos() 
        {
            SQLiteDataReader Resultado;
            DataTable Tabla = new DataTable();
            SQLiteConnection SqlCon = new SQLiteConnection();

            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sqlTarea = "SELECT * FROM articulos";
                SQLiteCommand comando = new SQLiteCommand(sqlTarea,SqlCon);
                SqlCon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }
    }
}
