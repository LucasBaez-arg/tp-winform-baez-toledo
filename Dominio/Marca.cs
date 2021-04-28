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
       private int id;
       private string descripcion;

       public Marca(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public Marca(int id, string descripcion)
        {
            this.descripcion = descripcion;
            this.id = id;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public override string ToString()
        {
            return this.descripcion;
        }

    }
}
