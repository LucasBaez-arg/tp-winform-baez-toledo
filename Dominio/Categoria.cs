﻿using System;
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
        private int id;

        public Categoria(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public Categoria(int id, string descripcion)
        {
            this.descripcion = descripcion;
            this.id = id;
        }

        public int Id{
            get{
               return id;
            } 
        }

        public override string ToString()
        {
            return this.descripcion;
        }
    }
}
