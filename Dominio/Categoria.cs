using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        //Atributos
        private string descripcion;

        public Categoria(string descripcion)
        {
             this.descripcion = descripcion;
        }

        public override string ToString()
        {
            return this.descripcion;
        }
    }
}
