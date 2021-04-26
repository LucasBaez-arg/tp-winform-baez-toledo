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

                string value = "WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id";
                datos.SetearConsulta("SELECT A.Codigo, A.Nombre, A.Descripcion,A.ImagenUrl, M.Descripcion AS Marca, C.Descripcion AS Categoria, ImagenUrl, A.Precio FROM ARTICULOS AS A, MARCAS AS M, CATEGORIAS AS C "+ value);
                datos.EjecutarLectura();

                while (datos.Leer.Read())
                {
                    Articulo art = new Articulo();
                    
                    art.Nombre = (string)datos.Leer["Nombre"];
                    art.Marca = new Marca((string)datos.Leer["Marca"]);
                    art.Precio = (decimal)datos.Leer["Precio"];
                    art.Imagen = (string)datos.Leer["ImagenUrl"];
                    art.Categoria = new Categoria((string)datos.Leer["Categoria"]);
                    art.Descripcion = (string)datos.Leer["Descripcion"];
                    art.CodigoArticulo = (string)datos.Leer["Codigo"];
                    
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
