using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Categoria> lista = new List<Categoria>();
            try
            {
                datos.SetearConsulta("SELECT id,descipcion FROM CATEGORIAS");
                datos.EjecutarLectura();
                while (datos.Leer.Read())
                {
                    lista.Add(new Categoria((int)datos.Leer["id"], (string)datos.Leer["descripcion"]));
                }

                return lista;
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
