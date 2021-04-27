using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {   
        //Atributos
       public string descripcion;

       public Marca(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public override string ToString()
        {
            return this.descripcion;
        }

    }
}
