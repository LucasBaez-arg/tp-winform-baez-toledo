using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {

        public List<Articulo> Listar()
        {

            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.SetearConsulta("SELECT Nombre FROM ARTICULOS");
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    Articulo art = new Articulo();
                    art.Nombre = (string)datos.Leer[0];

                    articulos.Add(art);
                }
                return articulos;
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                datos.CerraConexion();
            }
        }
    }

    
}
