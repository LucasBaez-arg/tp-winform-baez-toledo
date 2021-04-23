using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TPwinform
{
    class ArticuloNegocio
    {

        public List<Articulo> Listar()
        {

            List<Articulo> articulos = new List<Articulo>();

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader leer;

            try
            {
                conexion.ConnectionString = "data source=.\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT NOMBRE FROM Articulos";
                comando.Connection = conexion;

                conexion.Open();

                leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Articulo art = new Articulo();
                    art.Nombre = (string)leer[0];

                    articulos.Add(art);
                }
                return articulos;
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}
