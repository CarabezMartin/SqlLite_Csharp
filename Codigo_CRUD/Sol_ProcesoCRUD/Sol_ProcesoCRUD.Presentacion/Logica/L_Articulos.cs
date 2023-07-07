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
        public DataTable ListadoArticulos(string cTexto) 
        {
            SQLiteDataReader Resultado;
            DataTable Tabla = new DataTable();
            SQLiteConnection SqlCon = new SQLiteConnection();

            try
            {
                cTexto = cTexto.Trim();
                SqlCon = Conexion.getInstancia().CrearConexion();
                string sqlTarea = "SELECT a.articulo_id, a.descripcion, a.marca, m.descripcion, c.descripcion, a.medida_id,a.categoria_id " +
                                  "FROM articulos a INNER JOIN medidas m ON a.medida_id = m.medida_id INNER JOIN categorias c ON a.categoria_id = c.categoria_id" +
                                  " WHERE a.descripcion LIKE '"+ "%"+ cTexto +"%" + "'";
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
